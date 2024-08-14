using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class NotaCompraModel
    {
        public int numeroNota { get; set; }
        public int modelo { get; set; }
        public int serie { get; set; }
        public int idFornecedor { get; set; }   
        public DateTime dataEmissao { get; set; }
        public DateTime dataChegada { get; set; }
        public bool tipoFrete { get; set; }
        public decimal? valorFrete { get; set; }
        public decimal? valorSeguro { get; set; }
        public decimal? outrasDespesas { get; set; }
        public decimal totalProdutos { get; set; }
        public decimal totalPagar { get; set; }
        public int idCondPagamento { get; set; }
        public string observacao { get; set; }
        public DateTime? dataCancelamento { get; set; }
        public List<NotaCompra_ProdutoModel> Produtos { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
    }
}
