using MySqlX.XDevAPI;
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

        public override void Salvar()
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }
            int idAtual = idAlterar != -1 ? idAlterar : -1;
            if (produtoController.JaCadastrado(txtProduto.Texts, Convert.ToInt32(txtCodFornecedor.Texts), idAtual))
            {
                MessageBox.Show("Produto já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string produto = txtProduto.Texts;
                    string unidade = txtUN.Texts;
                    string usuario = Program.usuarioLogado;
                    int saldo = int.Parse(txtSaldo.Texts);
                    decimal precoVenda = decimal.Parse(FormataPreco(txtPrecoVenda.Texts));

                    decimal custoMedio = decimal.Parse(txtCustoMedio.Texts);
                    decimal custoUltCompra = decimal.Parse(txtCustoUltCompra.Texts);
                    decimal precoUltCompra = decimal.Parse(txtPrecoUltCompra.Texts);

                    string observacao = txtObservacao.Texts;
                    int idFornecedor = int.Parse(txtCodFornecedor.Texts);
                    int idModelo = int.Parse(txtCodModelo.Texts);

                    //   AtualizarCampoComDataPadrao(txtDataUltCompra, out DateTime dataUltCompra);
                    string dUltCompra = new string(txtDataUltCompra.Texts.Where(char.IsDigit).ToArray());
                    DateTime? dataUltCompra = string.IsNullOrEmpty(dUltCompra) || dUltCompra.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataUltCompra.Texts, "dd/MM/yyyy", null);

                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;
                    
                    ProdutoModel novoProduto = new ProdutoModel
                    {
                        Produto = produto,
                        Unidade = unidade,
                        Saldo = saldo,
                        custoMedio = custoMedio,
                        custoUltCompra = custoUltCompra,
                        precoVenda = precoVenda,
                        precoUltCompra = precoUltCompra,
                        dataUltCompra = dataUltCompra,
                        Observacao = observacao,
                        Ativo = isAtivo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        idFornecedor = idFornecedor,
                        idModelo = idModelo,
                        usuario = usuario,
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
        }

        public override void LimparCampos()
        {
            base.LimparCampos();
            idAlterar = -1;
            txtCodigo.Clear();
            txtProduto.Clear();
            txtUN.Clear();
            txtCodModelo.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtCodFornecedor.Clear();
            txtFornecedor.Clear();
            txtSaldo.Clear();
            txtCustoMedio.Clear();
            txtCustoUltCompra.Clear();
            txtPrecoVenda.Clear();
            txtPrecoUltCompra.Clear();
            txtDataUltCompra.Clear();
            txtObservacao.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtUsuarioUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        protected bool VerificaCamposObrigatorios()
        {
            if (!CampoObrigatorio(txtProduto.Texts))
            {
                MessageBox.Show("Campo Produto é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProduto.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtUN.Texts))
            {
                MessageBox.Show("Campo UN é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUN.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodModelo.Texts))
            {
                MessageBox.Show("Campo Cód. Modelo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodModelo.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodFornecedor.Texts))
            {
                MessageBox.Show("Campo Cód. Fornecedor é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFornecedor.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtPrecoVenda.Texts))
            {
                MessageBox.Show("Campo Preço Venda é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoVenda.Focus();
                return false;
            }
            return true;
        }

        public override void Carrega()
        {
            base.Carrega();
            txtPrecoVenda.ForeColor = Color.FromArgb(31, 31, 31);
            if (idAlterar != -1)
            {
                ProdutoModel produto = produtoController.GetById(idAlterar);
                if (produto != null)
                {
                    txtCodigo.Texts = produto.idProduto.ToString();
                    txtProduto.Texts = produto.Produto;
                    txtUsuarioUltAlt.Texts = produto.usuario;
                    txtSaldo.Texts = produto.Saldo.ToString();
                    txtUN.Texts = produto.Unidade.ToString();
                    txtCustoMedio.Texts = produto.custoMedio.ToString();
                    txtCustoUltCompra.Texts = produto.custoUltCompra.ToString();
                    txtPrecoVenda.Texts = produto.precoVenda.ToString("N2");
                    txtPrecoUltCompra.Texts = produto.precoUltCompra.ToString();
                    txtObservacao.Texts = produto.Observacao;   
                    txtDataCadastro.Texts = produto.dataCadastro.ToString();
                    txtDataUltAlt.Texts = produto.dataUltAlt.ToString();
                    rbAtivo.Checked = produto.Ativo;
                    rbInativo.Checked = !produto.Ativo;
                    txtCodFornecedor.Texts = produto.idFornecedor.ToString();
                    txtCodModelo.Texts = produto.idModelo.ToString();
                    txtDataUltCompra.Texts = produto.dataUltCompra.ToString();

                    ModeloModel modelo = modeloController.GetById(int.Parse(txtCodModelo.Texts));
                    if (modelo != null)
                    {
                        txtModelo.Texts = modelo.Modelo;
                        txtMarca.Texts = modelo.Marca;
                    }

                    FornecedorModel fornecedor = fornecedorController.GetById(int.Parse(txtCodFornecedor.Texts));
                    if (fornecedor != null)
                    {
                        txtFornecedor.Texts = fornecedor.fornecedor_razao_social;
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
            if (idAlterar == -1)
            {
                int novoCodigo = produtoController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
                txtSaldo.Texts = "0";
                txtPrecoUltCompra.Texts = "0";
                txtCustoMedio.Texts = "0";
                txtCustoUltCompra.Texts = "0";
            }
            if (Program.permissaoLogado == "ATENDENTE")
            {
                btnConsultaFornecedor.Enabled = false;
                txtCodFornecedor.Enabled = false;
            }
        }

        private void txtUN_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtUN.Texts))
            {
                MessageBox.Show("UN inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUN.Focus();
            }
        }

        private void txtCodModelo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodModelo.Texts))
            {
                var modelo = modeloController.getModelo(int.Parse(txtCodModelo.Texts));

                if (modelo.HasValue)
                {
                    txtModelo.Texts = modelo.Value.Modelo;
                    txtMarca.Texts = modelo.Value.Marca;
                }
                else
                {
                    MessageBox.Show("Modelo não encontrado ou inativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodModelo.Focus();
                    txtCodModelo.Clear();
                    txtModelo.Clear();
                    txtMarca.Clear();
                }
            }
        }

        private void txtCodModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConsultaModelos_Click(object sender, EventArgs e)
        {
            consultaModelos.btnSair.Text = "Selecionar";
            consultaModelos.cbBuscaInativos.Visible = false;

            if (consultaModelos.ShowDialog() == DialogResult.OK)
            {
                var modelosDetalhes = consultaModelos.Tag as Tuple<int, string, string>;

                if (modelosDetalhes != null)
                {
                    int modeloID = modelosDetalhes.Item1;
                    string modeloNome = modelosDetalhes.Item2;
                    string modeloMarca = modelosDetalhes.Item3;

                    txtCodModelo.Texts = modeloID.ToString();
                    txtModelo.Texts = modeloNome;
                    txtMarca.Texts = modeloMarca;
                }
            }
        }

        private void btnConsultaFornecedor_Click(object sender, EventArgs e)
        {
            consultaFornecedores.btnSair.Text = "Selecionar";
            consultaFornecedores.cbBuscaInativos.Visible = false;

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

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFornecedor.Texts))
            {
                string fornecedor = fornecedorController.getFornecedor(int.Parse(txtCodFornecedor.Texts));
                if (fornecedor != null)
                {
                    txtFornecedor.Texts = fornecedor;
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodFornecedor.Focus();
                    txtCodFornecedor.Clear();
                    txtFornecedor.Clear();
                }
            }
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrecoVenda.Texts))
            {
                try
                {
                    txtPrecoVenda.Texts = FormataPreco(txtPrecoVenda.Texts);

                    // Verifica se o valor é maior que zero
                    if (decimal.TryParse(txtPrecoVenda.Texts, out decimal preco) && preco > 0)
                    {
                        // Valor é válido e maior que zero
                    }
                    else
                    {
                        MessageBox.Show("O preço venda deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrecoVenda.Focus();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecoVenda.Focus();
                }
            }
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números, pontos, vírgulas e teclas de controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
