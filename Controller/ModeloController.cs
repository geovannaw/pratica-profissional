using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class ModeloController<T> : ControllerPai<T>
    {
        protected ModeloDAO<T> modeloDAO;

        public ModeloController() : base()
        {
            modeloDAO = new ModeloDAO<T>();
        }

        public override void Alterar(T obj)
        {
            modeloDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            modeloDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            return modeloDAO.GetAll(incluiInativos);
        }

        public override T GetById(int idObj)
        {
            return modeloDAO.GetById(idObj);
        }

        public override void Salvar(T obj)
        {
            modeloDAO.Salvar(obj);
        }

        public bool JaCadastrado(string nome)
        {
            List<T> obj = modeloDAO.GetAll(false);

            if (typeof(T) == typeof(ModeloModel))
            {
                var Model = obj.Cast<ModeloModel>().ToList();

                foreach (var modelo in Model)
                {
                    if (modelo.Modelo.Equals(nome, StringComparison.OrdinalIgnoreCase))
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
