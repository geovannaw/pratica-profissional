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
        public int GetUltimoCodigo()
        {
            return modeloDAO.GetUltimoCodigo();
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

        public bool JaCadastrado(string nome, string marca, int idAtual)
        {
            List<ModeloModel> modelos = modeloDAO.GetAll(false).Cast<ModeloModel>().ToList();

            foreach (ModeloModel modelo in modelos)
            {
                if (string.Equals(modelo.Modelo, nome, StringComparison.OrdinalIgnoreCase) && string.Equals(modelo.Marca, marca, StringComparison.OrdinalIgnoreCase) && modelo.idModelo != idAtual)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
