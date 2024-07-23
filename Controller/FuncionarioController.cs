using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class FuncionarioController<T> : ControllerPai<T>
    {
        protected FuncionarioDAO<T> funcionarioDAO;
        public FuncionarioController() : base()
        {
            funcionarioDAO = new FuncionarioDAO<T>();
        }
        public int GetUltimoCodigo()
        {
            return funcionarioDAO.GetUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            funcionarioDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            funcionarioDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            return funcionarioDAO.GetAll(incluiInativos);
        }

        public override T GetById(int idObj)
        {
            return funcionarioDAO.GetById(idObj);
        }

        public List<string> GetCEPByIdCidade(int idCidade)
        {
            return funcionarioDAO.GetCEPByIdCidade(idCidade);
        }

        public override void Salvar(T obj)
        {
            funcionarioDAO.Salvar(obj);
        }

        public bool JaCadastrado(string cpf, int idAtual)
        {
            if (string.IsNullOrEmpty(cpf))
                return false;
            List<FuncionarioModel> funcinoarios = funcionarioDAO.GetAll(false).Cast<FuncionarioModel>().ToList();

            foreach (FuncionarioModel funcionario in funcinoarios)
            {
                if (string.Equals(funcionario.cpf, cpf, StringComparison.OrdinalIgnoreCase) && funcionario.idFuncionario != idAtual)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
