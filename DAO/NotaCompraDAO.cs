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
                        notaCompra.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;

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
                            usuario = reader["usuario"].ToString(),
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
                        produto.descontoProd = reader["desconto"] != DBNull.Value ? Convert.ToDecimal(reader["desconto"]) : (decimal?)null;
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
            string query = "SELECT COUNT(*) FROM notaCompra WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor AND dataCancelamento IS NULL";

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
                                   (numeroNota, modelo, serie, idFornecedor, dataEmissao, dataChegada, tipoFrete, valorFrete, valorSeguro, outrasDespesas, totalProdutos, totalPagar, idCondPagamento, observacao, dataCadastro, dataUltAlt, usuario) 
                                   VALUES (@numeroNota, @modelo, @serie, @idFornecedor, @dataEmissao, @dataChegada, @tipoFrete, @valorFrete, @valorSeguro, @outrasDespesas, @totalProdutos, @totalPagar, @idCondPagamento, @observacao, @dataCadastro, @dataUltAlt, @usuario);";
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
                    cmdNFCompra.Parameters.AddWithValue("@usuario", obj.usuario);

                    cmdNFCompra.ExecuteNonQuery();

                    //insere os produtos da nota de compra
                    foreach (var produto in obj.Produtos)
                    {
                        string queryProduto = @"INSERT INTO notaCompra_Produto 
                                        (numeroNota, modelo, serie, idFornecedor, quantidadeProduto, precoProduto, custoMedio, custoUltCompra, rateio, idProduto, desconto) 
                                        VALUES (@numeroNota, @modelo, @serie, @idFornecedor, @quantidadeProduto, @precoProduto, @custoMedio, @custoUltCompra, @rateio, @idProduto, @desconto)";
                        SqlCommand cmdProduto = new SqlCommand(queryProduto, conn, transaction);

                        cmdProduto.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                        cmdProduto.Parameters.AddWithValue("@modelo", obj.modelo);
                        cmdProduto.Parameters.AddWithValue("@serie", obj.serie);
                        cmdProduto.Parameters.AddWithValue("@idFornecedor", obj.idFornecedor);
                        cmdProduto.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                        cmdProduto.Parameters.AddWithValue("@precoProduto", produto.precoProduto);
                        cmdProduto.Parameters.AddWithValue("@custoMedio", produto.custoMedio);
                        cmdProduto.Parameters.AddWithValue("@custoUltCompra", produto.custoUltCompra);
                        cmdProduto.Parameters.AddWithValue("@rateio", produto.rateio.HasValue ? (object)produto.rateio.Value : DBNull.Value);
                        cmdProduto.Parameters.AddWithValue("@desconto", produto.descontoProd.HasValue ? (object)produto.descontoProd.Value : DBNull.Value);
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
        private decimal calcularNovoCustoMedio(int saldoAtual, decimal custoMedioAtual, int quantidadeComprada, decimal custoNovaCompra)
        {
            if (saldoAtual == 0)
            {
                return Math.Round(custoNovaCompra, 4); 
            }
            decimal novoCustoMedio = ((saldoAtual * custoMedioAtual) + (quantidadeComprada * custoNovaCompra)) / (saldoAtual + quantidadeComprada);
            return Math.Round(novoCustoMedio, 4);
        }

        public void AtualizarProdutosNotaCompra(NotaCompraModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (var produto in obj.Produtos)
                    {
                        string querySelectProduto = "SELECT saldo, custoMedio FROM produto WHERE idProduto = @idProduto";
                        SqlCommand cmdSelectProduto = new SqlCommand(querySelectProduto, conn, transaction);
                        cmdSelectProduto.Parameters.AddWithValue("@idProduto", produto.idProduto);

                        using (SqlDataReader reader = cmdSelectProduto.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int saldoAtual = Convert.ToInt32(reader["saldo"]);
                                decimal custoMedioAtual = Convert.ToDecimal(reader["custoMedio"]);

                                decimal novoCustoMedio = calcularNovoCustoMedio(saldoAtual, custoMedioAtual, produto.quantidadeProduto, produto.custoUltCompra);

                                reader.Close();

                                string queryUpdateProduto = @"UPDATE produto SET 
                            saldo = saldo + @quantidadeProduto,
                            custoMedio = @novoCustoMedio,
                            custoUltCompra = @custoUltCompra,  
                            dataUltCompra = @dataUltCompra,
                            precoUltCompra = @precoUltCompra  
                            WHERE idProduto = @idProduto";

                                SqlCommand cmdUpdateProduto = new SqlCommand(queryUpdateProduto, conn, transaction);

                                cmdUpdateProduto.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                                cmdUpdateProduto.Parameters.AddWithValue("@novoCustoMedio", novoCustoMedio);
                                cmdUpdateProduto.Parameters.AddWithValue("@custoUltCompra", produto.custoUltCompra);
                                cmdUpdateProduto.Parameters.AddWithValue("@dataUltCompra", obj.dataEmissao);
                                cmdUpdateProduto.Parameters.AddWithValue("@precoUltCompra", produto.precoProduto); 
                                cmdUpdateProduto.Parameters.AddWithValue("@idProduto", produto.idProduto);

                                cmdUpdateProduto.ExecuteNonQuery();
                            }
                        }
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

        public class ParcelaPagaException : Exception
        {
            public ParcelaPagaException(string message) : base(message) { }
        }
        public bool CancelarNotaCompra(int numeroNota, int modelo, int serie, int idFornecedor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        //verifica se há alguma parcela paga
                        string queryVerificarParcelaPaga = @"
                    SELECT COUNT(*) 
                    FROM contasPagar 
                    WHERE numeroNota = @numeroNota 
                        AND modelo = @modelo 
                        AND serie = @serie 
                        AND idFornecedor = @idFornecedor
                        AND dataPagamento IS NOT NULL";

                        using (SqlCommand cmd = new SqlCommand(queryVerificarParcelaPaga, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                            cmd.Parameters.AddWithValue("@modelo", modelo);
                            cmd.Parameters.AddWithValue("@serie", serie);
                            cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);

                            int parcelasPagas = (int)cmd.ExecuteScalar();

                            if (parcelasPagas > 0)
                            {
                                throw new ParcelaPagaException("Não é possível cancelar! Existem parcelas já pagas para esta nota.");
                            }
                        }

                        //adiciona a data de cancelamento na nota de compra
                        string queryCancelarNota = @"
                UPDATE notaCompra
                SET dataCancelamento = @dataCancelamento
                WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor";

                        using (SqlCommand cmd = new SqlCommand(queryCancelarNota, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                            cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                            cmd.Parameters.AddWithValue("@modelo", modelo);
                            cmd.Parameters.AddWithValue("@serie", serie);
                            cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
                            cmd.ExecuteNonQuery();
                        }

                        //busca os produtos da nota para atualizar o estoque
                        string queryProdutosNota = @"
                SELECT idProduto, quantidadeProduto
                FROM notaCompra_Produto
                WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor";

                        List<(int idProduto, int quantidadeProduto)> produtos = new List<(int, int)>();

                        using (SqlCommand cmd = new SqlCommand(queryProdutosNota, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                            cmd.Parameters.AddWithValue("@modelo", modelo);
                            cmd.Parameters.AddWithValue("@serie", serie);
                            cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
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

                        //atualiza o estoque
                        foreach (var produto in produtos)
                        {
                            //tenta encontrar uma nota de compra anterior válida (sem dataCancelamento)
                            string queryNotaAnterior = @"
                    SELECT TOP 1 nc.dataChegada, ncp.precoProduto, ncp.custoMedio
                    FROM notaCompra nc
                    JOIN notaCompra_Produto ncp ON nc.numeroNota = ncp.numeroNota AND nc.modelo = ncp.modelo AND nc.serie = ncp.serie AND nc.idFornecedor = ncp.idFornecedor
                    WHERE ncp.idProduto = @idProduto AND nc.dataCancelamento IS NULL
                    ORDER BY nc.dataChegada DESC";

                            DateTime? dataUltCompra = null;
                            decimal precoUltCompra = 0;
                            decimal custoMedio = 0;
                            bool notaAnteriorEncontrada = false;

                            using (SqlCommand cmd = new SqlCommand(queryNotaAnterior, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@idProduto", produto.idProduto);
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        dataUltCompra = reader.GetDateTime(reader.GetOrdinal("dataChegada"));
                                        precoUltCompra = reader.GetDecimal(reader.GetOrdinal("precoProduto"));
                                        custoMedio = reader.GetDecimal(reader.GetOrdinal("custoMedio"));
                                        notaAnteriorEncontrada = true;
                                    }
                                }
                            }

                            //atualiza o saldo do produto e, se houver uma nota válida anterior, atualiza os atributos do produto
                            string queryAtualizarEstoque = @"
                    UPDATE produto
                    SET saldo = saldo - @quantidadeProduto, custoMedio = @custoMedio, dataUltCompra = @dataUltCompra, precoUltCompra = @precoUltCompra
                    WHERE idProduto = @idProduto";

                            using (SqlCommand cmd = new SqlCommand(queryAtualizarEstoque, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                                cmd.Parameters.AddWithValue("@idProduto", produto.idProduto);
                                cmd.Parameters.AddWithValue("@custoMedio", notaAnteriorEncontrada ? custoMedio : 0);
                                cmd.Parameters.AddWithValue("@dataUltCompra", (object)dataUltCompra ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@precoUltCompra", notaAnteriorEncontrada ? precoUltCompra : 0);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        //cancela as contas a pagar associadas à nota
                        string queryCancelarContasPagar = @"
                UPDATE contasPagar
                SET dataCancelamento = @dataCancelamento
                WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor";

                        using (SqlCommand cmd = new SqlCommand(queryCancelarContasPagar, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@dataCancelamento", DateTime.Now);
                            cmd.Parameters.AddWithValue("@numeroNota", numeroNota);
                            cmd.Parameters.AddWithValue("@modelo", modelo);
                            cmd.Parameters.AddWithValue("@serie", serie);
                            cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (ParcelaPagaException)
                    {
                        transaction.Rollback();
                        throw; //lançar novamente a exceção de parcela paga sem alterar a mensagem
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao cancelar a nota de compra: " + ex.Message);
                    }
                }
            }
            catch (ParcelaPagaException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na conexão com o banco de dados: " + ex.Message);
            }
        }

    }
}

