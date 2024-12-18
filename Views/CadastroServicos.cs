﻿using Sistema_Vendas.Controller;
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
        public override void Carrega()
        {
            base.Carrega();
            txtPreco.ForeColor = Color.FromArgb(31, 31, 31);
            if (idAlterar != -1)
            {
                ServicoModel servico = servicoController.GetById(idAlterar);
                if (servico != null)
                {
                    txtCodigo.Texts = servico.idServico.ToString();
                    txtServico.Texts = servico.servico;
                    txtUsuarioUltAlt.Texts = servico.usuario;
                    txtPreco.Texts = servico.preco.ToString("N2");
                    txtDataCadastro.Texts = servico.dataCadastro.ToString();
                    txtDataUltAlt.Texts = servico.dataUltAlt.ToString();
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
            if (!CampoObrigatorio(txtServico.Texts))
            {
                MessageBox.Show("Campo Serviço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServico.Focus();
            } 
            else if (!CampoObrigatorio(txtPreco.Texts))
            {
                MessageBox.Show("Campo Preço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPreco.Focus();
            }
            else
            {
                int idAtual = idAlterar != -1 ? idAlterar : -1;

                if (servicoController.JaCadastrado(txtServico.Texts, idAtual))
                {
                    MessageBox.Show("Serviço já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtServico.Focus();
                }
                else
                {
                    try
                    {
                        string servico = txtServico.Texts;
                        decimal preco = decimal.Parse(FormataPreco(txtPreco.Texts));
                        string usuario = Program.usuarioLogado;
                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                        ServicoModel novoServico = new ServicoModel
                        {
                            servico = servico,
                            preco = preco,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            usuario = usuario,
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
            base.LimparCampos();
            idAlterar = -1;
            txtCodigo.Clear();
            txtServico.Clear();
            txtPreco.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtUsuarioUltAlt.Clear();
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

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPreco.Texts))
            {
                try
                {
                    txtPreco.Texts = FormataPreco(txtPreco.Texts);

                    //verifica se o valor é maior que zero
                    if (decimal.TryParse(txtPreco.Texts, out decimal preco) && preco > 0)
                    {
                        //valor é válido e maior que zero
                    }
                    else
                    {
                        MessageBox.Show("O preço deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPreco.Focus();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPreco.Focus();
                }
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números, pontos, vírgulas e teclas de controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void CadastroServicos_Load(object sender, EventArgs e)
        {
            if(idAlterar == -1)
            {
                int novoCodigo = servicoController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void txtPreco__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPreco.Texts, "^[0-9.,]*$"))
            {
                txtPreco.Texts = System.Text.RegularExpressions.Regex.Replace(txtPreco.Texts, "[^0-9.,]", "");
            }
        }
    }
}
