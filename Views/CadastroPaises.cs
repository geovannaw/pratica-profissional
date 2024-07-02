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
            //verifica se há um país a ser alterado
            if (idAlterar != -1)
            {
                PaisModel pais = paisController.GetById(idAlterar);
                if (pais != null)
                {
                    //carrega os dados do país nos controles do formulário
                    txtCodigo.Text = pais.idPais.ToString();
                    txtPais.Text = pais.Pais;
                    txtSigla.Text = pais.Sigla;
                    txtDDI.Text = pais.DDI;
                    txtDataCadastro.Text = pais.dataCadastro.ToString();
                    txtDataUltAlt.Text = pais.dataUltAlt.ToString();
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
            if (!CampoObrigatorio(txtPais.Text))
            {
                MessageBox.Show("Campo País é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPais.Focus();
            }
            else if (!CampoObrigatorio(txtSigla.Text))
            {
                MessageBox.Show("Campo Sigla é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSigla.Focus();
            }
            else if (!CampoObrigatorio(txtDDI.Text))
            {
                MessageBox.Show("Campo DDI é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDI.Focus();
            }
            else
            {
                int idAtual = idAlterar != -1 ? idAlterar : -1;

                if (paisController.JaCadastrado(txtPais.Text, idAtual))
                {
                    MessageBox.Show("País já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPais.Focus();
                }
                else
                {
                    try
                    {
                        string pais = txtPais.Text;
                        string sigla = txtSigla.Text;
                        string ddi = txtDDI.Text;

                        DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                        PaisModel novoPais = new PaisModel
                        {
                            Pais = pais,
                            Sigla = sigla,
                            DDI = ddi,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
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
            idAlterar = -1;
            txtCodigo.Clear();
            txtPais.Clear();
            txtSigla.Clear();
            txtDDI.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
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

        }

        private void txtPais_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtPais.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPais.Focus();
            } 
        }

        private void txtSigla_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetrasSemEspaco(txtSigla.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSigla.Focus();
            }
        }

        private void txtDDI_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtDDI.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDI.Focus();
            }
        }
    }
}
