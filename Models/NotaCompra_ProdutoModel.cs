using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class NotaCompra_ProdutoModel
    {
        public int numeroNota { get; set; }
        public int modelo { get; set; }
        public int serie { get; set; }
        public int idFornecedor { get; set; }
        public int idProduto { get; set; }
        public decimal precoProduto { get; set; }
        public int quantidadeProduto { get; set; }
        public decimal? descontoProd { get; set; }
        public decimal custoMedio { get; set; }
        public decimal? rateio { get; set; }
    }
}
