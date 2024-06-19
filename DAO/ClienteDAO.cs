using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas.DAO
{
    public class ClienteDAO<T> : DAO<T>
    {
        public ClienteDAO() : base() { }
        public override void Alterar(T obj)
        {
            dynamic cliente = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE cliente SET tipo_pessoa = @tipo_pessoa, cliente_razao_social = @cliente_razao_social, apelido_nome_fantasia = @apelido_nome_fantasia, " +
                               "endereco = @endereco, bairro = @bairro, numero = @numero, cep = @cep, complemento = @complemento, sexo = @sexo, email = @email, " +
                               "telefone = @telefone, celular = @celular, nome_contato = @nome_contato, data_nasc = @data_nasc, cpf_cnpj = @cpf_cnpj, rg_ie = @rg_ie, ativo = @ativo, " +
                               "dataUltAlt = @dataUltAlt, idCidade = @idCidade, idCondPagamento = @idCondPagamento WHERE idCliente = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", cliente.idCliente);
                command.Parameters.AddWithValue("@tipo_pessoa", cliente.tipo_pessoa);
                command.Parameters.AddWithValue("@cliente_razao_social", cliente.cliente_razao_social);
                command.Parameters.AddWithValue("@apelido_nome_fantasia", cliente.apelido_nome_fantasia);
                command.Parameters.AddWithValue("@endereco", cliente.endereco);
                command.Parameters.AddWithValue("@bairro", cliente.bairro);
                command.Parameters.AddWithValue("@numero", cliente.numero);
                command.Parameters.AddWithValue("@cep", cliente.cep);
                command.Parameters.AddWithValue("@complemento", cliente.complemento);
                command.Parameters.AddWithValue("@sexo", cliente.sexo);
                command.Parameters.AddWithValue("@email", cliente.email);
                command.Parameters.AddWithValue("@telefone", cliente.telefone);
                command.Parameters.AddWithValue("@celular", cliente.celular);
                command.Parameters.AddWithValue("@nome_contato", cliente.nome_contato);
                command.Parameters.AddWithValue("@data_nasc", cliente.data_nasc);
                command.Parameters.AddWithValue("@cpf_cnpj", cliente.cpf_cnpj);
                command.Parameters.AddWithValue("@rg_ie", cliente.rg_ie);
                command.Parameters.AddWithValue("@ativo", cliente.Ativo);
                command.Parameters.AddWithValue("@dataUltAlt", cliente.dataUltAlt);
                command.Parameters.AddWithValue("@idCidade", cliente.idCidade);
                command.Parameters.AddWithValue("@idCondPagamento", cliente.idCondPagamento);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao alterar cliente: " + ex.Message);
                    throw;
                }
            }
        }


        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM cliente WHERE idCliente = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override List<T> GetAll(bool incluiInativos = false)
        {
            List<T> clientes = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM cliente" : "SELECT * FROM cliente WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idCliente = Convert.ToInt32(reader["idCliente"]);
                        obj.cliente_razao_social = reader["cliente_razao_social"].ToString();
                        obj.tipo_pessoa = Convert.ToBoolean(reader["tipo_pessoa"]);
                        obj.celular = reader["celular"].ToString();
                        obj.cpf_cnpj = reader["cpf_cnpj"].ToString();
                        clientes.Add(obj);
                    }
                }
            }
            return clientes;
        }

        public override T GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM cliente WHERE idCliente = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idCliente = Convert.ToInt32(reader["idCliente"]);
                        obj.tipo_pessoa = Convert.ToBoolean(reader["tipo_pessoa"]);
                        obj.cliente_razao_social = reader["cliente_razao_social"].ToString();
                        obj.apelido_nome_fantasia = reader["apelido_nome_fantasia"].ToString();
                        obj.endereco = reader["endereco"].ToString();
                        obj.bairro = reader["bairro"].ToString();
                        obj.numero = Convert.ToInt32(reader["numero"]);
                        obj.cep = reader["cep"].ToString();
                        obj.complemento = reader["complemento"].ToString();
                        obj.sexo = reader["sexo"].ToString();
                        obj.email = reader["email"].ToString();
                        obj.telefone = reader["telefone"].ToString();
                        obj.celular = reader["celular"].ToString();
                        obj.nome_contato = reader["nome_contato"].ToString();
                        obj.data_nasc = DateTime.Parse(reader["data_nasc"].ToString());
                        obj.cpf_cnpj = reader["cpf_cnpj"].ToString();
                        obj.rg_ie = reader["rg_ie"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        obj.idCidade = Convert.ToInt32(reader["idCidade"]);
                        obj.idCondPagamento = Convert.ToInt32(reader["idCondPagamento"]);
                        return obj;
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }

        public string GetCondPagamentoByClienteId(int idCliente)
        {
            string condPagamento = string.Empty; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT condicaoPagamento.condicaoPagamento FROM cliente INNER JOIN condicaoPagamento ON cliente.idCondPagamento = condicaoPagamento.idCondPagamento WHERE cliente.idCliente = @idCliente";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        condPagamento = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao obter Condição de Pagamento: " + ex.Message);
                }
            }
            return condPagamento;
        }

        public List<string> GetCEPByIdCidade(int idCidade)
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
                    cidade.idCidade = @idCidade";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idCidade", idCidade);

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
            dynamic cliente = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO cliente (tipo_pessoa, cliente_razao_social, apelido_nome_fantasia, endereco, bairro, numero, cep, complemento, sexo, email, telefone, celular, nome_contato, data_nasc, cpf_cnpj, rg_ie, ativo, dataCadastro, dataUltAlt, idCidade, idCondPagamento) " +
                               "VALUES (@tipo_pessoa, @cliente_razao_social, @apelido_nome_fantasia, @endereco, @bairro, @numero, @cep, @complemento, @sexo, @email, @telefone, @celular, @nome_contato, @data_nasc, @cpf_cnpj, @rg_ie, @ativo, @dataCadastro, @dataUltAlt, @idCidade, @idCondPagamento)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@tipo_pessoa", cliente.tipo_pessoa);
                command.Parameters.AddWithValue("@cliente_razao_social", cliente.cliente_razao_social);
                command.Parameters.AddWithValue("@apelido_nome_fantasia", cliente.apelido_nome_fantasia);
                command.Parameters.AddWithValue("@endereco", cliente.endereco);
                command.Parameters.AddWithValue("@bairro", cliente.bairro);
                command.Parameters.AddWithValue("@numero", cliente.numero);
                command.Parameters.AddWithValue("@cep", cliente.cep);
                command.Parameters.AddWithValue("@complemento", cliente.complemento);
                command.Parameters.AddWithValue("@sexo", cliente.sexo);
                command.Parameters.AddWithValue("@email", cliente.email);
                command.Parameters.AddWithValue("@telefone", cliente.telefone);
                command.Parameters.AddWithValue("@celular", cliente.celular);
                command.Parameters.AddWithValue("@nome_contato", cliente.nome_contato);
                command.Parameters.AddWithValue("@data_nasc", cliente.data_nasc);
                command.Parameters.AddWithValue("@cpf_cnpj", cliente.cpf_cnpj);
                command.Parameters.AddWithValue("@rg_ie", cliente.rg_ie);
                command.Parameters.AddWithValue("@ativo", cliente.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", cliente.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", cliente.dataUltAlt);
                command.Parameters.AddWithValue("@idCidade", cliente.idCidade);
                command.Parameters.AddWithValue("@idCondPagamento", cliente.idCondPagamento);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar cliente: " + ex.Message);
                    throw;
                }
            }
        }
    }
}
