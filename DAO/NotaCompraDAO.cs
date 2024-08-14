using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.DAO
{
    public class NotaCompraDAO : DAO<NotaCompraModel>
    {
        public override void Alterar(NotaCompraModel obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<NotaCompraModel> GetAll(bool incluiInativos = false)
        {
            List<NotaCompraModel> notasCompra = new List<NotaCompraModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM notaCompra";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NotaCompraModel notaCompra = new NotaCompraModel();
                        notaCompra.numeroNota = Convert.ToInt32(reader["numeroNota"]);
                        notaCompra.modelo = Convert.ToInt32(reader["modelo"]);
                        notaCompra.serie = Convert.ToInt32(reader["serie"]);
                        notaCompra.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                        notaCompra.dataChegada = Convert.ToDateTime(reader["dataChegada"]);

                        notasCompra.Add(notaCompra);
                    }
                }
            }
            return notasCompra;
        }

        public NotaCompraModel GetNotaById(int numero, int modelo, int serie, int idFornecedor)
        {
            NotaCompraModel notaCompra = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM notaCompra WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroNota", numero);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@serie", serie);
                cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        notaCompra = new NotaCompraModel
                        {
                            numeroNota = Convert.ToInt32(reader["numeroNota"]),
                            modelo = Convert.ToInt32(reader["modelo"]),
                            serie = Convert.ToInt32(reader["serie"]),
                            dataChegada = Convert.ToDateTime(reader["dataChegada"]),
                            dataEmissao = Convert.ToDateTime(reader["dataEmissao"]),
                            idFornecedor = Convert.ToInt32(reader["idFornecedor"]),
                            tipoFrete = Convert.ToBoolean(reader["tipoFrete"]),
                            valorFrete = reader["valorFrete"] != DBNull.Value ? Convert.ToDecimal(reader["valorFrete"]) : (decimal?)null,
                            valorSeguro = reader["valorSeguro"] != DBNull.Value ? Convert.ToDecimal(reader["valorSeguro"]) : (decimal?)null,
                            outrasDespesas = reader["outrasDespesas"] != DBNull.Value ? Convert.ToDecimal(reader["outrasDespesas"]) : (decimal?)null,
                            totalProdutos = Convert.ToDecimal(reader["totalProdutos"]),
                            totalPagar = Convert.ToDecimal(reader["totalPagar"]),
                            idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]),
                            observacao = reader["observacao"].ToString(),
                            dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null,
                            dataCadastro = Convert.ToDateTime(reader["dataCadastro"]),
                            dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]),
                        };

                        notaCompra.Produtos = GetProdutosByNFCompra(notaCompra.numeroNota, notaCompra.modelo, notaCompra.serie, notaCompra.idFornecedor);
                    }
                }
            }

            return notaCompra;
        }

        public List<NotaCompra_ProdutoModel> GetProdutosByNFCompra(int numeroNota, int modelo, int serie, int idFornecedor)
        {
            List<NotaCompra_ProdutoModel> produtos = new List<NotaCompra_ProdutoModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM notaCompra_Produto 
                         WHERE numeroNota = @numeroNota 
                         AND modelo = @modelo 
                         AND serie = @serie 
                         AND idFornecedor = @idFornecedor";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@serie", serie);
                cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NotaCompra_ProdutoModel produto = new NotaCompra_ProdutoModel();
                        produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                        produto.precoProduto = Convert.ToDecimal(reader["precoProduto"]);
                        produto.quantidadeProduto = Convert.ToInt32(reader["quantidadeProduto"]);

                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
        }


        public override NotaCompraModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExisteNota(int numeroNota, string modelo, string serie, int idFornecedor) //verificar se a nota existe no banco antes de liberar os campos
        {
            string query = "SELECT COUNT(*) FROM notaCompra WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@serie", serie);
                cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }


        public override void Salvar(NotaCompraModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //insere uma nova nota de compra
                    string queryNFCompra = @"INSERT INTO notaCompra 
                                   (numeroNota, modelo, serie, idFornecedor, dataEmissao, dataChegada, tipoFrete, valorFrete, valorSeguro, outrasDespesas, totalProdutos, totalPagar, idCondPagamento, observacao, dataCadastro, dataUltAlt) 
                                   VALUES (@numeroNota, @modelo, @serie, @idFornecedor, @dataEmissao, @dataChegada, @tipoFrete, @valorFrete, @valorSeguro, @outrasDespesas, @totalProdutos, @totalPagar, @idCondPagamento, @observacao, @dataCadastro, @dataUltAlt);";
                    SqlCommand cmdNFCompra = new SqlCommand(queryNFCompra, conn, transaction);

                    cmdNFCompra.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                    cmdNFCompra.Parameters.AddWithValue("@modelo", obj.modelo);
                    cmdNFCompra.Parameters.AddWithValue("@serie", obj.serie);
                    cmdNFCompra.Parameters.AddWithValue("@idFornecedor", obj.idFornecedor);
                    cmdNFCompra.Parameters.AddWithValue("@dataEmissao", obj.dataEmissao);
                    cmdNFCompra.Parameters.AddWithValue("@dataChegada", obj.dataChegada);
                    cmdNFCompra.Parameters.AddWithValue("@tipoFrete", obj.tipoFrete);
                    cmdNFCompra.Parameters.AddWithValue("@valorFrete", obj.valorFrete);
                    cmdNFCompra.Parameters.AddWithValue("@valorSeguro", obj.valorSeguro);
                    cmdNFCompra.Parameters.AddWithValue("@outrasDespesas", obj.outrasDespesas);
                    cmdNFCompra.Parameters.AddWithValue("@totalProdutos", obj.totalProdutos);
                    cmdNFCompra.Parameters.AddWithValue("@totalPagar", obj.totalPagar);
                    cmdNFCompra.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                    cmdNFCompra.Parameters.AddWithValue("@observacao", obj.observacao);
                    cmdNFCompra.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdNFCompra.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);

                    cmdNFCompra.ExecuteNonQuery();

                    //insere os produtos da nota de compra
                    foreach (var produto in obj.Produtos)
                    {
                        string queryProduto = @"INSERT INTO notaCompra_Produto 
                                        (numeroNota, modelo, serie, idFornecedor, quantidadeProduto, precoProduto, idProduto) 
                                        VALUES (@numeroNota, @modelo, @serie, @idFornecedor, @quantidadeProduto, @precoProduto, @idProduto)";
                        SqlCommand cmdProduto = new SqlCommand(queryProduto, conn, transaction);

                        cmdProduto.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                        cmdProduto.Parameters.AddWithValue("@modelo", obj.modelo);
                        cmdProduto.Parameters.AddWithValue("@serie", obj.serie);
                        cmdProduto.Parameters.AddWithValue("@idFornecedor", obj.idFornecedor);
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
                    throw new Exception("Erro no banco ao salvar Nota de Compra: " + ex.Message);
                }
            }
        }
    }
}

