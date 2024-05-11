using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas.Views
{
    public partial class CadastroPaiCEP : Form
    {
        public bool isAtivo = true;
        public int idAlterar = -1;
        public CadastroPaiCEP()
        {
            InitializeComponent();
        }

        public virtual void Salvar() { }
        public virtual void Bloqueia() { }
        public virtual void Desbloqueia() { }
        public virtual void Carrega() { }
        public virtual void LimparCampos() { }

        protected virtual void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        protected virtual void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            isAtivo = rbAtivo.Checked;
        }

        private void rbInativo_CheckedChanged(object sender, EventArgs e)
        {
            isAtivo = !rbInativo.Checked;
        }
    }
}
