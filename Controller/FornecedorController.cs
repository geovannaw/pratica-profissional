using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class FornecedorController<T> : ControllerPai<T>
    {
        protected FornecedorDAO<T> fornecedorDAO;
        public FornecedorController() : base()
        {
            fornecedorDAO = new FornecedorDAO<T>();
        }
        public int GetUltimoCodigo()
        {
            return fornecedorDAO.GetUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            fornecedorDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            fornecedorDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            return fornecedorDAO.GetAll(incluiInativos);
        }

        public override T GetById(int idObj)
        {
            return fornecedorDAO.GetById(idObj);
        }

        public string GetCondPagamentoByFornecedorId(int idFornecedor)
        {
            return fornecedorDAO.GetCondPagamentoByFornecedorId(idFornecedor);
        }

        public List<string> GetCEPByIdCidade(int idCidade)
        {
            return fornecedorDAO.GetCEPByIdCidade(idCidade);
        }

        public override void Salvar(T obj)
        {
            fornecedorDAO.Salvar(obj);
        }

        public bool JaCadastrado(string cpf_cnpj, int idAtual)
        {
            if (string.IsNullOrEmpty(cpf_cnpj))
                return false;
            List<FornecedorModel> fornecedores = fornecedorDAO.GetAll(false).Cast<FornecedorModel>().ToList();

            foreach (FornecedorModel fornecedor in fornecedores)
            {
                if (string.Equals(fornecedor.cpf_cnpj, cpf_cnpj, StringComparison.OrdinalIgnoreCase) && fornecedor.idFornecedor != idAtual)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
