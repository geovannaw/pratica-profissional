using Sistema_Vendas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class FornecedorController<T> : ControllerPai<T>
    {
        protected FornecedorDAO<T> fornecedorDAO;
        public FornecedorController() : base()
        {
            fornecedorDAO = new FornecedorDAO<T>();
        }
        public override void Alterar(T obj)
        {
            fornecedorDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            fornecedorDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            return fornecedorDAO.GetAll(incluiInativos);
        }

        public override T GetById(int idObj)
        {
            return fornecedorDAO.GetById(idObj);
        }

        public List<string> GetCEPByCidadeId(int idCidade)
        {
            return fornecedorDAO.GetCEPByCidadeId(idCidade);
        }

        public override void Salvar(T obj)
        {
            fornecedorDAO.Salvar(obj);
        }
    }
}
