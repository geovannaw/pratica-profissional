using Sistema_Vendas.Controller;
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
        NotaCompraController<NotaCompraModel> notaCompraController;

        decimal precoUNProduto;

        decimal frete;
        decimal seguro;
        decimal outrasDespesas;

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

            //desativa o DataGridView
            dataGridViewProdutos.Enabled = false;
            dataGridViewParcelas.Enabled = false;

            //desativa os RadioButtons
            rbCIF.Enabled = false;
            rbFOB.Enabled = false;

            //desativa o GroupBox
            groupBox2.Enabled = false;
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
            dataGridViewProdutos.Enabled = false;
            dataGridViewParcelas.Enabled = false;

            //desativa os RadioButtons
            rbCIF.Enabled = false;
            rbFOB.Enabled = false;

            //desativa o GroupBox
            groupBox2.Enabled = false;
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
            if (!CampoObrigatorio(txtNroNota.Texts))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DateTime.TryParse(txtDataEmissao.Texts, out DateTime dataEmissao);
                    DateTime.TryParse(txtDataChegada.Texts, out DateTime dataChegada);

                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    NotaCompraModel notaCompra = new NotaCompraModel
                    {
                        numeroNota = numeroNota,
                        modelo = modelo,
                        serie = serie,
                        idFornecedor = idFornecedor,
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
                        Produtos = obtemProdutos(valorFrete, valorSeguro, outrasDespesas, totalProdutos),
                    };

                    if (NumeroNota == -1 && Modelo == -1 && Serie == -1 && IdFornecedor == -1)
                        notaCompraController.Salvar(notaCompra);
                        notaCompraController.AtualizarProdutosNotaCompra(notaCompra);

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar a Nota de Compra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<NotaCompra_ProdutoModel> obtemProdutos(decimal valorFrete, decimal valorSeguro, decimal outrasDespesas, decimal totalProdutos)
        {
            List<NotaCompra_ProdutoModel> produtos = new List<NotaCompra_ProdutoModel>();

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
            {
                decimal precoUN = Convert.ToDecimal(row.Cells["PrecoUN"].Value);
                decimal quantidadeProduto = Convert.ToDecimal(row.Cells["quantidadeProduto"].Value);
                decimal precoTotalProd = precoUN * quantidadeProduto;

                // Calcular o Rateio e arredondar para 4 casas decimais
                decimal rateio = Math.Round(precoTotalProd / totalProdutos, 4);

                // Calcular o Custo do Produto e arredondar para 4 casas decimais
                decimal custoProd = Math.Round((valorFrete + valorSeguro + outrasDespesas) * rateio, 4);

                // Calcular o Custo Médio do Produto e arredondar para 4 casas decimais
                decimal custoMedio = Math.Round((precoTotalProd + custoProd) / quantidadeProduto, 4);

                // Se custo médio for igual ao preço unitário, considerar apenas o preço unitário
                if (custoProd == 0)
                {
                    custoMedio = Math.Round(precoUN, 4);
                }

                NotaCompra_ProdutoModel produto = new NotaCompra_ProdutoModel
                {
                    quantidadeProduto = Convert.ToInt32(row.Cells["quantidadeProduto"].Value),
                    precoProduto = Math.Round(precoUN, 4),
                    idProduto = Convert.ToInt32(row.Cells["idProduto"].Value),
                    rateio = rateio,
                    custoMedio = custoMedio,
                };

                produtos.Add(produto);
            }

            return produtos;
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
            VerificaNotaExistente();
            VerificaCamposPreenchidosNF();
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
                    precoUNProduto = produto.precoVenda;
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
                    dataGridViewProdutos.Rows.Add(
                        produto.idProduto,
                        produtoDetalhes.Produto,
                        produtoDetalhes.Unidade,
                        produto.quantidadeProduto,
                        produto.precoProduto,
                        (produto.quantidadeProduto * produto.precoProduto)
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
                foreach (var parcela in parcelas)
                {
                    string formaPagamento = condicaoPagamentoController.GetFormaPagByParcelaId(parcela.idParcela);
                    DateTime dataParcela = dataEmissao.AddDays(parcela.dias);
                    decimal valorParcela = (valorTotalNota * parcela.porcentagem) / 100;

                    dataGridViewParcelas.Rows.Add(
                        txtNroNota.Texts + "/" + parcela.numeroParcela,
                        formaPagamento,
                        dataParcela.ToString("dd/MM/yyyy"),
                        valorParcela.ToString("C2")
                    );
                }
            }
            else
            {
                MessageBox.Show("Data de emissão inválida.");
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
            }
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
            dataGridViewProdutos.Enabled = !camposPreenchidos;
        }
        private void VerificaCamposPreenchidosCondPagamento()
        {
            bool camposPreenchidos = !string.IsNullOrEmpty(txtCodCondPag.Texts);

            groupBox2.Enabled = !camposPreenchidos;
            rbCIF.Enabled = !camposPreenchidos;
            rbFOB.Enabled = !camposPreenchidos;
            txtValorFrete.Enabled = !camposPreenchidos;
            txtValorSeguro.Enabled = !camposPreenchidos;
            txtOutrasDespesas.Enabled = !camposPreenchidos;

        }

        private void txtNroNota_Leave(object sender, EventArgs e)
        {
            VerificaNotaExistente();
            VerificaCamposPreenchidosNF();
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            VerificaNotaExistente();
            VerificaCamposPreenchidosNF();
        }

        private void txtSerie_Leave(object sender, EventArgs e)
        {
            VerificaNotaExistente();
            VerificaCamposPreenchidosNF();
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            DateTime dataEmissao;
            DateTime dataHoje = DateTime.Now;
            bool dataValida = DateTime.TryParse(txtDataEmissao.Texts, out dataEmissao);

            string dataE = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrWhiteSpace(dataE) && dataValida)
            {
                if (dataEmissao > dataHoje)
                {
                    MessageBox.Show("Data de emissão inválida! A data deve ser menor ou igual a hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataEmissao.Focus();
                    return;
                }
                VerificaCamposPreenchidosNF();
            }
            else if (string.IsNullOrWhiteSpace(dataE) || !dataValida)
            {
                //se estiver vazio ou com a máscara inicial, sai do método sem validação
                return;
            }
        }

        private void limpaCamposProdutos()
        {
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtUN.Clear();
            txtQtdeProduto.Clear();
            txtPrecoProd.Clear();
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
                    decimal precoTotal = Convert.ToDecimal(txtPrecoProd.Texts) * Convert.ToInt32(txtQtdeProduto.Texts);

                    dataGridViewProdutos.Rows.Add(idProduto, produto, unidade, qtdeProduto, precoUN, precoTotal); //add nova linha com os valores 
                    atualizaTotalProdutos();
                    atualizaTotalPagar();
                    dataGridViewProdutos.Sort(dataGridViewProdutos.Columns["idProduto"], ListSortDirection.Ascending);
                    limpaCamposProdutos();
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
            VerificaCamposPreenchidosFrete();
            atualizaTotalPagar();
        }

        private void txtValorSeguro_Leave(object sender, EventArgs e)
        {
            txtValorSeguro.Texts = FormataPreco(txtValorSeguro.Texts);
            VerificaCamposPreenchidosFrete();
            atualizaTotalPagar();
        }

        private void txtOutrasDespesas_Leave(object sender, EventArgs e)
        {
            txtOutrasDespesas.Texts = FormataPreco(txtOutrasDespesas.Texts);
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
            CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
            exibirParcelasDGV(condPagamento.Parcelas);
        }

        private void rbCIF_CheckedChanged(object sender, EventArgs e)
        {
            txtValorFrete.Enabled = false;
            txtValorFrete.Texts = "0";
        }

        private void rbFOB_CheckedChanged(object sender, EventArgs e)
        {
            txtValorFrete.Enabled = true;
            txtValorFrete.Texts = "0";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar esta nota?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            string dataCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(dataCancelamento))
                {
                    NotaCompraDAO notaCompraDAO = new NotaCompraDAO();
                    bool sucesso = notaCompraDAO.CancelarNotaCompra(NumeroNota, Modelo, Serie, IdFornecedor);

                    if (sucesso)
                    {
                        MessageBox.Show("Nota cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cancelar a nota.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
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
            if (!string.IsNullOrEmpty(txtDataChegada.Texts))
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
            txtPrecoProd.Texts = FormataPreco(txtPrecoProd.Texts);
        }
    }
}
