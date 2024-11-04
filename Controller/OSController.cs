using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Controller
{
    public class OSController<T> : ControllerPai<T> where T : OrdemServicoModel
    {
        protected OSDAO osDAO;
        private ProdutoController<ProdutoModel> produtoController;
        public OSController() : base()
        {
            osDAO = new OSDAO();
            produtoController = new ProdutoController<ProdutoModel>();
        }
        public int GetUltimoCodigo()
        {
            return osDAO.GetUltimoCodigo();
        }
        public List<ProdutoModel> GetProdutosByOS(int idOrdemServico)
        {
            List<OS_ProdutoModel> osProdutos = osDAO.GetProdutosByOS(idOrdemServico);
            List<ProdutoModel> produtos = new List<ProdutoModel>();

            foreach (var osProduto in osProdutos)
            {
                ProdutoModel produto = produtoController.GetById(osProduto.idProduto);
                if (produto != null)
                {
                    produto.Saldo = osProduto.quantidadeProduto;
                    produtos.Add(produto);
                }
            }

            return produtos;
        }

        public override void Alterar(T obj)
        {
            osDAO.Alterar(obj);
        }

        public override void Delete(int idObj)
        {
            osDAO.Delete(idObj);
        }

        public override List<T> GetAll(bool incluiInativos)
        {
            List<T> lista = new List<T>();
            var ordens = osDAO.GetAll(incluiInativos);
            foreach (var item in ordens)
            {
                lista.Add(item as T);
            }
            return lista;
        }

        public override T GetById(int idObj)
        {
            return osDAO.GetById(idObj) as T;
        }

        public override void Salvar(T obj)
        {
            osDAO.Salvar(obj as OrdemServicoModel);
        }
        public ServicoModel GetServicoPorId(int idServico)
        {
            return osDAO.GetServicoPorId(idServico);
        }
        public ProdutoModel GetProdutoPorId(int idProduto)
        {
            return osDAO.GetProdutoPorId(idProduto);
        }

        public ClienteModel GetClientePorId(int idCliente)
        {
            return osDAO.GetClientePorId(idCliente);
        }
        public ClienteModel getCliente(int idCliente)
        {
            return osDAO.getCliente(idCliente);
        }
        public string GetClienteByOSid(int idOS)
        {
            return osDAO.GetClienteByOSid(idOS);
        }
    }
}
