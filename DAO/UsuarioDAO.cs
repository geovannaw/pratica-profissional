using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas.DAO
{
    public class UsuarioDAO<T> : DAO<T>
    {
        public int GetUltimoCodigo()
        {
            int proximoCodigo = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(idUsuario) FROM usuarios";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    proximoCodigo = Convert.ToInt32(result);
                }
            }
            return proximoCodigo;
        }
        public override void Alterar(T obj)
        {
            dynamic usuario = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE usuarios SET usuario = @usuario, senha = @senha, permissao = @permissao, ativo = @ativo, dataCadastro = @dataCadastro, dataUltAlt = @dataUltAlt, usuarioUltAlt = @usuarioUltAlt WHERE idUsuario = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", usuario.idUsuario);
                command.Parameters.AddWithValue("@usuario", usuario.usuario);

                //criptografar a senha antes de armazená-la
                string senhaCriptografada = Criptografia.GerarHashSenha(usuario.senha);
                command.Parameters.AddWithValue("@senha", senhaCriptografada);

                command.Parameters.AddWithValue("@permissao", usuario.permissao);
                command.Parameters.AddWithValue("@ativo", usuario.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", usuario.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", usuario.dataUltAlt);
                command.Parameters.AddWithValue("@usuarioUltAlt", usuario.usuarioUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public override void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM usuarios WHERE idUsuario = @id";

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
                        MessageBox.Show("Não é possível excluir o Usuário, pois ele está sendo utilizado em um cadastro.", "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<T> usuarios = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = incluiInativos ? "SELECT * FROM usuarios" : "SELECT * FROM usuarios WHERE ativo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idUsuario = Convert.ToInt32(reader["idUsuario"]);
                        obj.usuario = reader["Usuario"].ToString();
                        obj.senha = reader["Senha"].ToString();
                        obj.permissao = reader["Permissao"].ToString();
                        usuarios.Add(obj);
                    }
                }
            }
            return usuarios;
        }

        public override T GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM usuarios WHERE idUsuario = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dynamic obj = Activator.CreateInstance(typeof(T));
                        obj.idUsuario = Convert.ToInt32(reader["idUsuario"]);
                        obj.usuario = reader["usuario"].ToString();
                        obj.senha = reader["senha"].ToString(); 
                        obj.permissao = reader["permissao"].ToString();
                        obj.usuarioUltAlt = reader["usuarioUltAlt"].ToString();
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
            dynamic usuario = obj;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO usuarios (usuario, senha, permissao, ativo, dataCadastro, dataUltAlt, usuarioUltAlt) VALUES (@usuario, @senha, @permissao, @ativo, @dataCadastro, @dataUltAlt, @usuarioUltAlt)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@usuario", usuario.usuario);
                command.Parameters.AddWithValue("@senha", Criptografia.GerarHashSenha(usuario.senha));
                command.Parameters.AddWithValue("@permissao", usuario.permissao);
                command.Parameters.AddWithValue("@ativo", usuario.Ativo);
                command.Parameters.AddWithValue("@dataCadastro", usuario.dataCadastro);
                command.Parameters.AddWithValue("@dataUltAlt", usuario.dataUltAlt);
                command.Parameters.AddWithValue("@usuarioUltAlt", usuario.usuarioUltAlt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
