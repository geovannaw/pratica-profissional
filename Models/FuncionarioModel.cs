using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class FuncionarioModel
    {
        public int idFuncionario { get; set; }
        public string funcionario { get; set; }
        public string apelido { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public DateTime data_nasc { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string cargo { get; set; }
        public decimal salario { get; set; }
        public string pis { get; set; }
        public DateTime data_admissao { get; set; }
        public DateTime data_demissao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
        public int idCidade { get; set; }
    }
}
