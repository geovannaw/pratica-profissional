﻿using Sistema_Vendas.Controller;
using Sistema_Vendas.DAO;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Sistema_Vendas.DAO.NotaCompraDAO;

namespace Sistema_Vendas.Views
{
    public partial class CadastroNotaCompra : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private ConsultaFornecedores consultaFornecedores;
        private FornecedorController<FornecedorModel> fornecedorController;
        private ConsultaCondicaoPagamento consultaCondicaoPagamento;
        private CondicaoPagamentoController<CondicaoPagamentoModel> condicaoPagamentoController;
        private ConsultaProdutos consultaProdutos;
        private ProdutoController<ProdutoModel> produtoController;
        private NotaCompraController<NotaCompraModel> notaCompraController;
        private ContasPagarController<ContasPagarModel> contasPagarController;

        decimal precoUNProduto;

        bool isCIF = true;

        decimal frete;
        decimal seguro;
        decimal outrasDespesas;

        decimal juros;
        decimal descontos;
        decimal multa;

        int NumeroNota;
        int Modelo;
        int Serie;
        int IdFornecedor;
        public CadastroNotaCompra()
        {
            InitializeComponent();
            consultaFornecedores = new ConsultaFornecedores();
            fornecedorController = new FornecedorController<FornecedorModel>();
            consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            condicaoPagamentoController = new CondicaoPagamentoController<CondicaoPagamentoModel>();
            consultaProdutos = new ConsultaProdutos();
            produtoController = new ProdutoController<ProdutoModel>();
            notaCompraController = new NotaCompraController<NotaCompraModel>();
            contasPagarController = new ContasPagarController<ContasPagarModel>();
            txtNroNota.Focus();
        }
        public override void LimparCampos()
        {
            NumeroNota = -1;
            Modelo = -1;
            Serie = -1;
            IdFornecedor = -1;

            base.LimparCampos();
            //limpa todos os campos de texto
            txtNroNota.Clear();
            txtModelo.Clear();
            txtSerie.Clear();
            txtDataEmissao.Clear();
            txtDataChegada.Clear();
            txtCodFornecedor.Clear();
            txtFornecedor.Clear();
            lblCancelada.Visible = false;
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtUN.Clear();
            txtQtdeProduto.Clear();
            txtPrecoProd.Clear();
            txtValorFrete.Texts = "0";
            txtValorSeguro.Texts = "0";
            txtOutrasDespesas.Texts = "0";
            txtCodCondPag.Clear();
            txtCondPag.Clear();
            txtTotalProdutos.Clear();
            txtTotalPagar.Clear();
            txtObservacao.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtDataCancelamento.Clear();
            txtUsuarioUltAlt.Clear();
            txtDescontoProd.Clear();

            //limpa os DataGridViews
            dataGridViewProdutos.Rows.Clear();
            dataGridViewParcelas.Rows.Clear();

            rbCIF.Checked = true;

            Desbloqueia();
        }

        public void Desbloqueia()
        {
            txtNroNota.Enabled = true;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
            txtCodFornecedor.Enabled = true;
            txtObservacao.Enabled = true;

            txtDataEmissao.Enabled = false;
            txtDataChegada.Enabled = false;
            txtCodProduto.Enabled = false;
            txtProduto.Enabled = false;
            txtUN.Enabled = false;
            txtQtdeProduto.Enabled = false;
            txtPrecoProd.Enabled = false;
            txtDescontoProd.Enabled = false;
            txtValorFrete.Enabled = false;
            txtValorSeguro.Enabled = false;
            txtOutrasDespesas.Enabled = false;
            txtCodCondPag.Enabled = false;
            txtCondPag.Enabled = false;
            txtTotalProdutos.Enabled = false;
            txtTotalPagar.Enabled = false;
            txtObservacao.Enabled = false;
            txtDataCadastro.Enabled = false;
            txtDataUltAlt.Enabled = false;
            txtDataCancelamento.Enabled = false;

            btnConsultaFornecedor.Enabled = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = false;
            txtDataCancelamento.Visible = false;
            lblDataCancelamento.Visible = false;

            dataGridViewProdutos.Enabled = true;
            dataGridViewParcelas.Enabled = true;

            //desativa os RadioButtons
            rbCIF.Enabled = false;
            rbFOB.Enabled = false;

            //desativa o GroupBox
            groupBox2.Enabled = false;

            btnExcluirProduto.Visible = true;
        }

        public void BloqueiaTudo()
        {
            //desativa todos os campos de texto
            txtNroNota.Enabled = false;
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtDataEmissao.Enabled = false;
            txtDataChegada.Enabled = false;
            txtCodFornecedor.Enabled = false;
            txtFornecedor.Enabled = false;
            txtCodProduto.Enabled = false;
            txtProduto.Enabled = false;
            txtUN.Enabled = false;
            txtQtdeProduto.Enabled = false;
            txtPrecoProd.Enabled = false;
            txtDescontoProd.Enabled = false;
            txtValorFrete.Enabled = false;
            txtValorSeguro.Enabled = false;
            txtOutrasDespesas.Enabled = false;
            txtCodCondPag.Enabled = false;
            txtCondPag.Enabled = false;
            txtTotalProdutos.Enabled = false;
            txtTotalPagar.Enabled = false;
            txtObservacao.Enabled = false;
            txtDataCadastro.Enabled = false;
            txtDataUltAlt.Enabled = false;
            txtDataCancelamento.Enabled = false;

            //desativa todos os botões
            btnConsultaFornecedor.Enabled = false;
            btnConsultaProduto.Enabled = false;
            btnConsultaCondPag.Enabled = false;

            //desativa o DataGridView
            dataGridViewProdutos.Enabled = true;
            dataGridViewParcelas.Enabled = true;

            //desativa os RadioButtons
            rbCIF.Enabled = false;
            rbFOB.Enabled = false;

            //desativa o GroupBox
            groupBox2.Enabled = false;

            btnExcluirProduto.Visible = false;
        }

        public override void Carrega()
        {
            base.Carrega();

            var notaCompra = notaCompraController.GetNotaById(NumeroNota, Modelo, Serie, IdFornecedor);
            if (notaCompra != null)
            {
                txtNroNota.Texts = notaCompra.numeroNota.ToString();
                txtModelo.Texts = notaCompra.modelo.ToString();
                txtSerie.Texts = notaCompra.serie.ToString();
                txtDataEmissao.Texts = notaCompra.dataEmissao.ToString();
                txtDataChegada.Texts = notaCompra.dataChegada.ToString();
                txtCodFornecedor.Texts = notaCompra.idFornecedor.ToString();
                rbCIF.Checked = notaCompra.tipoFrete;
                rbFOB.Checked = !notaCompra.tipoFrete;
                txtValorFrete.Texts = notaCompra.valorFrete.ToString();
                txtValorSeguro.Texts = notaCompra.valorSeguro.ToString();
                txtOutrasDespesas.Texts = notaCompra.outrasDespesas.ToString();
                txtTotalPagar.Texts = notaCompra.totalPagar.ToString();
                txtTotalProdutos.Texts = notaCompra.totalProdutos.ToString();
                txtCodCondPag.Texts = notaCompra.idCondPagamento.ToString();
                txtObservacao.Texts = notaCompra.observacao.ToString();
                txtDataCadastro.Texts = notaCompra.dataCadastro.ToString();
                txtDataUltAlt.Texts = notaCompra.dataUltAlt.ToString();
                txtDataCancelamento.Texts = notaCompra.dataCancelamento.ToString();
                txtUsuarioUltAlt.Texts = notaCompra.usuario;

                FornecedorModel fornecedor = fornecedorController.GetById(int.Parse(txtCodFornecedor.Texts));
                CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));

                if (fornecedor != null)
                    txtFornecedor.Texts = fornecedor.fornecedor_razao_social;
                if (condPagamento != null)
                    txtCondPag.Texts = condPagamento.condicaoPagamento;

                if (notaCompra.dataCancelamento != null)
                {
                    lblCancelada.Visible = true;
                    lblDataCancelamento.Visible = true;
                    txtDataCancelamento.Visible = true;
                } else
                {
                    lblCancelada.Visible = false;
                    lblDataCancelamento.Visible = false;
                    txtDataCancelamento.Visible = false;
                }
                exibirProdutosDGV(notaCompra.Produtos);
                exibirParcelasDGV(condPagamento.Parcelas);
            }
        }
        public override void Salvar()
        {
            string dEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            string dChegada = new string(txtDataChegada.Texts.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(txtNroNota.Texts))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroNota.Focus();
            }
            else if (!CampoObrigatorio(txtModelo.Texts))
            {
                MessageBox.Show("Campo Modelo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelo.Focus();
            }
            else if (!CampoObrigatorio(txtSerie.Texts))
            {
                MessageBox.Show("Campo Série é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSerie.Focus();
            }
            else if (!CampoObrigatorio(txtCodFornecedor.Texts))
            {
                MessageBox.Show("Campo Código Fornecedor é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFornecedor.Focus();
            }
            else if (!CampoObrigatorio(dEmissao))
            {
                MessageBox.Show("Campo Data Emissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataEmissao.Focus();
            }
            else if (!CampoObrigatorio(dChegada))
            {
                MessageBox.Show("Campo Data Chegada é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataChegada.Focus();
            }
            else if (dataGridViewProdutos.Rows.Count <= 0)
            {
                MessageBox.Show("É necessário adicionar pelo menos um produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodProduto.Focus();
            }
            else if (!CampoObrigatorio(txtCodCondPag.Texts))
            {
                MessageBox.Show("Campo Código Condição de Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCondPag.Focus();
            }
            else if (dataGridViewParcelas.Rows.Count <= 0)
            {
                MessageBox.Show("É necessário adicionar pelo menos uma parcela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodProduto.Focus();
            }
            else
            {
                int.TryParse(txtNroNota.Texts, out int nroNota);
                int.TryParse(txtCodFornecedor.Texts, out int CodFornecedor);
                if (notaCompraController.ExisteNota(nroNota, txtModelo.Texts, txtSerie.Texts, CodFornecedor))
                {
                    MessageBox.Show("Nota já cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNroNota.Focus();
                }
                else
                {
                    try
                    {
                        int numeroNota = Convert.ToInt32(txtNroNota.Texts);
                        int modelo = Convert.ToInt32(txtModelo.Texts);
                        int serie = Convert.ToInt32(txtSerie.Texts);
                        int idFornecedor = Convert.ToInt32(txtCodFornecedor.Texts);
                        decimal valorFrete = Convert.ToDecimal(txtValorFrete.Texts);
                        decimal valorSeguro = Convert.ToDecimal(txtValorSeguro.Texts);
                        decimal outrasDespesas = Convert.ToDecimal(txtOutrasDespesas.Texts);
                        decimal totalProdutos = Convert.ToDecimal(txtTotalProdutos.Texts);
                        decimal totalPagar = Convert.ToDecimal(txtTotalPagar.Texts);
                        int idCondPagamento = Convert.ToInt32(txtCodCondPag.Texts);
                        string observacao = txtObservacao.Texts;
                        string usuario = Program.usuarioLogado;
                        DateTime.TryParse(txtDataEmissao.Texts, out DateTime dataEmissao);
                        DateTime.TryParse(txtDataChegada.Texts, out DateTime dataChegada);
                        dataChegada = dataChegada.Date.Add(DateTime.Now.TimeOfDay); //add a hora que está chegando

                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                        NotaCompraModel notaCompra = new NotaCompraModel
                        {
                            numeroNota = numeroNota,
                            modelo = modelo,
                            serie = serie,
                            idFornecedor = idFornecedor,
                            tipoFrete = isCIF,
                            valorFrete = valorFrete,
                            valorSeguro = valorSeguro,
                            outrasDespesas = outrasDespesas,
                            totalProdutos = totalProdutos,
                            totalPagar = totalPagar,
                            idCondPagamento = idCondPagamento,
                            dataEmissao = dataEmissao,
                            dataChegada = dataChegada,
                            observacao = observacao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            usuario = usuario,
                            Produtos = obtemProdutos(valorFrete, valorSeguro, outrasDespesas, totalProdutos),
                        };

                        notaCompraController.Salvar(notaCompra);
                        notaCompraController.AtualizarProdutosNotaCompra(notaCompra);


                        try //salvar contas a pagar
                        {
                            foreach (DataGridViewRow row in dataGridViewParcelas.Rows)
                            {
                                if (row.IsNewRow) continue;

                                //validação do que está no datagrid
                                if (row.Cells["idFormaPagamento"].Value == null || !int.TryParse(row.Cells["idFormaPagamento"].Value.ToString(), out int idFormaPagamento))
                                {
                                    MessageBox.Show("Forma de pagamento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                if (row.Cells["numeroParcela"].Value == null || !int.TryParse(row.Cells["numeroParcela"].Value.ToString(), out int parcela))
                                {
                                    MessageBox.Show("Número de parcela inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                if (row.Cells["valorParcela"].Value == null || !decimal.TryParse(row.Cells["valorParcela"].Value.ToString(), out decimal valorParcela))
                                {
                                    MessageBox.Show("Valor da parcela inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                if (row.Cells["dataVencimento"].Value == null || !DateTime.TryParse(row.Cells["dataVencimento"].Value.ToString(), out DateTime dataVencimento))
                                {
                                    MessageBox.Show("Data de vencimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                ContasPagarModel contaPagar = new ContasPagarModel
                                {
                                    numeroNota = numeroNota,
                                    modelo = modelo,
                                    serie = serie,
                                    idFornecedor = idFornecedor,
                                    dataEmissao = dataEmissao,
                                    idFormaPagamento = idFormaPagamento,
                                    parcela = parcela,
                                    valorParcela = valorParcela,
                                    dataVencimento = dataVencimento,
                                    dataPagamento = null,
                                    juros = juros,
                                    multa = multa,
                                    desconto = descontos,
                                    valorPago = null,
                                    dataCancelamento = null,
                                    observacao = observacao,
                                    usuario = usuario,
                                    dataCadastro = DateTime.Now,
                                    dataUltAlt = DateTime.Now
                                };

                                contasPagarController.Salvar(contaPagar);
                            }
                        }
                        catch (FormatException fe)
                        {
                            MessageBox.Show("Erro ao converter valores: " + fe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro ao salvar as Contas a Pagar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar a Nota de Compra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
        }

        private List<NotaCompra_ProdutoModel> obtemProdutos(decimal valorFrete, decimal valorSeguro, decimal outrasDespesas, decimal totalProdutos)
        {
            List<NotaCompra_ProdutoModel> produtos = new List<NotaCompra_ProdutoModel>();

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
            {
                decimal precoLiquido = Convert.ToDecimal(row.Cells["PrecoLiquido"].Value);
                decimal quantidadeProduto = Convert.ToDecimal(row.Cells["quantidadeProduto"].Value);
                decimal precoTotalProd = precoLiquido * quantidadeProduto;

                //calcular o rateio e arredondar para 4 casas decimais
                decimal rateio = Math.Round(precoTotalProd / totalProdutos, 4);

                //calcular o custo do produto e arredondar para 4 casas decimais
                decimal custoProd = Math.Round((valorFrete + valorSeguro + outrasDespesas) * rateio, 4);

                //calcular o custo médio do produto e arredondar para 4 casas decimais
                decimal custoMedio = Math.Round((precoTotalProd + custoProd) / quantidadeProduto, 4);

                //se custo médio for igual ao preço unitário, considerar apenas o preço unitário
                if (custoProd == 0)
                {
                    custoMedio = Math.Round(precoLiquido, 4);
                }

                NotaCompra_ProdutoModel produto = new NotaCompra_ProdutoModel
                {
                    quantidadeProduto = Convert.ToInt32(row.Cells["quantidadeProduto"].Value),
                    precoProduto = Math.Round(precoLiquido, 4),
                    descontoProd = row.Cells["DescontoProd"].Value != null ? Convert.ToDecimal(row.Cells["DescontoProd"].Value) : (decimal?)null,
                    idProduto = Convert.ToInt32(row.Cells["idProduto"].Value),
                    rateio = rateio,
                    custoMedio = custoMedio,
                    custoUltCompra = custoMedio 
                };

                produtos.Add(produto);
            }

            return produtos;
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

                    FornecedorModel fornecedorDetalhes = fornecedorController.GetById(fornecedorID);
                    if (fornecedorDetalhes != null)
                        txtCodCondPag.Texts = fornecedorDetalhes.idCondPagamento.ToString();
                    CondicaoPagamentoModel condPag = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
                    if (condPag != null)
                        txtCondPag.Texts = condPag.condicaoPagamento.ToString();
                }
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

                    FornecedorModel fornecedorDetalhes = fornecedorController.GetById(int.Parse(txtCodFornecedor.Texts));
                    if (fornecedorDetalhes != null)
                        txtCodCondPag.Texts = fornecedorDetalhes.idCondPagamento.ToString();
                    CondicaoPagamentoModel condPag = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
                    if (condPag != null)
                        txtCondPag.Texts = condPag.condicaoPagamento.ToString();
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodFornecedor.Focus();
                    txtCodFornecedor.Clear();
                    txtFornecedor.Clear();
                    txtCodCondPag.Clear();
                    txtCondPag.Clear();
                }
            }
            VerificaNotaExistente();
            VerificaCamposPreenchidosNF();
        }

        private void btnConsultaProduto_Click(object sender, EventArgs e)
        {
            consultaProdutos.btnSair.Text = "Selecionar";
            consultaProdutos.cbBuscaInativos.Visible = false;

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
                var produto = produtoController.getProduto(int.Parse(txtCodProduto.Texts));
                if (produto.HasValue)
                {
                    txtProduto.Texts = produto.Value.Produto;
                    txtUN.Texts = produto.Value.Unidade;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado ou inativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            consultaCondicaoPagamento.cbBuscaInativos.Visible = false;

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
                string condPagamento = condicaoPagamentoController.getCondicaoPag(int.Parse(txtCodCondPag.Texts));
                if (condPagamento != null)
                {
                    txtCondPag.Texts = condPagamento;
                }
                else
                {
                    MessageBox.Show("Condição de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCondPag.Focus();
                    txtCodCondPag.Clear();
                    txtCondPag.Clear();
                    dataGridViewParcelas.Rows.Clear();
                }
            } else
            {
                txtCodCondPag.Clear();
                txtCondPag.Clear();
                dataGridViewParcelas.Rows.Clear();

            }
            VerificaCamposPreenchidosCondPagamento();
        }

        private void exibirProdutosDGV(List<NotaCompra_ProdutoModel> produtos)
        {
            dataGridViewProdutos.Rows.Clear();

            foreach (var produto in produtos)
            {
                ProdutoModel produtoDetalhes = notaCompraController.GetProdutoPorId(produto.idProduto);

                if (produtoDetalhes != null)
                {
                    decimal descontoProd = produto.descontoProd ?? 0;
                    decimal precoLiquido = produto.precoProduto; 

                    dataGridViewProdutos.Rows.Add(
                        produto.idProduto,
                        produtoDetalhes.Produto,
                        produtoDetalhes.Unidade,
                        produto.quantidadeProduto,
                        (produto.precoProduto + descontoProd).ToString("F2"), 
                        descontoProd.ToString("F2"),         
                        precoLiquido.ToString("F2"),     
                        (produto.quantidadeProduto * precoLiquido).ToString("F2")
                    );
                }
            }

            if (dataGridViewProdutos.Columns.Contains("idProduto"))
            {
                dataGridViewProdutos.Sort(dataGridViewProdutos.Columns["idProduto"], ListSortDirection.Ascending);
            }
        }

        private void exibirParcelasDGV(List<ParcelaModel> parcelas)
        {
            dataGridViewParcelas.Rows.Clear();

            DateTime dataEmissao;
            decimal valorTotalNota;
            if (DateTime.TryParse(txtDataEmissao.Texts, out dataEmissao) && decimal.TryParse(txtTotalPagar.Texts, out valorTotalNota))
            {
                decimal somaParcelas = 0m;
                for (int i = 0; i < parcelas.Count; i++)
                {
                    var parcela = parcelas[i]; //parcela atual
                    int codFormaPagamento = parcela.idFormaPagamento;
                    string formaPagamento = condicaoPagamentoController.GetFormaPagByParcelaId(parcela.idParcela);
                    DateTime dataParcela = dataEmissao.AddDays(parcela.dias);
                    decimal valorParcela;

                    if (i == parcelas.Count - 1) //se for a ultima parcela
                    {
                        //para a última parcela, subtrai o valor das parcelas anteriores    
                        //assim nao corre o risco do valor final nao ser igual ao valor total
                        valorParcela = valorTotalNota - somaParcelas;
                    }
                    else
                    { //se nao for a ultima, faz a conta normal de acordo com a porcentagem do contas a pagar
                        valorParcela = Math.Round((valorTotalNota * parcela.porcentagem) / 100, 2);
                        somaParcelas += valorParcela;
                    }

                    dataGridViewParcelas.Rows.Add(
                        parcela.numeroParcela,
                        codFormaPagamento,
                        formaPagamento,
                        dataParcela.ToString("dd/MM/yyyy"),
                        valorParcela.ToString("F2")
                    );
                }
            }
            else
            {
                MessageBox.Show("Data de emissão ou valor total inválido.");
            }
        }

        private void CadastroNotaCompra_Load(object sender, EventArgs e)
        {
            if (NumeroNota != -1 && Modelo != -1 && Serie != -1 && IdFornecedor != -1)
            {
                btnCancelar.Visible = true;
                btnSalvar.Visible = false;
            }
            else
            {
                txtDataChegada.Texts = DateTime.Now.ToString();
                txtModelo.Texts = "55";
                txtSerie.Texts = "1";
            }
            if (Program.permissaoLogado == "ATENDENTE")
            {
                btnConsultaFornecedor.Enabled = false;
                txtCodFornecedor.Enabled = false;
            }
            dataGridViewParcelas.Columns["numeroParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewParcelas.Columns["idFormaPagamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewParcelas.Columns["valorParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewProdutos.Columns["idProduto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProdutos.Columns["quantidadeProduto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProdutos.Columns["PrecoUN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProdutos.Columns["DescontoProd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProdutos.Columns["PrecoLiquido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProdutos.Columns["precoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        public void SetID(int numero, int modelo, int serie, int idFornecedor)
        {
            NumeroNota = numero;
            Modelo = modelo;
            Serie = serie;
            IdFornecedor = idFornecedor;
        }
        private void VerificaCamposPreenchidosNF()
        {
            string dataEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            string dataChegada = new string(txtDataChegada.Texts.Where(char.IsDigit).ToArray());
            bool camposPreenchidos = !string.IsNullOrEmpty(txtNroNota.Texts) &&
                                     !string.IsNullOrEmpty(txtModelo.Texts) &&
                                     !string.IsNullOrEmpty(txtSerie.Texts) &&
                                     !string.IsNullOrEmpty(dataEmissao) &&
                                     !string.IsNullOrEmpty(dataChegada) &&
                                     !string.IsNullOrEmpty(txtCodFornecedor.Texts);

            txtCodProduto.Enabled = camposPreenchidos;
            txtQtdeProduto.Enabled = camposPreenchidos;
            txtPrecoProd.Enabled = camposPreenchidos;
            txtDescontoProd.Enabled = camposPreenchidos;
            btnConsultaProduto.Enabled = camposPreenchidos;
          //  btnExcluirProduto.Enabled= camposPreenchidos;
            dataGridViewProdutos.Enabled = camposPreenchidos;
        }
        private void VerificaProdutos()
        {
            if (NumeroNota == -1 && Modelo == -1 && Serie == -1 && IdFornecedor == -1)
            {
                bool habilitar = dataGridViewProdutos.Rows.Count > 0;

                //desabilita os campos com infos da nota
                txtNroNota.Enabled = !habilitar;
                txtModelo.Enabled = !habilitar;
                txtSerie.Enabled = !habilitar;
                txtDataEmissao.Enabled = !habilitar;
                txtDataChegada.Enabled = !habilitar;
                txtCodFornecedor.Enabled = !habilitar;
                btnConsultaFornecedor.Enabled = !habilitar;

                groupBox2.Enabled = habilitar;
                rbCIF.Enabled = habilitar;
                rbFOB.Enabled = habilitar;
                txtValorSeguro.Enabled = habilitar;
                txtOutrasDespesas.Enabled = habilitar;

                txtCodCondPag.Enabled = habilitar;
                btnConsultaCondPag.Enabled = habilitar;
                dataGridViewParcelas.Enabled = habilitar;
            }
        }
        private void VerificaCamposPreenchidosFrete()
        {
            bool camposPreenchidos = ((decimal.TryParse(txtValorFrete.Texts, out var valorFrete) && valorFrete != 0) ||
                                     (decimal.TryParse(txtValorSeguro.Texts, out var valorSeguro) && valorSeguro != 0) ||
                                     (decimal.TryParse(txtOutrasDespesas.Texts, out var outrasDespesas) && outrasDespesas != 0));

            txtCodProduto.Enabled = !camposPreenchidos;
            txtQtdeProduto.Enabled = !camposPreenchidos;
            txtPrecoProd.Enabled = !camposPreenchidos;
            txtDescontoProd.Enabled = !camposPreenchidos;
            dataGridViewProdutos.Enabled = !camposPreenchidos;
            btnConsultaProduto.Enabled = !camposPreenchidos;
        }
        private void VerificaCamposPreenchidosCondPagamento()
        {
            bool camposPreenchidos = (!string.IsNullOrEmpty(txtCodCondPag.Texts) || dataGridViewParcelas.Rows.Count > 0);

            groupBox2.Enabled = !camposPreenchidos;
            rbCIF.Enabled = !camposPreenchidos;
            rbFOB.Enabled = !camposPreenchidos;
            txtValorFrete.Enabled = !camposPreenchidos;
            txtValorSeguro.Enabled = !camposPreenchidos;
            txtOutrasDespesas.Enabled = !camposPreenchidos;

            txtCodProduto.Enabled = !camposPreenchidos;
            txtQtdeProduto.Enabled = !camposPreenchidos;
            txtPrecoProd.Enabled = !camposPreenchidos;
            txtDescontoProd.Enabled = !camposPreenchidos;
            dataGridViewProdutos.Enabled = !camposPreenchidos;
            btnConsultaProduto.Enabled = !camposPreenchidos;
            btnExcluirProduto.Enabled = !camposPreenchidos;

        }

        private void txtNroNota_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNroNota.Texts))
            {
                return;
            }
            //remove os zeros à esquerda e verifica se o valor é 0 ou se foi digitado apenas zeros
            if (string.IsNullOrWhiteSpace(txtNroNota.Texts.TrimStart('0')))
            {
                MessageBox.Show("O número da nota não pode ser 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroNota.Focus();
            } else
            {
                VerificaNotaExistente();
                VerificaCamposPreenchidosNF();
            }
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelo.Texts))
            {
                return;
            }
            //remove os zeros à esquerda e verifica se o valor é 0 ou se foi digitado apenas zeros
            if (string.IsNullOrWhiteSpace(txtModelo.Texts.TrimStart('0')))
            {
                MessageBox.Show("O modelo da nota não pode ser 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
            }
            else
            {
                VerificaNotaExistente();
                VerificaCamposPreenchidosNF();
            }
        }

        private void txtSerie_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerie.Texts))
            {
                return;
            }
            //remove os zeros à esquerda e verifica se o valor é 0 ou se foi digitado apenas zeros
            if (string.IsNullOrWhiteSpace(txtSerie.Texts.TrimStart('0')))
            {
                MessageBox.Show("A série da nota não pode ser 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerie.Focus();
            }
            else
            {
                VerificaNotaExistente();
                VerificaCamposPreenchidosNF();
            }
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            DateTime dataEmissao;
            string dataE = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            bool dataValida = DateTime.TryParse(txtDataEmissao.Texts, out dataEmissao);

            if (!string.IsNullOrEmpty(dataE))
            {
                if (!dataValida)
                {
                    MessageBox.Show("Data de Emissão inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataEmissao.Focus();
                    return;
                }

                if (!VerificarDataMenorOuIgualHoje(dataEmissao, "Emissão"))
                {
                    txtDataEmissao.Focus();
                    return;
                }

                //ver se a data de emissão não ultrapassa 5 anos no passado
                DateTime dataLimite = DateTime.Today.AddYears(-5);
                if (dataEmissao < dataLimite)
                {
                    MessageBox.Show("A data de emissão não pode ser superior a 5 anos no passado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataEmissao.Focus();
                    return;
                }
            }
        }

        private void limpaCamposProdutos()
        {
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtUN.Clear();
            txtQtdeProduto.Clear();
            txtPrecoProd.Clear();
            txtDescontoProd.Clear();
        }
        private void VerificaNotaExistente()
        {
            if (int.TryParse(txtNroNota.Texts, out int numeroNota) &&
                !string.IsNullOrWhiteSpace(txtModelo.Texts) &&
                !string.IsNullOrWhiteSpace(txtSerie.Texts) &&
                int.TryParse(txtCodFornecedor.Texts, out int idFornecedor))
            {
                bool notaExiste = notaCompraController.ExisteNota(numeroNota, txtModelo.Texts, txtSerie.Texts, idFornecedor);

                txtDataEmissao.Enabled = !notaExiste;
                txtDataChegada.Enabled = !notaExiste;
            }
            else
            {
                txtDataEmissao.Enabled = false;
                txtDataChegada.Enabled = false;
            }
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

                    //verificação para desconto, assumindo 0 se estiver vazio ou nulo
                    decimal descontoProd = string.IsNullOrEmpty(txtDescontoProd.Texts) ? 0 : Convert.ToDecimal(txtDescontoProd.Texts);
                    decimal precoLiquido = precoUN - descontoProd;

                    bool produtoJaAdicionado = false;

                    //verifica se o produto já foi adicionado
                    foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
                    {
                        if (row.Cells["idProduto"].Value != null && (int)row.Cells["idProduto"].Value == idProduto)
                        {
                            decimal precoExistente = (decimal)row.Cells["PrecoUN"].Value;
                            decimal descontoExistente = (decimal)row.Cells["DescontoProd"].Value; // Supondo que o desconto está em uma coluna chamada "desconto"

                            if (precoExistente == precoUN && descontoExistente == descontoProd)
                            {
                                //atualiza a quantidade se o preço e desconto forem os mesmos
                                int qtdeExistente = (int)row.Cells["quantidadeProduto"].Value;
                                row.Cells["quantidadeProduto"].Value = qtdeExistente + qtdeProduto;
                                row.Cells["precoTotal"].Value = (qtdeExistente + qtdeProduto) * precoLiquido;
                                produtoJaAdicionado = true;
                                break;
                            }
                            else
                            {
                                //bloqueia se o preço ou desconto forem diferentes
                                if (precoExistente != precoUN)
                                {
                                    MessageBox.Show("Este produto já foi adicionado com um preço diferente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (descontoExistente != descontoProd)
                                {
                                    MessageBox.Show("Este produto já foi adicionado com um desconto diferente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                produtoJaAdicionado = true;
                                break;
                            }
                        }
                    }

                    //adiciona uma nova linha se o produto não foi encontrado
                    if (!produtoJaAdicionado)
                    {
                        decimal precoTotal = qtdeProduto * precoLiquido;
                        dataGridViewProdutos.Rows.Add(idProduto, produto, unidade, qtdeProduto, precoUN, descontoProd, precoLiquido, precoTotal);
                    }

                    atualizaTotalProdutos();
                    atualizaTotalPagar();
                    limpaCamposProdutos();
                    dataGridViewProdutos.Sort(dataGridViewProdutos.Columns["idProduto"], ListSortDirection.Ascending);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
                }
            }
        }

        private void atualizaTotalProdutos()
        {
            decimal subtotalProd = 0;

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows) //percorre as linhas do dgv
            {
                subtotalProd += Convert.ToDecimal(row.Cells["precoTotal"].Value); //add os valores da coluna precoProduto a variavel
            }
            txtTotalProdutos.Texts = subtotalProd.ToString("F2"); //att o campo com 2 casas decimais
        }

        private void atualizaTotalPagar()
        {
            decimal totalProdutos = string.IsNullOrWhiteSpace(txtTotalProdutos.Texts) ? 0 : Convert.ToDecimal(txtTotalProdutos.Texts);
            frete = string.IsNullOrWhiteSpace(txtValorFrete.Texts) ? 0 : Convert.ToDecimal(txtValorFrete.Texts);
            seguro = string.IsNullOrWhiteSpace(txtValorSeguro.Texts) ? 0 : Convert.ToDecimal(txtValorSeguro.Texts);
            outrasDespesas = string.IsNullOrWhiteSpace(txtOutrasDespesas.Texts) ? 0 : Convert.ToDecimal(txtOutrasDespesas.Texts);

            decimal total = totalProdutos + frete + seguro + outrasDespesas;

            txtTotalPagar.Texts = total.ToString("F2");
        }

        private void txtValorFrete_Leave(object sender, EventArgs e)
        {
            txtValorFrete.Texts = FormataPreco(txtValorFrete.Texts);
            
            if (string.IsNullOrEmpty(txtValorFrete.Texts))
            {
                txtValorFrete.Texts = "0,00";
            }

            VerificaCamposPreenchidosFrete();
            atualizaTotalPagar();
        }

        private void txtValorSeguro_Leave(object sender, EventArgs e)
        {
            txtValorSeguro.Texts = FormataPreco(txtValorSeguro.Texts);
            if (string.IsNullOrEmpty(txtValorSeguro.Texts))
            {
                txtValorSeguro.Texts = "0,00";
            }
            VerificaCamposPreenchidosFrete();
            atualizaTotalPagar();
        }

        private void txtOutrasDespesas_Leave(object sender, EventArgs e)
        {
            txtOutrasDespesas.Texts = FormataPreco(txtOutrasDespesas.Texts);
            if (string.IsNullOrEmpty(txtOutrasDespesas.Texts))
            {
                txtOutrasDespesas.Texts = "0,00";
            }
            VerificaCamposPreenchidosFrete();
            atualizaTotalPagar();
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
                    atualizaTotalProdutos();
                    atualizaTotalPagar();
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

        private void btnAddCondPag_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodCondPag.Texts))
            {
                CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
                if (condPagamento != null)
                {
                    juros = condPagamento.juros;
                    multa = condPagamento.multa;
                    descontos = condPagamento.desconto;
                    exibirParcelasDGV(condPagamento.Parcelas);
                }
            }
        }

        private void rbCIF_CheckedChanged(object sender, EventArgs e)
        {
            isCIF = rbCIF.Checked;
            txtValorFrete.Enabled = false;
            txtValorFrete.Texts = "0";
            atualizaTotalPagar();
        }

        private void rbFOB_CheckedChanged(object sender, EventArgs e)
        {
            isCIF = !rbFOB.Checked;
            if (NumeroNota != -1 && Modelo != -1 && Serie != -1 && IdFornecedor != -1)
                txtValorFrete.Enabled = false;
            else
                txtValorFrete.Enabled = true;
            txtValorFrete.Texts = "0";
            atualizaTotalPagar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar esta nota?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string dataCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(dataCancelamento))
                {
                    try
                    {
                        bool sucesso = notaCompraController.CancelarNotaCompra(NumeroNota, Modelo, Serie, IdFornecedor);

                        if (sucesso)
                        {
                            MessageBox.Show("Nota cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (ParcelaPagaException ex)
                    {
                        //mensagem para parcelas pagas
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        //tratamento de outros erros
                        MessageBox.Show("Erro ao cancelar a nota: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Esta nota já foi cancelada anteriormente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CadastroNotaCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaNotaCompra)this.Owner).AtualizarConsultaNotaCompra(false);
        }

        private void dataGridViewProdutos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            VerificaProdutos();
        }

        private void dataGridViewProdutos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            VerificaProdutos();
        }

        private void txtDataChegada_Leave(object sender, EventArgs e)
        {
            string dChegada = new string(txtDataChegada.Texts.Where(char.IsDigit).ToArray());
            string dEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            if (!string.IsNullOrEmpty(dChegada) && !string.IsNullOrEmpty(dEmissao))
            {
                DateTime dataEmissao;
                DateTime dataChegada;
                DateTime dataHoje = DateTime.Now;

                bool dataEmissaoValida = DateTime.TryParse(txtDataEmissao.Texts, out dataEmissao);
                bool dataChegadaValida = DateTime.TryParse(txtDataChegada.Texts, out dataChegada);

                if (dataEmissaoValida && dataChegadaValida)
                {
                    if (dataChegada < dataEmissao || dataChegada > dataHoje)
                    {
                        MessageBox.Show("Data de chegada inválida! A data de chegada deve ser maior ou igual à data de emissão e menor ou igual à data de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDataChegada.Focus();
                    }
                    else
                    {
                        VerificaCamposPreenchidosNF();
                    }
                }
                else
                {
                    MessageBox.Show("Data de emissão ou data de chegada inválida! Verifique os valores inseridos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataChegada.Focus();
                }
            }
        }

        private void txtPrecoProd_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrecoProd.Texts))
            {
                try
                {
                    txtPrecoProd.Texts = FormataPreco(txtPrecoProd.Texts);

                    //verifica se o valor é maior que zero
                    if (decimal.TryParse(txtPrecoProd.Texts, out decimal preco) && preco > 0)
                    {
                        //valor é válido e maior que zero
                    }
                    else
                    {
                        MessageBox.Show("O preço deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrecoProd.Focus();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecoProd.Focus();
                }
            }
        }

        private void txtNroNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtValorFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtValorSeguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtOutrasDespesas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtQtdeProduto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQtdeProduto.Texts))
            {
                return;
            }
            //remove os zeros à esquerda e verifica se o valor é 0 ou se foi digitado apenas zeros
            if (string.IsNullOrWhiteSpace(txtQtdeProduto.Texts.TrimStart('0')))
            {
                MessageBox.Show("A quantidade não pode ser 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdeProduto.Focus();
            }
        }

        private void txtDescontoProd_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescontoProd.Texts))
            {
                try
                {
                    txtDescontoProd.Texts = FormataPreco(txtDescontoProd.Texts);

                    if (decimal.TryParse(txtDescontoProd.Texts, out decimal desconto) &&
                        decimal.TryParse(txtPrecoProd.Texts, out decimal preco))
                    {
                        if (desconto >= preco)
                        {
                            MessageBox.Show("O desconto não pode ser maior ou igual ao preço do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDescontoProd.Focus();
                            txtDescontoProd.Clear();
                            return;
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescontoProd.Focus();
                }
            }
        }

        private void txtDescontoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void CalcularPrecoTotalProd()
        {
            if (decimal.TryParse(txtQtdeProduto.Texts, out decimal quantidade) &&
        decimal.TryParse(txtPrecoProd.Texts, out decimal preco))
            {
                decimal desconto = decimal.TryParse(txtDescontoProd.Texts, out decimal descontoVal) ? descontoVal : 0;

                decimal precoTotal = quantidade * (preco - desconto);
                txtPrecoProdTotal.Texts = precoTotal.ToString("F2"); 
            }
            else
            {
                txtPrecoProdTotal.Texts = "0.00"; 
            }
        }

        private void txtQtdeProduto__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtQtdeProduto.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtQtdeProduto.Texts = System.Text.RegularExpressions.Regex.Replace(txtQtdeProduto.Texts, "[^0-9]", "");
            }
            CalcularPrecoTotalProd();
            dataGridViewParcelas.Rows.Clear();
        }

        private void txtPrecoProd__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrecoProd.Texts, "^[0-9.,]*$"))
            {
                txtPrecoProd.Texts = System.Text.RegularExpressions.Regex.Replace(txtPrecoProd.Texts, "[^0-9.,]", "");
            }
            CalcularPrecoTotalProd();
            dataGridViewParcelas.Rows.Clear();
        }

        private void txtDescontoProd__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDescontoProd.Texts, "^[0-9.,]*$"))
            {
                txtDescontoProd.Texts = System.Text.RegularExpressions.Regex.Replace(txtDescontoProd.Texts, "[^0-9.,]", "");
            }
            CalcularPrecoTotalProd();
            dataGridViewParcelas.Rows.Clear();
        }

        private void txtValorFrete__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtValorFrete.Texts, "^[0-9.,]*$"))
            {
                txtValorFrete.Texts = System.Text.RegularExpressions.Regex.Replace(txtValorFrete.Texts, "[^0-9.,]", "");
            }
            dataGridViewParcelas.Rows.Clear();
        }

        private void txtValorSeguro__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtValorSeguro.Texts, "^[0-9.,]*$"))
            {
                txtValorSeguro.Texts = System.Text.RegularExpressions.Regex.Replace(txtValorSeguro.Texts, "[^0-9.,]", "");
            }
            dataGridViewParcelas.Rows.Clear();
        }

        private void txtOutrasDespesas__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtOutrasDespesas.Texts, "^[0-9.,]*$"))
            {
                txtOutrasDespesas.Texts = System.Text.RegularExpressions.Regex.Replace(txtOutrasDespesas.Texts, "[^0-9.,]", "");
            }
            dataGridViewParcelas.Rows.Clear();
        }

        private void txtCodProduto__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodProduto.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtCodProduto.Texts = System.Text.RegularExpressions.Regex.Replace(txtCodProduto.Texts, "[^0-9]", "");
            }
            dataGridViewParcelas.Rows.Clear();
        }

        private void txtNroNota__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNroNota.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtNroNota.Texts = System.Text.RegularExpressions.Regex.Replace(txtNroNota.Texts, "[^0-9]", "");
            }
        }

        private void txtModelo__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtModelo.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtModelo.Texts = System.Text.RegularExpressions.Regex.Replace(txtModelo.Texts, "[^0-9]", "");
            }
        }

        private void txtSerie__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSerie.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtSerie.Texts = System.Text.RegularExpressions.Regex.Replace(txtSerie.Texts, "[^0-9]", "");
            }

        }

        private void txtCodFornecedor__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodFornecedor.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtCodFornecedor.Texts = System.Text.RegularExpressions.Regex.Replace(txtCodFornecedor.Texts, "[^0-9]", "");
            }
        }

        private void txtCodCondPag__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodCondPag.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtCodCondPag.Texts = System.Text.RegularExpressions.Regex.Replace(txtCodCondPag.Texts, "[^0-9]", "");
            }
        }
    }
}
