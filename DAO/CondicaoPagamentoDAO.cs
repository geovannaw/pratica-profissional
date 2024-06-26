using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas.DAO
{
    public class CondicaoPagamentoDAO : DAO<CondicaoPagamentoModel>
    {
        public CondicaoPagamentoDAO() : base()
        {
        }

        public override void Alterar(CondicaoPagamentoModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); //inicia transação

                try
                {
                    string queryCondicaoPagamento = @"UPDATE condicaoPagamento 
                                                       SET condicaoPagamento = @condicaoPagamento, desconto = @desconto, juros = @juros, multa = @multa, ativo = @ativo, dataUltAlt = @dataUltAlt 
                                                       WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdCondicaoPagamento = new SqlCommand(queryCondicaoPagamento, conn, transaction);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@condicaoPagamento", obj.condicaoPagamento);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@desconto", obj.desconto);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@juros", obj.juros);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@multa", obj.multa);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@ativo", obj.Ativo);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);

                    cmdCondicaoPagamento.ExecuteNonQuery(); //att condição de pag

                    //deleta as parcelas
                    string deleteParcelas = "DELETE FROM parcela WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdDeleteParcelas = new SqlCommand(deleteParcelas, conn, transaction);
                    cmdDeleteParcelas.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                    cmdDeleteParcelas.ExecuteNonQuery();
                    //add dnv as parcelas
                    foreach (var parcela in obj.Parcelas)
                    {
                        string queryParcela = @"INSERT INTO parcela 
                                                (numeroParcela, dias, porcentagem, idCondPagamento, idFormaPagamento) 
                                                VALUES (@numeroParcela, @dias, @porcentagem, @idCondPagamento, @idFormaPagamento)";
                        SqlCommand cmdParcela = new SqlCommand(queryParcela, conn, transaction);
                        cmdParcela.Parameters.AddWithValue("@numeroParcela", parcela.numeroParcela);
                        cmdParcela.Parameters.AddWithValue("@dias", parcela.dias);
                        cmdParcela.Parameters.AddWithValue("@porcentagem", parcela.porcentagem);
                        cmdParcela.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                        cmdParcela.Parameters.AddWithValue("@idFormaPagamento", parcela.idFormaPagamento);

                        cmdParcela.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro ao alterar condição de pagamento: " + ex.Message);
                }
            }
        }

        public override void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //deleta as parcelas com o id da condicao de pagamento
                    string deleteParcelas = "DELETE FROM parcela WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdDeleteParcelas = new SqlCommand(deleteParcelas, conn, transaction);
                    cmdDeleteParcelas.Parameters.AddWithValue("@idCondPagamento", id);
                    cmdDeleteParcelas.ExecuteNonQuery();

                    //deleta condicao de pagamento
                    string deleteCondicaoPagamento = "DELETE FROM condicaoPagamento WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdDeleteCondicaoPagamento = new SqlCommand(deleteCondicaoPagamento, conn, transaction);
                    cmdDeleteCondicaoPagamento.Parameters.AddWithValue("@idCondPagamento", id);
                    cmdDeleteCondicaoPagamento.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();

                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir a Condição de Pagamento, pois ela está sendo utilizada em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao deletar a condição de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override List<CondicaoPagamentoModel> GetAll(bool incluiInativos = false)
        {
            List<CondicaoPagamentoModel> condicoesPagamento = new List<CondicaoPagamentoModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM condicaoPagamento" : "SELECT * FROM condicaoPagamento WHERE ativo = 1";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CondicaoPagamentoModel condicaoPagamento = new CondicaoPagamentoModel();
                        condicaoPagamento.idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]);
                        condicaoPagamento.condicaoPagamento = reader["condicaoPagamento"].ToString();

                        condicoesPagamento.Add(condicaoPagamento);
                    }
                }
            }

            return condicoesPagamento;
        }

        public string GetFormaPagByParcelaId(int idParcela)
        {
            string formaPag = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT formaPagamento.formaPagamento FROM parcela INNER JOIN formaPagamento ON parcela.idFormaPagamento = formaPagamento.idFormaPagamento WHERE parcela.idParcela = @idParcela";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idParcela", idParcela);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        formaPag = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter a forma de pagamento: " + ex.Message);
                }
            }
            return formaPag;
        }

        public override CondicaoPagamentoModel GetById(int id)
        {
            CondicaoPagamentoModel condicaoPagamento = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM condicaoPagamento WHERE idCondPagamento = @idCondPagamento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCondPagamento", id);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        condicaoPagamento = new CondicaoPagamentoModel();
                        condicaoPagamento.idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]);
                        condicaoPagamento.condicaoPagamento = reader["condicaoPagamento"].ToString();
                        condicaoPagamento.desconto = Convert.ToDecimal(reader["desconto"]);
                        condicaoPagamento.juros = Convert.ToDecimal(reader["juros"]);
                        condicaoPagamento.multa = Convert.ToDecimal(reader["multa"]);
                        condicaoPagamento.Ativo = Convert.ToBoolean(reader["ativo"]);
                        condicaoPagamento.dataCadastro = Convert.ToDateTime(reader["dataCadastro"]);
                        condicaoPagamento.dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]);

                        // Carregar Parcelas
                        condicaoPagamento.Parcelas = GetParcelasByCondicaoPagamentoId(condicaoPagamento.idCondPagamento);
                    }
                }
            }

            return condicaoPagamento;
        }

        private List<ParcelaModel> GetParcelasByCondicaoPagamentoId(int idCondPagamento)
        {
            List<ParcelaModel> parcelas = new List<ParcelaModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM parcela WHERE idCondPagamento = @idCondPagamento";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCondPagamento", idCondPagamento);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ParcelaModel parcela = new ParcelaModel();
                        parcela.idParcela = Convert.ToInt32(reader["idParcela"]);
                        parcela.numeroParcela = Convert.ToInt32(reader["numeroParcela"]);
                        parcela.dias = Convert.ToInt32(reader["dias"]);
                        parcela.porcentagem = Convert.ToDecimal(reader["porcentagem"]);
                        parcela.idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]);
                        parcela.idFormaPagamento = Convert.ToInt32(reader["idFormaPagamento"]);

                        parcelas.Add(parcela);
                    }
                }
            }

            return parcelas;
        }

        public override void Salvar(CondicaoPagamentoModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //insere uma nova condicao de pagamento
                    string queryCondicaoPagamento = @"INSERT INTO condicaoPagamento 
                                               (condicaoPagamento, desconto, juros, multa, ativo, dataCadastro, dataUltAlt) 
                                               VALUES (@condicaoPagamento, @desconto, @juros, @multa, @ativo, @dataCadastro, @dataUltAlt);
                                               SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdCondicaoPagamento = new SqlCommand(queryCondicaoPagamento, conn, transaction); //novo comando para transacao e conexao
                    cmdCondicaoPagamento.Parameters.AddWithValue("@condicaoPagamento", obj.condicaoPagamento);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@desconto", obj.desconto);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@juros", obj.juros);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@multa", obj.multa);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@ativo", obj.Ativo);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);

                    int idCondPagamento = Convert.ToInt32(cmdCondicaoPagamento.ExecuteScalar()); //retorna o último valor da identidade gerada(SCOPE_IDENTITY)

                    //insere as parcelas da condição de pagamento
                    foreach (var parcela in obj.Parcelas)
                    {
                        string queryParcela = @"INSERT INTO parcela 
                                        (numeroParcela, dias, porcentagem, idCondPagamento, idFormaPagamento) 
                                        VALUES (@numeroParcela, @dias, @porcentagem, @idCondPagamento, @idFormaPagamento)";
                        SqlCommand cmdParcela = new SqlCommand(queryParcela, conn, transaction); //novo comando para inserir as parcelas e o id da condicao de pagamento
                        cmdParcela.Parameters.AddWithValue("@numeroParcela", parcela.numeroParcela);
                        cmdParcela.Parameters.AddWithValue("@dias", parcela.dias);
                        cmdParcela.Parameters.AddWithValue("@porcentagem", parcela.porcentagem);
                        cmdParcela.Parameters.AddWithValue("@idCondPagamento", idCondPagamento);
                        cmdParcela.Parameters.AddWithValue("@idFormaPagamento", parcela.idFormaPagamento);

                        cmdParcela.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro ao salvar condição de pagamento: " + ex.Message);
                }
            }
        }
    }
}
