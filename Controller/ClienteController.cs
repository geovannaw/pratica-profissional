using MySqlX.XDevAPI;
using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas.Controller
{
    public class ClienteController<T> : ControllerPai<T>
    {
        protected ClienteDAO<T> clienteDAO;
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

        public string GetCondPagamentoByClienteId(int idCliente)
        {
            return clienteDAO.GetCondPagamentoByClienteId(idCliente);
        }

        public List<string> GetCEPByIdCidade(int idCidade)
        {
            return clienteDAO.GetCEPByIdCidade(idCidade);
        }

        public override void Salvar(T obj)
        {
            clienteDAO.Salvar(obj);
        }

        public bool JaCadastrado(string cpf_cnpj, int idAtual)
        {
            List<ClienteModel> clientes = clienteDAO.GetAll(false).Cast<ClienteModel>().ToList();

            foreach (ClienteModel cliente in clientes)
            {
                if (string.Equals(cliente.cpf_cnpj, cpf_cnpj, StringComparison.OrdinalIgnoreCase) && cliente.idCliente != idAtual)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
