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
                               "custo_medio = @custo_medio, preco_venda = @preco_venda, preco_ult_compra = @preco_ult_compra, " +
                               "data_ult_compra = @data_ult_compra, observacao = @observacao, ativo = @ativo, " +
                               "dataUltAlt = @dataUltAlt, idFornecedor = @idFornecedor, idModelo = @idModelo WHERE idProduto = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", produto.idProduto);
                command.Parameters.AddWithValue("@produto", produto.Produto);
                command.Parameters.AddWithValue("@unidade", produto.Unidade);
                command.Parameters.AddWithValue("@saldo", produto.Saldo);
                command.Parameters.AddWithValue("@custo_medio", produto.Custo_medio);
                command.Parameters.AddWithValue("@preco_venda", produto.Preco_venda);
                command.Parameters.AddWithValue("@preco_ult_compra", produto.Preco_ult_compra);
                command.Parameters.AddWithValue("@data_ult_compra", produto.Data_ult_compra);
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
                string query = "DELETE FROM produto WHERE idProduto = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
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
                        obj.Preco_venda = Convert.ToDecimal(reader["preco_venda"]);
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
                        obj.Custo_medio = Convert.ToDecimal(reader["custo_medio"]);
                        obj.Preco_venda = Convert.ToDecimal(reader["preco_venda"]);
                        obj.Preco_ult_compra = Convert.ToDecimal(reader["preco_ult_compra"]);
                        obj.Data_ult_compra = DateTime.Parse(reader["data_ult_compra"].ToString());
                        obj.Observacao = reader["observacao"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        obj.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                        obj.idModelo = Convert.ToInt32(reader["idModelo"]);
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
                string query = "INSERT INTO produto (produto, unidade, saldo, custo_medio, preco_venda, preco_ult_compra, data_ult_compra, observacao, ativo, dataCadastro, dataUltAlt, idFornecedor, idModelo) " +
                               "VALUES (@produto, @unidade, @saldo, @custo_medio, @preco_venda, @preco_ult_compra, @data_ult_compra, @observacao, @ativo, @dataCadastro, @dataUltAlt, @idFornecedor, @idModelo)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", produto.idProduto);
                command.Parameters.AddWithValue("@produto", produto.Produto);
                command.Parameters.AddWithValue("@unidade", produto.Unidade);
                command.Parameters.AddWithValue("@saldo", produto.Saldo);
                command.Parameters.AddWithValue("@custo_medio", produto.Custo_medio);
                command.Parameters.AddWithValue("@preco_venda", produto.Preco_venda);
                command.Parameters.AddWithValue("@preco_ult_compra", produto.Preco_ult_compra);
                command.Parameters.AddWithValue("@data_ult_compra", produto.Data_ult_compra);
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
