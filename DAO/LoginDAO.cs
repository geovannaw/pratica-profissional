using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.DAO
{
    public class LoginDAO
    {
        protected string connectionString;
        public LoginDAO()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public string ValidarUsuario(string usuario, string senha)
        {
            string permissao = "";

            // Gera o hash da senha fornecida
            string senhaHash = Criptografia.GerarHashSenha(senha);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT permissao, ativo FROM usuarios WHERE usuario = @usuario AND senha = @senha";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senhaHash); // compara o hash da senha

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isAtivo = reader.GetBoolean(reader.GetOrdinal("ativo"));
                            if (!isAtivo)
                            {
                                return "inativo";
                            }

                            permissao = reader["permissao"].ToString();
                        }
                    }
                }
            }
            return permissao;
        }
    }
}
