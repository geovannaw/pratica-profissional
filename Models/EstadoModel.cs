using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class EstadoModel
    {
        public int idEstado { get; set; }
        public string Estado { get; set; }
        public string UF { get; set; }
        public int idPais { get; set; }
        public string usuario { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }

    }
}
