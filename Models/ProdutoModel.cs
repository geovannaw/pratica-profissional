using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class ProdutoModel
    {
        public int idProduto { get; set; }
        public string Produto { get; set; }
        public string Unidade { get; set; }
        public int Saldo { get; set; }
        public decimal custoMedio { get; set; }
        public decimal custoUltCompra { get; set; }
        public decimal precoVenda { get; set; }
        public decimal precoUltCompra { get; set; }
        public DateTime? dataUltCompra { get; set; }
        public string Observacao { get; set; }
        public int idFornecedor { get; set; }
        public int idModelo { get; set; }
        public string usuario { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
