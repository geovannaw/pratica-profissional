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

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT permissao, ativo FROM usuarios WHERE usuario = @usuario AND senha = @senha";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())  //ve resultado
                        {
                            bool isAtivo = reader.GetBoolean(reader.GetOrdinal("ativo"));  //valor de 'ativo'
                            if (!isAtivo)  //se o usuário não está ativo
                            {
                                return "inativo";  //retorna "inativo"
                            }

                            permissao = reader["permissao"].ToString();  //obtém a permissão
                        }
                    }
                }
            }
            return permissao;
        }
    }
}
