using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Sistema_Vendas.Models
{
    public abstract class DAO<T>
    {
        protected string connectionString;

        public DAO()
        { 
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public abstract List<T> GetAll(bool incluiInativos = false);
        public abstract void Salvar(T obj);
        public abstract void Delete(int id);
        public abstract void Alterar(T obj);
        public abstract T GetById(int id);

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
