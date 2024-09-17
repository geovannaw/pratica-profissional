using Sistema_Vendas.Controller;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sistema_Vendas.Views
{
    public partial class CadastroPaises : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private PaisController<PaisModel> paisController;
        public CadastroPaises() //contructor para inserir pais
        {
            InitializeComponent();
            paisController = new PaisController<PaisModel>();
        }
        public override void Carrega()
        {
            base.Carrega();
            //verifica se há um país a ser alterado
            if (idAlterar != -1)
            {
                PaisModel pais = paisController.GetById(idAlterar);
                if (pais != null)
                {
                    //carrega os dados do país nos controles do formulário
                    txtCodigo.Texts = pais.idPais.ToString();
                    txtPais.Texts = pais.Pais;
                    txtSigla.Texts = pais.Sigla;
                    txtDDI.Texts = pais.DDI;
                    txtUsuarioUltAlt.Texts = pais.usuario;
                    txtDataCadastro.Texts = pais.dataCadastro.ToString();
                    txtDataUltAlt.Texts = pais.dataUltAlt.ToString();
                    rbAtivo.Checked = pais.Ativo;
                    rbInativo.Checked = !pais.Ativo;
                }
                else
                {
                    MessageBox.Show("País não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!CampoObrigatorio(txtPais.Texts))
            {
                MessageBox.Show("Campo País é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPais.Focus();
            }
            else if (!CampoObrigatorio(txtSigla.Texts))
            {
                MessageBox.Show("Campo Sigla é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSigla.Focus();
            }
            else if (!CampoObrigatorio(txtDDI.Texts))
            {
                MessageBox.Show("Campo DDI é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDI.Focus();
            }
            else
            {
                int idAtual = idAlterar != -1 ? idAlterar : -1;

                if (paisController.JaCadastrado(txtPais.Texts, idAtual))
                {
                    MessageBox.Show("País já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPais.Focus();
                }
                else
                {
                    try
                    {
                        string pais = txtPais.Texts;
                        string sigla = txtSigla.Texts;
                        string ddi = txtDDI.Texts;
                        string usuario = Program.usuarioLogado;

                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                        PaisModel novoPais = new PaisModel
                        {
                            Pais = pais,
                            Sigla = sigla,
                            DDI = ddi,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            usuario = usuario,
                            Ativo = isAtivo
                        };

                        if (idAlterar == -1)
                        {
                            paisController.Salvar(novoPais);
                        }
                        else
                        {
                            novoPais.idPais = idAlterar; // ID do país alterado
                            paisController.Alterar(novoPais);
                        }

                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public override void LimparCampos()
        {
            base.LimparCampos();
            idAlterar = -1;
            txtCodigo.Clear();
            txtPais.Clear();
            txtSigla.Clear();
            txtDDI.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtUsuarioUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        private void CadastroPaises_FormClosed(object sender, FormClosedEventArgs e)
        {
               //atualiza a consulta de países ao fechar o formulário de cadastro
               ((ConsultaPaises)this.Owner).AtualizarConsultaPaises(false);
        }

        private void CadastroPaises_Load(object sender, EventArgs e)
        {
            if (idAlterar == -1)
            {
                int novoCodigo = paisController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
            
        }

        private void txtSigla_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetrasSemEspaco(txtSigla.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSigla.Focus();
            }
        }

        private void txtDDI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPais_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtPais.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPais.Focus();
            }
        }
    }
}
