using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System.Collections.Generic;

namespace Sistema_Vendas.Controller
{
    public class CondicaoPagamentoController<T> : ControllerPai<T> where T : CondicaoPagamentoModel
    {
        protected CondicaoPagamentoDAO condicaoPagamentoDAO;

        public CondicaoPagamentoController() : base()
        {
            condicaoPagamentoDAO = new CondicaoPagamentoDAO();
        }

        public string getCondicaoPag(int id)
        {
            return condicaoPagamentoDAO.getCondicaoPag(id);
        }
        public int GetUltimoCodigo()
        {
            return condicaoPagamentoDAO.GetUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            condicaoPagamentoDAO.Alterar(obj as CondicaoPagamentoModel);
        }

        public override void Delete(int idObj)
        {
            condicaoPagamentoDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluirInativos)
        {
            List<T> lista = new List<T>();
            var condicoes = condicaoPagamentoDAO.GetAll(incluirInativos);
            foreach (var item in condicoes)
            {
                lista.Add(item as T);
            }
            return lista;
        }

        public override T GetById(int idObj)
        {
            return condicaoPagamentoDAO.GetById(idObj) as T;
        }

        public string GetFormaPagByParcelaId(int idParcela)
        {
            return condicaoPagamentoDAO.GetFormaPagByParcelaId(idParcela);
        }

        public override void Salvar(T obj)
        {
            condicaoPagamentoDAO.Salvar(obj as CondicaoPagamentoModel);
        }
    }
}
