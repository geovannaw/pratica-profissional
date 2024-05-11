using MySqlX.XDevAPI;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.DAO
{
    public class DadosEmpresaDAO<T> : DAO<T>
    {
        public DadosEmpresaDAO() : base()
        {
        }

        public override void Alterar(T obj)
        {
            dynamic dadosEmpresa = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE dadosEmpresa SET razao_social = @razao_social, nome_fantasia = @nome_fantasia, " +
                               "endereco = @endereco, bairro = @bairro, numero = @numero, cep = @cep, complemento = @complemento, email = @email, " +
                               "telefone = @telefone, celular = @celular, cnpj = @cnpj, ie = @ie, nome_responsavel = @nome_responsavel, idCidade = @idCidade WHERE idDadosEmpresa = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", dadosEmpresa.idDadosEmpresa);
                command.Parameters.AddWithValue("@razao_social", dadosEmpresa.razao_social);
                command.Parameters.AddWithValue("@nome_fantasia", dadosEmpresa.nome_fantasia);
                command.Parameters.AddWithValue("@endereco", dadosEmpresa.endereco);
                command.Parameters.AddWithValue("@bairro", dadosEmpresa.bairro);
                command.Parameters.AddWithValue("@numero", dadosEmpresa.numero);
                command.Parameters.AddWithValue("@cep", dadosEmpresa.cep);
                command.Parameters.AddWithValue("@complemento", dadosEmpresa.complemento);
                command.Parameters.AddWithValue("@email", dadosEmpresa.email);
                command.Parameters.AddWithValue("@telefone", dadosEmpresa.telefone);
                command.Parameters.AddWithValue("@celular", dadosEmpresa.celular);
                command.Parameters.AddWithValue("@cnpj", dadosEmpresa.cnpj);
                command.Parameters.AddWithValue("@ie", dadosEmpresa.ie);
                command.Parameters.AddWithValue("@nome_responsavel", dadosEmpresa.nome_responsavel);
                command.Parameters.AddWithValue("@idCidade", dadosEmpresa.idCidade);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<T> GetAll(bool incluiInativos = false)
        {
            List<T> dadosEmpresa = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT idDadosEmpresa, razao_social, nome_fantasia, endereco, bairro, numero, cep, complemento, email, telefone, celular, cnpj, ie, nome_responsavel, idCidade FROM dadosEmpresa";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idDadosEmpresa = Convert.ToInt32(reader["idDadosEmpresa"]);
                        obj.razao_social = reader["razao_social"].ToString();
                        obj.nome_fantasia = reader["nome_fantasia"].ToString();
                        obj.endereco = reader["endereco"].ToString();
                        obj.bairro = reader["bairro"].ToString();
                        obj.numero = Convert.ToInt32(reader["numero"]);
                        obj.cep = reader["cep"].ToString();
                        obj.complemento = reader["complemento"].ToString();
                        obj.email = reader["email"].ToString();
                        obj.telefone = reader["telefone"].ToString();
                        obj.celular = reader["celular"].ToString();
                        obj.cnpj = reader["cnpj"].ToString();
                        obj.ie = reader["ie"].ToString();
                        obj.nome_responsavel = reader["nome_responsavel"].ToString();
                        obj.idCidade = Convert.ToInt32(reader["idCidade"]);
                        dadosEmpresa.Add(obj);
                    }
                }
            }
            return dadosEmpresa;
        }

        public override T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> GetCEPByCidadeId(int cidadeId)
        {
            List<string> cidadeInfos = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT 
                    cidade.cidade AS cidade,
                    estado.UF AS UF,
                    pais.pais AS pais
                FROM 
                    cidade
                JOIN 
                    estado ON cidade.idEstado = estado.idEstado
                JOIN 
                    pais ON estado.idPais = pais.idPais
                WHERE 
                    cidade.idCidade = @cidadeId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cidadeId", cidadeId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string cidadeInfo = string.Format("{0}, {1}, {2}",
                            reader["cidade"],
                            reader["UF"],
                            reader["pais"]);
                        cidadeInfos.Add(cidadeInfo);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter informações da cidade: " + ex.Message);
                }
            }
            return cidadeInfos;
        }

        public override void Salvar(T obj)
        {
            dynamic dadosEmpresa = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO dadosEmpresa (razao_social, nome_fantasia, endereco, bairro, numero, cep, complemento, email, telefone, celular, cnpj, ie, nome_responsavel, idCidade) " +
                               "VALUES (@razao_social, @nome_fantasia, @endereco, @bairro, @numero, @cep, @complemento, @email, @telefone, @celular, @cnpj, @ie, @nome_responsavel, @idCidade)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@razao_social", dadosEmpresa.razao_social);
                command.Parameters.AddWithValue("@nome_fantasia", dadosEmpresa.nome_fantasia);
                command.Parameters.AddWithValue("@endereco", dadosEmpresa.endereco);
                command.Parameters.AddWithValue("@bairro", dadosEmpresa.bairro);
                command.Parameters.AddWithValue("@numero", dadosEmpresa.numero);
                command.Parameters.AddWithValue("@cep", dadosEmpresa.cep);
                command.Parameters.AddWithValue("@complemento", dadosEmpresa.complemento);
                command.Parameters.AddWithValue("@email", dadosEmpresa.email);
                command.Parameters.AddWithValue("@telefone", dadosEmpresa.telefone);
                command.Parameters.AddWithValue("@celular", dadosEmpresa.celular);
                command.Parameters.AddWithValue("@cnpj", dadosEmpresa.cnpj);
                command.Parameters.AddWithValue("@ie", dadosEmpresa.ie);
                command.Parameters.AddWithValue("@nome_responsavel", dadosEmpresa.nome_responsavel);
                command.Parameters.AddWithValue("@idCidade", dadosEmpresa.idCidade);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar Dados da Empresa: " + ex.Message);
                    throw;
                }
            }
        }
    }
}
