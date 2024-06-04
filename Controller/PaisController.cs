using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_Vendas.Controller
{
    public class PaisController<T> : ControllerPai<T>
    {
        protected PaisDAO<T> paisDAO;

        public PaisController() : base()
        {
            paisDAO = new PaisDAO<T>();
        }

        public override void Alterar(T obj)
        {
            paisDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            paisDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluirInativos)
        {
            return paisDAO.GetAll(incluirInativos);
        }

        public override T GetById(int idObj)
        {
            return paisDAO.GetById(idObj);
        }

        public override void Salvar(T obj)
        {
            paisDAO.Salvar(obj);
        }

        public bool JaCadastrado(string nome)
        {
            List<T> obj = paisDAO.GetAll(false);

            if (typeof(T) == typeof(PaisModel))
            {
                var Model = obj.Cast<PaisModel>().ToList();

                foreach (var pais in Model)
                {
                    if (pais.Pais.Equals(nome, StringComparison.OrdinalIgnoreCase))
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

