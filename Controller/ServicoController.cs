using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class ServicoController<T> : ControllerPai<T>
    {
        protected ServicoDAO<T> servicoDAO;

        public ServicoController() : base()
        {
            servicoDAO = new ServicoDAO<T>();
        }
        public override void Alterar(T obj)
        {
            servicoDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            servicoDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            return servicoDAO.GetAll(incluiInativos);
        }

        public override T GetById(int idObj)
        {
            return servicoDAO.GetById(idObj);
        }

        public override void Salvar(T obj)
        {
            servicoDAO.Salvar(obj);
        }

        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = servicoDAO.GetAll(false);

            if (typeof(T) == typeof(ServicoModel))
            {
                var Model = obj.Cast<ServicoModel>().ToList();

                foreach (var servico in Model)
                {
                    if (servico.servico.Equals(nome, StringComparison.OrdinalIgnoreCase) && servico.idServico != idAtual)
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
