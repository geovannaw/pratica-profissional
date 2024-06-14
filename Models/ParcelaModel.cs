using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class ParcelaModel
    {
        public int idParcela { get; set; }
        public int numeroParcela { get; set; } 
        public int dias { get; set; }
        public decimal porcentagem { get; set; }
        public int idCondPagamento { get; set; }
        public int idFormaPagamento { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
