using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class EstadoController<T> : ControllerPai<T>
    {
        private EstadoDAO<T> estadoDAO;

        public EstadoController() : base() 
        { 
            estadoDAO = new EstadoDAO<T>();
        }
        public override void Alterar(T obj)
        {
            estadoDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            estadoDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluirInativos)
        {
            return estadoDAO.GetAll(incluirInativos);
        }

        public override T GetById(int idObj)
        {
            return estadoDAO.GetById(idObj);
        }

        public string GetNomePaisByEstadoId(int idEstado)
        {
            return estadoDAO.GetNomePaisByEstadoId(idEstado);
        }

        public override void Salvar(T obj)
        {
            estadoDAO.Salvar(obj);
        }
    }
}
