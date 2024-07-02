using MySqlX.XDevAPI;
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

        public override void Salvar()
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }
            int idAtual = idAlterar != -1 ? idAlterar : -1;
            if (produtoController.JaCadastrado(txtProduto.Text, Convert.ToInt32(txtCodFornecedor.Text), idAtual))
            {
                MessageBox.Show("Produto já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string produto = txtProduto.Text;
                    string unidade = txtUN.Text;
                    int saldo = int.Parse(txtSaldo.Text);

                    decimal custo_medio = decimal.Parse(txtCustoMedio.Text);
                    decimal preco_venda = decimal.Parse(FormataPreco(txtPrecoVenda.Text));
                    decimal preco_ult_compra = decimal.Parse(txtPrecoUltCompra.Text);

                    string observacao = txtObservacao.Text;
                    int idFornecedor = int.Parse(txtCodFornecedor.Text);
                    int idModelo = int.Parse(txtCodModelo.Text);

                    AtualizarCampoComDataPadrao(txtDataUltCompra, out DateTime data_ult_compra);

                    DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;
                    
                    ProdutoModel novoProduto = new ProdutoModel
                    {
                        Produto = produto,
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
        }

        public override void LimparCampos()
        {
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
            txtPrecoVenda.Clear();
            txtPrecoUltCompra.Clear();
            txtDataUltCompra.Clear();
            txtObservacao.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        protected bool VerificaCamposObrigatorios()
        {
            if (!CampoObrigatorio(txtProduto.Text))
            {
                MessageBox.Show("Campo Produto é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProduto.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtUN.Text))
            {
                MessageBox.Show("Campo UN é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUN.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodModelo.Text))
            {
                MessageBox.Show("Campo Cód. Modelo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodModelo.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodFornecedor.Text))
            {
                MessageBox.Show("Campo Cód. Fornecedor é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFornecedor.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtPrecoVenda.Text))
            {
                MessageBox.Show("Campo Preço Venda é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoVenda.Focus();
                return false;
            }
            return true;
        }

        public override void Carrega()
        {
            if (idAlterar != -1)
            {
                ProdutoModel produto = produtoController.GetById(idAlterar);
                if (produto != null)
                {
                    txtCodigo.Texts = produto.idProduto.ToString();
                    txtProduto.Text = produto.Produto;
                    txtSaldo.Text = produto.Saldo.ToString();
                    txtUN.Text = produto.Unidade.ToString();
                    txtCustoMedio.Text = produto.Custo_medio.ToString();
                    txtPrecoVenda.Text = produto.Preco_venda.ToString("N2");
                    txtPrecoUltCompra.Text = produto.Preco_ult_compra.ToString();
                    txtObservacao.Text = produto.Observacao;
                    txtDataCadastro.Text = produto.dataCadastro.ToString();
                    txtDataUltAlt.Text = produto.dataUltAlt.ToString();
                    rbAtivo.Checked = produto.Ativo;
                    rbInativo.Checked = !produto.Ativo;
                    txtCodFornecedor.Text = produto.idFornecedor.ToString();
                    txtCodModelo.Text = produto.idModelo.ToString();

                    AtualizarCampoData(produto.Data_ult_compra, txtDataUltCompra);

                    ModeloModel modelo = modeloController.GetById(int.Parse(txtCodModelo.Text));
                    if (modelo != null)
                    {
                        txtModelo.Text = modelo.Modelo;
                        txtMarca.Text = modelo.Marca;
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
            if (idAlterar == -1)
                txtCodigo.Texts = "0";
            txtSaldo.Text = "0";
            txtCustoMedio.Text = "0";
            txtPrecoUltCompra.Text = "0";
        }

        private void btnConsultaModelos_Click(object sender, EventArgs e)
        {
            consultaModelos.btnSair.Text = "Selecionar";

            if (consultaModelos.ShowDialog() == DialogResult.OK)
            {
                var modelosDetalhes = consultaModelos.Tag as Tuple<int, string, string>;

                if (modelosDetalhes != null)
                {
                    int modeloID = modelosDetalhes.Item1;
                    string modeloNome = modelosDetalhes.Item2;
                    string modeloMarca = modelosDetalhes.Item3;

                    txtCodModelo.Text = modeloID.ToString();
                    txtModelo.Text = modeloNome;
                    txtMarca.Text = modeloMarca;
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
                        txtMarca.Text = modelo.Marca;
                    }
                    else
                    {
                        MessageBox.Show("Modelo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodModelo.Focus();
                        txtCodModelo.Clear();
                        txtModelo.Clear();
                        txtMarca.Clear();
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
                        txtCodFornecedor.Focus();
                        txtCodFornecedor.Clear();
                        txtFornecedor.Clear();
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

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            try
            {
                txtPrecoVenda.Text = FormataPreco(txtPrecoVenda.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecoVenda.Focus();
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
