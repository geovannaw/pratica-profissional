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
                string query = "SELECT IDENT_CURRENT('ordemServico')";
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
                    // Insere uma nova OS
                    string queryOS = @"INSERT INTO ordemServico 
                               (data, precoTotal, status, dataEntrega, observacao, idCliente, porcentagemDesconto, idFuncionario, dataCadastro, dataUltAlt, Ativo) 
                               VALUES (@data, @precoTotal, @status, @dataEntrega, @observacao, @idCliente, @porcentagemDesconto, @idFuncionario, @dataCadastro, @dataUltAlt, @Ativo);
                               SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdOS = new SqlCommand(queryOS, conn, transaction); // Novo comando para transação e conexão
                    cmdOS.Parameters.AddWithValue("@data", obj.data);
                    cmdOS.Parameters.AddWithValue("@precoTotal", obj.precoTotal);
                    cmdOS.Parameters.AddWithValue("@status", obj.status);
                    cmdOS.Parameters.AddWithValue("@dataEntrega", obj.dataEntrega);
                    cmdOS.Parameters.AddWithValue("@observacao", obj.observacao);
                    cmdOS.Parameters.AddWithValue("@idCliente", obj.idCliente);
                    cmdOS.Parameters.AddWithValue("@porcentagemDesconto", obj.porcentagemDesconto);
                    cmdOS.Parameters.AddWithValue("@idFuncionario", obj.idFuncionario);
                    cmdOS.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdOS.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdOS.Parameters.AddWithValue("@Ativo", obj.Ativo);

                    int idOrdemServico = Convert.ToInt32(cmdOS.ExecuteScalar()); // Retorna o último valor da identidade gerada (SCOPE_IDENTITY)

                    // Atualiza o idOrdemServico nos produtos e serviços
                    foreach (var produto in obj.Produtos)
                    {
                        produto.idOrdemServico = idOrdemServico;
                    }

                    foreach (var servico in obj.Servicos)
                    {
                        servico.idOrdemServico = idOrdemServico;
                    }

                    // Insere os produtos da OS
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

                    // Insere os serviços da OS
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
                        ordemServico.precoTotal = Convert.ToDecimal(reader["precoTotal"]);
                        ordemServico.porcentagemDesconto = Convert.ToDecimal(reader["porcentagemDesconto"]);
                        ordemServico.observacao = reader["observacao"].ToString();
                        ordemServico.status = reader["status"].ToString();
                        ordemServico.data = Convert.ToDateTime(reader["data"]);
                        ordemServico.dataEntrega = Convert.ToDateTime(reader["dataEntrega"]);
                        ordemServico.Ativo = Convert.ToBoolean(reader["ativo"]);
                        ordemServico.dataCadastro = Convert.ToDateTime(reader["dataCadastro"]);
                        ordemServico.dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]);

                        // Carregar Produtos
                        ordemServico.Produtos = GetProdutosByOS(ordemServico.idOrdemServico);
                        // Carregar Serviços
                        ordemServico.Servicos = GetServicosByOS(ordemServico.idOrdemServico);
                    }
                }
            }

            return ordemServico;
        }
        private List<OS_ProdutoModel> GetProdutosByOS(int idOrdemServico)
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
                        ordemServico.dataEntrega = Convert.ToDateTime(reader["dataEntrega"]);

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
                SqlTransaction transaction = conn.BeginTransaction(); // Inicia a transação

                try
                {
                    // Atualiza os dados da Ordem de Serviço
                    string queryOrdemServico = @"UPDATE ordemServico 
                                         SET data = @data, precoTotal = @precoTotal, status = @status, 
                                             dataEntrega = @dataEntrega, observacao = @observacao, 
                                             idCliente = @idCliente, porcentagemDesconto = @porcentagemDesconto, 
                                             idFuncionario = @idFuncionario, dataUltAlt = @dataUltAlt, Ativo = @Ativo 
                                         WHERE idOrdemServico = @idOrdemServico";
                    SqlCommand cmdOrdemServico = new SqlCommand(queryOrdemServico, conn, transaction);
                    cmdOrdemServico.Parameters.AddWithValue("@data", obj.data);
                    cmdOrdemServico.Parameters.AddWithValue("@precoTotal", obj.precoTotal);
                    cmdOrdemServico.Parameters.AddWithValue("@status", obj.status);
                    cmdOrdemServico.Parameters.AddWithValue("@dataEntrega", obj.dataEntrega);
                    cmdOrdemServico.Parameters.AddWithValue("@observacao", obj.observacao);
                    cmdOrdemServico.Parameters.AddWithValue("@idCliente", obj.idCliente);
                    cmdOrdemServico.Parameters.AddWithValue("@porcentagemDesconto", obj.porcentagemDesconto);
                    cmdOrdemServico.Parameters.AddWithValue("@idFuncionario", obj.idFuncionario);
                    cmdOrdemServico.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    cmdOrdemServico.Parameters.AddWithValue("@Ativo", obj.Ativo);
                    cmdOrdemServico.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);

                    cmdOrdemServico.ExecuteNonQuery(); // Atualiza a Ordem de Serviço

                    // Atualiza os produtos da Ordem de Serviço
                    AtualizarProdutos(conn, transaction, obj);

                    // Atualiza os serviços da Ordem de Serviço
                    AtualizarServicos(conn, transaction, obj);

                    transaction.Commit(); // Confirma a transação
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Reverte a transação em caso de erro
                    throw new Exception("Erro ao alterar Ordem de Serviço: " + ex.Message);
                }
            }
        }

        private void AtualizarProdutos(SqlConnection conn, SqlTransaction transaction, OrdemServicoModel obj)
        {
            // Obtém os produtos existentes no banco de dados para a OS
            string querySelectProdutos = "SELECT * FROM OS_Produto WHERE idOrdemServico = @idOrdemServico";
            SqlCommand cmdSelectProdutos = new SqlCommand(querySelectProdutos, conn, transaction);
            cmdSelectProdutos.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectProdutos);
            DataTable produtosExistentes = new DataTable();
            adapter.Fill(produtosExistentes); // Preenche um DataTable com os produtos

            // Percorre os produtos da OS
            foreach (var produto in obj.Produtos)
            {
                bool existe = false; // Verifica se o produto existe

                foreach (DataRow row in produtosExistentes.Rows) // Percorre os produtos no banco
                {
                    if ((int)row["idProduto"] == produto.idProduto) // Verifica se o id do produto já existe
                    {
                        // Atualiza o produto existente
                        string queryUpdateProduto = @"UPDATE OS_Produto 
                                              SET quantidadeProduto = @quantidadeProduto, precoProduto = @precoProduto
                                              WHERE idOrdemServico = @idOrdemServico AND idProduto = @idProduto";
                        SqlCommand cmdUpdateProduto = new SqlCommand(queryUpdateProduto, conn, transaction);
                        cmdUpdateProduto.Parameters.AddWithValue("@quantidadeProduto", produto.quantidadeProduto);
                        cmdUpdateProduto.Parameters.AddWithValue("@precoProduto", produto.precoProduto);
                        cmdUpdateProduto.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);
                        cmdUpdateProduto.Parameters.AddWithValue("@idProduto", produto.idProduto);

                        cmdUpdateProduto.ExecuteNonQuery();
                        existe = true; // Marca que o produto existe
                        break;
                    }
                }
                if (!existe) // Se não existir o produto
                {
                    // Insere novo produto
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
            foreach (DataRow row in produtosExistentes.Rows) // Percorre novamente os produtos
            {
                bool existe = false;
                foreach (var produto in obj.Produtos) // Verifica se o produto ainda existe
                {
                    if ((int)row["idProduto"] == produto.idProduto)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe) // Se não existir mais
                {
                    // Apaga o produto que não foi encontrado
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
            // Obtém os serviços existentes no banco de dados para a OS
            string querySelectServicos = "SELECT * FROM OS_Servico WHERE idOrdemServico = @idOrdemServico";
            SqlCommand cmdSelectServicos = new SqlCommand(querySelectServicos, conn, transaction);
            cmdSelectServicos.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdSelectServicos);
            DataTable servicosExistentes = new DataTable();
            adapter.Fill(servicosExistentes); // Preenche um DataTable com os serviços

            // Percorre os serviços da OS
            foreach (var servico in obj.Servicos)
            {
                bool existe = false; // Verifica se o serviço existe

                foreach (DataRow row in servicosExistentes.Rows) // Percorre os serviços no banco
                {
                    if ((int)row["idServico"] == servico.idServico) // Verifica se o id do serviço já existe
                    {
                        // Atualiza o serviço existente
                        string queryUpdateServico = @"UPDATE OS_Servico 
                                              SET quantidadeServico = @quantidadeServico, precoServico = @precoServico 
                                              WHERE idOrdemServico = @idOrdemServico AND idServico = @idServico";
                        SqlCommand cmdUpdateServico = new SqlCommand(queryUpdateServico, conn, transaction);
                        cmdUpdateServico.Parameters.AddWithValue("@quantidadeServico", servico.quantidadeServico);
                        cmdUpdateServico.Parameters.AddWithValue("@precoServico", servico.precoServico);
                        cmdUpdateServico.Parameters.AddWithValue("@idOrdemServico", obj.idOrdemServico);
                        cmdUpdateServico.Parameters.AddWithValue("@idServico", servico.idServico);

                        cmdUpdateServico.ExecuteNonQuery();
                        existe = true; // Marca que o serviço existe
                        break;
                    }
                }
                if (!existe) // Se não existir o serviço
                {
                    // Insere novo serviço
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
            foreach (DataRow row in servicosExistentes.Rows) // Percorre novamente os serviços
            {
                bool existe = false;
                foreach (var servico in obj.Servicos) // Verifica se o serviço ainda existe
                {
                    if ((int)row["idServico"] == servico.idServico)
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe) // Se não existir mais
                {
                    // Apaga o serviço que não foi encontrado
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
                string query = "SELECT produto, preco_venda FROM produto WHERE idProduto = @idProduto";
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
                            Preco_venda = Convert.ToDecimal(reader["preco_venda"])
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
