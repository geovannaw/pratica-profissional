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
    public partial class CadastroServicos : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private ServicoController<ServicoModel> servicoController;
        public CadastroServicos()
        {
            InitializeComponent();
            servicoController = new ServicoController<ServicoModel>();
        }

        public CadastroServicos(int idServico) : this()
        {
            idAlterar = idServico;
            Carrega();
        }

        public override void Carrega()
        {
            if (idAlterar != -1)
            {
                ServicoModel servico = servicoController.GetById(idAlterar);
                if (servico != null)
                {
                    txtCodigo.Text = servico.idServico.ToString();
                    txtServico.Text = servico.servico;
                    txtPreco.Text = servico.preco.ToString();
                    txtDataCadastro.Text = servico.dataCadastro.ToString();
                    txtDataUltAlt.Text = servico.dataUltAlt.ToString();
                    rbAtivo.Checked = servico.Ativo;
                    rbInativo.Checked = !servico.Ativo;
                }
                else
                {
                    MessageBox.Show("Serviço não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void Salvar()
        {
            if (!CampoObrigatorio(txtServico.Text))
            {
                MessageBox.Show("Campo Serviço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServico.Focus();
            } 
            else if (!CampoObrigatorio(txtPreco.Text))
            {
                MessageBox.Show("Campo Preço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPreco.Focus();
            }
            else
            {
                int idAtual = idAlterar != -1 ? idAlterar : -1;

                if (servicoController.JaCadastrado(txtServico.Text, idAtual))
                {
                    MessageBox.Show("Serviço já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtServico.Focus();
                }
                else
                {
                    try
                    {
                        string servico = txtServico.Text;
                        decimal preco = Convert.ToDecimal(txtPreco.Text);
                        DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                        ServicoModel novoServico = new ServicoModel
                        {
                            servico = servico,
                            preco = preco,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = isAtivo
                        };

                        if (idAlterar == -1)
                        {
                            servicoController.Salvar(novoServico);
                        }
                        else
                        {
                            novoServico.idServico = idAlterar;
                            servicoController.Alterar(novoServico);
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
            txtServico.Clear();
            txtPreco.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        private void CadastroServicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaServicos)this.Owner).AtualizarConsultaServicos(false);
        }

        private void txtServico_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtServico.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServico.Focus();
            }
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtPreco.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPreco.Focus();
            }
        }
    }
}
