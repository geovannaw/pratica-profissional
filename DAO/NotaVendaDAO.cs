using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.DAO
{
    public class NotaVendaDAO : DAO<NotaVendaModel>
    {
        public override void Alterar(NotaVendaModel obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<NotaVendaModel> GetAll(bool incluiInativos = false)
        {
            List<NotaVendaModel> notasVenda = new List<NotaVendaModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM notaVenda";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NotaVendaModel notaVenda = new NotaVendaModel();
                        notaVenda.numeroNota = Convert.ToInt32(reader["numeroNota"]);
                        notaVenda.modelo = Convert.ToInt32(reader["modelo"]);
                        notaVenda.serie = Convert.ToInt32(reader["serie"]);
                        notaVenda.idCliente = Convert.ToInt32(reader["idCliente"]);
                        notaVenda.dataEmissao = Convert.ToDateTime(reader["dataEmissao"]);
                        notaVenda.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;

                        notasVenda.Add(notaVenda);
                    }
                }
            }
            return notasVenda;
        }
        public NotaVendaModel GetNotaById(int numero, int modelo, int serie, int idCliente)
        {
            NotaVendaModel notaVenda = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM notaVenda WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroNota", numero);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@serie", serie);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        notaVenda = new NotaVendaModel
                        {
                            numeroNota = Convert.ToInt32(reader["numeroNota"]),
                            modelo = Convert.ToInt32(reader["modelo"]),
                            serie = Convert.ToInt32(reader["serie"]),
                            dataEmissao = Convert.ToDateTime(reader["dataEmissao"]),
                            idCliente = Convert.ToInt32(reader["idCliente"]),
                            totalProdutos = Convert.ToDecimal(reader["totalProdutos"]),
                            totalPagar = Convert.ToDecimal(reader["totalPagar"]),
                            porcentagemDesconto = Convert.ToDecimal(reader["porcentagemDesconto"]),
                            idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]),
                            observacao = reader["observacao"].ToString(),
                            dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null,
                            dataCadastro = Convert.ToDateTime(reader["dataCadastro"]),
                            dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]),
                        };

                        notaVenda.Produtos = GetProdutosByNFVenda(notaVenda.numeroNota, notaVenda.modelo, notaVenda.serie, notaVenda.idCliente);
                    }
                }
            }

            return notaVenda;
        }
        public List<NotaVenda_ProdutoModel> GetProdutosByNFVenda(int numeroNota, int modelo, int serie, int idCliente)
        {
            List<NotaVenda_ProdutoModel> produtos = new List<NotaVenda_ProdutoModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM notaVenda_Produto 
                         WHERE numeroNota = @numeroNota 
                         AND modelo = @modelo 
                         AND serie = @serie 
                         AND idCliente = @idCliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@serie", serie);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NotaVenda_ProdutoModel produto = new NotaVenda_ProdutoModel();
                        produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                        produto.precoProduto = Convert.ToDecimal(reader["precoProduto"]);
                        produto.quantidadeProduto = Convert.ToInt32(reader["quantidadeProduto"]);

                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
        }
        public override NotaVendaModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        public bool ExisteNota(int numeroNota, string modelo, string serie, int idCliente) //verificar se a nota existe no banco antes de liberar os campos
        {
            string query = "SELECT COUNT(*) FROM notaVenda WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@serie", serie);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }


        public override void Salvar(NotaVendaModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //insere uma nova nota de venda
                    string queryNFVenda = @"INSERT INTO notaVenda 
                                   (numeroNota, modelo, serie, idCliente, dataEmissao, totalProdutos, totalPagar, porcentagemDesconto, idCondPagamento, observacao, dataCadastro, dataUltAlt) 
                                   VALUES (@numeroNota, @modelo, @serie, @idCliente, @dataEmissao, @totalProdutos, @totalPagar, @porcentagemDesconto, @idCondPagamento, @observacao, @dataCadastro, @dataUltAlt);";
                    SqlCommand cmdNFVenda = new SqlCommand(queryNFVenda, conn, transaction);

                    cmdNFVenda.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                    cmdNFVenda.Parameters.AddWithValue("@modelo", obj.modelo);
                    cmdNFVenda.Parameters.AddWithValue("@serie", obj.serie);
                    cmdNFVenda.Parameters.AddWithValue("@idCliente", obj.idCliente);
                    cmdNFVenda.Parameters.AddWithValue("@dataEmissao", obj.dataEmissao);
                    cmdNFVenda.Parameters.AddWithValue("@totalProdutos", obj.totalProdutos);
                    cmdNFVenda.Parameters.AddWithValue("@totalPagar", obj.totalPagar);
                    cmdNFVenda.Parameters.AddWithValue("@porcentagemDesconto", obj.porcentagemDesconto);
                    cmdNFVenda.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                    cmdNFVenda.Parameters.AddWithValue("@observacao", obj.observacao);
                    cmdNFVenda.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdNFVenda.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);

                    cmdNFVenda.ExecuteNonQuery();

                    //insere os produtos da nota de venda
                    foreach (var produto in obj.Produtos)
                    {
                        string queryProduto = @"INSERT INTO notaVenda_Produto 
                                        (numeroNota, modelo, serie, idCliente, quantidadeProduto, precoProduto, idProduto) 
                                        VALUES (@numeroNota, @modelo, @serie, @idCliente, @quantidadeProduto, @precoProduto, @idProduto)";
                        SqlCommand cmdProduto = new SqlCommand(queryProduto, conn, transaction);

                        cmdProduto.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                        cmdProduto.Parameters.AddWithValue("@modelo", obj.modelo);
                        cmdProduto.Parameters.AddWithValue("@serie", obj.serie);
                        cmdProduto.Parameters.AddWithValue("@idCliente", obj.idCliente);
                        cmdProduto.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                        cmdProduto.Parameters.AddWithValue("@precoProduto", produto.precoProduto);
                        cmdProduto.Parameters.AddWithValue("@idProduto", produto.idProduto);

                        cmdProduto.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro no banco ao salvar Nota de Venda: " + ex.Message);
                }
            }
        }
        public ProdutoModel GetProdutoPorId(int idProduto)
        {
            ProdutoModel produto = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT produto, unidade FROM produto WHERE idProduto = @idProduto";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idProduto", idProduto);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        produto = new ProdutoModel
                        {
                            idProduto = idProduto,
                            Produto = reader["produto"].ToString(),
                            Unidade = reader["unidade"].ToString()
                        };
                    }
                }
            }
            return produto;
        }
        public void AtualizarProdutosNotaVenda(NotaVendaModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (var produto in obj.Produtos)
                    {
                        string queryUpdateProduto = @"UPDATE produto SET 
                                    saldo = saldo - @quantidadeProduto
                                    WHERE idProduto = @idProduto";
                        SqlCommand cmdUpdateProduto = new SqlCommand(queryUpdateProduto, conn, transaction);

                        cmdUpdateProduto.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                        cmdUpdateProduto.Parameters.AddWithValue("@dataUltCompra", obj.dataEmissao);
                        cmdUpdateProduto.Parameters.AddWithValue("@precoUltCompra", produto.precoProduto);
                        cmdUpdateProduto.Parameters.AddWithValue("@idProduto", produto.idProduto);

                        cmdUpdateProduto.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
        public bool CancelarNotaVenda(int numeroNota, int modelo, int serie, int idCliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        //add dataCancelamento na nota de compra
                        string queryCancelarNota = @"
                    UPDATE notaVenda
                    SET dataCancelamento = @dataCancelamento
                    WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente";

                        using (SqlCommand cmd = new SqlCommand(queryCancelarNota, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                            cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                            cmd.Parameters.AddWithValue("@modelo", modelo);
                            cmd.Parameters.AddWithValue("@serie", serie);
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }

                        //puxa os produtos da nota para atualizar o estoque
                        string queryProdutosNota = @"
                    SELECT idProduto, quantidadeProduto
                    FROM notaVenda_Produto
                    WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente";

                        List<(int idProduto, int quantidadeProduto)> produtos = new List<(int, int)>();

                        using (SqlCommand cmd = new SqlCommand(queryProdutosNota, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                            cmd.Parameters.AddWithValue("@modelo", modelo);
                            cmd.Parameters.AddWithValue("@serie", serie);
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int idProduto = reader.GetInt32(reader.GetOrdinal("idProduto"));
                                    int quantidadeProduto = reader.GetInt32(reader.GetOrdinal("quantidadeProduto"));
                                    produtos.Add((idProduto, quantidadeProduto));
                                }
                            }
                        }

                        //att o estoque
                        foreach (var produto in produtos)
                        {
                            string queryAtualizarEstoque = @"
                        UPDATE produto
                        SET saldo = saldo + @quantidadeProduto
                        WHERE idProduto = @idProduto";

                            using (SqlCommand cmd = new SqlCommand(queryAtualizarEstoque, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                                cmd.Parameters.AddWithValue("@idProduto", produto.idProduto);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        //cancela as contas a receber associadas a nota
                        string queryCancelarContasReceber = @"
                    UPDATE contasReceber
                    SET dataCancelamento = @dataCancelamento
                    WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente";

                        using (SqlCommand cmd = new SqlCommand(queryCancelarContasReceber, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                            cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                            cmd.Parameters.AddWithValue("@modelo", modelo);
                            cmd.Parameters.AddWithValue("@serie", serie);
                            cmd.Parameters.AddWithValue("@idCliente", idCliente);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao cancelar a Nota de Venda: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na conexão com o banco de dados: " + ex.Message);
            }
        }
    }
}
