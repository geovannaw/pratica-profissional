using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
        public int GetUltimoCodigo()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IDENT_CURRENT('condicaoPagamento')";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    ultimoCodigo = Convert.ToInt32(result);
                }
            }
            return ultimoCodigo;
        }
        public override void Alterar(CondicaoPagamentoModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); //inicia a transação

                try
                {
                    //comando p/ atualizar a condição de pagamento
                    string queryCondicaoPagamento = @"UPDATE condicaoPagamento 
                                               SET condicaoPagamento = @condicaoPagamento, desconto = @desconto, juros = @juros, multa = @multa, ativo = @ativo, dataUltAlt = @dataUltAlt, usuario = @usuario 
                                               WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdCondicaoPagamento = new SqlCommand(queryCondicaoPagamento, conn, transaction);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@condicaoPagamento", obj.condicaoPagamento);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@desconto", obj.desconto);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@juros", obj.juros);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@multa", obj.multa);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@ativo", obj.Ativo);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@usuario", obj.usuario);

                    cmdCondicaoPagamento.ExecuteNonQuery(); //atualiza condição de pagamento

                    //obtem as parcelas que existem no banco referente ao id da cond. pagamento atual
                    string querySelectParcelas = "SELECT * FROM parcela WHERE idCondPagamento = @idCondPagamento";
                    SqlCommand cmdSelectParcelas = new SqlCommand(querySelectParcelas, conn, transaction);
                    cmdSelectParcelas.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectParcelas);
                    DataTable parcelasExistentes = new DataTable();
                    adapter.Fill(parcelasExistentes); //preenche um datatable com as parcelas

                    //percorre as parcelas
                    foreach (var parcela in obj.Parcelas)
                    {
                        bool existe = false; //verificar se parcela existe ou nao

                        foreach (DataRow row in parcelasExistentes.Rows) //percorre as parcelas no banco
                        {
                            if ((int)row["numeroParcela"] == parcela.numeroParcela) //vê se aquele nro de parcela já existe
                            {
                                //atualiza a parcela existente
                                string queryUpdateParcela = @"UPDATE parcela 
                                                      SET dias = @dias, porcentagem = @porcentagem, idFormaPagamento = @idFormaPagamento 
                                                      WHERE idCondPagamento = @idCondPagamento AND numeroParcela = @numeroParcela";
                                SqlCommand cmdUpdateParcela = new SqlCommand(queryUpdateParcela, conn, transaction);
                                cmdUpdateParcela.Parameters.AddWithValue("@dias", parcela.dias);
                                cmdUpdateParcela.Parameters.AddWithValue("@porcentagem", parcela.porcentagem);
                                cmdUpdateParcela.Parameters.AddWithValue("@idFormaPagamento", parcela.idFormaPagamento);
                                cmdUpdateParcela.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                                cmdUpdateParcela.Parameters.AddWithValue("@numeroParcela", parcela.numeroParcela);

                                cmdUpdateParcela.ExecuteNonQuery();
                                existe = true; //marca que a parcela existe
                                break;
                            }
                        }
                        if (!existe) //se não existir a parcela
                        {
                            //insere nova parcela
                            string queryInsertParcela = @"INSERT INTO parcela 
                                                  (numeroParcela, dias, porcentagem, idCondPagamento, idFormaPagamento) 
                                                  VALUES (@numeroParcela, @dias, @porcentagem, @idCondPagamento, @idFormaPagamento)";
                            SqlCommand cmdInsertParcela = new SqlCommand(queryInsertParcela, conn, transaction);
                            cmdInsertParcela.Parameters.AddWithValue("@numeroParcela", parcela.numeroParcela);
                            cmdInsertParcela.Parameters.AddWithValue("@dias", parcela.dias);
                            cmdInsertParcela.Parameters.AddWithValue("@porcentagem", parcela.porcentagem);
                            cmdInsertParcela.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                            cmdInsertParcela.Parameters.AddWithValue("@idFormaPagamento", parcela.idFormaPagamento);

                            cmdInsertParcela.ExecuteNonQuery();
                        }
                    }
                    foreach (DataRow row in parcelasExistentes.Rows) //percorre dnv as parcelas
                    {
                        bool existe = false; 
                        foreach (var parcela in obj.Parcelas) //vê se a parcela ainda existe
                        {
                            if ((int)row["numeroParcela"] == parcela.numeroParcela)
                            {
                                existe = true;
                                break;
                            }
                        }
                        if (!existe) //se nao existe mais
                        {   //apaga a parcela q nao foi encontrada
                            string queryDeleteParcela = "DELETE FROM parcela WHERE idCondPagamento = @idCondPagamento AND numeroParcela = @numeroParcela";
                            SqlCommand cmdDeleteParcela = new SqlCommand(queryDeleteParcela, conn, transaction);
                            cmdDeleteParcela.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                            cmdDeleteParcela.Parameters.AddWithValue("@numeroParcela", (int)row["numeroParcela"]);

                            cmdDeleteParcela.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit(); //confirma a transação
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); //se der erro, volta
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
                        condicaoPagamento.usuario = reader["usuario"].ToString();
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
                                               (condicaoPagamento, desconto, juros, multa, ativo, dataCadastro, dataUltAlt, usuario) 
                                               VALUES (@condicaoPagamento, @desconto, @juros, @multa, @ativo, @dataCadastro, @dataUltAlt, @usuario);
                                               SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdCondicaoPagamento = new SqlCommand(queryCondicaoPagamento, conn, transaction); //novo comando para transacao e conexao
                    cmdCondicaoPagamento.Parameters.AddWithValue("@condicaoPagamento", obj.condicaoPagamento);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@desconto", obj.desconto);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@juros", obj.juros);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@multa", obj.multa);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@ativo", obj.Ativo);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdCondicaoPagamento.Parameters.AddWithValue("@usuario", obj.usuario);

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
