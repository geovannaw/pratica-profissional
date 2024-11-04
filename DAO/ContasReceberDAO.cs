using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.DAO
{
    public class ContasReceberDAO : DAO<ContasReceberModel>
    {
        public override void Alterar(ContasReceberModel obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE contasReceber SET dataRecebimento = @dataRecebimento, dataEmissao = dataEmissao, idFormaPagamento = @idFormaPagamento, dataVencimento = @dataVencimento, valorParcela = @valorParcela, juros = @juros, multa = @multa, desconto = @desconto, valorRecebido = @valorRecebido, dataCancelamento = @dataCancelamento, observacao = @observacao, dataUltAlt = @dataUltAlt, usuario = @usuario
            WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente AND parcela = @parcela";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                command.Parameters.AddWithValue("@modelo", obj.modelo);
                command.Parameters.AddWithValue("@serie", obj.serie);
                command.Parameters.AddWithValue("@idCliente", obj.idCliente);
                command.Parameters.AddWithValue("@dataEmissao", obj.dataEmissao);
                command.Parameters.AddWithValue("@idFormaPagamento", obj.idFormaPagamento);
                command.Parameters.AddWithValue("@parcela", obj.parcela);
                command.Parameters.AddWithValue("@dataVencimento", obj.dataVencimento);
                command.Parameters.AddWithValue("@valorParcela", obj.valorParcela);
                command.Parameters.AddWithValue("@dataRecebimento", (object)obj.dataRecebimento ?? DBNull.Value);
                command.Parameters.AddWithValue("@juros", (object)obj.juros ?? DBNull.Value);
                command.Parameters.AddWithValue("@multa", (object)obj.multa ?? DBNull.Value);
                command.Parameters.AddWithValue("@desconto", (object)obj.desconto ?? DBNull.Value);
                command.Parameters.AddWithValue("@valorRecebido", (object)obj.valorRecebido ?? DBNull.Value);
                command.Parameters.AddWithValue("@dataCancelamento", (object)obj.dataCancelamento ?? DBNull.Value);
                command.Parameters.AddWithValue("@observacao", obj.observacao ?? string.Empty);
                command.Parameters.AddWithValue("@dataUltAlt", obj.dataUltAlt);
                command.Parameters.AddWithValue("@usuario", obj.usuario);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<ContasReceberModel> GetAll(bool incluiInativos = false)
        {
            List<ContasReceberModel> contasReceber = new List<ContasReceberModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contasReceber";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ContasReceberModel contaReceber = new ContasReceberModel();
                        contaReceber.numeroNota = Convert.ToInt32(reader["numeroNota"]);
                        contaReceber.modelo = Convert.ToInt32(reader["modelo"]);
                        contaReceber.serie = Convert.ToInt32(reader["serie"]);
                        contaReceber.idCliente = Convert.ToInt32(reader["idCliente"]);
                        contaReceber.dataVencimento = Convert.ToDateTime(reader["dataVencimento"]);
                        contaReceber.parcela = Convert.ToInt32(reader["parcela"]);
                        contaReceber.valorParcela = Convert.ToDecimal(reader["valorParcela"]);
                        contaReceber.dataRecebimento = reader["dataRecebimento"] != DBNull.Value ? Convert.ToDateTime(reader["dataRecebimento"]) : (DateTime?)null;
                        contaReceber.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;

                        contasReceber.Add(contaReceber);
                    }
                }
            }
            return contasReceber;
        }

        public override ContasReceberModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        public ContasReceberModel GetContaById(int numero, int modelo, int serie, int idCliente, int parcela)
        {
            ContasReceberModel contaReceber = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contasReceber WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente AND parcela = @parcela";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroNota", numero);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@serie", serie);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cmd.Parameters.AddWithValue("@parcela", parcela);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaReceber = new ContasReceberModel
                        {
                            numeroNota = Convert.ToInt32(reader["numeroNota"]),
                            modelo = Convert.ToInt32(reader["modelo"]),
                            serie = Convert.ToInt32(reader["serie"]),
                            dataEmissao = Convert.ToDateTime(reader["dataEmissao"]),
                            idCliente = Convert.ToInt32(reader["idCliente"]),
                            idFormaPagamento = Convert.ToInt32(reader["idFormaPagamento"]),
                            parcela = Convert.ToInt32(reader["parcela"]),
                            valorParcela = Convert.ToDecimal(reader["valorParcela"]),
                            dataVencimento = Convert.ToDateTime(reader["dataVencimento"]),

                            dataRecebimento = reader["dataRecebimento"] != DBNull.Value ? Convert.ToDateTime(reader["dataRecebimento"]) : (DateTime?)null,
                            juros = reader["juros"] != DBNull.Value ? Convert.ToDecimal(reader["juros"]) : (decimal?)null,
                            multa = reader["multa"] != DBNull.Value ? Convert.ToDecimal(reader["multa"]) : (decimal?)null,
                            desconto = reader["desconto"] != DBNull.Value ? Convert.ToDecimal(reader["desconto"]) : (decimal?)null,
                            valorRecebido = reader["valorRecebido"] != DBNull.Value ? Convert.ToDecimal(reader["valorRecebido"]) : (decimal?)null,

                            observacao = reader["observacao"].ToString(),
                            usuario = reader["usuario"].ToString(),
                            dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null,
                            dataCadastro = Convert.ToDateTime(reader["dataCadastro"]),
                            dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]),
                        };
                    }
                }
            }
            return contaReceber;
        }

        public override void Salvar(ContasReceberModel obj)
        {
            dynamic contaReceber = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO contasReceber (numeroNota, modelo, serie, idCliente, dataEmissao, idFormaPagamento, parcela, valorParcela, dataVencimento, dataRecebimento, juros, multa, desconto, valorRecebido, dataCancelamento, observacao, dataCadastro, dataUltAlt, usuario) 
                VALUES (@numeroNota, @modelo, @serie, @idCliente, @dataEmissao, @idFormaPagamento, @parcela, @valorParcela, @dataVencimento, @dataRecebimento, @juros, @multa, @desconto, @valorRecebido, @dataCancelamento,@observacao, @dataCadastro, @dataUltAlt, @usuario)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@numeroNota", contaReceber.numeroNota);
                command.Parameters.AddWithValue("@modelo", contaReceber.modelo);
                command.Parameters.AddWithValue("@serie", contaReceber.serie);
                command.Parameters.AddWithValue("@idCliente", contaReceber.idCliente);
                command.Parameters.AddWithValue("@dataEmissao", contaReceber.dataEmissao);
                command.Parameters.AddWithValue("@idFormaPagamento", contaReceber.idFormaPagamento);
                command.Parameters.AddWithValue("@parcela", contaReceber.parcela);
                command.Parameters.AddWithValue("@valorParcela", contaReceber.valorParcela);
                command.Parameters.AddWithValue("@dataVencimento", contaReceber.dataVencimento);
                command.Parameters.AddWithValue("@dataRecebimento", contaReceber.dataRecebimento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@juros", contaReceber.juros ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@multa", contaReceber.multa ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@desconto", contaReceber.desconto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@valorRecebido", contaReceber.valorRecebido ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataCancelamento", contaReceber.dataCancelamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@observacao", contaReceber.observacao ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataCadastro", contaReceber.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", contaReceber.dataUltAlt);
                command.Parameters.AddWithValue("@usuario", contaReceber.usuario);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar conta a receber: " + ex.Message);
                    throw;
                }
            }
        }

        public bool CancelarConta(ContasReceberModel obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Verifica se a conta a receber está associada a alguma nota de venda
                    string verificaVendaQuery = @"
                SELECT COUNT(*) FROM notaVenda
                WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente";

                    SqlCommand verificaVendaCommand = new SqlCommand(verificaVendaQuery, connection, transaction);
                    verificaVendaCommand.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                    verificaVendaCommand.Parameters.AddWithValue("@modelo", obj.modelo);
                    verificaVendaCommand.Parameters.AddWithValue("@serie", obj.serie);
                    verificaVendaCommand.Parameters.AddWithValue("@idCliente", obj.idCliente);

                    int vendaCount = (int)verificaVendaCommand.ExecuteScalar();

                    // Verifica se a conta a receber está associada a alguma nota de serviço
                    string verificaServicoQuery = @"
                SELECT COUNT(*) FROM notaServico
                WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente";

                    SqlCommand verificaServicoCommand = new SqlCommand(verificaServicoQuery, connection, transaction);
                    verificaServicoCommand.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                    verificaServicoCommand.Parameters.AddWithValue("@modelo", obj.modelo);
                    verificaServicoCommand.Parameters.AddWithValue("@serie", obj.serie);
                    verificaServicoCommand.Parameters.AddWithValue("@idCliente", obj.idCliente);

                    int servicoCount = (int)verificaServicoCommand.ExecuteScalar();

                    // Se existe uma nota associada, não cancelar
                    if (vendaCount > 0 || servicoCount > 0)
                    {
                        return false;
                    }

                    // Se não existe, atualizar a data de cancelamento
                    string cancelarQuery = @"
                UPDATE contasReceber
                SET dataCancelamento = @dataCancelamento
                WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idCliente = @idCliente AND parcela = @parcela";

                    SqlCommand cancelarCommand = new SqlCommand(cancelarQuery, connection, transaction);
                    cancelarCommand.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                    cancelarCommand.Parameters.AddWithValue("@modelo", obj.modelo);
                    cancelarCommand.Parameters.AddWithValue("@serie", obj.serie);
                    cancelarCommand.Parameters.AddWithValue("@idCliente", obj.idCliente);
                    cancelarCommand.Parameters.AddWithValue("@parcela", obj.parcela);
                    cancelarCommand.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento ?? (object)DBNull.Value);

                    cancelarCommand.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Erro ao cancelar conta a receber: " + ex.Message);
                    throw;
                }
            }
        }

        public bool VerificarParcelasNaoPagas(string numeroNota, string modelo, string serie, int idCliente, int parcelaAtual)
        {
            string query = @"
        SELECT COUNT(*)
        FROM contasReceber
        WHERE numeroNota = @numeroNota
          AND modelo = @modelo
          AND serie = @serie
          AND idCliente = @idCliente
          AND parcela < @parcelaAtual
          AND dataRecebimento IS NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numeroNota", numeroNota);
                command.Parameters.AddWithValue("@modelo", modelo);
                command.Parameters.AddWithValue("@serie", serie);
                command.Parameters.AddWithValue("@idCliente", idCliente);
                command.Parameters.AddWithValue("@parcelaAtual", parcelaAtual);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
    }
}
