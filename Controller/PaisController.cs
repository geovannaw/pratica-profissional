using Sistema_Vendas.DAO;
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
        public int GetUltimoCodigo()
        {
            return paisDAO.GetUltimoCodigo();
        }
        public string getPais(int id)
        {
            return paisDAO.getPais(id);
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

        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = paisDAO.GetAll(false);

            if (typeof(T) == typeof(PaisModel))
            {
                var Model = obj.Cast<PaisModel>().ToList();

                foreach (var pais in Model)
                {
                    //verifica se o nome já existe e não é o país atual que está sendo alterado
                    if (pais.Pais.Equals(nome, StringComparison.OrdinalIgnoreCase) && pais.idPais != idAtual)
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

