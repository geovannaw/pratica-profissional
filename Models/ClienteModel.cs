using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class ClienteModel
    {
        public int idCliente { get; set; }
        public bool tipo_pessoa { get; set; }
        public string cliente_razao_social { get; set; }
        public string apelido_nome_fantasia { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string nome_contato { get; set; }
        public DateTime data_nasc { get; set; }
        public string cpf_cnpj { get; set; }
        public string rg_ie { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
        public int idCidade { get; set; }
        public int idCondPagamento { get; set; }
    }
}
