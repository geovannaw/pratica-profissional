using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class NotaCompraController<T> : ControllerPai<T> where T : NotaCompraModel
    {
        protected NotaCompraDAO notaCompraDAO;
        public NotaCompraController() : base()
        {
            notaCompraDAO = new NotaCompraDAO();
        }
        public override void Alterar(T obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int idObj)
        {
            throw new NotImplementedException();
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            List<T> lista = new List<T>();
            var ordens = notaCompraDAO.GetAll(incluiInativos);
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

        public T GetNotaById (int numero, int modelo, int serie, int idFornecedor)
        {
            return notaCompraDAO.GetNotaById(numero, modelo, serie, idFornecedor) as T;
        }

        public override void Salvar(T obj)
        {
            notaCompraDAO.Salvar(obj as NotaCompraModel);
        }

        public bool ExisteNota(int numeroNota, string modelo, string serie, int idFornecedor)
        {
            return notaCompraDAO.ExisteNota(numeroNota, modelo, serie, idFornecedor);
        }
    }
}
