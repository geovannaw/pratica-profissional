using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class FormaPagamentoController<T> : ControllerPai<T>
    {
        protected FormaPagamentoDAO<T> formaPagamentoDAO;
        public FormaPagamentoController() : base()
        {
            formaPagamentoDAO = new FormaPagamentoDAO<T>();
        }
        public string getFormaPag(int id)
        {
            return formaPagamentoDAO.getFormaPag(id);
        }
        public int GetUltimoCodigo()
        {
            return formaPagamentoDAO.GetUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            formaPagamentoDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            formaPagamentoDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            return formaPagamentoDAO.GetAll(incluiInativos);
        }

        public override T GetById(int idObj)
        {
            return formaPagamentoDAO.GetById(idObj);
        }

        public override void Salvar(T obj)
        {
            formaPagamentoDAO.Salvar(obj);
        }

        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = formaPagamentoDAO.GetAll(false);

            if (typeof(T) == typeof(FormaPagamentoModel))
            {
                var Model = obj.Cast<FormaPagamentoModel>().ToList();

                foreach (var formaPag in Model)
                {
                    if (formaPag.formaPagamento.Equals(nome, StringComparison.OrdinalIgnoreCase) && formaPag.idFormaPagamento != idAtual)
                    {
                        return true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Aviso: O tipo genérico T não é compatível.");
            }

            return false;
        }
    }
}
