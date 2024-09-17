using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas.DAO
{
    public class FuncionarioDAO<T> : DAO<T>
    {
        public FuncionarioDAO() : base() { }
        public int GetUltimoCodigo()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IDENT_CURRENT('funcionario')";
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
        public override void Alterar(T obj)
        {
            dynamic funcionario = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE funcionario SET funcionario = @funcionario, apelido = @apelido, " +
                               "endereco = @endereco, bairro = @bairro, numero = @numero, cep = @cep, complemento = @complemento, sexo = @sexo, email = @email, " +
                               "telefone = @telefone, celular = @celular, data_nasc = @data_nasc, cpf = @cpf, rg = @rg, ativo = @ativo, cargo = @cargo, salario = @salario, pis = @pis, " +
                               "data_admissao = @data_admissao, data_demissao = @data_demissao, dataUltAlt = @dataUltAlt, idCidade = @idCidade, usuario = @usuario WHERE idFuncionario = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", funcionario.idFuncionario);
                command.Parameters.AddWithValue("@funcionario", funcionario.funcionario);
                command.Parameters.AddWithValue("@apelido", funcionario.apelido);
                command.Parameters.AddWithValue("@endereco", funcionario.endereco);
                command.Parameters.AddWithValue("@bairro",  funcionario.bairro);
                command.Parameters.AddWithValue("@numero", funcionario.numero);
                command.Parameters.AddWithValue("@cep", funcionario.cep);
                command.Parameters.AddWithValue("@complemento", funcionario.complemento);
                command.Parameters.AddWithValue("@sexo", funcionario.sexo);
                command.Parameters.AddWithValue("@email", funcionario.email);
                command.Parameters.AddWithValue("@telefone", funcionario.telefone);
                command.Parameters.AddWithValue("@celular", funcionario.celular);
                command.Parameters.AddWithValue("@data_nasc", funcionario.data_nasc);
                command.Parameters.AddWithValue("@cpf", funcionario.cpf);
                command.Parameters.AddWithValue("@rg", funcionario.rg);
                command.Parameters.AddWithValue("@cargo", funcionario.cargo);
                command.Parameters.AddWithValue("@salario", funcionario.salario);
                command.Parameters.AddWithValue("@pis", funcionario.pis);
                command.Parameters.AddWithValue("@data_admissao", funcionario.data_admissao);
                command.Parameters.AddWithValue("@data_demissao", funcionario.data_demissao);
                command.Parameters.AddWithValue("@ativo", funcionario.Ativo);
                command.Parameters.AddWithValue("@dataUltAlt", funcionario.dataUltAlt);
                command.Parameters.AddWithValue("@idCidade", funcionario.idCidade);
                command.Parameters.AddWithValue("@usuario", funcionario.usuario);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao alterar funcionário: " + ex.Message);
                    throw;
                }
            }
        }

        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM funcionario WHERE idFuncionario = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    //verifica se a exceção está relacionada a uma restrição de chave estrangeira (uso em algum cadastro)
                    if (ex.Number == 547) //código de erro para conflito de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o Funcionário, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public override List<T> GetAll(bool incluiInativos = false)
        {
            List<T> funcionarios = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM funcionario" : "SELECT * FROM funcionario WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idFuncionario = Convert.ToInt32(reader["idFuncionario"]);
                        obj.funcionario = reader["funcionario"].ToString();
                        obj.cargo = reader["cargo"].ToString();
                        obj.celular = reader["celular"].ToString();
                        obj.cpf = reader["cpf"].ToString();
                        funcionarios.Add(obj);
                    }
                }
            }
            return funcionarios;
        }

        public override T GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM funcionario WHERE idFuncionario = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idFuncionario = Convert.ToInt32(reader["idFuncionario"]);
                        obj.funcionario = reader["funcionario"].ToString();
                        obj.apelido = reader["apelido"].ToString();
                        obj.endereco = reader["endereco"].ToString();
                        obj.bairro = reader["bairro"].ToString();
                        obj.numero = reader["numero"].ToString();
                        obj.cep = reader["cep"].ToString();
                        obj.complemento = reader["complemento"].ToString();
                        obj.sexo = reader["sexo"].ToString();
                        obj.email = reader["email"].ToString();
                        obj.telefone = reader["telefone"].ToString();
                        obj.celular = reader["celular"].ToString();
                        obj.usuario = reader["usuario"].ToString();
                        obj.data_nasc = DateTime.Parse(reader["data_nasc"].ToString());
                        obj.cpf = reader["cpf"].ToString();
                        obj.rg = reader["rg"].ToString();
                        obj.cargo = reader["cargo"].ToString();
                        obj.salario = Convert.ToDecimal(reader["salario"].ToString());
                        obj.pis = reader["pis"].ToString();
                        obj.data_admissao = DateTime.Parse(reader["data_admissao"].ToString());
                        obj.data_demissao = DateTime.Parse(reader["data_demissao"].ToString());
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        obj.idCidade = Convert.ToInt32(reader["idCidade"]);
                        return obj;
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
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
            dynamic funcionario = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO funcionario (funcionario, apelido, endereco, bairro, numero, cep, complemento, sexo, email, telefone, celular, data_nasc, cpf, rg, cargo, salario, pis, data_admissao, data_demissao, ativo, dataCadastro, dataUltAlt, idCidade, usuario) " +
                               "VALUES (@funcionario, @apelido, @endereco, @bairro, @numero, @cep, @complemento, @sexo, @email, @telefone, @celular, @data_nasc, @cpf, @rg, @cargo, @salario, @pis, @data_admissao, @data_demissao, @ativo, @dataCadastro, @dataUltAlt, @idCidade, @usuario)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", funcionario.idFuncionario);
                command.Parameters.AddWithValue("@funcionario", funcionario.funcionario);
                command.Parameters.AddWithValue("@apelido", funcionario.apelido);
                command.Parameters.AddWithValue("@endereco", funcionario.endereco);
                command.Parameters.AddWithValue("@bairro", funcionario.bairro);
                command.Parameters.AddWithValue("@numero", funcionario.numero);
                command.Parameters.AddWithValue("@cep", funcionario.cep);
                command.Parameters.AddWithValue("@complemento", funcionario.complemento);
                command.Parameters.AddWithValue("@sexo", funcionario.sexo);
                command.Parameters.AddWithValue("@email", funcionario.email);
                command.Parameters.AddWithValue("@telefone", funcionario.telefone);
                command.Parameters.AddWithValue("@celular", funcionario.celular);
                command.Parameters.AddWithValue("@data_nasc", funcionario.data_nasc);
                command.Parameters.AddWithValue("@cpf", funcionario.cpf);
                command.Parameters.AddWithValue("@rg", funcionario.rg);
                command.Parameters.AddWithValue("@cargo", funcionario.cargo);
                command.Parameters.AddWithValue("@salario", funcionario.salario);
                command.Parameters.AddWithValue("@pis", funcionario.pis);
                command.Parameters.AddWithValue("@data_admissao", funcionario.data_admissao);
                command.Parameters.AddWithValue("@data_demissao", funcionario.data_demissao);
                command.Parameters.AddWithValue("@ativo", funcionario.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", funcionario.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", funcionario.dataUltAlt);
                command.Parameters.AddWithValue("@idCidade", funcionario.idCidade);
                command.Parameters.AddWithValue("@usuario", funcionario.usuario);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao salvar funcionario: " + ex.Message);
                    throw;
                }
            }
        }
    }
}
