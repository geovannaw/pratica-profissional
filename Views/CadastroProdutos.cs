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
    public partial class CadastroProdutos : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private ProdutoController<ProdutoModel> produtoController;
        private ConsultaFornecedores consultaFornecedores;
        private ConsultaModelos consultaModelos;
        public CadastroProdutos()
        {
            InitializeComponent();
            produtoController = new ProdutoController<ProdutoModel>();
            consultaFornecedores = new ConsultaFornecedores();
            consultaModelos = new ConsultaModelos();
        }
        public CadastroProdutos(int idProduto) : this()
        {
            idAlterar = idProduto;
            Carrega();
        }

        public override void Salvar()
        {
            try
            {
                string descricao = txtDescricao.Text;
                string unidade = txtUN.Text;
                int saldo = int.Parse(txtSaldo.Text);
                decimal custo_medio = Convert.ToDecimal(txtCustoMedio.Text);
                decimal preco_venda = Convert.ToDecimal(txtPrecoVenda.Text);
                decimal preco_ult_compra = Convert.ToDecimal(txtPrecoUltCompra.Text);
                string observacao = txtObservacao.Text;
                int idFornecedor = int.Parse(txtCodFornecedor.Text);
                int idModelo = int.Parse(txtCodModelo.Text);

                DateTime data_ult_compra;
                DateTime.TryParse(txtDataUltCompra.Text, out data_ult_compra);

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

                ProdutoModel novoProduto = new ProdutoModel
                {
                    Descricao = descricao,
                    Unidade = unidade,
                    Saldo = saldo,
                    Custo_medio = custo_medio,
                    Preco_venda = preco_venda,
                    Preco_ult_compra = preco_ult_compra,
                    Data_ult_compra = data_ult_compra,
                    Observacao = observacao,
                    Ativo = isAtivo,
                    dataCadastro = dataCadastro,
                    dataUltAlt = dataUltAlt,
                    idFornecedor = idFornecedor,
                    idModelo = idModelo,
                };

                if (idAlterar == -1)
                {
                    produtoController.Salvar(novoProduto);
                }
                else
                {
                    novoProduto.IdProduto = idAlterar;
                    produtoController.Alterar(novoProduto);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Carrega()
        {
            if (idAlterar != -1)
            {
                ProdutoModel produto = produtoController.GetById(idAlterar);
                if (produto != null)
                {
                    txtCodigo.Text = produto.IdProduto.ToString();
                    txtDescricao.Text = produto.Descricao;
                    txtSaldo.Text = produto.Saldo.ToString();
                    txtUN.Text = produto.Unidade.ToString();
                    txtCustoMedio.Text = produto.Custo_medio.ToString();
                    txtPrecoVenda.Text = produto.Preco_venda.ToString();
                    txtPrecoUltCompra.Text = produto.Preco_ult_compra.ToString();
                    txtDataUltCompra.Text = produto.Data_ult_compra.ToString();
                    txtObservacao.Text = produto.Observacao;
                    txtDataCadastro.Text = produto.dataCadastro.ToString();
                    txtDataUltAlt.Text = produto.dataUltAlt.ToString();
                    rbAtivo.Checked = produto.Ativo;
                    rbInativo.Checked = !produto.Ativo;
                    txtFornecedor.Text = produto.idFornecedor.ToString();
                    txtModelo.Text = produto.idModelo.ToString();

                }
                else
                {
                    MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CadastroProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaProdutos)this.Owner).AtualizarConsultaProdutos(false);
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Text = "0";
            }
            if (idAlterar == -1)
            {
                txtDataCadastro.Text = DateTime.Now.ToString();
                txtDataUltAlt.Text = DateTime.Now.ToString();
            }
        }
    }
}
