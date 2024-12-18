﻿using Sistema_Vendas.Controller;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Sistema_Vendas.DAO.NotaServicoDAO;

namespace Sistema_Vendas.Views
{
    public partial class CadastroNotasServico : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private ConsultaClientes consultaClientes;
        private ClienteController<ClienteModel> clienteController;
        private ConsultaCondicaoPagamento consultaCondicaoPagamento;
        private CondicaoPagamentoController<CondicaoPagamentoModel> condicaoPagamentoController;
        private ConsultaServicos consultaServicos;
        private ServicoController<ServicoModel> servicoController;
        private NotaServicoController<NotaServicoModel> notaServicoController;
        private ContasReceberController<ContasReceberModel> contasReceberController;

        int NumeroNota;
        int Modelo;
        int Serie;
        int IdCliente;

        decimal juros;
        decimal descontos;
        decimal multa;
        public CadastroNotasServico()
        {
            InitializeComponent();
            consultaClientes = new ConsultaClientes();
            clienteController = new ClienteController<ClienteModel>();
            consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            condicaoPagamentoController = new CondicaoPagamentoController<CondicaoPagamentoModel>();
            consultaServicos = new ConsultaServicos();
            servicoController = new ServicoController<ServicoModel>();
            notaServicoController = new NotaServicoController<NotaServicoModel>();
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
            txtCodServico.Clear();
            txtServico.Clear();
            txtQtdeServico.Clear();
            txtPrecoServico.Clear();
            txtCodCondPag.Clear();
            txtCondPag.Clear();
            txtTotalServicos.Clear();
            txtTotalPagar.Clear();
            txtObservacao.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtDataCancelamento.Clear();
            txtPorcentagemDesconto.Clear();
            txtDesconto.Clear();
            txtUsuarioUltAlt.Clear();
            txtDescontoServ.Clear();
            txtPrecoServTotal.Clear();

            //limpa os DataGridViews
            dataGridViewServicos.Rows.Clear();
            dataGridViewParcelas.Rows.Clear();

            Desbloqueia();
        }

        public void Desbloqueia()
        {
         //   txtNroNota.Enabled = false;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
            txtCodCliente.Enabled = true;
            txtObservacao.Enabled = true;

            txtCodServico.Enabled = false;
            txtServico.Enabled = false;
            txtQtdeServico.Enabled = false;
            txtPrecoServico.Enabled = false;
            txtDescontoServ.Enabled = false;
            txtCodCondPag.Enabled = false;
            txtCondPag.Enabled = false;
            txtTotalServicos.Enabled = false;
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

            dataGridViewServicos.Enabled = true;
            dataGridViewParcelas.Enabled = true;

            btnExcluirServico.Visible = true;
        }

        public void BloqueiaTudo()
        {
            //desativa todos os campos de texto
            txtNroNota.Enabled = false;
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtCodCliente.Enabled = false;
            txtCliente.Enabled = false;
            txtCodServico.Enabled = false;
            txtServico.Enabled = false;
            txtQtdeServico.Enabled = false;
            txtPrecoServico.Enabled = false;
            txtDescontoServ.Enabled = false;
            txtCodCondPag.Enabled = false;
            txtCondPag.Enabled = false;
            txtTotalServicos.Enabled = false;
            txtTotalPagar.Enabled = false;
            txtObservacao.Enabled = false;
            txtDataCadastro.Enabled = false;
            txtDataUltAlt.Enabled = false;
            txtDataCancelamento.Enabled = false;
            txtPorcentagemDesconto.Enabled = false;

            //desativa todos os botões
            btnConsultaCliente.Enabled = false;
            btnConsultaServico.Enabled = false;
            btnConsultaCondPag.Enabled = false;

            //desativa o DataGridView
            dataGridViewServicos.Enabled = true;
            dataGridViewParcelas.Enabled = true;

            btnExcluirServico.Visible = false;
        }
        public override void Carrega()
        {
            base.Carrega();

            var notaServico = notaServicoController.GetNotaById(NumeroNota, Modelo, Serie, IdCliente);
            if (notaServico != null)
            {
                txtNroNota.Texts = notaServico.numeroNota.ToString();
                txtModelo.Texts = notaServico.modelo.ToString();
                txtSerie.Texts = notaServico.serie.ToString();
                txtDataEmissao.Texts = notaServico.dataEmissao.ToString();
                txtCodCliente.Texts = notaServico.idCliente.ToString();
                txtTotalPagar.Texts = notaServico.totalPagar.ToString();
                txtTotalServicos.Texts = notaServico.totalServicos.ToString();
                txtPorcentagemDesconto.Texts = notaServico.porcentagemDesconto.ToString();
                txtCodCondPag.Texts = notaServico.idCondPagamento.ToString();
                txtObservacao.Texts = notaServico.observacao.ToString();
                txtDataCadastro.Texts = notaServico.dataCadastro.ToString();
                txtDataUltAlt.Texts = notaServico.dataUltAlt.ToString();
                txtDataCancelamento.Texts = notaServico.dataCancelamento.ToString();
                txtUsuarioUltAlt.Texts = notaServico.usuario;

                ClienteModel cliente = clienteController.GetById(int.Parse(txtCodCliente.Texts));
                CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));

                if (cliente != null)
                    txtCliente.Texts = cliente.cliente_razao_social;
                if (condPagamento != null)
                    txtCondPag.Texts = condPagamento.condicaoPagamento;

                if (notaServico.dataCancelamento != null)
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
                exibirServicosDGV(notaServico.Servicos);
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
            else if (dataGridViewServicos.Rows.Count <= 0)
            {
                MessageBox.Show("É necessário adicionar pelo menos um serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodServico.Focus();
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
                    decimal totalServicos = Convert.ToDecimal(txtTotalServicos.Texts);
                    decimal totalPagar = Convert.ToDecimal(txtTotalPagar.Texts);
                    decimal porcentagemDesconto = Convert.ToDecimal(txtPorcentagemDesconto.Texts);
                    int idCondPagamento = Convert.ToInt32(txtCodCondPag.Texts);
                    string observacao = txtObservacao.Texts;
                    string usuario = Program.usuarioLogado;
                    DateTime.TryParse(txtDataEmissao.Texts, out DateTime dataEmissao);
                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    NotaServicoModel notaServico = new NotaServicoModel
                    {
                      //  numeroNota = numeroNota,
                        modelo = modelo,
                        serie = serie,
                        idCliente = idCliente,
                        totalServicos = totalServicos,
                        totalPagar = totalPagar,
                        porcentagemDesconto = porcentagemDesconto,
                        idCondPagamento = idCondPagamento,
                        dataEmissao = dataEmissao,
                        observacao = observacao,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        usuario = usuario,
                        Servicos = obtemServicos(totalServicos),
                    };

                    notaServicoController.Salvar(notaServico);

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
                    MessageBox.Show("Ocorreu um erro ao salvar a Nota de Serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private List<NotaServico_ServicoModel> obtemServicos(decimal totalServicos)
        {
            List<NotaServico_ServicoModel> servicos = new List<NotaServico_ServicoModel>();

            foreach (DataGridViewRow row in dataGridViewServicos.Rows)
            {
                decimal precoUN = Convert.ToDecimal(row.Cells["PrecoUN"].Value);
                decimal quantidadeServico = Convert.ToDecimal(row.Cells["quantidadeServico"].Value);
                decimal precoTotalServ = precoUN * quantidadeServico;

                NotaServico_ServicoModel servico = new NotaServico_ServicoModel
                {
                    quantidadeServico = Convert.ToInt32(row.Cells["quantidadeServico"].Value),
                    precoServico = Math.Round(precoUN, 4),
                    descontoServ = row.Cells["DescontoServ"].Value != null ? Convert.ToDecimal(row.Cells["DescontoServ"].Value) : (decimal?)null,
                    idServico = Convert.ToInt32(row.Cells["idServico"].Value),
                };

                servicos.Add(servico);
            }

            return servicos;
        }
        private void exibirServicosDGV(List<NotaServico_ServicoModel> servicos)
        {
            dataGridViewServicos.Rows.Clear();

            foreach (var servico in servicos)
            {
                ServicoModel servicoDetalhes = notaServicoController.GetServicoPorId(servico.idServico);
                decimal descontoServ = servico.descontoServ ?? 0;
                decimal precoLiquido = servico.precoServico - descontoServ;

                if (servicoDetalhes != null)
                {
                    dataGridViewServicos.Rows.Add(
                        servico.idServico,
                        servicoDetalhes.servico,
                        servico.quantidadeServico,
                        servico.precoServico.ToString("F2"),
                        descontoServ.ToString("F2"),
                        precoLiquido.ToString("F2"),
                        (servico.quantidadeServico * precoLiquido).ToString("F2")
                    );
                }
            }

            if (dataGridViewServicos.Columns.Contains("idServico"))
            {
                dataGridViewServicos.Sort(dataGridViewServicos.Columns["idServico"], ListSortDirection.Ascending);
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

        private void CadastroNotasServico_Load(object sender, EventArgs e)
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
                int novoCodigo = notaServicoController.GetUltimoNumeroNota() + 1;
                txtNroNota.Texts = novoCodigo.ToString();
            }
            dataGridViewParcelas.Columns["numeroParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewParcelas.Columns["idFormaPagamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewParcelas.Columns["valorParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewServicos.Columns["idServico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewServicos.Columns["quantidadeServico"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewServicos.Columns["PrecoUN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewServicos.Columns["DescontoServ"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewServicos.Columns["PrecoLiquido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewServicos.Columns["precoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void VerificaNotaExistente()
        {
            if (int.TryParse(txtNroNota.Texts, out int numeroNota) &&
                !string.IsNullOrWhiteSpace(txtModelo.Texts) &&
                !string.IsNullOrWhiteSpace(txtSerie.Texts) &&
                int.TryParse(txtCodCliente.Texts, out int idCliente))
            {
                bool notaExiste = notaServicoController.ExisteNota(numeroNota, txtModelo.Texts, txtSerie.Texts, idCliente);

                if (notaExiste)
                {
                    MessageBox.Show("Nota de Venda já existe! Verifique os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodServico.Enabled = !notaExiste;
                    txtQtdeServico.Enabled = !notaExiste;
                    txtPrecoServico.Enabled = !notaExiste; 
                    txtDescontoServ.Enabled = !notaExiste;
                    btnConsultaServico.Enabled = !notaExiste;
                    dataGridViewServicos.Enabled = !notaExiste;
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

            txtCodServico.Enabled = camposPreenchidos;
            txtQtdeServico.Enabled = camposPreenchidos;
            txtDescontoServ.Enabled = camposPreenchidos;
            btnConsultaServico.Enabled = camposPreenchidos;
            dataGridViewServicos.Enabled = camposPreenchidos;
            txtPorcentagemDesconto.Enabled = camposPreenchidos;
        }
        private void VerificaServicos()
        {
            if (NumeroNota == -1 && Modelo == -1 && Serie == -1 && IdCliente == -1)
            {
                bool habilitar = dataGridViewServicos.Rows.Count > 0;

                //desabilita os campos com infos da nota
              //  txtNroNota.Enabled = !habilitar;
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

            txtCodServico.Enabled = !camposPreenchidos;
            txtQtdeServico.Enabled = !camposPreenchidos;
            txtDescontoServ.Enabled = !camposPreenchidos;
            dataGridViewServicos.Enabled = !camposPreenchidos;
            txtPorcentagemDesconto.Enabled = !camposPreenchidos;
            btnConsultaServico.Enabled = !camposPreenchidos;
        }
        private void limpaCamposServicos()
        {
            txtCodServico.Clear();
            txtServico.Clear();
            txtQtdeServico.Clear();
            txtPrecoServico.Clear();
            txtDescontoServ.Clear();
            txtPrecoServTotal.Clear();
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
                if (txtModelo.Texts != "22" && txtModelo.Texts != "21")
                {
                    MessageBox.Show("O modelo da nota de serviço deve ser 21 ou 22. Verifique legislação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    txtCondPag.Clear();
                    txtCodCondPag.Clear();
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
                    decimal precoUNServ = Convert.ToDecimal(txtPrecoServico.Texts); // preço unitário
                    int quantidadeServ = Convert.ToInt32(txtQtdeServico.Texts); // quantidade

                    decimal descontoServ = string.IsNullOrEmpty(txtDescontoServ.Texts) ? 0 : Convert.ToDecimal(txtDescontoServ.Texts);
                    decimal precoLiquido = precoUNServ - descontoServ;
                    decimal precoTotal = precoLiquido * quantidadeServ;

                    bool servicoExistente = false;

                    foreach (DataGridViewRow row in dataGridViewServicos.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["idServico"].Value) == codigoServico)
                        {
                            int quantidadeAtual = Convert.ToInt32(row.Cells["quantidadeServico"].Value);
                            decimal descontoAtual = Convert.ToDecimal(row.Cells["DescontoServ"].Value);

                            if (descontoAtual != descontoServ)
                            {
                                MessageBox.Show("Desconto do serviço atual não corresponde ao desconto do serviço já adicionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; 
                            }

                            int novaQuantidade = quantidadeAtual + quantidadeServ;

                            row.Cells["quantidadeServico"].Value = novaQuantidade;
                            row.Cells["precoTotal"].Value = (precoLiquido * novaQuantidade).ToString("N2");

                            servicoExistente = true;
                            break;
                        }
                    }

                    if (!servicoExistente)
                    {
                        dataGridViewServicos.Rows.Add(codigoServico, servico, quantidadeServ, precoUNServ, descontoServ, precoLiquido, precoTotal);
                    }

                    atualizaTotalServicos();
                    atualizaTotalPagar();
                    dataGridViewServicos.Sort(dataGridViewServicos.Columns["idServico"], ListSortDirection.Ascending);
                    limpaCamposServicos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar serviço: " + ex.Message);
                }
            }
        }
        private void atualizaTotalServicos()
        {
            decimal subtotalProd = 0;

            foreach (DataGridViewRow row in dataGridViewServicos.Rows) //percorre as linhas do dgv
            {
                subtotalProd += Convert.ToDecimal(row.Cells["precoTotal"].Value); //add os valores da coluna precoProduto a variavel
            }
            txtTotalServicos.Texts = subtotalProd.ToString("F2"); //att o campo com 2 casas decimais
        }

        private void atualizaTotalPagar()
        {
            decimal subtotalProd = Convert.ToDecimal(txtTotalServicos.Texts);
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
                    atualizaTotalServicos();
                    atualizaTotalPagar();
                }
                else
                {
                    MessageBox.Show("Selecione um serviço para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao serviço produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCondPag_Click(object sender, EventArgs e)
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

            if (result == DialogResult.Yes)
            {
                string dataCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());

                if (string.IsNullOrEmpty(dataCancelamento))
                {
                    try
                    {
                        bool sucesso = notaServicoController.CancelarNotaServico(NumeroNota, Modelo, Serie, IdCliente);

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

        private void CadastroNotasServico_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaNotasServico)this.Owner).AtualizarConsultaNotaServico(false);
        }

        private void dataGridViewServicos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            VerificaServicos();
        }

        private void dataGridViewServicos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            VerificaServicos();
        }

        private void txtPorcentagemDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
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
                    txtCodCondPag.Clear();
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

        private void txtCodServico_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodServico.Texts))
            {
                var servico = servicoController.getServico(int.Parse(txtCodServico.Texts));
                if (servico.HasValue)
                {
                    txtServico.Texts = servico.Value.servico;
                    txtPrecoServico.Texts = servico.Value.preco.ToString();
                }
                else
                {
                    MessageBox.Show("Serviço não encontrado ou inativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodServico.Focus();
                    txtCodServico.Clear();
                    txtServico.Clear();
                    txtPrecoServico.Clear();
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
                    decimal precoUN = infosServico.Item3;

                    txtCodServico.Texts = idServico.ToString();
                    txtServico.Texts = servico;
                    txtPrecoServico.Texts = precoUN.ToString();
                }
            }
        }
        public void atualizaDesconto()
        {
            if (!string.IsNullOrEmpty(txtPorcentagemDesconto.Texts))
            {
                decimal porcentagem = Convert.ToDecimal(txtPorcentagemDesconto.Texts);
                if (porcentagem <= 100)
                {
                    try
                    {
                        //verifica se o valor do txtTotal é válido e converte para decimal
                        if (decimal.TryParse(txtTotalServicos.Texts, out decimal subtotalServ))
                        {
                            //atualiza o total considerando o desconto
                            atualizaTotalPagar();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira valores válidos para o total dos serviços.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtDescontoProd_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescontoServ.Texts))
            {
                try
                {
                    txtDescontoServ.Texts = FormataPreco(txtDescontoServ.Texts);

                    if (decimal.TryParse(txtDescontoServ.Texts, out decimal desconto) &&
                        decimal.TryParse(txtPrecoServico.Texts, out decimal preco))
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

        private void txtQtdeServico__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtQtdeServico.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtQtdeServico.Texts = System.Text.RegularExpressions.Regex.Replace(txtQtdeServico.Texts, "[^0-9]", "");
            }
            CalcularPrecoTotalServ();
            dataGridViewParcelas.Rows.Clear();
        }

        private void txtPrecoServico__TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoTotalServ();
        }

        private void txtDescontoProd__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDescontoServ.Texts, "^[0-9.,]*$"))
            {
                txtDescontoServ.Texts = System.Text.RegularExpressions.Regex.Replace(txtDescontoServ.Texts, "[^0-9.,]", "");
            }
            CalcularPrecoTotalServ();
            dataGridViewParcelas.Rows.Clear();
        }
        private void CalcularPrecoTotalServ()
        {
            if (decimal.TryParse(txtQtdeServico.Texts, out decimal quantidade) &&
        decimal.TryParse(txtPrecoServico.Texts, out decimal preco))
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

        private void txtCodServico__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodServico.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtCodServico.Texts = System.Text.RegularExpressions.Regex.Replace(txtCodServico.Texts, "[^0-9]", "");
            }
            dataGridViewParcelas.Rows.Clear();
        }

        private void txtCodCondPag__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodCondPag.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtCodCondPag.Texts = System.Text.RegularExpressions.Regex.Replace(txtCodCondPag.Texts, "[^0-9]", "");
            }
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

        private void txtCodCliente__TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodCliente.Texts, "^[0-9]*$"))
            {
                //remove caracteres não numéricos
                txtCodCliente.Texts = System.Text.RegularExpressions.Regex.Replace(txtCodCliente.Texts, "[^0-9]", "");
            }
        }
    }
}
