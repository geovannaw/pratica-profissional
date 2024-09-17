using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class UsuarioModel
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string permissao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public string usuarioUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
