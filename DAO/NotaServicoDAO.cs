using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.DAO
{
    public class NotaServicoDAO : DAO<NotaServicoModel>
    {
        public int GetUltimoNumeroNota()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(numeroNota), 0) FROM notaServico";
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
        public override void Alterar(NotaServicoModel obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<NotaServicoModel> GetAll(bool incluiInativos = false)
        {
            List<NotaServicoModel> notasServico = new List<NotaServicoModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM notaServico";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NotaServicoModel notaServico = new NotaServicoModel();
                        notaServico.numeroNota = Convert.ToInt32(reader["numeroNota"]);
                        notaServico.modelo = Convert.ToInt32(reader["modelo"]);
                        notaServico.serie = Convert.ToInt32(reader["serie"]);
                        notaServico.idCliente = Convert.ToInt32(reader["idCliente"]);
                        notaServico.dataEmissao = Convert.ToDateTime(reader["dataEmissao"]);
                        notaServico.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;

                        notasServico.Add(notaServico);
                    }
                }
            }
            return notasServico;
        }
        public NotaServicoModel GetNotaById(int numero, int modelo, int serie, int idCliente)
        {
            NotaServicoModel notaServico = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM notaServico WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente";
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
                        notaServico = new NotaServicoModel
                        {
                            numeroNota = Convert.ToInt32(reader["numeroNota"]),
                            modelo = Convert.ToInt32(reader["modelo"]),
                            serie = Convert.ToInt32(reader["serie"]),
                            dataEmissao = Convert.ToDateTime(reader["dataEmissao"]),
                            idCliente = Convert.ToInt32(reader["idCliente"]),
                            totalServicos = Convert.ToDecimal(reader["totalServicos"]),
                            totalPagar = Convert.ToDecimal(reader["totalPagar"]),
                            porcentagemDesconto = Convert.ToDecimal(reader["porcentagemDesconto"]),
                            idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]),
                            observacao = reader["observacao"].ToString(),
                            dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null,
                            dataCadastro = Convert.ToDateTime(reader["dataCadastro"]),
                            dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]),
                        };

                        notaServico.Servicos = GetServicosByNFServico(notaServico.numeroNota, notaServico.modelo, notaServico.serie, notaServico.idCliente);
                    }
                }
            }

            return notaServico;
        }
        public List<NotaServico_ServicoModel> GetServicosByNFServico(int numeroNota, int modelo, int serie, int idCliente)
        {
            List<NotaServico_ServicoModel> servicos = new List<NotaServico_ServicoModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM notaServico_Servico 
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
                        NotaServico_ServicoModel servico = new NotaServico_ServicoModel();
                        servico.idServico = Convert.ToInt32(reader["idServico"]);
                        servico.precoServico = Convert.ToDecimal(reader["precoServico"]);
                        servico.quantidadeServico = Convert.ToInt32(reader["quantidadeServico"]);

                        servicos.Add(servico);
                    }
                }
            }
            return servicos;
        }
        public bool ExisteNota(int numeroNota, string modelo, string serie, int idCliente) //verificar se a nota existe no banco antes de liberar os campos
        {
            string query = "SELECT COUNT(*) FROM notaServico WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente";

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

        public override NotaServicoModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Salvar(NotaServicoModel obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //insere uma nova nota de servico
                    string queryNFServico = @"INSERT INTO notaServico 
                                   (modelo, serie, idCliente, dataEmissao, totalServicos, totalPagar, porcentagemDesconto, idCondPagamento, observacao, dataCadastro, dataUltAlt) 
                                   VALUES (@modelo, @serie, @idCliente, @dataEmissao, @totalServicos, @totalPagar, @porcentagemDesconto, @idCondPagamento, @observacao, @dataCadastro, @dataUltAlt);
                                   SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdNFServico = new SqlCommand(queryNFServico, conn, transaction);

                    cmdNFServico.Parameters.AddWithValue("@modelo", obj.modelo);
                    cmdNFServico.Parameters.AddWithValue("@serie", obj.serie);
                    cmdNFServico.Parameters.AddWithValue("@idCliente", obj.idCliente);
                    cmdNFServico.Parameters.AddWithValue("@dataEmissao", obj.dataEmissao);
                    cmdNFServico.Parameters.AddWithValue("@totalServicos", obj.totalServicos);
                    cmdNFServico.Parameters.AddWithValue("@totalPagar", obj.totalPagar);
                    cmdNFServico.Parameters.AddWithValue("@porcentagemDesconto", obj.porcentagemDesconto);
                    cmdNFServico.Parameters.AddWithValue("@idCondPagamento", obj.idCondPagamento);
                    cmdNFServico.Parameters.AddWithValue("@observacao", obj.observacao);
                    cmdNFServico.Parameters.AddWithValue("@dataCadastro", obj.dataCadastro);
                    cmdNFServico.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                    int numeroNota = Convert.ToInt32(cmdNFServico.ExecuteScalar());

                    //insere os servicos da nota de servico
                    foreach (var servico in obj.Servicos)
                    {
                        string queryProduto = @"INSERT INTO notaServico_Servico 
                                        (numeroNota, modelo, serie, idCliente, quantidadeServico, precoServico, idServico) 
                                        VALUES (@numeroNota, @modelo, @serie, @idCliente, @quantidadeServico, @precoServico, @idServico)";
                        SqlCommand cmdProduto = new SqlCommand(queryProduto, conn, transaction);

                        cmdProduto.Parameters.AddWithValue("@numeroNota", numeroNota);
                        cmdProduto.Parameters.AddWithValue("@modelo", obj.modelo);
                        cmdProduto.Parameters.AddWithValue("@serie", obj.serie);
                        cmdProduto.Parameters.AddWithValue("@idCliente", obj.idCliente);
                        cmdProduto.Parameters.AddWithValue("@quantidadeServico", servico.quantidadeServico);
                        cmdProduto.Parameters.AddWithValue("@precoServico", servico.precoServico);
                        cmdProduto.Parameters.AddWithValue("@idServico", servico.idServico);

                        cmdProduto.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro no banco ao salvar Nota de Serviço: " + ex.Message);
                }
            }
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

        public bool CancelarNotaServico(int numeroNota, int modelo, int serie, int idCliente) //ARRUMAR
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        //add dataCancelamento na nota de servico
                        string queryCancelarNota = @"
                    UPDATE notaServico
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
                        throw new Exception("Erro ao cancelar a Nota de Serviço: " + ex.Message);
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
