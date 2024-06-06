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

        public List<string> GetCEPByCidadeId(int idCidade)
        {
            return fornecedorDAO.GetCEPByCidadeId(idCidade);
        }

        public override void Salvar(T obj)
        {
            fornecedorDAO.Salvar(obj);
        }

        public bool JaCadastrado(string cpf_cnpj, int idAtual)
        {
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

        public bool BuscaNome(string fornecedor_razao_social, int idAtual)
        {
            List<FornecedorModel> fornecedores = fornecedorDAO.GetAll(false).Cast<FornecedorModel>().ToList();

            foreach (FornecedorModel fornecedor in fornecedores)
            {
                if (string.Equals(fornecedor.fornecedor_razao_social, fornecedor_razao_social, StringComparison.OrdinalIgnoreCase) && fornecedor.idFornecedor != idAtual)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
