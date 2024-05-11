using Sistema_Vendas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class ClienteController<T> : ControllerPai<T>
    {
        private ClienteDAO<T> clienteDAO;
        public ClienteController() : base()
        {
            clienteDAO = new ClienteDAO<T>();
        }
        public override void Alterar(T obj)
        {
            clienteDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            clienteDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            return clienteDAO.GetAll(incluiInativos);
        }

        public override T GetById(int idObj)
        {
            return clienteDAO.GetById(idObj);
        }

        public List<string> GetCEPByCidadeId(int idCidade)
        {
            return clienteDAO.GetCEPByCidadeId(idCidade);
        }

        public override void Salvar(T obj)
        {
            clienteDAO.Salvar(obj);
        }
    }
}
