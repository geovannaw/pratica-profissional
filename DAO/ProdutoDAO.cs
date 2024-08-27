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
    public class ProdutoDAO<T> : DAO<T>
    {
        public ProdutoDAO() : base() { }
        public int GetUltimoCodigo()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IDENT_CURRENT('produto')";
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
        public override void Alterar(T obj)
        {
            dynamic produto = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE produto SET produto = @produto, unidade = @unidade, saldo = @saldo, " +
                               "custoMedio = @custoMedio, precoVenda = @precoVenda, precoUltCompra = @precoUltCompra, " +
                               "dataUltCompra = @dataUltCompra, observacao = @observacao, ativo = @ativo, " +
                               "dataUltAlt = @dataUltAlt, idFornecedor = @idFornecedor, idModelo = @idModelo WHERE idProduto = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", produto.idProduto);
                command.Parameters.AddWithValue("@produto", produto.Produto);
                command.Parameters.AddWithValue("@unidade", produto.Unidade);
                command.Parameters.AddWithValue("@saldo", produto.Saldo);
                command.Parameters.AddWithValue("@custoMedio", produto.custoMedio);
                command.Parameters.AddWithValue("@precoVenda", produto.precoVenda);
                command.Parameters.AddWithValue("@precoUltCompra", produto.precoUltCompra);
                command.Parameters.AddWithValue("@dataUltCompra", (object)produto.dataUltCompra ?? DBNull.Value);
                command.Parameters.AddWithValue("@observacao", produto.Observacao);
                command.Parameters.AddWithValue("@ativo", produto.Ativo);
                command.Parameters.AddWithValue("@dataUltAlt", produto.dataUltAlt);
                command.Parameters.AddWithValue("@idFornecedor", produto.idFornecedor);
                command.Parameters.AddWithValue("@idModelo", produto.idModelo);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao alterar produto: " + ex.Message);
                    throw;
                }
            }
        }
        public void AtualizarSaldo(int idProduto, int quantidade)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Produto SET saldo = saldo + @quantidade WHERE idProduto = @idProduto";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@idProduto", idProduto);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao atualizar saldo do produto: " + ex.Message);
                    throw;
                }
            }
        }

        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryCheckSaldo = "SELECT saldo FROM produto WHERE idProduto = @id";
                SqlCommand commandCheckSaldo = new SqlCommand(queryCheckSaldo, connection);
                commandCheckSaldo.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    //verifica o saldo do produto
                    object saldoObj = commandCheckSaldo.ExecuteScalar();
                    if (saldoObj != null)
                    {
                        decimal saldo = Convert.ToDecimal(saldoObj);
                        if (saldo > 0)
                        {
                            MessageBox.Show("Não é possível excluir o produto, pois ele ainda possui saldo.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    //se o saldo for 0, continua a exclusão
                    string queryDelete = "DELETE FROM produto WHERE idProduto = @id";
                    SqlCommand commandDelete = new SqlCommand(queryDelete, connection);
                    commandDelete.Parameters.AddWithValue("@id", id);
                    commandDelete.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    //verifica se a exceção está relacionada a uma restrição de chave estrangeira (uso em algum cadastro)
                    if (ex.Number == 547) //código de erro para conflito de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o Produto, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public override List<T> GetAll(bool incluiInativos = false)
        {
            List<T> produtos = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM produto" : "SELECT * FROM produto WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idProduto = Convert.ToInt32(reader["idProduto"]);
                        obj.Produto = reader["produto"].ToString();
                        obj.Unidade = reader["unidade"].ToString();
                        obj.precoVenda = Convert.ToDecimal(reader["precoVenda"]);
                        obj.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                        produtos.Add(obj);
                    }
                }
            }
            return produtos;
        }

        public override T GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM produto WHERE idProduto = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idProduto = Convert.ToInt32(reader["idProduto"]);
                        obj.Produto = reader["produto"].ToString();
                        obj.Unidade = reader["unidade"].ToString();
                        obj.Saldo = Convert.ToInt32(reader["saldo"]);
                        obj.precoVenda = Convert.ToDecimal(reader["precoVenda"]);
                        obj.precoUltCompra = Convert.ToDecimal(reader["precoUltCompra"]);
                        obj.custoMedio = Convert.ToDecimal(reader["custoMedio"]);
                        obj.Observacao = reader["observacao"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        obj.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                        obj.idModelo = Convert.ToInt32(reader["idModelo"]);

                        obj.dataUltCompra = reader["dataUltCompra"] != DBNull.Value ? Convert.ToDateTime(reader["dataUltCompra"]) : (DateTime?)null;
                        return obj;
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }

        public override void Salvar(T obj)
        {
            dynamic produto = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO produto (produto, unidade, saldo, custoMedio, precoVenda, precoUltCompra, dataUltCompra, observacao, ativo, dataCadastro, dataUltAlt, idFornecedor, idModelo) " +
                               "VALUES (@produto, @unidade, @saldo, @custoMedio, @precoVenda, @precoUltCompra, @dataUltCompra, @observacao, @ativo, @dataCadastro, @dataUltAlt, @idFornecedor, @idModelo)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", produto.idProduto);
                command.Parameters.AddWithValue("@produto", produto.Produto);
                command.Parameters.AddWithValue("@unidade", produto.Unidade);
                command.Parameters.AddWithValue("@saldo", produto.Saldo);
                command.Parameters.AddWithValue("@custoMedio", produto.custoMedio);
                command.Parameters.AddWithValue("@precoVenda", produto.precoVenda);
                command.Parameters.AddWithValue("@precoUltCompra", produto.precoUltCompra);
                command.Parameters.AddWithValue("@dataUltCompra", produto.dataUltCompra ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@observacao", produto.Observacao);
                command.Parameters.AddWithValue("@ativo", produto.Ativo);
                command.Parameters.AddWithValue("@dataUltAlt", produto.dataUltAlt);
                command.Parameters.AddWithValue("@dataCadastro", produto.dataCadastro);
                command.Parameters.AddWithValue("@idFornecedor", produto.idFornecedor);
                command.Parameters.AddWithValue("@idModelo", produto.idModelo);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar produto: " + ex.Message);
                    throw;
                }
            }
        }
    }
}
