﻿using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.DAO
{
    public class ContasPagarDAO : DAO<ContasPagarModel>
    {
        public override void Alterar(ContasPagarModel obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE contasPagar SET dataPagamento = @dataPagamento, dataEmissao = dataEmissao, idFormaPAgamento = @idFormaPagamento, dataVencimento = @dataVencimento, valorParcela = @valorParcela, juros = @juros, multa = @multa, desconto = @desconto, valorPago = @valorPago, dataCancelamento = @dataCancelamento, observacao = @observacao, dataUltAlt = @dataUltAlt, usuario = @usuario
            WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor AND parcela = @parcela";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                command.Parameters.AddWithValue("@modelo", obj.modelo);
                command.Parameters.AddWithValue("@serie", obj.serie);
                command.Parameters.AddWithValue("@idFornecedor", obj.idFornecedor);
                command.Parameters.AddWithValue("@dataEmissao", obj.dataEmissao);
                command.Parameters.AddWithValue("@idFormaPagamento", obj.idFormaPagamento);
                command.Parameters.AddWithValue("@parcela", obj.parcela);
                command.Parameters.AddWithValue("@dataVencimento", obj.dataVencimento);
                command.Parameters.AddWithValue("@valorParcela", obj.valorParcela);
                command.Parameters.AddWithValue("@dataPagamento", (object)obj.dataPagamento ?? DBNull.Value);
                command.Parameters.AddWithValue("@juros", (object)obj.juros ?? DBNull.Value);
                command.Parameters.AddWithValue("@multa", (object)obj.multa ?? DBNull.Value);
                command.Parameters.AddWithValue("@desconto", (object)obj.desconto ?? DBNull.Value);
                command.Parameters.AddWithValue("@valorPago", (object)obj.valorPago ?? DBNull.Value);
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

        public override List<ContasPagarModel> GetAll(bool incluiInativos = false)
        {
            List<ContasPagarModel> contasPagar = new List<ContasPagarModel>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contasPagar";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ContasPagarModel contaPagar = new ContasPagarModel();
                        contaPagar.numeroNota = Convert.ToInt32(reader["numeroNota"]);
                        contaPagar.modelo = Convert.ToInt32(reader["modelo"]);
                        contaPagar.serie = Convert.ToInt32(reader["serie"]);
                        contaPagar.idFornecedor = Convert.ToInt32(reader["idFornecedor"]);
                        contaPagar.dataVencimento = Convert.ToDateTime(reader["dataVencimento"]);
                        contaPagar.parcela = Convert.ToInt32(reader["parcela"]);
                        contaPagar.valorParcela = Convert.ToDecimal(reader["valorParcela"]);
                        contaPagar.dataPagamento = reader["dataPagamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataPagamento"]) : (DateTime?)null;
                        contaPagar.dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null;

                        contasPagar.Add(contaPagar);
                    }
                }
            }
            return contasPagar;
        }

        public override ContasPagarModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ContasPagarModel GetContaById(int numero, int modelo, int serie, int idFornecedor, int parcela)
        {
            ContasPagarModel contaPagar = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM contasPagar WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor AND parcela = @parcela";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numeroNota", numero);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@serie", serie);
                cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
                cmd.Parameters.AddWithValue("@parcela", parcela);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaPagar = new ContasPagarModel
                        {
                            numeroNota = Convert.ToInt32(reader["numeroNota"]),
                            modelo = Convert.ToInt32(reader["modelo"]),
                            serie = Convert.ToInt32(reader["serie"]),
                            dataEmissao = Convert.ToDateTime(reader["dataEmissao"]),
                            idFornecedor = Convert.ToInt32(reader["idFornecedor"]),
                            idFormaPagamento = Convert.ToInt32(reader["idFormaPagamento"]),
                            parcela = Convert.ToInt32(reader["parcela"]),
                            valorParcela = Convert.ToDecimal(reader["valorParcela"]),
                            dataVencimento = Convert.ToDateTime(reader["dataVencimento"]),

                            dataPagamento = reader["dataPagamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataPagamento"]) : (DateTime?)null,
                            juros = reader["juros"] != DBNull.Value ? Convert.ToDecimal(reader["juros"]) : (decimal?)null,
                            multa = reader["multa"] != DBNull.Value ? Convert.ToDecimal(reader["multa"]) : (decimal?)null,
                            desconto = reader["desconto"] != DBNull.Value ? Convert.ToDecimal(reader["desconto"]) : (decimal?)null,
                            valorPago = reader["valorPago"] != DBNull.Value ? Convert.ToDecimal(reader["valorPago"]) : (decimal?)null,

                            observacao = reader["observacao"].ToString(),
                            usuario = reader["usuario"].ToString(),
                            dataCancelamento = reader["dataCancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["dataCancelamento"]) : (DateTime?)null,
                            dataCadastro = Convert.ToDateTime(reader["dataCadastro"]),
                            dataUltAlt = Convert.ToDateTime(reader["dataUltAlt"]),
                        };
                    }
                }
            }
            return contaPagar;
        }

        public override void Salvar(ContasPagarModel obj)
        {
            dynamic contaPagar = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO contasPagar (numeroNota, modelo, serie, idFornecedor, dataEmissao, idFormaPagamento, parcela, valorParcela, dataVencimento, dataPagamento, juros, multa, desconto, valorPago, dataCancelamento, observacao, dataCadastro, dataUltAlt, usuario) 
                VALUES (@numeroNota, @modelo, @serie, @idFornecedor, @dataEmissao, @idFormaPagamento, @parcela, @valorParcela, @dataVencimento, @dataPagamento, @juros, @multa, @desconto, @valorPago, @dataCancelamento,@observacao, @dataCadastro, @dataUltAlt, @usuario)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@numeroNota", contaPagar.numeroNota);
                command.Parameters.AddWithValue("@modelo", contaPagar.modelo);
                command.Parameters.AddWithValue("@serie", contaPagar.serie);
                command.Parameters.AddWithValue("@idFornecedor", contaPagar.idFornecedor);
                command.Parameters.AddWithValue("@dataEmissao", contaPagar.dataEmissao);
                command.Parameters.AddWithValue("@idFormaPagamento", contaPagar.idFormaPagamento);
                command.Parameters.AddWithValue("@parcela", contaPagar.parcela);
                command.Parameters.AddWithValue("@valorParcela", contaPagar.valorParcela);
                command.Parameters.AddWithValue("@dataVencimento", contaPagar.dataVencimento);
                command.Parameters.AddWithValue("@dataPagamento", contaPagar.dataPagamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@juros", contaPagar.juros ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@multa", contaPagar.multa ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@desconto", contaPagar.desconto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@valorPago", contaPagar.valorPago ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataCancelamento", contaPagar.dataCancelamento ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@observacao", contaPagar.observacao ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@dataCadastro", contaPagar.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", contaPagar.dataUltAlt);
                command.Parameters.AddWithValue("@usuario", contaPagar.usuario);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar conta a pagar: " + ex.Message);
                    throw;
                }
            }
        }
        public bool CancelarConta(ContasPagarModel obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    //verifica se a conta a pagar está associada a alguma nota de compra
                    string verificaQuery = @"
                SELECT COUNT(*) FROM notaCompra
                WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor";

                    SqlCommand verificaCommand = new SqlCommand(verificaQuery, connection, transaction);
                    verificaCommand.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                    verificaCommand.Parameters.AddWithValue("@modelo", obj.modelo);
                    verificaCommand.Parameters.AddWithValue("@serie", obj.serie);
                    verificaCommand.Parameters.AddWithValue("@idFornecedor", obj.idFornecedor);

                    int count = (int)verificaCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        //se existe uma nota associada, não cancelar
                        return false;
                    }

                    //se nao existe, atualizar a data de cancelamento
                    string cancelarQuery = @"
                UPDATE contasPagar
                SET dataCancelamento = @dataCancelamento
                WHERE numeroNota = @numeroNota AND modelo = @modelo AND serie = @serie AND idFornecedor = @idFornecedor AND parcela = @parcela";

                    SqlCommand cancelarCommand = new SqlCommand(cancelarQuery, connection, transaction);
                    cancelarCommand.Parameters.AddWithValue("@numeroNota", obj.numeroNota);
                    cancelarCommand.Parameters.AddWithValue("@modelo", obj.modelo);
                    cancelarCommand.Parameters.AddWithValue("@serie", obj.serie);
                    cancelarCommand.Parameters.AddWithValue("@idFornecedor", obj.idFornecedor);
                    cancelarCommand.Parameters.AddWithValue("@parcela", obj.parcela);
                    cancelarCommand.Parameters.AddWithValue("@dataCancelamento", obj.dataCancelamento ?? (object)DBNull.Value);

                    cancelarCommand.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Erro ao cancelar conta a pagar: " + ex.Message);
                    throw;
                }
            }
        }
        public bool VerificarParcelasNaoPagas(string numeroNota, string modelo, string serie, int idFornecedor, int parcelaAtual)
        {
            string query = @"
        SELECT COUNT(*)
        FROM contasPagar
        WHERE numeroNota = @numeroNota
          AND modelo = @modelo
          AND serie = @serie
          AND idFornecedor = @idFornecedor
          AND parcela < @parcelaAtual
          AND dataPagamento IS NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numeroNota", numeroNota);
                command.Parameters.AddWithValue("@modelo", modelo);
                command.Parameters.AddWithValue("@serie", serie);
                command.Parameters.AddWithValue("@idFornecedor", idFornecedor);
                command.Parameters.AddWithValue("@parcelaAtual", parcelaAtual);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
    }
}
