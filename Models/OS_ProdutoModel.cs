using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class OS_ProdutoModel
    {
        public int id_os_produto { get; set; }
        public int quantidadeProduto { get; set; }
        public decimal precoProduto { get; set; }
        public int idProduto { get; set; }
        public int idOrdemServico { get; set; }
    }
}
