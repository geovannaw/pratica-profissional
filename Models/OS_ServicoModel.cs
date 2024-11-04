using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class OS_ServicoModel
    {
        public int id_os_servico { get; set; }
        public int quantidadeServico { get; set; }
        public decimal precoServico { get; set; }
        public int idServico { get; set; }
        public decimal? descontoServ { get; set; }
        public int idOrdemServico { get; set; }
    }
}
