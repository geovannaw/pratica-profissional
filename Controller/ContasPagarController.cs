using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class ContasPagarController<T> : ControllerPai<T> where T : ContasPagarModel
    {
        protected ContasPagarDAO contasPagarDAO;
        public ContasPagarController() : base()
        {
            contasPagarDAO = new ContasPagarDAO();
        }
        public override void Alterar(T obj)
        {
            contasPagarDAO.Alterar(obj as ContasPagarModel);
        }

        public override void Delete(int idObj)
        {
            throw new NotImplementedException();
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            List<T> lista = new List<T>();
            var ordens = contasPagarDAO.GetAll(incluiInativos);
            foreach (var item in ordens)
            {
                lista.Add(item as T);
            }
            return lista;
        }

        public override T GetById(int idObj)
        {
            throw new NotImplementedException();
        }

        public T GetContaById(int numero, int modelo, int serie, int idFornecedor, int parcela)
        {
            return contasPagarDAO.GetContaById(numero, modelo, serie, idFornecedor, parcela) as T;
        }

        public override void Salvar(T obj)
        {
            contasPagarDAO.Salvar(obj as ContasPagarModel);
        }
    }
}
