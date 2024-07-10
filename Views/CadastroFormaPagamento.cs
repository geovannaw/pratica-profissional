using Sistema_Vendas.Controller;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Vendas.Views
{
    public partial class CadastroFormaPagamento : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private FormaPagamentoController<FormaPagamentoModel> formaPagamentoController;
        public CadastroFormaPagamento()
        {
            InitializeComponent();
            formaPagamentoController = new FormaPagamentoController<FormaPagamentoModel>();
        }
        public override void Carrega()
        {
            if (idAlterar != -1)
            {
                FormaPagamentoModel formaPag = formaPagamentoController.GetById(idAlterar);
                if (formaPag != null)
                {
                    txtCodigo.Texts = formaPag.idFormaPagamento.ToString();
                    txtFormaPagamento.Texts = formaPag.formaPagamento;
                    txtDataCadastro.Texts = formaPag.dataCadastro.ToString();
                    txtDataUltAlt.Texts = formaPag.dataUltAlt.ToString();
                    rbAtivo.Checked = formaPag.Ativo;
                    rbInativo.Checked = !formaPag.Ativo;
                }
                else
                {
                    MessageBox.Show("Forma de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void Salvar()
        {
            if (!CampoObrigatorio(txtFormaPagamento.Texts))
            {
                MessageBox.Show("Campo Forma de Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFormaPagamento.Focus();
            }
            else
            {
                int idAtual = idAlterar != -1 ? idAlterar : -1;

                if (formaPagamentoController.JaCadastrado(txtFormaPagamento.Texts, idAtual))
                {
                    MessageBox.Show("Forma de Pagamento já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFormaPagamento.Focus();
                }
                else
                {
                    try
                    {
                        string formaPagamento = txtFormaPagamento.Texts;
                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                        FormaPagamentoModel novaFormaPag = new FormaPagamentoModel
                        {
                            formaPagamento = formaPagamento,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = isAtivo
                        };

                        if (idAlterar == -1)
                        {
                            formaPagamentoController.Salvar(novaFormaPag);
                        }
                        else
                        {
                            novaFormaPag.idFormaPagamento = idAlterar;
                            formaPagamentoController.Alterar(novaFormaPag);
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
            txtFormaPagamento.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        private void CadastroFormaPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaFormasPagamento)this.Owner).AtualizarConsultaFormasPag(false);
        }

        private void txtFormaPagamento_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtFormaPagamento.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFormaPagamento.Focus();
            }
        }
    }
}
