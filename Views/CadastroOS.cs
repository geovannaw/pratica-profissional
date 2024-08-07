﻿using Mysqlx.Crud;
using Sistema_Vendas.Controller;
using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Vendas.Views
{
    public partial class CadastroOS : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private ConsultaClientes consultaClientes;
        private ClienteController<ClienteModel> clienteController;
        private OSController<OrdemServicoModel> ordemServicoController;
        private FuncionarioController<FuncionarioModel> funcionarioController;
        private ConsultaFuncionarios consultaFuncionarios;
        private ConsultaProdutos consultaProdutos;
        private ConsultaServicos consultaServicos;
        private ProdutoController<ProdutoModel> produtoController;
        private ServicoController<ServicoModel> servicoController;

        decimal precoUNProduto;
        decimal precoUNServico;

        bool isAdquirido = true;
        private bool carregando = false;

        public CadastroOS()
        {
            InitializeComponent();
            consultaClientes = new ConsultaClientes();
            clienteController = new ClienteController<ClienteModel>();
            ordemServicoController = new OSController<OrdemServicoModel>();
            consultaFuncionarios = new ConsultaFuncionarios();
            funcionarioController = new FuncionarioController<FuncionarioModel>();
            consultaProdutos = new ConsultaProdutos();
            consultaServicos = new ConsultaServicos();
            produtoController = new ProdutoController<ProdutoModel>();
            servicoController = new ServicoController<ServicoModel>();
            txtCodCliente.Focus();
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }
        public override void LimparCampos()
        {
            base.LimparCampos();
            idAlterar = -1;
            txtCodigo.Clear();
            txtCodCliente.Clear();
            txtCliente.Clear();
            txtCelular.Clear();
            txtCodFuncionario.Clear();
            txtFuncionario.Clear();
            txtObservacao.Clear();
            txtDataOS.Clear();
            txtDataEntrega.Clear();
            cbSituacao.SelectedIndex = -1;
            txtSubtotalProdutos.Clear();
            txtSubtotalServicos.Clear();
            txtDesconto.Clear();
            txtPorcentagemDesconto.Clear();
            txtTotal.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            rbAtivo.Checked = true;

            txtCodProduto.Enabled = true;
            btnConsultaProduto.Enabled = true;
            txtQtdeProduto.Enabled = true;
            dataGridViewProdutos.Enabled = true;
            txtDataOS.Enabled = true;

            dataGridViewProdutos.Rows.Clear();
            dataGridViewServicos.Rows.Clear();
            limpaCamposProdutos();
            limpaCamposServicos();
        }

        private List<OS_ProdutoModel> obtemProdutos()
        {
            List<OS_ProdutoModel> produtos = new List<OS_ProdutoModel>(); 

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows) //percorrendo o dgv de produtos
            {
                OS_ProdutoModel produto = new OS_ProdutoModel //armazena os valores das linhas
                {
                    quantidadeProduto = Convert.ToInt32(row.Cells["quantidadeProduto"].Value),
                    precoProduto = Convert.ToDecimal(row.Cells["precoProduto"].Value),
                    idProduto = Convert.ToInt32(row.Cells["idProduto"].Value),
                };
                produtos.Add(produto);
            }

            return produtos;
        }
        private List<OS_ServicoModel> obtemServicos()
        {
            List<OS_ServicoModel> servicos = new List<OS_ServicoModel>();

            foreach (DataGridViewRow row in dataGridViewServicos.Rows) //percorrendo o dgv de servicos
            {
                OS_ServicoModel servico = new OS_ServicoModel //armazena os valores das linhas
                {
                    quantidadeServico = Convert.ToInt32(row.Cells["quantidadeServico"].Value),
                    precoServico = Convert.ToDecimal(row.Cells["precoServico"].Value),
                    idServico = Convert.ToInt32(row.Cells["idServiço"].Value),
                };
                servicos.Add(servico);
            }

            return servicos;
        }
        public override void Salvar()
        {
            decimal porcentagem = Convert.ToDecimal(txtPorcentagemDesconto.Texts);
            string dEntrega = new string(txtDataEntrega.Texts.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(txtCodCliente.Texts))
            {
                MessageBox.Show("Campo Cód. Cliente é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCliente.Focus();
            }
            else if (!CampoObrigatorio(txtCodFuncionario.Texts))
            {
                MessageBox.Show("Campo Cód. Funcionário é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFuncionario.Focus();
            }
            else if (!CampoObrigatorio(dEntrega))
            {
                MessageBox.Show("Campo Data Entrega é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataEntrega.Focus();
            }
            else if (!CampoObrigatorio(cbSituacao.Texts))
            {
                MessageBox.Show("Campo Situação é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSituacao.Focus();
            }
            else if (porcentagem > 100)
            {
                MessageBox.Show("A porcentagem deve ser igual ou menor que 100.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPorcentagemDesconto.Focus();
            }
            else if (dataGridViewServicos.Rows.Count == 0)
            {
                MessageBox.Show("É necessário adicionar pelo menos um serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int codCliente = Convert.ToInt32(txtCodCliente.Texts);
                    int codFuncionario = Convert.ToInt32(txtCodFuncionario.Texts);
                    decimal porcentagemDesconto = Convert.ToDecimal(txtPorcentagemDesconto.Texts);
                    string situacao = cbSituacao.Texts.ToString();
                    decimal total = Convert.ToDecimal(txtTotal.Texts);
                    string observacao = txtObservacao.Texts;
                    DateTime.TryParse(txtDataOS.Texts, out DateTime dataOS);
                    DateTime.TryParse(txtDataEntrega.Texts, out DateTime dataEntrega);
                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    OrdemServicoModel novaOS = new OrdemServicoModel
                    {
                        idCliente = codCliente,
                        idFuncionario = codFuncionario,
                        porcentagemDesconto = porcentagemDesconto,
                        status = situacao,
                        precoTotal = total,
                        dataEntrega = dataEntrega,
                        data = dataOS,
                        observacao = observacao,
                        Ativo = isAtivo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        Produtos = obtemProdutos(),
                        Servicos = obtemServicos(),
                    };

                    //armazena a lista de produtos originais (apenas ao alterar)
                    List<ProdutoModel> produtosOriginais = null;
                    if (idAlterar != -1)
                    {
                        produtosOriginais = ordemServicoController.GetProdutosByOS(idAlterar);
                    }

                    if (idAlterar == -1)
                    {
                        ordemServicoController.Salvar(novaOS);
                    }
                    else
                    {
                        novaOS.idOrdemServico = idAlterar;
                        ordemServicoController.Alterar(novaOS);
                    }

                    //atualiza saldo dos produtos
                    foreach (var produto in novaOS.Produtos)
                    {
                        ProdutoModel produtoDetalhes = produtoController.GetById(produto.idProduto);
                        if (produtoDetalhes != null)
                        {
                            int quantidadeOriginal = 0;
                            if (produtosOriginais != null)
                            {
                                var produtoOriginal = produtosOriginais.FirstOrDefault(p => p.idProduto == produto.idProduto);
                                if (produtoOriginal != null)
                                {
                                    quantidadeOriginal = produtoOriginal.Saldo;
                                }
                            }

                            produtoDetalhes.Saldo -= (produto.quantidadeProduto - quantidadeOriginal);
                            produtoController.Alterar(produtoDetalhes);
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar Ordem de Serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void Carrega()
        {
            base.Carrega();
            carregando = true;

            var ordemServico = ordemServicoController.GetById(idAlterar);
            if (ordemServico != null)
            {
                txtCodigo.Texts = ordemServico.idOrdemServico.ToString();
                txtCodCliente.Texts = ordemServico.idCliente.ToString();
                txtCodFuncionario.Texts = ordemServico.idFuncionario.ToString();
                txtDataOS.Texts = ordemServico.data.ToString();
                txtDataEntrega.Texts = ordemServico.dataEntrega.ToString();
                txtObservacao.Texts = ordemServico.observacao.ToString();
                txtTotal.Texts = ordemServico.precoTotal.ToString();
                txtPorcentagemDesconto.Texts = ordemServico.porcentagemDesconto.ToString();
                txtDataCadastro.Texts = ordemServico.dataCadastro.ToString();
                txtDataUltAlt.Texts = ordemServico.dataUltAlt.ToString();
                rbAtivo.Checked = ordemServico.Ativo;

                if (!cbSituacao.Items.Contains(ordemServico.status))
                {
                    cbSituacao.Items.Add(ordemServico.status);
                }
                cbSituacao.Texts = ordemServico.status;

                FuncionarioModel funcionario = funcionarioController.GetById(int.Parse(txtCodFuncionario.Texts));
                ClienteModel clienteDetalhes = ordemServicoController.GetClientePorId(ordemServico.idCliente);
                txtCliente.Texts = clienteDetalhes.cliente_razao_social;
                txtCelular.Texts = clienteDetalhes.celular;

                if (funcionario != null)
                {
                    txtFuncionario.Texts = funcionario.funcionario;
                }

                if(cbSituacao.SelectedItem.ToString() == "CANCELADO")
                {
                    txtCodProduto.Enabled = false;
                    btnConsultaProduto.Enabled = false;
                    txtQtdeProduto.Enabled = false;
                    dataGridViewProdutos.Enabled = false;
                } else
                {
                    txtCodProduto.Enabled = true;
                    btnConsultaProduto.Enabled = true;
                    txtQtdeProduto.Enabled = true;
                    dataGridViewProdutos.Enabled = true;
                }
                txtDataOS.Enabled = false;
                exibirProdutosDGV(ordemServico.Produtos);
                exibirServicosDGV(ordemServico.Servicos);
                atualizaSubtotalProdutos();
                atualizaSubtotalServicos();
                atualizaDesconto();
            }
            carregando = false;
        }
        private void exibirProdutosDGV(List<OS_ProdutoModel> produtos)
        {
            dataGridViewProdutos.Rows.Clear(); 

            foreach (var produto in produtos) 
            {
                ProdutoModel produtoDetalhes = ordemServicoController.GetProdutoPorId(produto.idProduto);
                
                if (produtoDetalhes != null)
                {
                    dataGridViewProdutos.Rows.Add(
                        produto.idProduto,
                        produtoDetalhes.Produto,    
                        produtoDetalhes.Preco_venda, 
                        produto.quantidadeProduto,
                        produto.precoProduto
                    );
                }
            }
            dataGridViewProdutos.Sort(dataGridViewProdutos.Columns["idProduto"], ListSortDirection.Ascending);
        }

        private void exibirServicosDGV(List<OS_ServicoModel> servicos)
        {
            dataGridViewServicos.Rows.Clear(); 

            foreach (var servico in servicos)
            {
                ServicoModel servicoDetalhes = ordemServicoController.GetServicoPorId(servico.idServico);

                if (servicoDetalhes != null)
                {
                    dataGridViewServicos.Rows.Add(
                        servico.idServico,
                        servicoDetalhes.servico, 
                        servicoDetalhes.preco, 
                        servico.quantidadeServico,
                        servico.precoServico
                    );
                }
            }
            dataGridViewServicos.Sort(dataGridViewServicos.Columns["idServiço"], ListSortDirection.Ascending);
        }

        private void atualizaSubtotalProdutos()
        {
            decimal subtotalProd = 0;

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows) //percorre as linhas do dgv
            {
                subtotalProd += Convert.ToDecimal(row.Cells["precoProduto"].Value); //add os valores da coluna precoProduto a variavel
            }
            txtSubtotalProdutos.Texts = subtotalProd.ToString("F2"); //att o campo com 2 casas decimais
        }

        private void atualizaSubtotalServicos()
        {
            decimal subtotalServ = 0;

            foreach (DataGridViewRow row in dataGridViewServicos.Rows) //percorre as linhas do dgv
            {
                subtotalServ += Convert.ToDecimal(row.Cells["precoServico"].Value); //add os valores da coluna precoServico a variavel
            }
            txtSubtotalServicos.Texts = subtotalServ.ToString("F2"); //att o campo com 2 casas decimais
        }

        private void atualizaTotal()
        {
            decimal subtotalProd = Convert.ToDecimal(txtSubtotalProdutos.Texts);
            decimal subtotalServ = Convert.ToDecimal(txtSubtotalServicos.Texts);
            decimal total = subtotalProd + subtotalServ;

            decimal porcentagemDesconto = 0;
            decimal.TryParse(txtPorcentagemDesconto.Texts, out porcentagemDesconto);

            decimal valorDesconto = 0;
            if (porcentagemDesconto > 0)
            {
                valorDesconto = (total * porcentagemDesconto) / 100;
            }

            decimal totalComDesconto = total - valorDesconto;

            txtTotal.Texts = totalComDesconto.ToString("F2");
            txtDesconto.Texts = valorDesconto.ToString("F2");
        }

        private void CadastroOS_Load(object sender, EventArgs e)
        {
            tabPrincipal.SelectedTab = tabDadosPrincipais;
            if (idAlterar == -1)
            {
                int novoCodigo = ordemServicoController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
                txtDataOS.Texts = DateTime.Now.ToString();
                txtSubtotalProdutos.Texts = "0";
                txtSubtotalServicos.Texts = "0";
                txtPorcentagemDesconto.Texts = "0";
            }
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            consultaClientes.btnSair.Text = "Selecionar";

            if (consultaClientes.ShowDialog() == DialogResult.OK)
            {
                var infosCliente = consultaClientes.Tag as Tuple<int, string, string>;
                if (infosCliente != null)
                {
                    int idCliente = infosCliente.Item1;
                    string cliente = infosCliente.Item2;
                    string celular = infosCliente.Item3;

                    txtCodCliente.Texts = idCliente.ToString();
                    txtCliente.Texts = cliente;
                    txtCelular.Texts = celular;
                }
            }
        }

        private void btnConsultaFuncionario_Click(object sender, EventArgs e)
        {
            consultaFuncionarios.btnSair.Text = "Selecionar";

            if (consultaFuncionarios.ShowDialog() == DialogResult.OK)
            {
                var infosFunc = consultaFuncionarios.Tag as Tuple<int, string>;
                if (infosFunc != null)
                {
                    int idFunc = infosFunc.Item1;
                    string funcionario = infosFunc.Item2;

                    txtCodFuncionario.Texts = idFunc.ToString();
                    txtFuncionario.Texts = funcionario;
                }
            }
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

                    txtCodProduto.Texts = idProd.ToString();
                    txtProduto.Texts = produto;
                }
            }
        }

        private void btnConsultaServico_Click(object sender, EventArgs e)
        {
            consultaServicos.btnSair.Text = "Selecionar";

            if (consultaServicos.ShowDialog() == DialogResult.OK)
            {
                var infosServico = consultaServicos.Tag as Tuple<int, string, decimal>;
                if (infosServico != null)
                {
                    int idServico = infosServico.Item1;
                    string servico = infosServico.Item2;
                    precoUNServico = infosServico.Item3;

                    txtCodServico.Texts = idServico.ToString();
                    txtServico.Texts = servico;
                }
            }
        }

        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio(txtCodProduto.Texts))
            {
                MessageBox.Show("Campo Cód. Produto é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodProduto.Focus();
            }
            else if (!CampoObrigatorio(txtQtdeProduto.Texts))
            {
                MessageBox.Show("Campo Quantidade Produto é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtdeProduto.Focus();
            }
            else
            {
                try
                {
                    int codigoProduto = Convert.ToInt32(txtCodProduto.Texts);
                    string produto = txtProduto.Texts;
                    decimal pUNProd = precoUNProduto;
                    int quantidadeProd = Convert.ToInt32(txtQtdeProduto.Texts);
                    decimal pTotal = quantidadeProd * pUNProd;
                    decimal precoTotalProd = pTotal;

                    // Verificar saldo do produto
                    ProdutoModel produtoDetalhes = produtoController.GetById(codigoProduto);
                    if (produtoDetalhes != null)
                    {
                        if (produtoDetalhes.Saldo >= quantidadeProd)
                        {
                            bool produtoExistente = false;

                            foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["idProduto"].Value) == codigoProduto)
                                {
                                    int quantidadeAtual = Convert.ToInt32(row.Cells["quantidadeProduto"].Value);
                                    row.Cells["quantidadeProduto"].Value = quantidadeAtual + quantidadeProd;
                                    row.Cells["precoProduto"].Value = (quantidadeAtual + quantidadeProd) * pUNProd;
                                    produtoExistente = true;
                                    break;
                                }
                            }

                            if (!produtoExistente)
                            {
                                dataGridViewProdutos.Rows.Add(codigoProduto, produto, pUNProd, quantidadeProd, precoTotalProd);
                            }

                            atualizaSubtotalProdutos();
                            atualizaTotal();
                            dataGridViewProdutos.Sort(dataGridViewProdutos.Columns["idProduto"], ListSortDirection.Ascending);
                            limpaCamposProdutos();
                        }
                        else
                        {
                            MessageBox.Show("Saldo insuficiente para o produto selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
                }
            }
        }
        public void limpaCamposProdutos()
        {
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtQtdeProduto.Clear();
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio(txtCodServico.Texts))
            {
                MessageBox.Show("Campo Cód. Serviço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodServico.Focus();
            }
            else if (!CampoObrigatorio(txtQtdeServico.Texts))
            {
                MessageBox.Show("Campo Quantidade Serviço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtdeServico.Focus();
            }
            else
            {
                try
                {
                    int codigoServico = Convert.ToInt32(txtCodServico.Texts);
                    string servico = txtServico.Texts;
                    decimal pUNServ = precoUNServico;
                    int quantidadeServ = Convert.ToInt32(txtQtdeServico.Texts);
                    decimal sTotal = quantidadeServ * pUNServ;
                    decimal precoTotalServ = sTotal;

                    bool servicoExistente = false;

                    foreach (DataGridViewRow row in dataGridViewServicos.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["idServiço"].Value) == codigoServico)
                        {
                            int quantidadeAtual = Convert.ToInt32(row.Cells["quantidadeServico"].Value);
                            row.Cells["quantidadeServico"].Value = quantidadeAtual + quantidadeServ;
                            row.Cells["precoServico"].Value = (quantidadeAtual + quantidadeServ) * pUNServ;
                            servicoExistente = true;
                            break;
                        }
                    }

                    if (!servicoExistente)
                    {
                        dataGridViewServicos.Rows.Add(codigoServico, servico, pUNServ, quantidadeServ, precoTotalServ);
                    }

                    atualizaSubtotalServicos();
                    atualizaTotal();
                    dataGridViewServicos.Sort(dataGridViewServicos.Columns["idServiço"], ListSortDirection.Ascending);
                    limpaCamposServicos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar serviço: " + ex.Message);
                }
            }
        }
        public void limpaCamposServicos()
        {
            txtCodServico.Clear();
            txtServico.Clear();
            txtQtdeServico.Clear();
        }

        private void CadastroOS_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaOS)this.Owner).AtualizarConsultaOS(false);
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCliente.Texts))
            {
                ClienteModel clienteDetalhes = ordemServicoController.GetClientePorId(int.Parse(txtCodCliente.Texts));
                if (clienteDetalhes != null)
                {
                    txtCliente.Texts = clienteDetalhes.cliente_razao_social;
                    txtCelular.Texts = clienteDetalhes.celular;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCliente.Focus();
                    txtCodCliente.Clear();
                    txtCliente.Clear();
                    txtCelular.Clear();
                }
            }
        }

        private void txtCodFuncionario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFuncionario.Texts))
            {
                FuncionarioModel funcionario = funcionarioController.GetById(int.Parse(txtCodFuncionario.Texts));
                if (funcionario != null)
                {
                    txtFuncionario.Texts = funcionario.funcionario;
                }
                else
                {
                    MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodFuncionario.Focus();
                    txtCodFuncionario.Clear();
                    txtFuncionario.Clear();
                }
            }
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodFuncionario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQtdeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQtdeServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodProduto.Focus();
                    txtCodProduto.Clear();
                    txtProduto.Clear();
                    txtQtdeProduto.Clear();
                }
            }
        }

        private void txtCodServico_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodServico.Texts))
            {
                ServicoModel servico = servicoController.GetById(int.Parse(txtCodServico.Texts));
                if (servico != null)
                {
                    txtServico.Texts = servico.servico;
                    precoUNServico = servico.preco;
                }
                else
                {
                    MessageBox.Show("Serviço não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodServico.Focus();
                    txtCodServico.Clear();
                    txtServico.Clear();
                    txtQtdeServico.Clear();
                }
            }
        }

        public void atualizaDesconto()
        {
            decimal porcentagem = Convert.ToDecimal(txtPorcentagemDesconto.Texts);
            if (porcentagem <= 100)
            {
                try
                {
                    //verifica se o valor do txtTotal é válido e converte para decimal
                    if (decimal.TryParse(txtSubtotalProdutos.Texts, out decimal subtotalProd) &&
                        decimal.TryParse(txtSubtotalServicos.Texts, out decimal subtotalServ))
                    {
                        //atualiza o total considerando o desconto
                        atualizaTotal();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira valores válidos para o subtotal dos produtos e serviços.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao calcular o desconto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A porcentagem deve ser menor ou igual a 100. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPorcentagemDesconto.Focus();
            }
        }

        private void txtPorcentagemDesconto_Leave(object sender, EventArgs e)
        {
            atualizaDesconto();
        }

        private void txtPorcentagemDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dataGridViewProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProdutos.Columns["quantidadeProduto"].Index)
            {
                //obtém a linha editada
                DataGridViewRow row = dataGridViewProdutos.Rows[e.RowIndex];

                //obtém a quantidade e o preço unitário
                int quantidade;
                decimal precoUnitario;

                if (int.TryParse(row.Cells["quantidadeProduto"].Value.ToString(), out quantidade) &&
                    decimal.TryParse(row.Cells["precoUNProd"].Value.ToString(), out precoUnitario))
                {
                    //calcula o preço total
                    decimal precoTotal = quantidade * precoUnitario;

                    //atualiza preço Total
                    row.Cells["precoProduto"].Value = precoTotal;
                    atualizaSubtotalProdutos();
                    atualizaTotal();
                }
                else
                {
                    MessageBox.Show("Quantidade ou Preço Unitário inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewServicos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewServicos.Columns["quantidadeServico"].Index)
            {
                //obtém a linha editada
                DataGridViewRow row = dataGridViewServicos.Rows[e.RowIndex];

                //obtém a quantidade e o preço unitário
                int quantidade;
                decimal precoUnitario;

                if (int.TryParse(row.Cells["quantidadeServico"].Value.ToString(), out quantidade) &&
                    decimal.TryParse(row.Cells["precoUNServ"].Value.ToString(), out precoUnitario))
                {
                    //calcula o preço total
                    decimal precoTotal = quantidade * precoUnitario;

                    //atualiza preço Total
                    row.Cells["precoServico"].Value = precoTotal;
                    atualizaSubtotalServicos();
                    atualizaTotal();
                }
                else
                {
                    MessageBox.Show("Quantidade ou Preço Unitário inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProdutos.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewProdutos.SelectedRows)
                    {
                        dataGridViewProdutos.Rows.Remove(row);
                    }
                    atualizaSubtotalProdutos();
                    atualizaTotal();
                }
                else
                {
                    MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewServicos.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewServicos.SelectedRows)
                    {
                        dataGridViewServicos.Rows.Remove(row);
                    }
                    atualizaSubtotalServicos();
                    atualizaTotal();
                }
                else
                {
                    MessageBox.Show("Selecione um serviço para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDataOS_Leave(object sender, EventArgs e)
        {

        }

        private void txtDataEntrega_Leave(object sender, EventArgs e)
        {
            DateTime dataEntrega;
            DateTime dataOS;
            DateTime.TryParse(txtDataEntrega.Texts, out dataEntrega);
            DateTime.TryParse(txtDataOS.Texts, out dataOS);

            string dataE = new string(txtDataEntrega.Texts.Where(char.IsDigit).ToArray());
            if (!string.IsNullOrWhiteSpace(dataE))
            {
                //verifica se a data de entrega é maior ou igual a hoje
                if (dataEntrega < dataOS)
                {
                    MessageBox.Show("Data de entrega inválida! A data deve ser maior ou igual a hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataEntrega.Focus();
                }
            }
            {
                // Se estiver vazio ou com a máscara inicial, sai do método sem validação
                return;
            }
 
        }

        private void cbSituacao_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregando) return;
            if (cbSituacao.SelectedIndex == -1) return;
            if (cbSituacao.SelectedItem.ToString() == "CANCELADO")
            {
                if (MessageBox.Show("Tem certeza que deseja cancelar a Ordem de Serviço? Ao cancelar, os produtos presentes voltarão ao estoque.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idOS;
                    if (int.TryParse(txtCodigo.Texts, out idOS))
                    {
                        // Recupera a lista de produtos associados à OS
                        List<ProdutoModel> produtos = ordemServicoController.GetProdutosByOS(idOS);

                        // Volta o estoque de cada produto
                        foreach (var produto in produtos)
                        {
                            produtoController.AtualizarSaldo(produto.idProduto, produto.Saldo);
                        }

                        txtCodProduto.Enabled = false;
                        btnConsultaProduto.Enabled = false;
                        txtQtdeProduto.Enabled = false;
                        dataGridViewProdutos.Enabled = false;

                        MessageBox.Show("Ordem de Serviço cancelada e estoque atualizado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Código da Ordem de Serviço inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        } 
    }
}
