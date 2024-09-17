using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class ContasReceberModel
    {
        public int numeroNota { get; set; }
        public int modelo { get; set; }
        public int serie { get; set; }
        public int idCliente { get; set; }
        public DateTime dataEmissao { get; set; }
        public int parcela { get; set; }
        public decimal valorParcela { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime? dataRecebimento { get; set; }
        public decimal? valorRecebido { get; set; }
        public decimal? juros { get; set; }
        public decimal? multa { get; set; }
        public decimal? desconto { get; set; }
        public int idFormaPagamento { get; set; }
        public string observacao { get; set; }
        public string usuario { get; set; }
        public DateTime? dataCancelamento { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
    }
}
