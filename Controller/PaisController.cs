using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;

namespace Sistema_Vendas.Controller
{
    public class PaisController<T> : ControllerPai<T>
    {
        private PaisDAO<T> paisDAO;

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
    }
}
