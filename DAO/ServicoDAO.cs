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
    public class ServicoDAO<T> : DAO<T>
    {
        public ServicoDAO() : base()
        {
        }
        public int GetUltimoCodigo()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idServico) FROM servico";
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
            dynamic servico = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE servico SET servico = @servico, preco = @preco, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idServico = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", servico.idServico);
                command.Parameters.AddWithValue("@servico", servico.servico);
                command.Parameters.AddWithValue("@preco", servico.preco);
                command.Parameters.AddWithValue("@ativo", servico.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", servico.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", servico.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM servico WHERE idServico = @id";

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
                        MessageBox.Show("Não é possível excluir o Serviço, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<T> servico = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM servico" : "SELECT * FROM servico WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idServico = Convert.ToInt32(reader["idServico"]);
                        obj.servico = reader["servico"].ToString();
                        obj.preco = Convert.ToDecimal(reader["preco"]);
                        servico.Add(obj);
                    }
                }
            }
            return servico;
        }

        public override T GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM servico WHERE idServico = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idServico = Convert.ToInt32(reader["idServico"]);
                        obj.servico = reader["servico"].ToString();
                        obj.preco = Convert.ToDecimal(reader["preco"]);
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }

        public override void Salvar(T obj)
        {
            dynamic servico = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO servico (servico, preco, ativo, dataCadastro, dataUltAlt) VALUES (@servico, @preco, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", servico.idServico);
                command.Parameters.AddWithValue("@servico", servico.servico);
                command.Parameters.AddWithValue("@preco", servico.preco);
                command.Parameters.AddWithValue("@ativo", servico.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", servico.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", servico.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
