using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class PaisModel
    {
        public int idPais { get; set; }
        public string Pais { get; set; }
        public string DDI { get; set; }
        public string Sigla { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }

    }
}
