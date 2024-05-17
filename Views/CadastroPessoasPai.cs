using Sistema_Vendas.Controller;
using Sistema_Vendas.Models;
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
        public CadastroPessoasPai()
        {
            InitializeComponent();
        }

        public virtual void Salvar() { }
        public virtual void Bloqueia() { }
        public virtual void Desbloqueia() { }
        public virtual void Carrega() { }
        public virtual void LimparCampos() { }

        protected bool VerificaCamposObrigatorios()
        {
            if (!CampoObrigatorio(txtCliente_razao_social.Text))
            {
                MessageBox.Show("Campo Cliente / Razão Social é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCliente_razao_social.Focus();
                return false;
            }
            if (rbFisica.Checked)
            {
                if (!CampoObrigatorio(txtSexo.Text))
                {
                    MessageBox.Show("Campo Sexo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSexo.Focus();
                    return false;
                }
            }
            string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(celular))
            {
                MessageBox.Show("Campo Celular é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtEmail.Text))
            {
                MessageBox.Show("Campo Email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(cep))
            {
                MessageBox.Show("Campo CEP é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCEP.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtEndereco.Text))
            {
                MessageBox.Show("Campo Endereço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtNumero.Text))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtBairro.Text))
            {
                MessageBox.Show("Campo Bairro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodCidade.Text))
            {
                MessageBox.Show("Campo Código Cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCidade.Focus();
                return false;
            }

            return true;
        }

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
            lblCliente_razao_social.Text = "Cliente *";
            lblApelido_nome_fantasia.Text = "Apelido";
            lblCPF_CNPJ.Text = "CPF *";
            txtCPF_CNPJ.Mask = "000.000.000-00";
            lblIE_RG.Text = "RG";
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
            lblCliente_razao_social.Text = "Razão Social *";
            lblApelido_nome_fantasia.Text = "Nome Fantasia";
            lblCPF_CNPJ.Text = "CNPJ *";
            txtCPF_CNPJ.Mask = "00.000.000/0000-00";
            lblIE_RG.Text = "Inscrição Estadual";
            txtSexo.Visible = false;
            lblSexo.Visible = false;
            lblDataNasc.Text = "Data Fund.";
        }

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            string cpf_cnpj = new string(txtCPF_CNPJ.Text.Where(char.IsDigit).ToArray());
            string pais = txtPais.Text.ToLower();
            if (pais == "brasil") 
            {
                if (!CampoObrigatorio(cpf_cnpj))
                {
                    MessageBox.Show("CPF obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCliente_razao_social_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtCliente_razao_social.Text))
            {
                MessageBox.Show("Cliente / Razão Social inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCliente_razao_social.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidaEmail(txtEmail.Text))
            {
                MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtEndereco.Text))
            {
                MessageBox.Show("Endereço inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtNumero.Text))
            {
                MessageBox.Show("Número inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
            }
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtBairro.Text))
            {
                MessageBox.Show("Bairro inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
            }
        }

        private void txtSexo_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtSexo.Text))
            {
                MessageBox.Show("Sexo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSexo.Focus();
            }
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtCelular.Text))
            {
                MessageBox.Show("Celular inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtTelefone.Text))
            {
                MessageBox.Show("Telefone inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone.Focus();
            }
        }

        private void txtApelido_nome_fantasia_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtApelido_nome_fantasia.Text))
            {
                MessageBox.Show("Apelido / Nome Fantasia inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApelido_nome_fantasia.Focus();
            }
        }

        private void txtIE_RG_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtIE_RG.Text))
            {
                MessageBox.Show("RG / IE inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIE_RG.Focus();
            }
        }
    }
}
