﻿using MySqlX.XDevAPI;
using Sistema_Vendas.Controller;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Vendas.Views
{
    public partial class CadastroFornecedores : Sistema_Vendas.Views.CadastroPessoasPai
    {
        private FornecedorController<FornecedorModel> fornecedorController;
        private ConsultaCidades consultaCidades;
        private ConsultaCondicaoPagamento consultaCondicaoPagamento;
        private CondicaoPagamentoController<CondicaoPagamentoModel> condicaoPagamentoController;
        public CadastroFornecedores()
        {
            InitializeComponent();
            fornecedorController = new FornecedorController<FornecedorModel>();
            consultaCidades = new ConsultaCidades();
            consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            condicaoPagamentoController = new CondicaoPagamentoController<CondicaoPagamentoModel>();
            lblCliente_razao_social.Text = "Fornecedor *";
        }
        public override void Salvar()
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }
            int idAtual = idAlterar != -1 ? idAlterar : -1;
            string cpf_cnpj = new string(txtCPF_CNPJ.Text.Where(char.IsDigit).ToArray());

            if (fornecedorController.JaCadastrado(cpf_cnpj, idAtual))
            {
                MessageBox.Show("Fornecedor já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF_CNPJ.Focus();
            }
            else
            {
                try
                {
                    string cliente_razao_social = txtCliente_razao_social.Text;
                    string apelido_nome_fantasia = txtApelido_nome_fantasia.Text;
                    string endereco = txtEndereco.Text;
                    string bairro = txtBairro.Text;
                    int numero = Convert.ToInt32(txtNumero.Text);
                    string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());
                    string complemento = txtComplemento.Text;
                    string email = txtEmail.Text;
                    string telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
                    string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());
                    string nome_contato = txtContato.Text;
                    string rg_ie = new string(txtIE_RG.Text.Where(char.IsDigit).ToArray());
                    int idCidade = Convert.ToInt32(txtCodCidade.Text);
                    int idCondPagamento = Convert.ToInt32(txtCodCondPag.Text);

                    AtualizarCampoComDataPadrao(txtDataNasc, out DateTime data_nasc);
                    if (rbFisica.Checked)
                    {
                        if (!VerificarDataMenorOuIgualHoje(data_nasc, "nascimento"))
                        {
                            txtDataNasc.Focus();
                            return;
                        }
                    } else
                    {
                        if (!VerificarDataMenorOuIgualHoje(data_nasc, "fundação"))
                        {
                            txtDataNasc.Focus();
                            return;
                        }
                    }

                    DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                    string sexo;
                    if (isFisico)
                    {
                        sexo = txtSexo.SelectedItem.ToString();
                    }
                    else
                    {
                        sexo = "Outro"; //quando for jurídico não tem
                    }

                    FornecedorModel novoFornecedor = new FornecedorModel
                    {
                        tipo_pessoa = isFisico,
                        fornecedor_razao_social = cliente_razao_social,
                        apelido_nome_fantasia = apelido_nome_fantasia,
                        endereco = endereco,
                        bairro = bairro,
                        numero = numero,
                        cep = cep,
                        complemento = complemento,
                        sexo = sexo,
                        email = email,
                        telefone = telefone,
                        celular = celular,
                        nome_contato = nome_contato,
                        data_nasc = data_nasc,
                        cpf_cnpj = cpf_cnpj,
                        rg_ie = rg_ie,
                        Ativo = isAtivo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        idCidade = idCidade,
                        idCondPagamento = idCondPagamento
                    };

                    if (idAlterar == -1)
                    {
                        fornecedorController.Salvar(novoFornecedor);
                    }
                    else
                    {
                        novoFornecedor.idFornecedor = idAlterar;
                        fornecedorController.Alterar(novoFornecedor);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void Carrega()
        {
            rbFisica.Enabled = false;
            rbJuridica.Enabled = false;
            if (idAlterar != -1)
            {
                FornecedorModel fornecedor = fornecedorController.GetById(idAlterar);
                if (fornecedor != null)
                {
                    txtCodigo.Text = fornecedor.idFornecedor.ToString();
                    rbFisica.Checked = fornecedor.tipo_pessoa;
                    rbJuridica.Checked = !fornecedor.tipo_pessoa;
                    txtCliente_razao_social.Text = fornecedor.fornecedor_razao_social;
                    txtApelido_nome_fantasia.Text = fornecedor.apelido_nome_fantasia;
                    txtEndereco.Text = fornecedor.endereco;
                    txtBairro.Text = fornecedor.bairro;
                    txtNumero.Text = fornecedor.numero.ToString();
                    txtCEP.Text = fornecedor.cep;
                    txtComplemento.Text = fornecedor.complemento;
                    txtCodCidade.Text = fornecedor.idCidade.ToString();
                    txtSexo.Text = fornecedor.sexo;
                    txtEmail.Text = fornecedor.email;
                    txtTelefone.Text = fornecedor.telefone;
                    txtCelular.Text = fornecedor.celular;
                    txtContato.Text = fornecedor.nome_contato;
                    txtCPF_CNPJ.Text = fornecedor.cpf_cnpj;
                    txtIE_RG.Text = fornecedor.rg_ie;
                    txtDataCadastro.Text = fornecedor.dataCadastro.ToString();
                    txtDataUltAlt.Text = fornecedor.dataUltAlt.ToString();
                    rbAtivo.Checked = fornecedor.Ativo;
                    rbInativo.Checked = !fornecedor.Ativo;
                    txtCodCondPag.Text = fornecedor.idCondPagamento.ToString();

                    string condPagamento = fornecedorController.GetCondPagamentoByFornecedorId(fornecedor.idFornecedor);

                    if (!string.IsNullOrEmpty(condPagamento))
                    {
                        txtCondPag.Text = condPagamento;
                    }

                    AtualizarCampoData(fornecedor.data_nasc, txtDataNasc);

                    List<string> cidadeEstadoPais = fornecedorController.GetCEPByIdCidade(fornecedor.idCidade);

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtCidade.Text = info[0].Trim();
                            txtUF.Text = info[1].Trim();
                            txtPais.Text = info[2].Trim();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtIE_RG_Leave(object sender, EventArgs e)
        {

        }

        private void CadastroFornecedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaFornecedores)this.Owner).AtualizarConsultaFornecedores(false);
        }

        private void CadastroFornecedores_Load(object sender, EventArgs e)
        {
        }

        private void txtCliente_razao_social_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtCliente_razao_social.Text))
            {
                MessageBox.Show("Fornecedor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCliente_razao_social.Focus();
            }
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCliente_razao_social.Text = "Fornecedor *";
        }

        private void btnConsultaCidades_Click(object sender, EventArgs e)
        {
            consultaCidades.btnSair.Text = "Selecionar";

            if (consultaCidades.ShowDialog() == DialogResult.OK)
            {
                var cidadeDetalhes = consultaCidades.Tag as Tuple<int, string>;

                if (cidadeDetalhes != null)
                {
                    int cidadeID = cidadeDetalhes.Item1;
                    string cidadeNome = cidadeDetalhes.Item2;

                    txtCodCidade.Text = cidadeID.ToString();
                    txtCidade.Text = cidadeNome;

                    List<string> cidadeEstadoPais = fornecedorController.GetCEPByIdCidade(cidadeID);

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtUF.Text = info[1].Trim();
                            txtPais.Text = info[2].Trim();
                        }
                    }
                }
            }
        }

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCidade.Text))
            {
                if (!VerificaNumeros(txtCodCidade.Text))
                {
                    MessageBox.Show("Cód. Cidade inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCidade.Focus();
                }
                else
                {
                    List<string> cidadeEstadoPais = fornecedorController.GetCEPByIdCidade(int.Parse(txtCodCidade.Text));

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtCidade.Text = info[0].Trim();
                            txtUF.Text = info[1].Trim();
                            txtPais.Text = info[2].Trim();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Código Cidade não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodCidade.Focus();
                        txtCodCidade.Clear();
                        txtCidade.Clear();
                        txtUF.Clear();
                        txtPais.Clear();
                    }
                }
            }
        }

        private void txtCodCondPag_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtCodCondPag.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCondPag.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCodCondPag.Text))
                {
                    CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Text));
                    if (condPagamento != null)
                    {
                        txtCondPag.Text = condPagamento.condicaoPagamento;
                    }
                    else
                    {
                        MessageBox.Show("Condição de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodCondPag.Focus();
                        txtCodCondPag.Clear();
                        txtCondPag.Clear();
                    }
                }
            }
        }

        private void btnConsultaCondPag_Click(object sender, EventArgs e)
        {
            consultaCondicaoPagamento.btnSair.Text = "Selecionar";
            if (consultaCondicaoPagamento.ShowDialog() == DialogResult.OK)
            {
                var condPagamento = consultaCondicaoPagamento.Tag as Tuple<int, string>;
                if (condPagamento != null)
                {
                    int idCondPag = condPagamento.Item1;
                    string condicaoPagamento = condPagamento.Item2;

                    txtCodCondPag.Text = idCondPag.ToString();
                    txtCondPag.Text = condicaoPagamento;
                }
            }
        }
    }
}
