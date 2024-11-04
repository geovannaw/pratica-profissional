using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class NotaServico_ServicoModel
    {
        public int numeroNota { get; set; }
        public int modelo { get; set; }
        public int serie { get; set; }
        public int idCliente { get; set; }
        public int idServico { get; set; }
        public decimal? descontoServ { get; set; }
        public decimal precoServico { get; set; }
        public int quantidadeServico { get; set; }
    }
}
