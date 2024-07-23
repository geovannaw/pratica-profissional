using Sistema_Vendas.DAO;
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
        protected EstadoDAO<T> estadoDAO;

        public EstadoController() : base() 
        { 
            estadoDAO = new EstadoDAO<T>();
        }
        public int GetUltimoCodigo()
        {
            return estadoDAO.GetUltimoCodigo();
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

        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = estadoDAO.GetAll(false);

            if (typeof(T) == typeof(EstadoModel))
            {
                var Model = obj.Cast<EstadoModel>().ToList();

                foreach (var estado in Model)
                {
                    if (estado.Estado.Equals(nome, StringComparison.OrdinalIgnoreCase) && estado.idEstado != idAtual)
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
