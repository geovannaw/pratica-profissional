using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class NotaServicoController<T> : ControllerPai<T> where T : NotaServicoModel
    {
        protected NotaServicoDAO notaServicoDAO;
        public NotaServicoController() : base()
        {
            notaServicoDAO = new NotaServicoDAO();
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
            var ordens = notaServicoDAO.GetAll(incluiInativos);
            foreach (var item in ordens)
            {
                lista.Add(item as T);
            }
            return lista;
        }
        public T GetNotaById(int numero, int modelo, int serie, int idCliente)
        {
            return notaServicoDAO.GetNotaById(numero, modelo, serie, idCliente) as T;
        }

        public override T GetById(int idObj)
        {
            throw new NotImplementedException();
        }

        public override void Salvar(T obj)
        {
            notaServicoDAO.Salvar(obj as NotaServicoModel);
        }
        public ServicoModel GetServicoPorId(int idServico)
        {
            return notaServicoDAO.GetServicoPorId(idServico);
        }
        public bool CancelarNotaServico(int numeroNota, int modelo, int serie, int idCliente)
        {
            return notaServicoDAO.CancelarNotaServico(numeroNota, modelo, serie, idCliente);
        }

        public bool ExisteNota(int numeroNota, string modelo, string serie, int idCliente)
        {
            return notaServicoDAO.ExisteNota(numeroNota, modelo, serie, idCliente);
        }
    }
}
