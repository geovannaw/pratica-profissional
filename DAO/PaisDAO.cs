using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Vendas.Models
{
    public class PaisDAO<T> : DAO<T>
    {
        public PaisDAO() : base()
        {
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            List<T> paises = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM pais" : "SELECT * FROM pais WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idPais = Convert.ToInt32(reader["idPais"]);
                        obj.Pais = reader["Pais"].ToString();
                        obj.Sigla = reader["Sigla"].ToString();
                        obj.DDI = reader["DDI"].ToString();
                        paises.Add(obj);
                    }
                }
            }
            return paises;
        }

        public override void Salvar(T obj)
        {
            dynamic pais = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO pais (pais, sigla, DDI, ativo, dataCadastro, dataUltAlt) VALUES (@pais, @sigla, @DDI, @ativo, @dataCadastro, @dataUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@pais", pais.Pais);
                command.Parameters.AddWithValue("@sigla", pais.Sigla);
                command.Parameters.AddWithValue("@DDI", pais.DDI);
                command.Parameters.AddWithValue("@ativo", pais.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", pais.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", pais.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM pais WHERE idPais = @id";

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
                        MessageBox.Show("Não é possível excluir o País, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public override void Alterar(T obj)
        {
            dynamic pais = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE pais SET Pais = @pais, Sigla = @sigla, DDI = @DDI, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt WHERE idPais = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", pais.idPais);
                command.Parameters.AddWithValue("@pais", pais.Pais);
                command.Parameters.AddWithValue("@sigla", pais.Sigla);
                command.Parameters.AddWithValue("@DDI", pais.DDI);
                command.Parameters.AddWithValue("@ativo", pais.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", pais.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", pais.dataUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override T GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM pais WHERE idPais = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idPais = Convert.ToInt32(reader["idPais"]);
                        obj.Pais = reader["Pais"].ToString();
                        obj.Sigla = reader["Sigla"].ToString();
                        obj.DDI = reader["DDI"].ToString();
                        obj.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        obj.dataCadastro = DateTime.Parse(reader["dataCadastro"].ToString());
                        obj.dataUltAlt = DateTime.Parse(reader["dataUltAlt"].ToString());
                        return obj;
                    }
                    else
                    {
                        return default(T); // retorna default se o país não for encontrado
                    }
                }
            }
        }
    }
}
