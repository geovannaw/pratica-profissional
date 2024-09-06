using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class NotaVendaController<T> : ControllerPai<T> where T : NotaVendaModel
    {
        protected NotaVendaDAO notaVendaDAO;
        public NotaVendaController() : base()
        {
            notaVendaDAO = new NotaVendaDAO();
        }
        public int GetUltimoNumeroNota()
        {
            return notaVendaDAO.GetUltimoNumeroNota();
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
            var ordens = notaVendaDAO.GetAll(incluiInativos);
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
        public T GetNotaById(int numero, int modelo, int serie, int idCliente)
        {
            return notaVendaDAO.GetNotaById(numero, modelo, serie, idCliente) as T;
        }

        public override void Salvar(T obj)
        {
            notaVendaDAO.Salvar(obj as NotaVendaModel);
        }
        public ProdutoModel GetProdutoPorId(int idProduto)
        {
            return notaVendaDAO.GetProdutoPorId(idProduto);
        }

        public void AtualizarProdutosNotaVenda(NotaVendaModel obj)
        {
            notaVendaDAO.AtualizarProdutosNotaVenda((NotaVendaModel)obj);
        }
        public bool CancelarNotaVenda(int numeroNota, int modelo, int serie, int idCliente)
        {
            return notaVendaDAO.CancelarNotaVenda(numeroNota, modelo, serie, idCliente);
        }

        public bool ExisteNota(int numeroNota, string modelo, string serie, int idCliente)
        {
            return notaVendaDAO.ExisteNota(numeroNota, modelo, serie, idCliente);
        }
    }
}
