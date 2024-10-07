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
    public class ModeloDAO<T> : DAO<T>
    {
        public ModeloDAO() : base() { }
        public int GetUltimoCodigo()
        {
            int ultimoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idModelo) FROM modelo";
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
            dynamic modelo = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE modelo SET Modelo = @modelo, Marca = @marca, Observacao = @observacao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt, usuario = @usuario WHERE idModelo = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", modelo.idModelo);
                command.Parameters.AddWithValue("@modelo", modelo.Modelo);
                command.Parameters.AddWithValue("@marca", modelo.Marca);
                command.Parameters.AddWithValue("@observacao", modelo.Observacao);
                command.Parameters.AddWithValue("@ativo", modelo.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", modelo.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", modelo.dataUltAlt);
                command.Parameters.AddWithValue("@usuario", modelo.usuario);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM modelo WHERE idModelo = @id";

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
                        MessageBox.Show("Não é possível excluir o Modelo, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<T> modelos = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM modelo" : "SELECT * FROM modelo WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idModelo = Convert.ToInt32(reader["idModelo"]);
                        obj.Modelo = reader["Modelo"].ToString();
                        obj.Marca = reader["Marca"].ToString();
                        modelos.Add(obj);
                    }
                }
            }
            return modelos;
        }

        public override T GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM modelo WHERE idModelo = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idModelo = Convert.ToInt32(reader["idModelo"]);
                        obj.Modelo = reader["Modelo"].ToString();
                        obj.Marca = reader["Marca"].ToString();
                        obj.usuario = reader["usuario"].ToString();
                        obj.Observacao = reader["Observacao"].ToString();
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
            dynamic modelo = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO modelo (modelo, marca, observacao, ativo, dataCadastro, dataUltAlt, usuario) VALUES (@modelo, @marca, @observacao, @ativo, @dataCadastro, @dataUltAlt, @usuario)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@modelo", modelo.Modelo);
                command.Parameters.AddWithValue("@marca", modelo.Marca);
                command.Parameters.AddWithValue("@observacao", modelo.Observacao);
                command.Parameters.AddWithValue("@ativo", modelo.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", modelo.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", modelo.dataUltAlt);
                command.Parameters.AddWithValue("@usuario", modelo.usuario);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
