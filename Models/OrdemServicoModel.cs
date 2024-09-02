using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class OrdemServicoModel
    {
        public int idOrdemServico { get; set; }
        public DateTime data { get; set; }
        public decimal precoTotal { get; set; }
        public string status { get; set; }
        public string observacao { get; set; }
        public DateTime? dataEntrega { get; set; }
        public DateTime dataPrevista { get; set; }
        public DateTime? dataCancelamento { get; set; }
        public decimal? valorRetirada { get; set; }
        public decimal valorEntrada { get; set; }
        public decimal porcentagemDesconto { get; set; }
        public int idFuncionario { get; set; }
        public int idCliente { get; set; }
        public int idCondPagamento { get; set; }
        public List<OS_ProdutoModel> Produtos { get; set; }
        public List<OS_ServicoModel> Servicos { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }

}
