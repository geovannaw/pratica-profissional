using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Sistema_Vendas.Models;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace Sistema_Vendas.DAO
{
    public class OSDAO : DAO<OrdemServicoModel>
    {
        public int GetUltimoCodigo()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idOrdemServico) FROM ordemServico";
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
        public override void Salvar(OrdemServicoModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryOS = @"INSERT INTO ordemServico 
                               (data, precoTotal, status, dataEntrega, observacao, idCliente, idCondPagamento, porcentagemDesconto, idFuncionario, dataPrevista, dataCancelamento, valorRetirada, valorEntrada, dataCadastro, dataUltAlt, Ativo, usuario) 
                               VALUES (@data, @precoTotal, @status, @dataEntrega, @observacao, @idCliente, @idCondPagamento, @porcentagemDesconto, @idFuncionario, @dataPrevista, @dataCancelamento, @valorRetirada, @valorEntrada, @dataCadastro, @dataUltAlt, @Ativo, @usuario);
                               SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdOS = new SqlCommand(queryOS, conn, transaction);
                    cmdOS.Parameters.AddWithValue("@data", obj.data);
                    cmdOS.Parameters.AddWithValue("@precoTotal", obj.precoTotal);
                    cmdOS.Parameters.AddWithValue("@valorEntrada", obj.valorEntrada);
                    cmdOS.Parameters.AddWithValue("@status", obj.status);
                    cmdOS.Parameters.AddWithValue("@observacao", obj.observacao);
                    cmdOS.Parameters.AddWithValue("@idCliente", obj.idCliente);
                    cmdOS.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                    cmdOS.Parameters.AddWithValue("@porcentagemDesconto", obj.porcentagemDesconto);
                    cmdOS.Parameters.AddWithValue("@idFuncionario", obj.idFuncionario);
                    cmdOS.Parameters.AddWithValue("@dataPrevista", obj.dataPrevista);
                    cmdOS.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdOS.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdOS.Parameters.AddWithValue("@Ativo", obj.Ativo);
                    cmdOS.Parameters.AddWithValue("@usuario", obj.usuario);

                    cmdOS.Parameters.AddWithValue("@dataEntrega", obj.dataEntrega.HasValue ? (object)obj.dataEntrega.Value : DBNull.Value);
                    cmdOS.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento.HasValue ? (object)obj.dataCancelamento.Value : DBNull.Value);
                    cmdOS.Parameters.AddWithValue("@valorRetirada", obj.valorRetirada.HasValue ? (object)obj.valorRetirada.Value : DBNull.Value);

                    int idOrdemServico = Convert.ToInt32(cmdOS.ExecuteScalar());
                    foreach (var produto in obj.Produtos)
                    {
                        produto.idOrdemServico = idOrdemServico;
                    }
                    foreach (var servico in obj.Servicos)
                    {
                        servico.idOrdemServico = idOrdemServico;
                    }
                    foreach (var produto in obj.Produtos)
                    {
                        string queryProduto = @"INSERT INTO OS_Produto 
                                        (quantidadeProduto, precoProduto, idOrdemServico, idProduto) 
                                        VALUES (@quantidadeProduto, @precoProduto, @idOrdemServico, @idProduto)";
                        SqlCommand cmdProduto = new SqlCommand(queryProduto, conn, transaction);
                        cmdProduto.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                        cmdProduto.Parameters.AddWithValue("@precoProduto", produto.precoProduto);
                        cmdProduto.Parameters.AddWithValue("@idOrdemServico", produto.idOrdemServico);
                        cmdProduto.Parameters.AddWithValue("@idProduto", produto.idProduto);

                        cmdProduto.ExecuteNonQuery();
                    }
                    foreach (var servico in obj.Servicos)
                    {
                        string queryServico = @"INSERT INTO OS_Servico 
                                        (quantidadeServico, precoServico, idOrdemServico, idServico) 
                                        VALUES (@quantidadeServico, @precoServico, @idOrdemServico, @idServico)";
                        SqlCommand cmdServico = new SqlCommand(queryServico, conn, transaction);
                        cmdServico.Parameters.AddWithValue("@quantidadeServico", servico.quantidadeServico);
                        cmdServico.Parameters.AddWithValue("@precoServico", servico.precoServico);
                        cmdServico.Parameters.AddWithValue("@idOrdemServico", servico.idOrdemServico);
                        cmdServico.Parameters.AddWithValue("@idServico", servico.idServico);

                        cmdServico.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro no banco ao salvar Ordem de Serviço: " + ex.Message);
                }
            }
        }

        public override OrdemServicoModel GetById(int id)
        {
            OrdemServicoModel ordemServico = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ordemServico WHERE idOrdemServico = @idOrdemServico";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idOrdemServico", id);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ordemServico = new OrdemServicoModel();
                        ordemServico.idOrdemServico = Convert.ToInt32(reader["idOrdemServico"]);
                        ordemServico.idCliente = Convert.ToInt32(reader["idCliente"]);
                        ordemServico.idFuncionario = Convert.ToInt32(reader["idFuncionario"]);
                        ordemServico.idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]);
                        ordemServico.dataPrevista = Convert.ToDateTime(reader["dataPrevista"]);
                        ordemServico.precoTotal = Convert.ToDecimal(reader["precoTotal"]);
                        ordemServico.valorEntrada = Convert.ToDecimal(reader["valorEntrada"]);
                        ordemServico.valorRetirada = reader["valorRetirada"] != DBNull.Value ? Convert.ToDecimal(reader["valorRetirada"]) : (decimal?)null;
                        ordemServico.porcentagemDesconto = Convert.ToDecimal(reader["porcentagemDesconto"]);
                        ordemServico.observacao = reader["observacao"].ToString();
                        ordemServico.status = reader["status"].ToString();
                        ordemServico.usuario = reader["usuario"].ToString();
                        ordemServico.data = Convert.ToDateTime(reader["data"]);
                        ordemServico.dataEntrega = reader["dataEntrega"] != DBNull.Value ? Convert.ToDateTime(reader["dataEntrega"]) : (DateTime?)null;
                        ordemServico.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;
                        ordemServico.Ativo = Convert.ToBoolean(reader["ativo"]);
                        ordemServico.dataCadastro = Convert.ToDateTime(reader["dataCadastro"]);
                        ordemServico.dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]);

                        ordemServico.Produtos = GetProdutosByOS(ordemServico.idOrdemServico);
                        ordemServico.Servicos = GetServicosByOS(ordemServico.idOrdemServico);
                    }
                }
            }

            return ordemServico;
        }
        public List<OS_ProdutoModel> GetProdutosByOS(int idOrdemServico)
        {
            List<OS_ProdutoModel> produtos = new List<OS_ProdutoModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM OS_Produto WHERE idOrdemServico = @idOrdemServico";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idOrdemServico", idOrdemServico);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OS_ProdutoModel produto = new OS_ProdutoModel();
                        produto.id_os_produto = Convert.ToInt32(reader["id_os_produto"]);
                        produto.precoProduto = Convert.ToDecimal(reader["precoProduto"]);
                        produto.quantidadeProduto = Convert.ToInt32(reader["quantidadeProduto"]);
                        produto.idProduto = Convert.ToInt32(reader["idProduto"]);
                        produto.idOrdemServico = Convert.ToInt32(reader["idOrdemServico"]);

                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
        }
        private List<OS_ServicoModel> GetServicosByOS(int idOrdemServico)
        {
            List<OS_ServicoModel> servicos = new List<OS_ServicoModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM OS_Servico WHERE idOrdemServico = @idOrdemServico";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idOrdemServico", idOrdemServico);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OS_ServicoModel servico = new OS_ServicoModel();
                        servico.id_os_servico = Convert.ToInt32(reader["id_os_servico"]);
                        servico.precoServico = Convert.ToDecimal(reader["precoServico"]);
                        servico.quantidadeServico = Convert.ToInt32(reader["quantidadeServico"]);
                        servico.idServico = Convert.ToInt32(reader["idServico"]);
                        servico.idOrdemServico = Convert.ToInt32(reader["idOrdemServico"]);

                        servicos.Add(servico);
                    }
                }
            }
            return servicos;
        }

        public override List<OrdemServicoModel> GetAll(bool incluiInativos = false)
        {
            List<OrdemServicoModel> ordemServicos = new List<OrdemServicoModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM ordemServico" : "SELECT * FROM ordemServico WHERE ativo = 1";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrdemServicoModel ordemServico = new OrdemServicoModel();
                        ordemServico.idOrdemServico = Convert.ToInt32(reader["idOrdemServico"]);
                        ordemServico.status = reader["status"].ToString();
                        ordemServico.idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                        ordemServico.dataPrevista = Convert.ToDateTime(reader["dataPrevista"]);

                        ordemServicos.Add(ordemServico);
                    }
                }
            }
            return ordemServicos;
        }

        public override void Alterar(OrdemServicoModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); //inicio transação

                try
                {
                    //att dados OS
                    string queryOrdemServico = @"UPDATE ordemServico 
                                         SET data = @data, precoTotal = @precoTotal, status = @status, 
                                             dataEntrega = @dataEntrega, observacao = @observacao, 
                                             idCliente = @idCliente, idCondPagamento = @idCondPagamento, porcentagemDesconto = @porcentagemDesconto, 
                                             idFuncionario = @idFuncionario, dataPrevista = @dataPrevista, dataCancelamento = @dataCancelamento,
                                             valorRetirada = @valorRetirada, valorEntrada = @valorEntrada, dataUltAlt = @dataUltAlt, Ativo = @Ativo, usuario = @usuario 
                                         WHERE idOrdemServico = @idOrdemServico";
                    SqlCommand cmdOrdemServico = new SqlCommand(queryOrdemServico, conn, transaction);
                    cmdOrdemServico.Parameters.AddWithValue("@data", obj.data);
                    cmdOrdemServico.Parameters.AddWithValue("@precoTotal", obj.precoTotal);
                    cmdOrdemServico.Parameters.AddWithValue("@valorEntrada", obj.valorEntrada);
                    cmdOrdemServico.Parameters.AddWithValue("@status", obj.status);
                    cmdOrdemServico.Parameters.AddWithValue("@observacao", obj.observacao);
                    cmdOrdemServico.Parameters.AddWithValue("@idCliente", obj.idCliente);
                    cmdOrdemServico.Parameters.AddWithValue("@porcentagemDesconto", obj.porcentagemDesconto);
                    cmdOrdemServico.Parameters.AddWithValue("@idFuncionario", obj.idFuncionario);
                    cmdOrdemServico.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                    cmdOrdemServico.Parameters.AddWithValue("@dataPrevista", obj.dataPrevista);
                    cmdOrdemServico.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdOrdemServico.Parameters.AddWithValue("@Ativo", obj.Ativo);
                    cmdOrdemServico.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);
                    cmdOrdemServico.Parameters.AddWithValue("@usuario", obj.usuario);

                    cmdOrdemServico.Parameters.AddWithValue("@dataEntrega", obj.dataEntrega.HasValue ? (object)obj.dataEntrega.Value : DBNull.Value);
                    cmdOrdemServico.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento.HasValue ? (object)obj.dataCancelamento.Value : DBNull.Value);
                    cmdOrdemServico.Parameters.AddWithValue("@valorRetirada", obj.valorRetirada.HasValue ? (object)obj.valorRetirada.Value : DBNull.Value);

                    cmdOrdemServico.ExecuteNonQuery(); //att OS

                    //att produtos
                    AtualizarProdutos(conn, transaction, obj);

                    //att serviços
                    AtualizarServicos(conn, transaction, obj);

                    transaction.Commit(); //confirma transação
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); //rollback se der erro
                    throw new Exception("Erro ao alterar Ordem de Serviço: " + ex.Message);
                }
            }
        }

        private void AtualizarProdutos(SqlConnection conn, SqlTransaction transaction, OrdemServicoModel obj)
        {
            string querySelectProdutos = "SELECT * FROM OS_Produto WHERE idOrdemServico = @idOrdemServico";
            SqlCommand cmdSelectProdutos = new SqlCommand(querySelectProdutos, conn, transaction);
            cmdSelectProdutos.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectProdutos);
            DataTable produtosExistentes = new DataTable();
            adapter.Fill(produtosExistentes);

            foreach (var produto in obj.Produtos)
            {
                bool existe = false;

                foreach (DataRow row in produtosExistentes.Rows)
                {
                    if ((int)row["idProduto"] == produto.idProduto)
                    {
                        string queryUpdateProduto = @"UPDATE OS_Produto 
                                              SET quantidadeProduto = @quantidadeProduto, precoProduto = @precoProduto
                                              WHERE idOrdemServico = @idOrdemServico AND idProduto = @idProduto";
                        SqlCommand cmdUpdateProduto = new SqlCommand(queryUpdateProduto, conn, transaction);
                        cmdUpdateProduto.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                        cmdUpdateProduto.Parameters.AddWithValue("@precoProduto", produto.precoProduto);
                        cmdUpdateProduto.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);
                        cmdUpdateProduto.Parameters.AddWithValue("@idProduto", produto.idProduto);

                        cmdUpdateProduto.ExecuteNonQuery();
                        existe = true;
                        break;
                    }
                }
                if (!existe) //se o produto nao existe na OS, ele adiciona
                {
                    string queryInsertProduto = @"INSERT INTO OS_Produto 
                                          (quantidadeProduto, precoProduto, idOrdemServico, idProduto) 
                                          VALUES (@quantidadeProduto, @precoProduto, @idOrdemServico, @idProduto)";
                    SqlCommand cmdInsertProduto = new SqlCommand(queryInsertProduto, conn, transaction);
                    cmdInsertProduto.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                    cmdInsertProduto.Parameters.AddWithValue("@precoProduto", produto.precoProduto);
                    cmdInsertProduto.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);
                    cmdInsertProduto.Parameters.AddWithValue("@idProduto", produto.idProduto);

                    cmdInsertProduto.ExecuteNonQuery();
                }
            }
            foreach (DataRow row in produtosExistentes.Rows)
            {
                bool existe = false;
                foreach (var produto in obj.Produtos)
                {
                    if ((int)row["idProduto"] == produto.idProduto)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe) //se existia mas foi deletado, faz o delete para alterar
                {
                    string queryDeleteProduto = "DELETE FROM OS_Produto WHERE idOrdemServico = @idOrdemServico AND idProduto = @idProduto";
                    SqlCommand cmdDeleteProduto = new SqlCommand(queryDeleteProduto, conn, transaction);
                    cmdDeleteProduto.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);
                    cmdDeleteProduto.Parameters.AddWithValue("@idProduto", (int)row["idProduto"]);

                    cmdDeleteProduto.ExecuteNonQuery();
                }
            }
        }

        private void AtualizarServicos(SqlConnection conn, SqlTransaction transaction, OrdemServicoModel obj)
        {
            //busca os serviços da OS
            string querySelectServicos = "SELECT * FROM OS_Servico WHERE idOrdemServico = @idOrdemServico";
            SqlCommand cmdSelectServicos = new SqlCommand(querySelectServicos, conn, transaction);
            cmdSelectServicos.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectServicos);
            DataTable servicosExistentes = new DataTable();
            adapter.Fill(servicosExistentes);

            //percorre os serviços
            foreach (var servico in obj.Servicos)
            {
                bool existe = false; //ve se serviço existe

                foreach (DataRow row in servicosExistentes.Rows) //percorre os serviços
                {
                    if ((int)row["idServico"] == servico.idServico) //ve se o id do serviço já existe
                    {
                        //atualiza
                        string queryUpdateServico = @"UPDATE OS_Servico 
                                              SET quantidadeServico = @quantidadeServico, precoServico = @precoServico 
                                              WHERE idOrdemServico = @idOrdemServico AND idServico = @idServico";
                        SqlCommand cmdUpdateServico = new SqlCommand(queryUpdateServico, conn, transaction);
                        cmdUpdateServico.Parameters.AddWithValue("@quantidadeServico", servico.quantidadeServico);
                        cmdUpdateServico.Parameters.AddWithValue("@precoServico", servico.precoServico);
                        cmdUpdateServico.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);
                        cmdUpdateServico.Parameters.AddWithValue("@idServico", servico.idServico);

                        cmdUpdateServico.ExecuteNonQuery();
                        existe = true; //narca que existe
                        break;
                    }
                }
                if (!existe) //se não existir
                {
                    //add novo
                    string queryInsertServico = @"INSERT INTO OS_Servico 
                                          (quantidadeServico, precoServico, idOrdemServico, idServico) 
                                          VALUES (@quantidadeServico, @precoServico, @idOrdemServico, @idServico)";
                    SqlCommand cmdInsertServico = new SqlCommand(queryInsertServico, conn, transaction);
                    cmdInsertServico.Parameters.AddWithValue("@quantidadeServico", servico.quantidadeServico);
                    cmdInsertServico.Parameters.AddWithValue("@precoServico", servico.precoServico);
                    cmdInsertServico.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);
                    cmdInsertServico.Parameters.AddWithValue("@idServico", servico.idServico);

                    cmdInsertServico.ExecuteNonQuery();
                }
            }
            foreach (DataRow row in servicosExistentes.Rows) //percorre os serviços
            {
                bool existe = false;
                foreach (var servico in obj.Servicos) //verifica se o serviço ainda existe
                {
                    if ((int)row["idServico"] == servico.idServico)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe) //se não existir mais
                {
                    //apaga o que não foi encontrado
                    string queryDeleteServico = "DELETE FROM OS_Servico WHERE idOrdemServico = @idOrdemServico AND idServico = @idServico";
                    SqlCommand cmdDeleteServico = new SqlCommand(queryDeleteServico, conn, transaction);
                    cmdDeleteServico.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);
                    cmdDeleteServico.Parameters.AddWithValue("@idServico", (int)row["idServico"]);

                    cmdDeleteServico.ExecuteNonQuery();
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
                    //deleta a OS_produto com o id da OS
                    string deleteOSProd = "DELETE FROM OS_Produto WHERE idOrdemServico = @idOrdemServico";
                    SqlCommand cmdDeleteOSProd = new SqlCommand(deleteOSProd, conn, transaction);
                    cmdDeleteOSProd.Parameters.AddWithValue("@idOrdemServico", id);
                    cmdDeleteOSProd.ExecuteNonQuery();

                    //deleta a OS_servico com o id da OS
                    string deleteOSServ = "DELETE FROM OS_Servico WHERE idOrdemServico = @idOrdemServico";
                    SqlCommand cmdDeleteOSServ = new SqlCommand(deleteOSServ, conn, transaction);
                    cmdDeleteOSServ.Parameters.AddWithValue("@idOrdemServico", id);
                    cmdDeleteOSServ.ExecuteNonQuery();

                    //deleta Ordem Serviço
                    string deleteOS = "DELETE FROM ordemServico WHERE idOrdemServico = @idOrdemServico";
                    SqlCommand cmdDeleteOS = new SqlCommand(deleteOS, conn, transaction);
                    cmdDeleteOS.Parameters.AddWithValue("@idOrdemServico", id);
                    cmdDeleteOS.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();

                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir a Ordem de Serviço, pois ela está sendo utilizada em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao deletar a Ordem de Serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public ProdutoModel GetProdutoPorId(int idProduto)
        {
            ProdutoModel produto = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT produto, precoVenda FROM produto WHERE idProduto = @idProduto";
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
                            precoVenda = Convert.ToDecimal(reader["precoVenda"])
                        };
                    }
                }
            }
            return produto;
        }

        public ServicoModel GetServicoPorId(int idServico)
        {
            ServicoModel servico = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT servico, preco FROM servico WHERE idServico = @idServico";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idServico", idServico);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        servico = new ServicoModel
                        {
                            idServico = idServico,
                            servico = reader["servico"].ToString(),
                            preco = Convert.ToDecimal(reader["preco"])
                        };
                    }
                }
            }
            return servico;
        }
        public ClienteModel GetClientePorId(int idCliente)
        {
            ClienteModel cliente = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT cliente_razao_social, celular FROM cliente WHERE idCliente = @idCliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = new ClienteModel
                        {
                            idCliente = idCliente,
                            cliente_razao_social = reader["cliente_razao_social"].ToString(),
                            celular = reader["celular"].ToString()
                        };
                    }
                }
            }
            return cliente;
        }
        public string GetClienteByOSid(int idOS)
        {
            string cliente = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT cliente.cliente_razao_social FROM ordemServico INNER JOIN cliente ON ordemServico.idCliente = cliente.idCliente WHERE ordemServico.idOrdemServico = @idOS";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idOS", idOS);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        cliente = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter o nome do cliente: " + ex.Message);
                }
            }
            return cliente;
        }
    }
}
