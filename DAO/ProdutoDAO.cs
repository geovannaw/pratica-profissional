using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.DAO
{
    public class ProdutoDAO<T> : DAO<T>
    {
        public ProdutoDAO() : base() { }

        public override void Alterar(T obj)
        {
            dynamic produto = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE produto SET descricao = @descricao, unidade = @unidade, saldo = @saldo, " +
                               "custo_medio = @custo_medio, preco_venda = @preco_venda, preco_ult_compra = @preco_ult_compra, " +
                               "data_ult_compra = @data_ult_compra, observacao = @observacao, ativo = @ativo, " +
                               "dataUltAlt = @dataUltAlt, idFornecedor = @idFornecedor, idModelo = @idModelo WHERE idProduto = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", produto.idProduto);
                command.Parameters.AddWithValue("@descricao", produto.Descricao);
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

        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM produto WHERE idProduto = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
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
                        obj.Descricao = reader["descricao"].ToString();
                        obj.Unidade = reader["unidade"].ToString();
                        obj.Preco_venda = Convert.ToDecimal(reader["preco_venda"]);
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
                        obj.Descricao = reader["descricao"].ToString();
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
                string query = "INSERT INTO produto (descricao, unidade, saldo, custo_medio, preco_venda, preco_ult_compra, data_ult_compra, observacao, ativo, dataCadastro, dataUltAlt, idFornecedor, idModelo) " +
                               "VALUES (@descricao, @unidade, @saldo, @custo_medio, @preco_venda, @preco_ult_compra, @data_ult_compra, @observacao, @ativo, @dataCadastro, @dataUltAlt, @idFornecedor, @idModelo)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", produto.idProduto);
                command.Parameters.AddWithValue("@descricao", produto.Descricao);
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
