using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Vendas.Views
{
    public partial class ConsultaNotaCompra : Sistema_Vendas.ConsultaPai
    {
        private CadastroNotaCompra cadastroNotaCompra;
        public ConsultaNotaCompra()
        {
            InitializeComponent();
            cadastroNotaCompra = new CadastroNotaCompra();
            cadastroNotaCompra.Owner = this;
        }
        public override void Incluir()
        {
            ResetCadastro();
            cadastroNotaCompra.txtNroNota.Focus();
            cadastroNotaCompra.ShowDialog();
        }

        private void ResetCadastro()
        {
            cadastroNotaCompra.LimparCampos();
        }
        private void ResetCadastro(int id)
        {
            cadastroNotaCompra.SetID(id);
            cadastroNotaCompra.Carrega();
        }
        public void Visualizar()
        {
            if (dataGridViewNFCompra.SelectedRows.Count > 0)
            {
                int idNFCompra = (int)dataGridViewNFCompra.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idNFCompra);
                cadastroNotaCompra.txtNroNota.Focus();
                cadastroNotaCompra.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma nota para visualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Visualizar();
        }
    }
}
