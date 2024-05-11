using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class DadosEmpresaModel
    {
        public int idDadosEmpresa { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string cnpj { get; set; }
        public string ie { get; set; }
        public string nome_responsavel { get; set; }
        public int idCidade { get; set; }
    }
}
