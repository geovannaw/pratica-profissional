using Mysqlx.Notice;
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
using static Sistema_Vendas.DAO.NotaVendaDAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sistema_Vendas.Views
{
    public partial class CadastroNotaVenda : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private ConsultaClientes consultaClientes;
        private ClienteController<ClienteModel> clienteController;
        private ConsultaCondicaoPagamento consultaCondicaoPagamento;
        private CondicaoPagamentoController<CondicaoPagamentoModel> condicaoPagamentoController;
        private ConsultaProdutos consultaProdutos;
        private ProdutoController<ProdutoModel> produtoController;
        private NotaVendaController<NotaVendaModel> notaVendaController;
        private ContasReceberController<ContasReceberModel> contasReceberController;

        int NumeroNota;
        int Modelo;
        int Serie;
        int IdCliente;

        decimal juros;
        decimal descontos;
        decimal multa;
        public CadastroNotaVenda()
        {
            InitializeComponent();
            consultaClientes = new ConsultaClientes();
            clienteController = new ClienteController<ClienteModel>();
            consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            condicaoPagamentoController = new CondicaoPagamentoController<CondicaoPagamentoModel>();
            consultaProdutos = new ConsultaProdutos();
            produtoController = new ProdutoController<ProdutoModel>();
            notaVendaController = new NotaVendaController<NotaVendaModel>();
            contasReceberController = new ContasReceberController<ContasReceberModel>();
            txtNroNota.Focus();

        }

        public void SetID(int numero, int modelo, int serie, int idCliente)
        {
            NumeroNota = numero;
            Modelo = modelo;
            Serie = serie;
            IdCliente = idCliente;
        }
        public override void LimparCampos()
        {
            NumeroNota = -1;
            Modelo = -1;
            Serie = -1;
            IdCliente = -1;

            base.LimparCampos();
            //limpa todos os campos de texto
            txtNroNota.Clear();
            txtModelo.Clear();
            txtSerie.Clear();
            txtDataEmissao.Clear();
            txtCodCliente.Clear();
            txtCliente.Clear();
            lblCancelada.Visible = false;
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtUN.Clear();
            txtDescontoProd.Clear();
            txtPrecoProdTotal.Clear();
            txtQtdeProduto.Clear();
            txtPrecoProd.Clear();
            txtCodCondPag.Clear();
            txtCondPag.Clear();
            txtTotalProdutos.Clear();
            txtTotalPagar.Clear();
            txtObservacao.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtDataCancelamento.Clear();
            txtPorcentagemDesconto.Clear();
            txtDesconto.Clear();
            txtUsuarioUltAlt.Clear();

            //limpa os DataGridViews
            dataGridViewProdutos.Rows.Clear();
            dataGridViewParcelas.Rows.Clear();

            Desbloqueia();
        }

        public void Desbloqueia()
        {
           // txtNroNota.Enabled = true;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
            txtCodCliente.Enabled = true;
            txtObservacao.Enabled = true;

            txtCodProduto.Enabled = false;
            txtProduto.Enabled = false;
            txtUN.Enabled = false;
            txtQtdeProduto.Enabled = false;
            txtDescontoProd.Enabled = false;
            txtPrecoProd.Enabled = false;
            txtCodCondPag.Enabled = false;
            txtCondPag.Enabled = false;
            txtTotalProdutos.Enabled = false;
            txtTotalPagar.Enabled = false;
            txtObservacao.Enabled = false;
            txtDataCadastro.Enabled = false;
            txtDataUltAlt.Enabled = false;
            txtDataCancelamento.Enabled = false;
            txtPorcentagemDesconto.Enabled = false;

            btnConsultaCliente.Enabled = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = false;
            txtDataCancelamento.Visible = false;
            lblDataCancelamento.Visible = false;

            dataGridViewProdutos.Enabled = true;
            dataGridViewParcelas.Enabled = true;

            btnExcluirProduto.Visible = true;
        }

        public void BloqueiaTudo()
        {
            //desativa todos os campos de texto
            txtNroNota.Enabled = false;
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtCodCliente.Enabled = false;
            txtCliente.Enabled = false;
            txtCodProduto.Enabled = false;
            txtProduto.Enabled = false;
            txtUN.Enabled = false;
            txtQtdeProduto.Enabled = false;
            txtDescontoProd.Enabled = false;
            txtPrecoProd.Enabled = false;
            txtCodCondPag.Enabled = false;
            txtCondPag.Enabled = false;
            txtTotalProdutos.Enabled = false;
            txtTotalPagar.Enabled = false;
            txtObservacao.Enabled = false;
            txtDataCadastro.Enabled = false;
            txtDataUltAlt.Enabled = false;
            txtDataCancelamento.Enabled = false;
            txtPorcentagemDesconto.Enabled = false;

            //desativa todos os botões
            btnConsultaCliente.Enabled = false;
            btnConsultaProduto.Enabled = false;
            btnConsultaCondPag.Enabled = false;

            //desativa o DataGridView
            dataGridViewProdutos.Enabled = true;
            dataGridViewParcelas.Enabled = true;

            btnExcluirProduto.Visible = false;
        }
        public override void Carrega()
        {
            base.Carrega();

            var notaVenda = notaVendaController.GetNotaById(NumeroNota, Modelo, Serie, IdCliente);
            if (notaVenda != null)
            {
                txtNroNota.Texts = notaVenda.numeroNota.ToString();
                txtModelo.Texts = notaVenda.modelo.ToString();
                txtSerie.Texts = notaVenda.serie.ToString();
                txtDataEmissao.Texts = notaVenda.dataEmissao.ToString();
                txtCodCliente.Texts = notaVenda.idCliente.ToString();
                txtTotalPagar.Texts = notaVenda.totalPagar.ToString();
                txtTotalProdutos.Texts = notaVenda.totalProdutos.ToString();
                txtPorcentagemDesconto.Texts = notaVenda.porcentagemDesconto.ToString();
                txtCodCondPag.Texts = notaVenda.idCondPagamento.ToString();
                txtObservacao.Texts = notaVenda.observacao.ToString();
                txtDataCadastro.Texts = notaVenda.dataCadastro.ToString();
                txtDataUltAlt.Texts = notaVenda.dataUltAlt.ToString();
                txtDataCancelamento.Texts = notaVenda.dataCancelamento.ToString();
                txtUsuarioUltAlt.Texts = notaVenda.usuario;

                ClienteModel cliente = clienteController.GetById(int.Parse(txtCodCliente.Texts));
                CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));

                if (cliente != null)
                    txtCliente.Texts = cliente.cliente_razao_social;
                if (condPagamento != null)
                    txtCondPag.Texts = condPagamento.condicaoPagamento;

                if (notaVenda.dataCancelamento != null)
                {
                    lblCancelada.Visible = true;
                    lblDataCancelamento.Visible = true;
                    txtDataCancelamento.Visible = true;
                }
                else
                {
                    lblCancelada.Visible = false;
                    lblDataCancelamento.Visible = false;
                    txtDataCancelamento.Visible = false;
                }
                exibirProdutosDGV(notaVenda.Produtos);
                exibirParcelasDGV(condPagamento.Parcelas);
            }
        }
        public override void Salvar()
        {
            string dEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
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
            else if (!CampoObrigatorio(txtCodCliente.Texts))
            {
                MessageBox.Show("Campo Código Cliente é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCliente.Focus();
            }
            else if (!CampoObrigatorio(dEmissao))
            {
                MessageBox.Show("Campo Data Emissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataEmissao.Focus();
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
                txtCodCondPag.Focus();
            }
            else
            {
                try
                {
                    int numeroNota = Convert.ToInt32(txtNroNota.Texts);
                    int modelo = Convert.ToInt32(txtModelo.Texts);
                    int serie = Convert.ToInt32(txtSerie.Texts);
                    int idCliente = Convert.ToInt32(txtCodCliente.Texts);
                    decimal totalProdutos = Convert.ToDecimal(txtTotalProdutos.Texts);
                    decimal totalPagar = Convert.ToDecimal(txtTotalPagar.Texts);
                    decimal porcentagemDesconto = Convert.ToDecimal(txtPorcentagemDesconto.Texts);
                    int idCondPagamento = Convert.ToInt32(txtCodCondPag.Texts);
                    string observacao = txtObservacao.Texts;
                    DateTime.TryParse(txtDataEmissao.Texts, out DateTime dataEmissao);
                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    string usuario = Program.usuarioLogado;
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    NotaVendaModel notaVenda = new NotaVendaModel
                    {
                     //   numeroNota = numeroNota,
                        modelo = modelo,
                        serie = serie,
                        idCliente = idCliente,
                        totalProdutos = totalProdutos,
                        totalPagar = totalPagar,
                        porcentagemDesconto = porcentagemDesconto,
                        idCondPagamento = idCondPagamento,
                        dataEmissao = dataEmissao,
                        observacao = observacao,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        usuario = usuario,
                        Produtos = obtemProdutos(totalProdutos),
                    };

                    notaVendaController.Salvar(notaVenda);
                    notaVendaController.AtualizarProdutosNotaVenda(notaVenda);


                    try //salvar contas a receber
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

                            ContasReceberModel contaReceber = new ContasReceberModel
                            {
                                numeroNota = numeroNota,
                                modelo = modelo,
                                serie = serie,
                                idCliente = idCliente,
                                dataEmissao = dataEmissao,
                                idFormaPagamento = idFormaPagamento,
                                parcela = parcela,
                                valorParcela = valorParcela,
                                dataVencimento = dataVencimento,
                                dataRecebimento = null,
                                juros = juros,
                                multa = multa,
                                desconto = descontos,
                                valorRecebido = null,
                                dataCancelamento = null,
                                observacao = observacao,
                                usuario = usuario,
                                dataCadastro = DateTime.Now,
                                dataUltAlt = DateTime.Now
                            };

                            contasReceberController.Salvar(contaReceber);
                        }
                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show("Erro ao converter valores: " + fe.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar as Contas a Receber: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar a Nota de Venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private List<NotaVenda_ProdutoModel> obtemProdutos(decimal totalProdutos)
        {
            List<NotaVenda_ProdutoModel> produtos = new List<NotaVenda_ProdutoModel>();

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
            {
                decimal precoUN = Convert.ToDecimal(row.Cells["PrecoUN"].Value);
                decimal quantidadeProduto = Convert.ToDecimal(row.Cells["quantidadeProduto"].Value);
                decimal precoTotalProd = precoUN * quantidadeProduto;

                NotaVenda_ProdutoModel produto = new NotaVenda_ProdutoModel
                {
                    quantidadeProduto = Convert.ToInt32(row.Cells["quantidadeProduto"].Value),
                    precoProduto = Math.Round(precoUN, 4),
                    descontoProd = row.Cells["DescontoProd"].Value != null ? Convert.ToDecimal(row.Cells["DescontoProd"].Value) : (decimal?)null,
                    idProduto = Convert.ToInt32(row.Cells["idProduto"].Value),
                };

                produtos.Add(produto);
            }
            
            return produtos;
        }
        private void exibirProdutosDGV(List<NotaVenda_ProdutoModel> produtos)
        {
            dataGridViewProdutos.Rows.Clear();

            foreach (var produto in produtos)
            {
                ProdutoModel produtoDetalhes = notaVendaController.GetProdutoPorId(produto.idProduto);

                decimal descontoProd = produto.descontoProd ?? 0;
                decimal precoLiquido = produto.precoProduto - descontoProd;

                if (produtoDetalhes != null)
                {
                    dataGridViewProdutos.Rows.Add(
                        produto.idProduto,
                        produtoDetalhes.Produto,
                        produtoDetalhes.Unidade,
                        produto.quantidadeProduto,
                        produto.precoProduto,
                        descontoProd,
                        precoLiquido,
                        (produto.quantidadeProduto * precoLiquido)
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
        private void CadastroNotaVenda_Load(object sender, EventArgs e)
        {
            if (NumeroNota != -1 && Modelo != -1 && Serie != -1 && IdCliente != -1)
            {
                btnCancelar.Visible = true;
                btnSalvar.Visible = false;
            }
            else
            {
                txtDataEmissao.Texts = DateTime.Now.ToString();
                txtPorcentagemDesconto.Texts = "0";
                txtSerie.Texts = "1";
                txtModelo.Texts = "65";
                int novoCodigo = notaVendaController.GetUltimoNumeroNota() + 1;
                txtNroNota.Texts = novoCodigo.ToString();
            }
        }
        private void VerificaNotaExistente()
        {
            if (int.TryParse(txtNroNota.Texts, out int numeroNota) &&
                !string.IsNullOrWhiteSpace(txtModelo.Texts) &&
                !string.IsNullOrWhiteSpace(txtSerie.Texts) &&
                int.TryParse(txtCodCliente.Texts, out int idCliente))
            {
                bool notaExiste = notaVendaController.ExisteNota(numeroNota, txtModelo.Texts, txtSerie.Texts, idCliente);

                if (notaExiste)
                {
                    MessageBox.Show("Nota de Venda já existe! Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodProduto.Enabled = !notaExiste;
                    txtQtdeProduto.Enabled = !notaExiste;
                    txtDescontoProd.Enabled = !notaExiste;
                    btnConsultaProduto.Enabled = !notaExiste;
                    dataGridViewProdutos.Enabled = !notaExiste;
                    txtPorcentagemDesconto.Enabled = !notaExiste;
                }
            }
        }
        private void VerificaCamposPreenchidosNF()
        {
            string dataEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            bool camposPreenchidos = !string.IsNullOrEmpty(txtNroNota.Texts) &&
                                     !string.IsNullOrEmpty(txtModelo.Texts) &&
                                     !string.IsNullOrEmpty(txtSerie.Texts) &&
                                     !string.IsNullOrEmpty(dataEmissao) &&
                                     !string.IsNullOrEmpty(txtCodCliente.Texts);

            txtCodProduto.Enabled = camposPreenchidos;
            txtQtdeProduto.Enabled = camposPreenchidos;
            txtDescontoProd.Enabled = camposPreenchidos;
            btnConsultaProduto.Enabled = camposPreenchidos;
            dataGridViewProdutos.Enabled = camposPreenchidos;
            txtPorcentagemDesconto.Enabled = camposPreenchidos;
        }
        private void VerificaProdutos()
        {
            if (NumeroNota == -1 && Modelo == -1 && Serie == -1 && IdCliente == -1)
            {
                bool habilitar = dataGridViewProdutos.Rows.Count > 0;

                //desabilita os campos com infos da nota
               // txtNroNota.Enabled = !habilitar;
                txtModelo.Enabled = !habilitar;
                txtSerie.Enabled = !habilitar;
                txtCodCliente.Enabled = !habilitar;
                btnConsultaCliente.Enabled = !habilitar;

                txtCodCondPag.Enabled = habilitar;
                btnConsultaCondPag.Enabled = habilitar;
                dataGridViewParcelas.Enabled = habilitar;
            }
        }
        private void VerificaCamposPreenchidosCondPagamento()
        {
            bool camposPreenchidos = !string.IsNullOrEmpty(txtCodCondPag.Texts);

            txtCodProduto.Enabled = !camposPreenchidos;
            txtQtdeProduto.Enabled = !camposPreenchidos;
            dataGridViewProdutos.Enabled = !camposPreenchidos;
            txtPorcentagemDesconto.Enabled = !camposPreenchidos;
            btnConsultaProduto.Enabled = !camposPreenchidos;
        }

        private void txtNroNota_Leave(object sender, EventArgs e)
        {
            VerificaNotaExistente();
            VerificaCamposPreenchidosNF();
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtModelo.Texts))
            {
                if (txtModelo.Texts != "55" && txtModelo.Texts != "65")
                {
                    MessageBox.Show("O modelo da nota de venda deve ser 55 ou 65. Verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModelo.Focus();
                }
                else
                {
                    VerificaNotaExistente();
                    VerificaCamposPreenchidosNF();
                }
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

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCliente.Texts))
            {
                string cliente = clienteController.getCliente(int.Parse(txtCodCliente.Texts));
                if (cliente != null)
                {
                    txtCliente.Texts = cliente;

                    ClienteModel clienteDetalhes = clienteController.GetById(int.Parse(txtCodCliente.Texts));
                    if (clienteDetalhes != null)
                        txtCodCondPag.Texts = clienteDetalhes.idCondPagamento.ToString();
                    CondicaoPagamentoModel condPag = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
                    if (condPag != null)
                        txtCondPag.Texts = condPag.condicaoPagamento.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCliente.Focus();
                    txtCodCliente.Clear();
                    txtCliente.Clear();
                    txtCodCondPag.Clear();
                    txtCondPag.Clear();
                }
            }
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
            if (!dataValida)
            {
                MessageBox.Show("Data de emissão inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataEmissao.Focus();
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
            txtPrecoProdTotal.Clear();
            txtDescontoProd.Clear();
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

                    decimal precoTotal = precoLiquido * qtdeProduto;

                    //verificar saldo do produto
                    ProdutoModel produtoDetalhes = produtoController.GetById(idProduto);
                    if (produtoDetalhes != null)
                    {
                        bool produtoExistente = false;
                        int quantidadeAtualNoGrid = 0;
                        decimal descontoAtual = 0;

                        foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["idProduto"].Value) == idProduto)
                            {
                                quantidadeAtualNoGrid = Convert.ToInt32(row.Cells["quantidadeProduto"].Value);
                                descontoAtual = Convert.ToDecimal(row.Cells["DescontoProd"].Value); 
                                produtoExistente = true;
                                break;
                            }
                        }

                        int quantidadeTotal = quantidadeAtualNoGrid + qtdeProduto;

                        if (produtoDetalhes.Saldo >= quantidadeTotal)
                        {
                            if (produtoExistente)
                            {
                                //verifica se o desconto é o mesmo
                                if (descontoAtual != descontoProd)
                                {
                                    MessageBox.Show("Desconto do produto atual não corresponde ao desconto do produto já adicionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; 
                                }

                                //atualiza a quantidade e o preço total
                                foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
                                {
                                    if (Convert.ToInt32(row.Cells["idProduto"].Value) == idProduto)
                                    {
                                        int quantidadeAtual = Convert.ToInt32(row.Cells["quantidadeProduto"].Value);
                                        row.Cells["quantidadeProduto"].Value = quantidadeAtual + qtdeProduto;
                                        row.Cells["PrecoUN"].Value = precoUN;
                                        row.Cells["precoTotal"].Value = (quantidadeAtual + qtdeProduto) * precoLiquido;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                //adiciona nova linha
                                dataGridViewProdutos.Rows.Add(idProduto, produto, unidade, qtdeProduto, precoUN, descontoProd, precoLiquido, precoTotal);
                            }

                            atualizaTotalProdutos();
                            atualizaTotalPagar();
                            dataGridViewProdutos.Sort(dataGridViewProdutos.Columns["idProduto"], ListSortDirection.Ascending);
                            limpaCamposProdutos();
                        }
                        else
                        {
                            MessageBox.Show("Saldo insuficiente para o produto selecionado. Saldo disponível: " + produtoDetalhes.Saldo, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
            decimal subtotalProd = Convert.ToDecimal(txtTotalProdutos.Texts);
            decimal total = subtotalProd;

            decimal porcentagemDesconto = 0;
            decimal.TryParse(txtPorcentagemDesconto.Texts, out porcentagemDesconto);

            decimal valorDesconto = 0;
            if (porcentagemDesconto > 0)
            {
                valorDesconto = (total * porcentagemDesconto) / 100;
            }

            decimal totalComDesconto = total - valorDesconto;

            txtTotalPagar.Texts = totalComDesconto.ToString("F2");
            txtDesconto.Texts = valorDesconto.ToString("F2");
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
            adicionarCondPagamento();
        }

        private void adicionarCondPagamento()
        {
            CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
            juros = condPagamento.juros;
            multa = condPagamento.multa;
            descontos = condPagamento.desconto;
            exibirParcelasDGV(condPagamento.Parcelas);
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
                        bool sucesso = notaVendaController.CancelarNotaVenda(NumeroNota, Modelo, Serie, IdCliente);

                        if (sucesso)
                        {
                            MessageBox.Show("Nota cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cancelar a nota.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (ParcelaPagaException ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar cancelar a nota: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Esta nota já foi cancelada anteriormente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CadastroNotaVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaNotasVenda)this.Owner).AtualizarConsultaNotaVenda(false);
        }

        private void dataGridViewProdutos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            VerificaProdutos();
        }

        private void dataGridViewProdutos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            VerificaProdutos();
        }

        private void txtPorcentagemDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
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

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
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
                    txtCondPag.Clear();
                    txtCondPag.Clear();
                }
            }
            VerificaCamposPreenchidosCondPagamento();
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

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            consultaClientes.btnSair.Text = "Selecionar";
            consultaClientes.cbBuscaInativos.Visible = false;

            if (consultaClientes.ShowDialog() == DialogResult.OK)
            {
                var infosCliente = consultaClientes.Tag as Tuple<int, string, string>;
                if (infosCliente != null)
                {
                    int idCliente = infosCliente.Item1;
                    string cliente = infosCliente.Item2;

                    txtCodCliente.Texts = idCliente.ToString();
                    txtCliente.Texts = cliente;

                    ClienteModel clienteDetalhes = clienteController.GetById(idCliente);
                    if (clienteDetalhes != null)
                        txtCodCondPag.Texts = clienteDetalhes.idCondPagamento.ToString();
                    CondicaoPagamentoModel condPag = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
                    if (condPag != null)
                        txtCondPag.Texts = condPag.condicaoPagamento.ToString();
                }
            }
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
                    decimal precoVenda = infosProd.Item3;
                    string unidade = infosProd.Item4;

                    txtCodProduto.Texts = idProd.ToString();
                    txtProduto.Texts = produto;
                    txtUN.Texts = unidade;
                    txtPrecoProd.Texts = precoVenda.ToString();
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
                    txtPrecoProd.Texts = produto.Value.PrecoVenda.ToString();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado ou inativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodProduto.Focus();
                    txtCodProduto.Clear();
                    txtProduto.Clear();
                    txtUN.Clear();
                    txtPrecoProd.Clear();
                }
            }
        }
        public void atualizaDesconto()
        {
            if(!string.IsNullOrEmpty(txtPorcentagemDesconto.Texts))
            {
                decimal porcentagem = Convert.ToDecimal(txtPorcentagemDesconto.Texts);
                if (porcentagem <= 100)
                {
                    try
                    {
                        //verifica se o valor do txtTotal é válido e converte para decimal
                        if (decimal.TryParse(txtTotalProdutos.Texts, out decimal subtotalProd))
                        {
                            //atualiza o total considerando o desconto
                            atualizaTotalPagar();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira valores válidos para o total dos produtos.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void txtPorcentagemDesconto_Leave(object sender, EventArgs e)
        {
            atualizaDesconto();
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

        private void txtPrecoProd__TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoTotalProd();
        }

        private void txtDescontoProd__TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoTotalProd();
        }

        private void txtQtdeProduto__TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoTotalProd();
        }
    }
}
