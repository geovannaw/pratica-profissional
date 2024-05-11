using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas.Views
{
    public partial class CadastroPessoasPai : Form
    {
        public bool isAtivo = true;
        public bool isFisico = true;
        public int idAlterar = -1;
        Label novaLabel;
        public CadastroPessoasPai()
        {
            InitializeComponent();

            novaLabel = new Label();
        }

        public virtual void Salvar() { }
        public virtual void Bloqueia() { }
        public virtual void Desbloqueia() { }
        public virtual void Carrega() { }
        public virtual void LimparCampos() { }

        private void CadastroPessoasPai_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            isFisico = rbFisica.Checked;
            lblCliente_razao_social.Text = "Cliente";
            lblApelido_nome_fantasia.Text = "Apelido";
            lblCPF_CNPJ.Text = "CPF";
            txtCPF_CNPJ.Mask = "000.000.000-00";
            lblIE_RG.Text = "RG";
            txtIE_RG.Mask = "00.000.000-0";
            txtSexo.Visible = true;
            lblSexo.Visible = true;
            lblDataNasc.Text = "Data Nasc.";
        }

        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            isAtivo = rbAtivo.Checked;
        }

        private void rbInativo_CheckedChanged(object sender, EventArgs e)
        {
            isAtivo = !rbInativo.Checked;
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            isFisico = !rbJuridica.Checked;
            lblCliente_razao_social.Text = "Razão Social";
            lblApelido_nome_fantasia.Text = "Nome Fantasia";
            lblCPF_CNPJ.Text = "CNPJ";
            txtCPF_CNPJ.Mask = "00.000.000/0000-00";
            lblIE_RG.Text = "Inscrição Estadual";
            txtIE_RG.Mask = "00.000.0000-0";
            txtSexo.Visible = false;
            lblSexo.Visible = false;
            lblDataNasc.Text = "Data Fund.";
        }

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            Label novaLabel = new Label();
            novaLabel.Text = " *Obrigatório*";
            novaLabel.ForeColor = Color.Red;
            novaLabel.Font = new Font("Microsoft Sans Serif", 5.0f);
            this.Controls.Add(novaLabel);


            string cpf_cnpj = new string(txtCPF_CNPJ.Text.Where(char.IsDigit).ToArray());
            string pais = txtPais.Text.ToLower();
            if (pais == "brasil")
            {
                if (!CampoObrigatorio(cpf_cnpj))
                {
                    //  lblCPF_CNPJ.ForeColor = Color.Red;
                    lblCPF_CNPJ.Text = lblCPF_CNPJ.Text + novaLabel.Text;
                }
            }
            if (!rbFisica.Checked)
            {
                if (!ValidaCNPJ(cpf_cnpj))
                {
                    MessageBox.Show("CNPJ inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF_CNPJ.Focus();
                }
            }
            else
            {
                if (!ValidaCPF(cpf_cnpj))
                {
                    MessageBox.Show("CPF inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF_CNPJ.Focus();
                }
            }
        }
    }
}
