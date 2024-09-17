using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class CidadeModel
    {
        public int idCidade { get; set; }
        public string Cidade { get; set; }
        public int DDD { get; set; }
        public int idEstado { get; set; }
        public string usuario { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }

    }
}
