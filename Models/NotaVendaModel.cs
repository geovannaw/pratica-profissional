using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class NotaVendaModel
    {
        public int numeroNota { get; set; }
        public int modelo { get; set; }
        public int serie { get; set; }
        public int idCliente { get; set; }
        public DateTime dataEmissao { get; set; }
        public decimal totalProdutos { get; set; }
        public decimal totalPagar { get; set; }
        public decimal porcentagemDesconto { get; set; }
        public int idCondPagamento { get; set; }
        public string observacao { get; set; }
        public DateTime? dataCancelamento { get; set; }
        public List<NotaVenda_ProdutoModel> Produtos { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
    }
}
