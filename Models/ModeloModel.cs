﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.Models
{
    public class ModeloModel
    {
        public int idModelo { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Observacao { get; set; }
        public string usuario { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataUltAlt { get; set; }
        public bool Ativo { get; set; }
    }
}
