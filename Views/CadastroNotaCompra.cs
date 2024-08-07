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
    public partial class CadastroNotaCompra : Sistema_Vendas.Views.CadastroPaiCEP
    {
        ConsultaFornecedores consultaFornecedores;
        FornecedorController<FornecedorModel> fornecedorController;
        ConsultaCondicaoPagamento consultaCondicaoPagamento;
        CondicaoPagamentoController<CondicaoPagamentoModel> condicaoPagamentoController;
        ConsultaProdutos consultaProdutos;
        ProdutoController<ProdutoModel> produtoController;

        decimal precoUNProduto;
        public CadastroNotaCompra()
        {
            InitializeComponent();
            consultaFornecedores = new ConsultaFornecedores();
            fornecedorController = new FornecedorController<FornecedorModel>();
            consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            condicaoPagamentoController = new CondicaoPagamentoController<CondicaoPagamentoModel>();
            consultaProdutos = new ConsultaProdutos();
            produtoController = new ProdutoController<ProdutoModel>();
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

                    txtCodFornecedor.Texts = fornecedorID.ToString();
                    txtFornecedor.Texts = fornecedorNome;
                }
            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFornecedor.Texts))
            {
                FornecedorModel fornecedor = fornecedorController.GetById(int.Parse(txtCodFornecedor.Texts));
                if (fornecedor != null)
                {
                    txtFornecedor.Texts = fornecedor.fornecedor_razao_social;
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodFornecedor.Focus();
                    txtCodFornecedor.Clear();
                    txtFornecedor.Clear();
                }
            }
            VerificaCamposPreenchidos();
        }

        private void btnConsultaProduto_Click(object sender, EventArgs e)
        {
            consultaProdutos.btnSair.Text = "Selecionar";

            if (consultaProdutos.ShowDialog() == DialogResult.OK)
            {
                var infosProd = consultaProdutos.Tag as Tuple<int, string, decimal, string>;
                if (infosProd != null)
                {
                    int idProd = infosProd.Item1;
                    string produto = infosProd.Item2;
                    precoUNProduto = infosProd.Item3;
                    string unidade = infosProd.Item4;

                    txtCodProduto.Texts = idProd.ToString();
                    txtProduto.Texts = produto;
                    txtUN.Texts = unidade;
                }
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodProduto.Texts))
            {
                ProdutoModel produto = produtoController.GetById(int.Parse(txtCodProduto.Texts));
                if (produto != null)
                {
                    txtProduto.Texts = produto.Produto;
                    precoUNProduto = produto.Preco_venda;
                    txtUN.Texts = produto.Unidade;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodProduto.Focus();
                    txtCodProduto.Clear();
                    txtProduto.Clear();
                    txtUN.Clear();

                }
            }
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodCondPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

                    txtCodCondPag.Texts = idCondPag.ToString();
                    txtCondPag.Texts = condicaoPagamento;
                }
            }
        }

        private void txtCodCondPag_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCondPag.Texts))
            {
                CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
                if (condPagamento != null)
                {
                    txtCondPag.Texts = condPagamento.condicaoPagamento;
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

        private void CadastroNotaCompra_Load(object sender, EventArgs e)
        {
            if (idAlterar != -1)
            {
                btnCancelar.Visible = true;
                btnSalvar.Visible = false;
            }
        }
        public void SetID(int id)
        {
            idAlterar = id;
        }
        private void VerificaCamposPreenchidos()
        {
            string dataEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            string dataChegada = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            bool camposPreenchidos = !string.IsNullOrEmpty(txtNroNota.Texts) &&
                                     !string.IsNullOrEmpty(txtModelo.Texts) &&
                                     !string.IsNullOrEmpty(txtSerie.Texts) &&
                                     !string.IsNullOrEmpty(dataEmissao) &&
                                     !string.IsNullOrEmpty(dataChegada) &&
                                     !string.IsNullOrEmpty(txtCodFornecedor.Texts);

            txtCodProduto.Enabled = camposPreenchidos;
            txtQtdeProduto.Enabled = camposPreenchidos;
            txtPrecoProd.Enabled = camposPreenchidos;
            groupBox2.Enabled = camposPreenchidos;
            rbCIF.Enabled = camposPreenchidos;
            rbFOB.Enabled = camposPreenchidos;
            txtValorFrete.Enabled = camposPreenchidos;
            txtValorSeguro.Enabled = camposPreenchidos;
            txtOutrasDespesas.Enabled = camposPreenchidos;
            txtNroNota.Enabled = !camposPreenchidos;
            txtModelo.Enabled = !camposPreenchidos;
            txtSerie.Enabled = !camposPreenchidos;
            txtDataEmissao.Enabled = !camposPreenchidos;
            txtDataChegada.Enabled = !camposPreenchidos;
            txtCodFornecedor.Enabled = !camposPreenchidos;
        }
        private void VerificaCamposPreenchidosFrete()
        {
            bool camposPreenchidos = !string.IsNullOrEmpty(txtValorFrete.Texts) ||
                                     !string.IsNullOrEmpty(txtValorSeguro.Texts) ||
                                     !string.IsNullOrEmpty(txtOutrasDespesas.Texts);

            txtCodProduto.Enabled = !camposPreenchidos;
            txtQtdeProduto.Enabled = !camposPreenchidos;
            txtPrecoProd.Enabled = !camposPreenchidos;
            
        }


        private void txtNroNota_Leave(object sender, EventArgs e)
        {
            VerificaCamposPreenchidos();
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            VerificaCamposPreenchidos();
        }

        private void txtSerie_Leave(object sender, EventArgs e)
        {
            VerificaCamposPreenchidos();
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            VerificaCamposPreenchidos();
        }

        private void txtDataChegada_Leave(object sender, EventArgs e)
        {
            VerificaCamposPreenchidos();
        }

        private void limpaCamposProdutos()
        {
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtUN.Clear();
            txtQtdeProduto.Clear();
            txtPrecoProd.Clear();
        }

        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio(txtCodProduto.Texts))
            {
                MessageBox.Show("Campo Código Produto é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodProduto.Focus();
            }
            else if (!CampoObrigatorio(txtQtdeProduto.Texts))
            {
                MessageBox.Show("Campo Quantidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtdeProduto.Focus();
            }
            else if (!CampoObrigatorio(txtPrecoProd.Texts))
            {
                MessageBox.Show("Campo Preço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoProd.Focus();
            }
            else
            {
                try
                {
                    int idProduto = Convert.ToInt32(txtCodProduto.Texts);
                    string produto = txtProduto.Texts;
                    int qtdeProduto = Convert.ToInt32(txtQtdeProduto.Texts);
                    string unidade = txtUN.Texts;
                    decimal precoUN = Convert.ToDecimal(txtPrecoProd.Texts);
                    decimal precoTotal = Convert.ToDecimal(txtPrecoProd.Texts) * Convert.ToInt32(txtQtdeProduto.Texts);

                    dataGridViewProdutos.Rows.Add(idProduto, produto, qtdeProduto, unidade, precoUN, precoTotal); //add nova linha com os valores 

                  //  atualizaPorcentagemTotal();
                    dataGridViewProdutos.Sort(dataGridViewProdutos.Columns["idProduto"], ListSortDirection.Ascending);
                    limpaCamposProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
                }
            }
        }

        private void txtValorFrete_Leave(object sender, EventArgs e)
        {
            VerificaCamposPreenchidosFrete();
        }

        private void txtValorSeguro_Leave(object sender, EventArgs e)
        {
            VerificaCamposPreenchidosFrete();
        }

        private void txtOutrasDespesas_Leave(object sender, EventArgs e)
        {
            VerificaCamposPreenchidosFrete();
        }
    }
}
