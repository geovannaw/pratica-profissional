using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class ProdutoController<T> : ControllerPai<T>
    {
        protected ProdutoDAO<T> produtoDAO;
        public ProdutoController() : base()
        {
            produtoDAO = new ProdutoDAO<T>();
        }
        public int GetUltimoCodigo()
        {
            return produtoDAO.GetUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            produtoDAO.Alterar(obj);
        }
        public void AtualizarSaldo(int idProduto, int quantidade)
        {
            produtoDAO.AtualizarSaldo(idProduto, quantidade);
        }
        public override void Delete(int idObj)
        {
            produtoDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            return produtoDAO.GetAll(incluiInativos);
        }

        public override T GetById(int idObj)
        {
            return produtoDAO.GetById(idObj);
        }

        public override void Salvar(T obj)
        {
            produtoDAO.Salvar(obj);
        }

        public bool JaCadastrado(string nome, int idFornecedor, int idAtual)
        {
            List<ProdutoModel> produtos = produtoDAO.GetAll(false).Cast<ProdutoModel>().ToList();

            foreach (ProdutoModel produto in produtos)
            {
                if (string.Equals(produto.Produto, nome, StringComparison.OrdinalIgnoreCase) && produto.idFornecedor == idFornecedor && produto.idProduto != idAtual)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
