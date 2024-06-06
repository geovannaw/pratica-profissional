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
        private ModeloController<ModeloModel> modeloController;
        private FornecedorController<FornecedorModel> fornecedorController;
        public CadastroProdutos()
        {
            InitializeComponent();
            produtoController = new ProdutoController<ProdutoModel>();
            consultaFornecedores = new ConsultaFornecedores();
            consultaModelos = new ConsultaModelos();
            modeloController = new ModeloController<ModeloModel>();
            fornecedorController = new FornecedorController<FornecedorModel>();
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
                    novoProduto.idProduto = idAlterar;
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
                    txtCodigo.Text = produto.idProduto.ToString();
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
                    txtCodFornecedor.Text = produto.idFornecedor.ToString();
                    txtCodModelo.Text = produto.idModelo.ToString();

                    ModeloModel modelo = modeloController.GetById(int.Parse(txtCodModelo.Text));
                    if (modelo != null)
                    {
                        txtModelo.Text = modelo.Modelo;
                    }

                    FornecedorModel fornecedor = fornecedorController.GetById(int.Parse(txtCodFornecedor.Text));
                    if (fornecedor != null)
                    {
                        txtFornecedor.Text = fornecedor.fornecedor_razao_social;
                    }
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

        private void btnConsultaModelos_Click(object sender, EventArgs e)
        {
            consultaModelos.btnSair.Text = "Selecionar";

            if (consultaModelos.ShowDialog() == DialogResult.OK)
            {
                var modelosDetalhes = consultaModelos.Tag as Tuple<int, string>;

                if (modelosDetalhes != null)
                {
                    int modeloID = modelosDetalhes.Item1;
                    string modeloNome = modelosDetalhes.Item2;

                    txtCodModelo.Text = modeloID.ToString();
                    txtModelo.Text = modeloNome;
                }
            }
        }

        private void btnConsultaFornecedor_Click(object sender, EventArgs e)
        {
            consultaFornecedores.btnSair.Text = "Selecionar";

            if (consultaFornecedores.ShowDialog() == DialogResult.OK)
            {
                var fornecedoresDetalhes = consultaFornecedores.Tag as Tuple<int, string>;

                if (fornecedoresDetalhes != null)
                {
                    int fornecedorID = fornecedoresDetalhes.Item1;
                    string fornecedorNome = fornecedoresDetalhes.Item2;

                    txtCodFornecedor.Text = fornecedorID.ToString();
                    txtFornecedor.Text = fornecedorNome;
                }
            }

        }

        private void txtCodModelo_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtCodModelo.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodModelo.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCodModelo.Text))
                {
                    ModeloModel modelo = modeloController.GetById(int.Parse(txtCodModelo.Text));
                    if (modelo != null)
                    {
                        txtModelo.Text = modelo.Modelo;
                    }
                    else
                    {
                        MessageBox.Show("Modelo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtCodFornecedor.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFornecedor.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCodFornecedor.Text))
                {
                    FornecedorModel fornecedor = fornecedorController.GetById(int.Parse(txtCodFornecedor.Text));
                    if (fornecedor != null)
                    {
                        txtFornecedor.Text = fornecedor.fornecedor_razao_social;
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtUN_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtUN.Text))
            {
                MessageBox.Show("UN inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUN.Focus();
            }
        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtSaldo.Text))
            {
                MessageBox.Show("Saldo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaldo.Focus();
            }
        }

        private void txtCustoMedio_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtCustoMedio.Text))
            {
                MessageBox.Show("Custo Médio inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustoMedio.Focus();
            }
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtPrecoVenda.Text))
            {
                MessageBox.Show("Preço Venda inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoVenda.Focus();
            }
        }

        private void txtPrecoUltCompra_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtPrecoUltCompra.Text))
            {
                MessageBox.Show("Preço Última Compra inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoUltCompra.Focus();
            }
        }
    }
}
