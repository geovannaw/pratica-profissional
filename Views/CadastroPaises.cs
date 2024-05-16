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

        //construtor para alterar um país
        public CadastroPaises(int idPais) : this()
        {
            idAlterar = idPais;
            Carrega();
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
                try
                {
                    string pais = txtPais.Text;
                    string sigla = txtSigla.Text;
                    string ddi = txtDDI.Text;
                    DateTime dataCadastro;
                    DateTime dataUltAlt;

                    DateTime.TryParse(txtDataCadastro.Text, out dataCadastro);

                    if (idAlterar != -1)
                    {
                        DateTime.TryParse(DateTime.Now.ToString(), out dataUltAlt);
                    }
                    else
                    {
                        DateTime.TryParse(txtDataUltAlt.Text, out dataUltAlt);
                    }

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
                        novoPais.idPais = idAlterar; //ID do país alterado
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

        public override void Bloqueia() { }
        public override void Desbloqueia() { }
        public override void LimparCampos() { }

        private void CadastroPaises_FormClosed(object sender, FormClosedEventArgs e)
        {
               //atualiza a consulta de países ao fechar o formulário de cadastro
               ((ConsultaPaises)this.Owner).AtualizarConsultaPaises(false);
        }

        private void CadastroPaises_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Text = "0";
            }
            if (idAlterar == -1)
            {
                txtDataCadastro.Text = DateTime.Now.ToString();
                txtDataUltAlt.Text = DateTime.Now.ToString();
            }
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
