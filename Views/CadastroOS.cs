using Mysqlx.Crud;
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
        private CondicaoPagamentoController<CondicaoPagamentoModel> condicaoPagamentoController;
        private ConsultaCondicaoPagamento consultaCondicaoPagamento;
        private NotaServicoController<NotaServicoModel> notaServicoController;
        private NotaVendaController<NotaVendaModel> notaVendaController;
        private ContasReceberController<ContasReceberModel> contasReceberController;
        private ConsultaFormasPagamento consultaFormasPagamento;

        decimal precoUNProduto;
        decimal precoUNServico;

        decimal juros;
        decimal descontos;
        decimal multa;

        string statusOS;

        int idFormaPag;

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
            condicaoPagamentoController = new CondicaoPagamentoController<CondicaoPagamentoModel>();
            consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            notaServicoController = new NotaServicoController<NotaServicoModel>();
            notaVendaController = new NotaVendaController<NotaVendaModel>();
            contasReceberController = new ContasReceberController<ContasReceberModel>();
            consultaFormasPagamento = new ConsultaFormasPagamento();
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
            txtSubtotalProdutos.Clear();
            txtSubtotalServicos.Clear();
            txtDesconto.Clear();
            txtPorcentagemDesconto.Clear();
            txtTotal.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtDataCancelamento.Clear();
            txtValorEntrada.Clear();
            txtValorRetirada.Clear();
            txtValorPendente.Clear();
            txtDataPrevista.Clear();
            txtUsuarioUltAlt.Clear();
            txtCodCondPag.Clear();
            txtCondPag.Clear();

            txtValorRetirada.Enabled = false;
            txtDataCancelamento.Visible = false;
            lblDataCancelamento.Visible = false;

            cbSituacao.Enabled = false;
            cbSituacao.Items.Clear();
            cbSituacao.Items.Add("PENDENTE");


            Desbloqueia();

            dataGridViewProdutos.Rows.Clear();
            dataGridViewServicos.Rows.Clear();

            limpaCamposProdutos();
            limpaCamposServicos();
        }

        public override void Desbloqueia()
        {
            base.Desbloqueia();
            txtValorEntrada.Enabled = true;
            txtCodCliente.Enabled = true;
            txtCodFuncionario.Enabled = true;
            txtCodProduto.Enabled = true;
            txtCodServico.Enabled = true;
            txtQtdeProduto.Enabled = true;
            txtQtdeServico.Enabled = true;
            txtDataPrevista.Enabled = true;
            txtDescontoProd.Enabled = true;
            txtDescontoServ.Enabled = true;
            txtObservacao.Enabled = true;

           // cbSituacao.Enabled = true;
            rbAtivo.Checked = true;

            btnConsultaCliente.Enabled = true;
            btnConsultaFuncionario.Enabled = true;
            btnConsultaProduto.Enabled = true;
            btnConsultaServico.Enabled = true;

            dataGridViewProdutos.Enabled = true;
            dataGridViewServicos.Enabled = true;

            btnCancelar.Visible = false;
        }

        public override void Bloqueia()
        {
            base.Bloqueia();
            txtCodCliente.Enabled = false;
            txtCodFuncionario.Enabled = false;
            txtCodProduto.Enabled=false;
            txtCodServico.Enabled=false;
            txtQtdeProduto.Enabled= false;
            txtQtdeServico.Enabled= false;
            txtDataPrevista.Enabled = false;
            txtValorEntrada.Enabled = false;
            txtDescontoProd.Enabled = false;
            txtDescontoServ.Enabled = false;
            txtObservacao.Enabled = false;

            txtValorRetirada.Enabled = (statusOS == "PRONTO");

            btnConsultaCliente.Enabled=false;
            btnConsultaFuncionario.Enabled=false;
            btnConsultaProduto.Enabled=false;
            btnConsultaServico.Enabled=false;

            dataGridViewProdutos.Enabled = false;
            dataGridViewServicos.Enabled = false;

            if (statusOS == "CANCELADO")
            {
                btnCancelar.Visible = false;
            }
            else
            {
                btnCancelar.Visible = true;
            }
            if (statusOS == "RETIRADO")
            {
                cbSituacao.Enabled = false;
            } else
            {
                cbSituacao.Enabled = true;
            }
        }

        private List<OS_ProdutoModel> obtemProdutos()
        {
            List<OS_ProdutoModel> produtos = new List<OS_ProdutoModel>(); 

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows) //percorrendo o dgv de produtos
            {
                OS_ProdutoModel produto = new OS_ProdutoModel //armazena os valores das linhas
                {
                    quantidadeProduto = Convert.ToInt32(row.Cells["quantidadeProduto"].Value),
                    precoProduto = Convert.ToDecimal(row.Cells["precoUNProd"].Value),
                    descontoProd = row.Cells["DescontoProd"].Value != null ? Convert.ToDecimal(row.Cells["DescontoProd"].Value) : (decimal?)null,
                    idProduto = Convert.ToInt32(row.Cells["idProduto"].Value),
                };
                produtos.Add(produto);
            }

            return produtos;
        }
        private List<OS_ServicoModel> obtemServicos()
        {
            List<OS_ServicoModel> servicos = new List<OS_ServicoModel>();

            foreach (DataGridViewRow row in dataGridViewServicos.Rows)
            {
                OS_ServicoModel servico = new OS_ServicoModel
                {
                    quantidadeServico = Convert.ToInt32(row.Cells["quantidadeServico"].Value),
                    precoServico = Convert.ToDecimal(row.Cells["precoUNServ"].Value), 
                    descontoServ = row.Cells["DescontoServ"].Value != null ? Convert.ToDecimal(row.Cells["DescontoServ"].Value) : (decimal?)null,
                    idServico = Convert.ToInt32(row.Cells["idServiço"].Value),
                };
                servicos.Add(servico);
            }

            return servicos;
        }

        private List<NotaServico_ServicoModel> obtemServicosNota(decimal totalServicos)
        {
            List<NotaServico_ServicoModel> servicos = new List<NotaServico_ServicoModel>();

            foreach (DataGridViewRow row in dataGridViewServicos.Rows)
            {
                decimal precoUN = Convert.ToDecimal(row.Cells["precoUNServ"].Value);
                int quantidadeServico = Convert.ToInt32(row.Cells["quantidadeServico"].Value);
                decimal descontoServ = Convert.ToDecimal(row.Cells["DescontoServ"].Value);
                decimal precoTotalServ = precoUN * quantidadeServico;

                NotaServico_ServicoModel servico = new NotaServico_ServicoModel
                {
                    quantidadeServico = quantidadeServico,
                    precoServico = Math.Round(precoUN, 4),
                    descontoServ = descontoServ,
                    idServico = Convert.ToInt32(row.Cells["idServiço"].Value),
                };

                servicos.Add(servico);
            }

            return servicos;
        }
        private List<NotaVenda_ProdutoModel> obtemProdutosNota(decimal totalProdutos)
        {
            List<NotaVenda_ProdutoModel> produtos = new List<NotaVenda_ProdutoModel>();

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
            {
                decimal precoUN = Convert.ToDecimal(row.Cells["precoUNProd"].Value);
                int quantidadeProduto = Convert.ToInt32(row.Cells["quantidadeProduto"].Value);
                decimal descontoProd = Convert.ToDecimal(row.Cells["DescontoProd"].Value);
                decimal precoTotalProd = precoUN * quantidadeProduto;

                NotaVenda_ProdutoModel produto = new NotaVenda_ProdutoModel
                {
                    quantidadeProduto = quantidadeProduto,
                    descontoProd = descontoProd,
                    precoProduto = Math.Round(precoUN, 4),
                    idProduto = Convert.ToInt32(row.Cells["idProduto"].Value),
                };

                produtos.Add(produto);
            }

            return produtos;
        }
        public override void Salvar()
        {
            decimal porcentagem = Convert.ToDecimal(txtPorcentagemDesconto.Texts);
            string dPrevista = new string(txtDataPrevista.Texts.Where(char.IsDigit).ToArray());
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
            else if (!CampoObrigatorio(txtValorEntrada.Texts))
            {
                MessageBox.Show("Campo Valor Entrada é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorEntrada.Focus();
            }
            else if (!CampoObrigatorio(dPrevista))
            {
                MessageBox.Show("Campo Data Prevista é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataPrevista.Focus();
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
                    decimal? valorRetirada = string.IsNullOrEmpty(txtValorRetirada.Texts) ? (decimal?)null : Convert.ToDecimal(txtValorRetirada.Texts);
                    decimal porcentagemDesconto = Convert.ToDecimal(txtPorcentagemDesconto.Texts);
                    string situacao = cbSituacao.Texts.ToString();
                    decimal total = Convert.ToDecimal(txtTotal.Texts);
                    decimal valorEntrada = Convert.ToDecimal(txtValorEntrada.Texts);
                    string observacao = txtObservacao.Texts;
                    int idCondPagamento = Convert.ToInt32(txtCodCondPag.Texts);
                    string usuario = Program.usuarioLogado;
                    DateTime.TryParse(txtDataOS.Texts, out DateTime dataOS);

                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime.TryParse(txtDataPrevista.Texts, out DateTime dataPrevista);

                    DateTime? dataEntrega = DateTime.TryParse(txtDataEntrega.Texts, out DateTime tempDataEntrega) ? tempDataEntrega : (DateTime?)null;
                    DateTime? dataCancelamento = DateTime.TryParse(txtDataCancelamento.Texts, out DateTime tempDataCancelamento) ? tempDataCancelamento : (DateTime?)null;

                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    OrdemServicoModel novaOS = new OrdemServicoModel
                    {
                        idCliente = codCliente,
                        idFuncionario = codFuncionario,
                        dataCancelamento = dataCancelamento,
                        dataPrevista = dataPrevista,
                        valorRetirada = valorRetirada,
                        porcentagemDesconto = porcentagemDesconto,
                        status = situacao,
                        precoTotal = total,
                        valorEntrada = valorEntrada,
                        dataEntrega = dataEntrega,
                        idCondPagamento = idCondPagamento,
                        data = dataOS,
                        observacao = observacao,
                        Ativo = isAtivo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        usuario = usuario,
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
                        consultaFormasPagamento.isFromOS = true;
                        consultaFormasPagamento.btnSair.Text = "Selecionar";
                        consultaFormasPagamento.Text = "Selecione a Forma de Pagamento do Valor de Entrada";
                        consultaFormasPagamento.ControlBox = false;
                        consultaFormasPagamento.cbBuscaInativos.Visible = false;

                        if (consultaFormasPagamento.ShowDialog() == DialogResult.OK)
                        {
                            var infosFormaPag = consultaFormasPagamento.Tag as Tuple<int, string>;
                            if (infosFormaPag != null)
                            {
                                idFormaPag = infosFormaPag.Item1;
                            }
                        }
                        int numeroOS = int.Parse(txtCodigo.Texts);
                        try
                        {
                            ContasReceberModel contaReceber = new ContasReceberModel
                            {
                                numeroNota = numeroOS,
                                modelo = 0,
                                serie = 0,
                                idCliente = codCliente,
                                dataEmissao = dataOS,
                                idFormaPagamento = idFormaPag,
                                parcela = 1,
                                valorParcela = valorEntrada,
                                dataVencimento = dataOS,
                                dataRecebimento = dataOS,
                                juros = juros,
                                multa = multa,
                                desconto = descontos,
                                valorRecebido = valorEntrada,
                                usuario = usuario,
                                dataCancelamento = null,
                                observacao = "REFERENTE A ORDEM DE SERVIÇO CÓDIGO " + txtCodigo.Texts,
                                dataCadastro = DateTime.Now,
                                dataUltAlt = DateTime.Now
                            };

                            contasReceberController.Salvar(contaReceber);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro ao salvar Conta a Receber: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            cbSituacao.Enabled = true;

            var ordemServico = ordemServicoController.GetById(idAlterar);
            if (ordemServico != null)
            {
                txtCodigo.Texts = ordemServico.idOrdemServico.ToString();
                txtCodCliente.Texts = ordemServico.idCliente.ToString();
                txtCodFuncionario.Texts = ordemServico.idFuncionario.ToString();
                txtValorRetirada.Texts = ordemServico.valorRetirada.ToString();
                txtValorEntrada.Texts = ordemServico.valorEntrada.ToString();
                txtDataPrevista.Texts = ordemServico.dataPrevista.ToString();
                txtDataCancelamento.Texts = ordemServico.dataCancelamento.ToString();
                txtDataOS.Texts = ordemServico.data.ToString();
                txtDataEntrega.Texts = ordemServico.dataEntrega.ToString();
                txtObservacao.Texts = ordemServico.observacao.ToString();
                txtTotal.Texts = ordemServico.precoTotal.ToString();
                txtPorcentagemDesconto.Texts = ordemServico.porcentagemDesconto.ToString();
                txtDataCadastro.Texts = ordemServico.dataCadastro.ToString();
                txtDataUltAlt.Texts = ordemServico.dataUltAlt.ToString();
                txtCodCondPag.Texts = ordemServico.idCondPagamento.ToString();
                rbAtivo.Checked = ordemServico.Ativo;
                txtUsuarioUltAlt.Texts = ordemServico.usuario;

                if (!cbSituacao.Items.Contains(ordemServico.status))
                {
                    cbSituacao.Items.Add(ordemServico.status);
                }
                cbSituacao.Texts = ordemServico.status;
                statusOS = ordemServico.status;

                FuncionarioModel funcionario = funcionarioController.GetById(int.Parse(txtCodFuncionario.Texts));
                ClienteModel clienteDetalhes = ordemServicoController.GetClientePorId(ordemServico.idCliente);
                CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
                txtCliente.Texts = clienteDetalhes.cliente_razao_social;
                txtCelular.Texts = clienteDetalhes.celular;
                txtCondPag.Texts = condPagamento.condicaoPagamento;

                if (funcionario != null)
                {
                    txtFuncionario.Texts = funcionario.funcionario;
                }
                
                if (statusOS == "PENDENTE")
                {
                    cbSituacao.Items.Clear();
                    cbSituacao.Items.Add("EM ANDAMENTO");
                }
                if (statusOS == "EM ANDAMENTO")
                {
                    cbSituacao.Items.Clear();
                    cbSituacao.Items.Add("PRONTO");
                }
                if (statusOS == "PRONTO")
                {
                    cbSituacao.Items.Clear();
                    cbSituacao.Items.Add("RETIRADO");
                    txtValorRetirada.Enabled = true;
                }
                
                cbSituacao.SelectedItem = statusOS;

                if (statusOS == "CANCELADO")
                {
                    Bloqueia();
                    txtValorRetirada.Enabled = false;
                    cbSituacao.Enabled = false;

                    lblDataCancelamento.Visible = true;
                    txtDataCancelamento.Visible = true;
                }
                else
                {
                    txtCodProduto.Enabled = true;
                    btnConsultaProduto.Enabled = true;
                    txtQtdeProduto.Enabled = true;
                    txtDescontoProd.Enabled = true;
                    dataGridViewProdutos.Enabled = true;
                    btnSalvar.Visible = true;
                    cbSituacao.Enabled = true;

                    lblDataCancelamento.Visible = false;
                    txtDataCancelamento.Visible = false;

                    txtValorEntrada.Enabled = false;
                    txtValorEntrada.Enabled = false;
                    txtValorRetirada.Enabled = statusOS == "PRONTO";
                }
                Bloqueia();
                exibirProdutosDGV(ordemServico.Produtos);
                exibirServicosDGV(ordemServico.Servicos);
                atualizaSubtotalProdutos();
                atualizaSubtotalServicos();
                atualizaDesconto();
                calculaValorPendente();
            }
            carregando = false;
        }
        private void exibirProdutosDGV(List<OS_ProdutoModel> produtos)
        {
            dataGridViewProdutos.Rows.Clear(); 

            foreach (var produto in produtos) 
            {
                ProdutoModel produtoDetalhes = ordemServicoController.GetProdutoPorId(produto.idProduto);
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
            dataGridViewProdutos.Sort(dataGridViewProdutos.Columns["idProduto"], ListSortDirection.Ascending);
        }

        private void exibirServicosDGV(List<OS_ServicoModel> servicos)
        {
            dataGridViewServicos.Rows.Clear(); 

            foreach (var servico in servicos)
            {
                ServicoModel servicoDetalhes = ordemServicoController.GetServicoPorId(servico.idServico);
                decimal descontoServ = servico.descontoServ ?? 0;
                decimal precoLiquido = servico.precoServico - descontoServ;

                if (servicoDetalhes != null)
                {
                    dataGridViewServicos.Rows.Add(
                        servico.idServico,
                        servicoDetalhes.servico,
                        servico.quantidadeServico,
                        servico.precoServico,
                        descontoServ,
                        precoLiquido,
                        (servico.quantidadeServico * precoLiquido)
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
                cbSituacao.SelectedItem = "PENDENTE";
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
                    string celular = infosCliente.Item3;

                    txtCodCliente.Texts = idCliente.ToString();
                    txtCliente.Texts = cliente;
                    txtCelular.Texts = celular;

                    ClienteModel clienteDetalhes = clienteController.GetById(idCliente);
                    if (clienteDetalhes != null)
                        txtCodCondPag.Texts = clienteDetalhes.idCondPagamento.ToString();
                    CondicaoPagamentoModel condPag = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
                    if (condPag != null)
                        txtCondPag.Texts = condPag.condicaoPagamento.ToString();

                }
            }
        }

        private void btnConsultaFuncionario_Click(object sender, EventArgs e)
        {
            consultaFuncionarios.btnSair.Text = "Selecionar";
            consultaFuncionarios.cbBuscaInativos.Visible = false;

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

        public void limpaCamposProdutos()
        {
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtQtdeProduto.Clear();
            txtPrecoProd.Clear();
            txtUNProd.Clear();
            txtDescontoProd.Clear();
            txtPrecoProdTotal.Clear();
        }
        public void limpaCamposServicos()
        {
            txtCodServico.Clear();
            txtServico.Clear();
            txtQtdeServico.Clear();
            txtPrecoServ.Clear();
            txtDescontoServ.Clear();
            txtPrecoServTotal.Clear();
        }

        private void CadastroOS_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaOS)this.Owner).AtualizarConsultaOS(false);
        }

        private void txtCodFuncionario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFuncionario.Texts))
            {
                string funcionario = funcionarioController.getFuncionario(int.Parse(txtCodFuncionario.Texts));
                if (funcionario != null)
                {
                    txtFuncionario.Texts = funcionario;
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

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            
        }

        private void txtDataOS_Leave(object sender, EventArgs e)
        {

        }

        private void txtDataEntrega_Leave(object sender, EventArgs e)
        { 
        }

        private void cbSituacao_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregando) return;
            if (cbSituacao.SelectedIndex == -1) return;
            if (cbSituacao.Texts == "EM ANDAMENTO" && statusOS != "EM ANDAMENTO")
            {

                if (MessageBox.Show("Deseja alterar a situação para 'EM ANDAMENTO'?", "Confirmação de Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Salvar();
                }
                else
                {
                    cbSituacao.Items.Add("PENDENTE");
                    cbSituacao.SelectedItem = statusOS;
                    Salvar();
                }
            }
            if (cbSituacao.Texts == "PRONTO" && statusOS != "PRONTO")
            {
                if (MessageBox.Show("Deseja alterar a situação para 'PRONTO'?", "Confirmação de Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Salvar();
                }
                else
                {
                    cbSituacao.Items.Add("EM ANDAMENTO");
                    cbSituacao.SelectedItem = statusOS;
                    Salvar();
                }
            }
            //quando o pedido for retirado, ele gera uma nota de venda e/ou serviço, de acordo com o que está na OS e uma conta a receber, com o valor pendente
            //para acertar na retirada
            string usuario = Program.usuarioLogado;
            if (cbSituacao.Texts == "RETIRADO" && statusOS != "RETIRADO") //ver status os tbm para não fazer a operação 2x caso precise voltar ao status (por ex, ao colocar NAO para cancelar)
            {
                if (MessageBox.Show("Confirmar retirada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtValorPendente.Texts != "0,00")
                    {
                        MessageBox.Show("Valor pendente detectado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbSituacao.Items.Add("PRONTO");
                        cbSituacao.SelectedItem = statusOS;
                        txtValorRetirada.Focus();
                    }
                    //    {
                    //        txtDataEntrega.Texts = DateTime.Now.ToString();
                    //        cbSituacao.Enabled = false;
                    //        int idCondPagamento = Convert.ToInt32(txtCodCondPag.Texts);
                    //        string observacao = "REFERENTE A ORDEM DE SERVIÇO CÓDIGO " + txtCodigo.Texts;
                    //        int idCliente = Convert.ToInt32(txtCodCliente.Texts);
                    //        DateTime.TryParse(txtDataOS.Texts, out DateTime dataEmissao);
                    //        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    //        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    //        try
                    //        {
                    //            int modelo = 21;
                    //            int serie = 1;
                    //            decimal totalServicos = Convert.ToDecimal(txtSubtotalServicos.Texts);
                    //            decimal totalPagar = Convert.ToDecimal(txtSubtotalServicos.Texts);

                    //            NotaServicoModel notaServico = new NotaServicoModel
                    //            {
                    //                modelo = modelo,
                    //                serie = serie,
                    //                idCliente = idCliente,
                    //                totalServicos = totalServicos,
                    //                totalPagar = totalPagar,
                    //                porcentagemDesconto = 0,
                    //                idCondPagamento = idCondPagamento,
                    //                dataEmissao = dataEmissao,
                    //                observacao = observacao,
                    //                dataCadastro = dataCadastro,
                    //                dataUltAlt = dataUltAlt,
                    //                usuario = usuario,
                    //                Servicos = obtemServicosNota(totalServicos),
                    //            };

                    //            notaServicoController.Salvar(notaServico);
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            MessageBox.Show("Ocorreu um erro ao salvar Nota de Serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        }
                    //        if (dataGridViewProdutos.Rows.Count > 0)
                    //        {
                    //            try
                    //            {
                    //                int modelo = 65;
                    //                int serie = 1;
                    //                decimal totalProdutos = Convert.ToDecimal(txtSubtotalProdutos.Texts);
                    //                decimal totalPagar = Convert.ToDecimal(txtSubtotalProdutos.Texts);
                    //                NotaVendaModel notaVenda = new NotaVendaModel
                    //                {
                    //                    modelo = modelo,
                    //                    serie = serie,
                    //                    idCliente = idCliente,
                    //                    totalProdutos = totalProdutos,
                    //                    totalPagar = totalPagar,
                    //                    porcentagemDesconto = 0,
                    //                    idCondPagamento = idCondPagamento,
                    //                    dataEmissao = dataEmissao,
                    //                    observacao = observacao,
                    //                    dataCadastro = dataCadastro,
                    //                    dataUltAlt = dataUltAlt,
                    //                    usuario = usuario,
                    //                    Produtos = obtemProdutosNota(totalProdutos),
                    //                };

                    //                notaVendaController.Salvar(notaVenda);
                    //            }
                    //            catch (Exception ex)
                    //            {
                    //                MessageBox.Show("Ocorreu um erro ao salvar Nota de Venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //            }
                    //        }
                    //        Salvar();
                    //    }
                    //    else
                    //    {
                    //        cbSituacao.Texts = statusOS;
                    //    }
                    //}
                    else if (txtValorPendente.Texts == "0,00")
                    {
                        txtDataEntrega.Texts = DateTime.Now.ToString();
                        cbSituacao.Enabled = false;
                        int idCliente = Convert.ToInt32(txtCodCliente.Texts);
                        decimal totalPagar = Convert.ToDecimal(txtSubtotalProdutos.Texts);
                        int idCondPagamento = Convert.ToInt32(txtCodCondPag.Texts);
                        string observacao = "REFERENTE A ORDEM DE SERVIÇO CÓDIGO " + txtCodigo.Texts;
                        DateTime.TryParse(txtDataOS.Texts, out DateTime dataEmissao);
                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                        if (txtValorEntrada.Texts != txtTotal.Texts) //se na entrada nao ter sido pago o total, gera uma conta a receber
                        {
                            consultaFormasPagamento.isFromOS = true;
                            consultaFormasPagamento.btnSair.Text = "Selecionar";
                            consultaFormasPagamento.Text = "Selecione a Forma de Pagamento do Valor de Entrada";
                            consultaFormasPagamento.ControlBox = false;
                            consultaFormasPagamento.cbBuscaInativos.Visible = false;

                            if (consultaFormasPagamento.ShowDialog() == DialogResult.OK)
                            {
                                var infosFormaPag = consultaFormasPagamento.Tag as Tuple<int, string>;
                                if (infosFormaPag != null)
                                {
                                    idFormaPag = infosFormaPag.Item1;
                                }
                            }
                            int numeroOS = int.Parse(txtCodigo.Texts);
                            decimal valorRetirada = Convert.ToDecimal(txtValorRetirada.Texts);
                            DateTime.TryParse(txtDataPrevista.Texts, out DateTime dataPrevista);
                            DateTime.TryParse(txtDataOS.Texts, out DateTime dataOS);
                            DateTime.TryParse(txtDataEntrega.Texts, out DateTime dataEntrega);
                            try
                            {
                                ContasReceberModel contaReceber = new ContasReceberModel
                                {
                                    numeroNota = numeroOS,
                                    modelo = 0,
                                    serie = 0,
                                    idCliente = idCliente,
                                    dataEmissao = dataOS,
                                    idFormaPagamento = idFormaPag,
                                    parcela = 2,
                                    valorParcela = valorRetirada,
                                    dataVencimento = dataEntrega,
                                    dataRecebimento = dataEntrega,
                                    juros = juros,
                                    multa = multa,
                                    desconto = descontos,
                                    valorRecebido = valorRetirada,
                                    dataCancelamento = null,
                                    usuario = usuario,
                                    observacao = "REFERENTE A ORDEM DE SERVIÇO CÓDIGO " + txtCodigo.Texts,
                                    dataCadastro = DateTime.Now,
                                    dataUltAlt = DateTime.Now
                                };

                                contasReceberController.Salvar(contaReceber);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocorreu um erro ao salvar Conta a Receber: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        try
                        {
                            int modelo = 21;
                            int serie = 1;
                            decimal totalServicos = Convert.ToDecimal(txtSubtotalServicos.Texts);

                            NotaServicoModel notaServico = new NotaServicoModel
                            {
                                modelo = modelo,
                                serie = serie,
                                idCliente = idCliente,
                                totalServicos = totalServicos,
                                totalPagar = totalPagar,
                                porcentagemDesconto = 0,
                                idCondPagamento = idCondPagamento,
                                dataEmissao = dataEmissao,
                                observacao = observacao,
                                dataCadastro = dataCadastro,
                                dataUltAlt = dataUltAlt,
                                usuario = usuario,
                                Servicos = obtemServicosNota(totalServicos),
                            };

                            notaServicoController.Salvar(notaServico);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro ao salvar Nota de Serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (dataGridViewProdutos.Rows.Count > 0)
                        {
                            try
                            {
                                int modelo = 65;
                                int serie = 1;
                                decimal totalProdutos = Convert.ToDecimal(txtSubtotalProdutos.Texts);

                                NotaVendaModel notaVenda = new NotaVendaModel
                                {
                                    modelo = modelo,
                                    serie = serie,
                                    idCliente = idCliente,
                                    totalProdutos = totalProdutos,
                                    totalPagar = totalPagar,
                                    porcentagemDesconto = 0,
                                    idCondPagamento = idCondPagamento,
                                    dataEmissao = dataEmissao,
                                    observacao = observacao,
                                    dataCadastro = dataCadastro,
                                    dataUltAlt = dataUltAlt,
                                    usuario = usuario,
                                    Produtos = obtemProdutosNota(totalProdutos),
                                };

                                notaVendaController.Salvar(notaVenda);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocorreu um erro ao salvar Nota de Venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        Salvar();
                    }
                }
                else
                {
                    cbSituacao.Items.Add("PRONTO");
                    cbSituacao.SelectedItem = statusOS;
                    Salvar();
                }
            }
        }

        private void calculaValorPendente()
        {
            if (!string.IsNullOrEmpty(txtTotal.Texts))
            {
                decimal valorTotal = decimal.Parse(txtTotal.Texts);
                decimal valorEntrada = string.IsNullOrEmpty(txtValorEntrada.Texts) ? 0 : decimal.Parse(txtValorEntrada.Texts);
                decimal valorRetirada = string.IsNullOrEmpty(txtValorRetirada.Texts) ? 0 : decimal.Parse(txtValorRetirada.Texts);
                decimal valorRestante = valorTotal - valorEntrada - valorRetirada;
                txtValorPendente.Texts = valorRestante.ToString("F2");
            }
        }

        private void txtDataPrevista_Leave(object sender, EventArgs e)
        {
            DateTime dataPrevista;
            DateTime dataOS;
            DateTime.TryParse(txtDataPrevista.Texts, out dataPrevista);
            DateTime.TryParse(txtDataOS.Texts, out dataOS);

            string dataP = new string(txtDataPrevista.Texts.Where(char.IsDigit).ToArray());
            if (!string.IsNullOrWhiteSpace(dataP))
            {
                //verifica se a data prevista é maior ou igual a hoje
                if (dataPrevista < dataOS)
                {
                    MessageBox.Show("Data Prevista inválida! A data deve ser maior ou igual a hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataPrevista.Focus();
                }
            }
            {
                return;
            }
        }

        private void txtValorRetirada_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorRetirada.Texts))
            {
                try
                {
                    decimal valorRetirada = Convert.ToDecimal(txtValorRetirada.Texts);
                    decimal valorPendente = Convert.ToDecimal(txtValorPendente.Texts); 

                    if (valorRetirada == 0 && valorPendente != 0)
                    {
                        MessageBox.Show("Valor de retirada não pode ser zero enquanto ainda houver valor pendente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtValorRetirada.Focus();
                        return;
                    }

                    //ver se o valor de retirada não é maior que o valor pendente
                    if (valorRetirada > valorPendente)
                    {
                        MessageBox.Show("Valor de retirada não pode exceder o valor pendente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtValorRetirada.Focus();
                        return;
                    }

                    txtValorRetirada.Texts = FormataPreco(valorRetirada.ToString("F2"));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorRetirada.Focus();
                }
            }
            calculaValorPendente();
        }

        private void txtValorRetirada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtValorEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtValorEntrada_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorEntrada.Texts))
            {
                try
                {
                    txtValorEntrada.Texts = FormataPreco(txtValorEntrada.Texts);

                    //verifica se o valor de entrada é um número válido e maior que zero
                    if (decimal.TryParse(txtValorEntrada.Texts, out decimal valorEntrada) && valorEntrada > 0)
                    {
                        //converte o valor total também para decimal
                        if (decimal.TryParse(txtTotal.Texts, out decimal valorTotal))
                        {
                            //verifica se o valor de entrada é maior que o valor total
                            if (valorEntrada > valorTotal)
                            {
                                MessageBox.Show("Valor de entrada maior que o total! Verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtValorEntrada.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("O valor total é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtValorEntrada.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O valor de entrada deve ser maior que zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtValorEntrada.Focus();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorEntrada.Focus();
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
                    decimal pUNProd = Convert.ToDecimal(txtPrecoProd.Texts);
                    string unidade = txtUNProd.Texts;
                    int quantidadeProd = Convert.ToInt32(txtQtdeProduto.Texts);

                    // Verificação para desconto
                    decimal descontoProd = string.IsNullOrEmpty(txtDescontoProd.Texts) ? 0 : Convert.ToDecimal(txtDescontoProd.Texts);
                    decimal precoLiquido = pUNProd - descontoProd;

                    decimal precoTotal = precoLiquido * quantidadeProd;

                    // Verificar saldo do produto
                    ProdutoModel produtoDetalhes = produtoController.GetById(codigoProduto);
                    if (produtoDetalhes != null)
                    {
                        bool produtoExistente = false;
                        decimal descontoAtual = 0;
                        int quantidadeAtualNoGrid = 0;

                        foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["idProduto"].Value) == codigoProduto)
                            {
                                quantidadeAtualNoGrid = Convert.ToInt32(row.Cells["quantidadeProduto"].Value);
                                descontoAtual = Convert.ToDecimal(row.Cells["DescontoProd"].Value);
                                produtoExistente = true;
                                break;
                            }
                        }

                        int quantidadeTotal = quantidadeAtualNoGrid + quantidadeProd;

                        if (produtoDetalhes.Saldo >= quantidadeTotal)
                        {
                            if (produtoExistente)
                            {
                                if (descontoAtual == descontoProd)
                                {
                                    foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
                                    {
                                        if (Convert.ToInt32(row.Cells["idProduto"].Value) == codigoProduto)
                                        {
                                            int quantidadeAtual = Convert.ToInt32(row.Cells["quantidadeProduto"].Value);
                                            row.Cells["quantidadeProduto"].Value = quantidadeAtual + quantidadeProd;
                                            row.Cells["PrecoUNProd"].Value = pUNProd;
                                            row.Cells["PrecoLiquidoProd"].Value = precoLiquido;
                                            row.Cells["precoProduto"].Value = (quantidadeAtual + quantidadeProd) * precoLiquido;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Desconto do produto atual não corresponde ao desconto do produto já adicionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                dataGridViewProdutos.Rows.Add(codigoProduto, produto, unidade, quantidadeProd, pUNProd, descontoProd, precoLiquido, precoTotal);
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
                    decimal pUNServ = decimal.Parse(txtPrecoServ.Texts);
                    int quantidadeServ = Convert.ToInt32(txtQtdeServico.Texts);

                    decimal descontoServ = string.IsNullOrEmpty(txtDescontoServ.Texts) ? 0 : Convert.ToDecimal(txtDescontoServ.Texts);
                    decimal precoLiquido = pUNServ - descontoServ;
                    decimal precoTotal = precoLiquido * quantidadeServ;

                    bool servicoExistente = false;

                    foreach (DataGridViewRow row in dataGridViewServicos.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["idServiço"].Value) == codigoServico)
                        {
                            decimal descontoAtual = Convert.ToDecimal(row.Cells["DescontoServ"].Value);

                            if (descontoAtual == descontoServ)
                            {
                                int quantidadeAtual = Convert.ToInt32(row.Cells["quantidadeServico"].Value);
                                row.Cells["quantidadeServico"].Value = quantidadeAtual + quantidadeServ;
                                row.Cells["precoServico"].Value = ((quantidadeAtual + quantidadeServ) * pUNServ).ToString("F2");
                            }
                            else
                            {
                                MessageBox.Show("Desconto do serviço atual não corresponde ao desconto do serviço já adicionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            servicoExistente = true;
                            break;
                        }
                    }

                    if (!servicoExistente)
                    {
                        dataGridViewServicos.Rows.Add(
                            codigoServico,
                            servico,
                            quantidadeServ,
                            pUNServ.ToString("F2"),
                            descontoServ.ToString("F2"), 
                            precoLiquido.ToString("F2"),
                            precoTotal.ToString("F2")
                        );
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

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCliente.Texts))
            {
                ClienteModel clienteDetalhes = ordemServicoController.getCliente(int.Parse(txtCodCliente.Texts));
                if (clienteDetalhes != null)
                {
                    txtCliente.Texts = clienteDetalhes.cliente_razao_social;
                    txtCelular.Texts = clienteDetalhes.celular;
                    ClienteModel cliente = clienteController.GetById(int.Parse(txtCodCliente.Texts));
                    if (cliente != null)
                        txtCodCondPag.Texts = cliente.idCondPagamento.ToString();
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
                    txtCelular.Clear();
                    txtCodCondPag.Clear();
                    txtCondPag.Clear();
                }
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodProduto.Texts))
            {
                var produto = produtoController.getProduto(int.Parse(txtCodProduto.Texts));
                if (produto != null)
                {
                    txtProduto.Texts = produto.Value.Produto;
                    txtPrecoProd.Texts = produto.Value.PrecoVenda.ToString();
                    txtUNProd.Texts = produto.Value.Unidade;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodProduto.Focus();
                    txtCodProduto.Clear();
                    txtProduto.Clear();
                    txtQtdeProduto.Clear();
                    txtPrecoProd.Clear();
                    txtUNProd.Clear();
                }
            }
        }

        private void txtCodServico_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodServico.Texts))
            {
                var servico = servicoController.getServico(int.Parse(txtCodServico.Texts));
                if (servico.HasValue)
                {
                    txtServico.Texts = servico.Value.servico;
                    txtPrecoServ.Texts = servico.Value.preco.ToString();
                }
                else
                {
                    MessageBox.Show("Serviço não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodServico.Focus();
                    txtCodServico.Clear();
                    txtServico.Clear();
                    txtQtdeServico.Clear();
                    txtPrecoServ.Clear();
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
                    decimal precoProd = infosProd.Item3;
                    string un = infosProd.Item4;

                    txtCodProduto.Texts = idProd.ToString();
                    txtProduto.Texts = produto;
                    txtPrecoProd.Texts = precoProd.ToString();
                    txtUNProd.Texts = un;
                }
            }
        }

        private void btnConsultaServico_Click(object sender, EventArgs e)
        {
            consultaServicos.btnSair.Text = "Selecionar";
            consultaServicos.cbBuscaInativos.Visible = false;

            if (consultaServicos.ShowDialog() == DialogResult.OK)
            {
                var infosServico = consultaServicos.Tag as Tuple<int, string, decimal>;
                if (infosServico != null)
                {
                    int idServico = infosServico.Item1;
                    string servico = infosServico.Item2;
                    decimal precoServ = infosServico.Item3;

                    txtCodServico.Texts = idServico.ToString();
                    txtServico.Texts = servico;
                    txtPrecoServ.Texts = precoServ.ToString("F2");
                }
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

        private void btnExcluirServicos_Click(object sender, EventArgs e)
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

        private void txtCodCondPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void txtQtdeServico_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQtdeServico.Texts))
            {
                return;
            }
            //remove os zeros à esquerda e verifica se o valor é 0 ou se foi digitado apenas zeros
            if (string.IsNullOrWhiteSpace(txtQtdeServico.Texts.TrimStart('0')))
            {
                MessageBox.Show("A quantidade não pode ser 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdeServico.Focus();
            }
        }

        private void txtDescontoProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDescontoServ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
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

        private void txtDescontoServ_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescontoServ.Texts))
            {
                try
                {
                    txtDescontoServ.Texts = FormataPreco(txtDescontoServ.Texts);

                    if (decimal.TryParse(txtDescontoServ.Texts, out decimal desconto) &&
                        decimal.TryParse(txtPrecoServ.Texts, out decimal preco))
                    {
                        if (desconto >= preco)
                        {
                            MessageBox.Show("O desconto não pode ser maior ou igual ao preço do serviço.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDescontoServ.Focus();
                            txtDescontoServ.Clear();
                            return;
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescontoServ.Focus();
                }
            }
        }

        private void txtPrecoServTotal__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescontoServ__TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoTotalServ();
        }

        private void txtPrecoServ__TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoTotalServ();
        }

        private void txtQtdeServico__TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoTotalServ();
        }
        private void CalcularPrecoTotalServ()
        {
            if (decimal.TryParse(txtQtdeServico.Texts, out decimal quantidade) &&
        decimal.TryParse(txtPrecoServ.Texts, out decimal preco))
            {
                decimal desconto = decimal.TryParse(txtDescontoServ.Texts, out decimal descontoVal) ? descontoVal : 0;

                decimal precoTotal = quantidade * (preco - desconto);
                txtPrecoServTotal.Texts = precoTotal.ToString("F2");
            }
            else
            {
                txtPrecoServTotal.Texts = "0.00";
            }
        }
        private void CancelarContaReceber(string codigoOS)
        {
            try
            {
                int numeroOS = int.Parse(codigoOS);
                int codCliente = int.Parse(txtCodCliente.Texts);
                //busca a Conta a Receber associada à OS e cancela se existir
                ContasReceberModel contaReceber = contasReceberController.GetContaById(numeroOS, 0, 0, codCliente, 1);
                if (contaReceber != null)
                {
                    contaReceber.dataCancelamento = DateTime.Now;
                    contasReceberController.Alterar(contaReceber);
                    MessageBox.Show("Conta a Receber cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar Conta a Receber: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (statusOS == "PENDENTE")
            {
                if (MessageBox.Show("Tem certeza que deseja cancelar a Ordem de Serviço? Ao cancelar, os produtos presentes voltarão ao estoque.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CancelarContaReceber(txtCodigo.Texts);

                    txtCodProduto.Enabled = false;
                    btnConsultaProduto.Enabled = false;
                    txtQtdeProduto.Enabled = false;
                    txtDescontoProd.Enabled = false;
                    dataGridViewProdutos.Enabled = false;

                    txtDataCancelamento.Visible = true;
                    lblDataCancelamento.Visible = true;
                    txtDataCancelamento.Texts = DateTime.Now.ToString();

                    cbSituacao.Items.Add("CANCELADO");
                    cbSituacao.Texts = "CANCELADO";

                    Salvar();

                    int idOS;
                    if (int.TryParse(txtCodigo.Texts, out idOS))
                    {
                        //busca os produtos da OS
                        List<ProdutoModel> produtos = ordemServicoController.GetProdutosByOS(idOS);

                        //volta o estoque dos produtos
                        foreach (var produto in produtos)
                        {
                            produtoController.AtualizarSaldo(produto.idProduto, produto.Saldo);
                        }

                        MessageBox.Show("Ordem de Serviço cancelada e estoque atualizado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Código da Ordem de Serviço inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                   // cbSituacao.Items.Add("PENDENTE");
                   // cbSituacao.SelectedItem = statusOS;
                }
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja cancelar a Ordem de Serviço?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtCodProduto.Enabled = false;
                    txtDescontoProd.Enabled = false;
                    btnConsultaProduto.Enabled = false;
                    txtQtdeProduto.Enabled = false;
                    dataGridViewProdutos.Enabled = false;

                    txtDataCancelamento.Visible = true;
                    lblDataCancelamento.Visible = true;
                    txtDataCancelamento.Texts = DateTime.Now.ToString();

                    cbSituacao.Items.Add("CANCELADO");
                    cbSituacao.Texts = "CANCELADO";

                    Salvar();
                }
                else
                {
                    cbSituacao.Items.Clear();
                    cbSituacao.Items.Add("EM ANDAMENTO");
                    cbSituacao.Items.Add("PRONTO");
                    cbSituacao.Items.Add("RETIRADO");
                    cbSituacao.Texts = statusOS;
                    cbSituacao.SelectedItem = statusOS;
                  //  Salvar();
                }
            }
        }
    }
}
