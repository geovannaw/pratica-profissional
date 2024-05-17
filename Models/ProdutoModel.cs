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
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public int Saldo { get; set; }
        public decimal Custo_medio { get; set; }
        public decimal Preco_venda { get; set; }
        public decimal Preco_ult_compra { get; set; }
        public DateTime Data_ult_compra { get; set; }
        public string Observacao { get; set; }
        public int idFornecedor { get; set; }
        public int idModelo { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
