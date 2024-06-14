using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas
{
    public partial class ConsultaPai : Form
    {
        public ConsultaPai()
        {
            InitializeComponent();
        }

        public virtual void Incluir() { }
        public virtual void Alterar() { }
        public virtual void Excluir() { }
        public virtual void Pesquisar () { }

        protected virtual void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        protected virtual void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        protected virtual void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        protected virtual void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }
    }
}
