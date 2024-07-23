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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public virtual void LimparCampos()
        {
            idAlterar = -1;
            txtCodigo.Clear();
            txtCliente_razao_social.Clear();
            txtApelido_nome_fantasia.Clear();
            txtSexo.SelectedIndex = -1;
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtContato.Clear();
            txtContato.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCodCidade.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtPais.Clear();
            txtCPF_CNPJ.Clear();
            txtIE_RG.Clear();
            txtDataNasc.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtCodCondPag.Clear();
            txtCondPag.Clear();
            rbFisica.Checked = true;
            rbAtivo.Checked = true;
            rbFisica.Enabled = true;
            rbJuridica.Enabled = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        protected bool VerificaCamposObrigatorios()
        {
            string cpf_cnpj = new string(txtCPF_CNPJ.Texts.Where(char.IsDigit).ToArray());
            string pais = txtPais.Texts;
            if (pais == "BRASIL")
            {
                if (!CampoObrigatorio(cpf_cnpj))
                {
                    MessageBox.Show("CPF / CNPJ obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF_CNPJ.Focus();
                    return false;
                }
            }
            if (!CampoObrigatorio(txtCliente_razao_social.Texts))
            {
                MessageBox.Show("Campo obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCliente_razao_social.Focus();
                return false;
            }
            if (rbFisica.Checked)
            {
                if (!CampoObrigatorio(txtSexo.Texts))
                {
                    MessageBox.Show("Campo Sexo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSexo.Focus();
                    return false;
                }
            }
            if (rbJuridica.Checked)
            {
                if (!CampoObrigatorio(txtContato.Texts))
                {
                    MessageBox.Show("Campo Nome Contato é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContato.Focus();
                    return false;
                }
            }
            string celular = new string(txtCelular.Texts.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(celular))
            {
                MessageBox.Show("Campo Celular é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtEmail.Texts))
            {
                MessageBox.Show("Campo Email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            string cep = new string(txtCEP.Texts.Where(char.IsDigit).ToArray());
            if (pais == "BRASIL")
            {
                if (!CampoObrigatorio(cep))
                {
                    MessageBox.Show("Campo CEP é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCEP.Focus();
                    return false;
                }
            }
            if (!CampoObrigatorio(txtEndereco.Texts))
            {
                MessageBox.Show("Campo Endereço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtNumero.Texts))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtBairro.Texts))
            {
                MessageBox.Show("Campo Bairro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodCidade.Texts))
            {
                MessageBox.Show("Campo Código Cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCidade.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodCondPag.Texts))
            {
                MessageBox.Show("Campo Código Condição de Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCondPag.Focus();
                return false;
            }

            return true;
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            isFisico = rbFisica.Checked;
            lblApelido_nome_fantasia.Text = "Apelido";
            lblCPF_CNPJ.Text = "CPF *";
            txtCPF_CNPJ.Mask = "000.000.000-00";
            lblIE_RG.Text = "RG";
            txtSexo.Visible = true;
            lblSexo.Visible = true;
            lblContato.Visible = false;
            txtContato.Visible = false;
            lblDataNasc.Text = "Data Nasc.";
            txtCPF_CNPJ.Clear();
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
            lblContato.Visible = true;
            txtContato.Visible = true;
            lblDataNasc.Text = "Data Fund.";
            txtCPF_CNPJ.Clear();
        }

        private void CadastroPessoasPai_Load(object sender, EventArgs e)
        {
            if (idAlterar == -1)
            {
                txtDataCadastro.Texts = DateTime.Now.ToString();
                txtDataUltAlt.Texts = DateTime.Now.ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {

        }

        private void txtCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            string cpf_cnpj = new string(txtCPF_CNPJ.Texts.Where(char.IsDigit).ToArray());
            //string pais = txtPais.Texts.ToLower();
            //if (pais == "brasil") 
            //{
            //    if (!CampoObrigatorio(cpf_cnpj))
            //    {
            //        MessageBox.Show("CPF / CNPJ obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtCPF_CNPJ.Focus();
            //    }               
            //}
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

        private void txtContato_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtContato.Texts))
            {
                MessageBox.Show("Nome do Contato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContato.Focus();
            }
        }

        private void txtIE_RG_Leave(object sender, EventArgs e)
        {
            string RG_IE = new string(txtIE_RG.Texts.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(txtIE_RG.Texts) && !rbFisica.Checked)
            {
                if (!ValidaIE(txtUF.Texts, RG_IE))
                {
                    MessageBox.Show("IE inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIE_RG.Focus();
                }

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidaEmail(txtEmail.Texts))
            {
                MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void txtCliente_razao_social_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtCliente_razao_social.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCliente_razao_social.Focus();
            }
        }

        private void txtCodCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodCondPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIE_RG_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
