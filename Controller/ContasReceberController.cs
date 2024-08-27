using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class ContasReceberController<T> : ControllerPai<T> where T : ContasReceberModel
    {
        protected ContasReceberDAO contasReceberDAO;
        public ContasReceberController() : base()
        {
            contasReceberDAO = new ContasReceberDAO();
        }
        public override void Alterar(T obj)
        {
            contasReceberDAO.Alterar(obj as ContasReceberModel);
        }

        public override void Delete(int idObj)
        {
            throw new NotImplementedException();
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            List<T> lista = new List<T>();
            var ordens = contasReceberDAO.GetAll(incluiInativos);
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

        public T GetContaById(int numero, int modelo, int serie, int idCliente, int parcela)
        {
            return contasReceberDAO.GetContaById(numero, modelo, serie, idCliente, parcela) as T;
        }

        public override void Salvar(T obj)
        {
            contasReceberDAO.Salvar(obj as ContasReceberModel);
        }
        public bool CancelarConta(T obj)
        {
            return contasReceberDAO.CancelarConta(obj as ContasReceberModel);
        }
        public bool JaCadastrado(int numeroNota, int modelo, int serie, int idCliente, int parcela, bool incluindo)
        {
            List<ContasReceberModel> contasReceber = contasReceberDAO.GetAll(false).Cast<ContasReceberModel>().ToList();

            foreach (ContasReceberModel conta in contasReceber)
            {
                if (conta.numeroNota == numeroNota &&
                    conta.modelo == modelo &&
                    conta.serie == serie &&
                    conta.idCliente == idCliente &&
                    conta.parcela == parcela)
                {
                    //se estiver incluindo e já existe uma conta com a mesma chave composta
                    if (incluindo)
                    {
                        return true;
                    }
                    else
                    {
                        //se estiver alterando e encontrou outra conta com a mesma chave composta, diferente da atual
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
