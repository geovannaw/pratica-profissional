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

namespace Sistema_Vendas.Views
{
    public partial class CadastroContasPagar : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private ConsultaFormasPagamento consultaFormasPagamento;
        private FormaPagamentoController<FormaPagamentoModel> formaPagamentoController;
        private ConsultaFornecedores consultaFornecedores;
        private FornecedorController<FornecedorModel> fornecedorController;
        private ContasPagarController<ContasPagarModel> contasPagarController;

        int NumeroNota;
        int Modelo;
        int Serie;
        int IdFornecedor;
        int Parcela;

        decimal? porcentagemJuros;
        decimal? porcentagemMulta;
        decimal? porcentagemDesconto;
        public CadastroContasPagar()
        {
            InitializeComponent();
            contasPagarController = new ContasPagarController<ContasPagarModel>();
            consultaFormasPagamento = new ConsultaFormasPagamento();
            consultaFornecedores = new ConsultaFornecedores();
            fornecedorController = new FornecedorController<FornecedorModel>();
            formaPagamentoController = new FormaPagamentoController<FormaPagamentoModel>();
        }
        public void SetID(int numero, int modelo, int serie, int idFornecedor, int parcela)
        {
            NumeroNota = numero;
            Modelo = modelo;
            Serie = serie;
            IdFornecedor = idFornecedor;
            Parcela = parcela;
        }
        public override void LimparCampos()
        {
            base.LimparCampos();

            NumeroNota = -1;
            Modelo = -1;
            Serie = -1;
            IdFornecedor = -1;
            Parcela = -1;

            txtNroNota.Clear();
            txtSerie.Clear();
            txtModelo.Clear();
            txtCodFornecedor.Clear();
            txtDataEmissao.Clear();
            txtFornecedor.Clear();
            txtCodFormaPag.Clear();
            txtFormaPag.Clear();
            txtParcela.Clear();
            txtValorParcela.Clear();
            txtDataVencimento.Clear();
            txtJuros.Clear();
            txtMulta.Clear();
            txtDesconto.Clear();
            txtTotalPagar.Clear();
            txtValorPago.Clear();
            txtDataPagamento.Clear();
            txtDataCancelamento.Clear();
            txtUsuarioUltAlt.Clear();

            lblDataCancelamento.Visible = false;
            txtDataCancelamento.Visible = false;

            btnCancelar.Visible = false;

            Desbloqueia();
        }

        public override void Bloqueia()
        {
            base.Bloqueia(); 
            txtNroNota.Enabled = false;
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtCodFornecedor.Enabled = false;
            txtDataEmissao.Enabled = false;
            txtCodFormaPag.Enabled = false;
            txtParcela.Enabled = false;
            txtValorParcela.Enabled = false;

            btnConsultaFormaPag.Enabled = false;
            btnConsultaFornecedor.Enabled = false;
        }

        public void BloqueiaTudo()
        {
            //usado quando a conta já está paga ou está cancelada
            txtJuros.Enabled = false;
            txtMulta.Enabled = false;
            txtDesconto.Enabled = false;
            txtValorPago.Enabled = false;
            txtDataVencimento.Enabled = false;
        }
        public void DesbloqueiaTudo ()
        {
            txtJuros.Enabled = true;
            txtMulta.Enabled = true;
            txtDesconto.Enabled = true;
            txtValorPago.Enabled = true;
            txtDataVencimento.Enabled = true;
        }
        public override void Desbloqueia()
        {
            base.Desbloqueia();

            btnPagar.Visible = false;
            btnSalvar.Visible = true;

            txtNroNota.Enabled = true;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
            txtCodFornecedor.Enabled = true;
            txtDataEmissao.Enabled = true;
            txtCodFormaPag.Enabled = true;
            txtParcela.Enabled = true;
            txtValorParcela.Enabled = true;

            txtJuros.Enabled = true;
            txtMulta.Enabled = true;
            txtDesconto.Enabled = true;
            txtValorPago.Enabled = true;
            txtDataVencimento.Enabled = true;

            btnConsultaFormaPag.Enabled = true;
            btnConsultaFornecedor.Enabled = true;
        }
        public override void Carrega()
        {
            base.Carrega();
            var contasPagar = contasPagarController.GetContaById(NumeroNota, Modelo, Serie, IdFornecedor, Parcela);
            if (contasPagar != null)
            {
                txtNroNota.Texts = contasPagar.numeroNota.ToString();
                txtModelo.Texts = contasPagar.modelo.ToString();
                txtSerie.Texts = contasPagar.serie.ToString();
                txtCodFornecedor.Texts = contasPagar.idFornecedor.ToString();
                txtDataEmissao.Texts = contasPagar.dataEmissao.ToString();
                txtCodFormaPag.Texts = contasPagar.idFormaPagamento.ToString();
                txtParcela.Texts = contasPagar.parcela.ToString();
                txtValorParcela.Texts = contasPagar.valorParcela.ToString();
                txtDataVencimento.Texts = contasPagar.dataVencimento.ToString();
                porcentagemJuros = contasPagar.juros;
                porcentagemMulta = contasPagar.multa;
                porcentagemDesconto = contasPagar.desconto;
                txtValorPago.Texts = contasPagar.valorPago.ToString();
                txtDataPagamento.Texts = contasPagar.dataPagamento.ToString();
                txtObservacao.Texts = contasPagar.observacao.ToString();
                txtDataCancelamento.Texts = contasPagar.dataCancelamento.ToString();
                txtDataCadastro.Texts = contasPagar.dataCadastro.ToString();
                txtDataUltAlt.Texts = contasPagar.dataUltAlt.ToString();
                txtUsuarioUltAlt.Texts = contasPagar.usuario;

                FornecedorModel fornecedor = fornecedorController.GetById(int.Parse(txtCodFornecedor.Texts));
                FormaPagamentoModel formaPagamento = formaPagamentoController.GetById(int.Parse(txtCodFormaPag.Texts));

                if (fornecedor != null)
                    txtFornecedor.Texts = fornecedor.fornecedor_razao_social;
                if (formaPagamento != null)
                    txtFormaPag.Texts = formaPagamento.formaPagamento;

                if (contasPagar.dataCancelamento != null)
                {
                    lblDataCancelamento.Visible = true;
                    txtDataCancelamento.Visible = true;
                    btnCancelar.Visible = false;
                    BloqueiaTudo();
                }
                else
                {
                    lblDataCancelamento.Visible = false;
                    txtDataCancelamento.Visible = false;
                    btnCancelar.Visible = true;
                    DesbloqueiaTudo();
                }
                if (contasPagar.dataPagamento == null)
                {
                    calcularJuros();
                    calcularMulta();
                    calcularDesconto();
                }
                else
                {
                    BloqueiaTudo();
                }
                calculaTotalPagar();
            }
        }
        public override void Salvar()
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }

            int numeroNF = int.Parse(txtNroNota.Texts);
            int modeloNF = int.Parse(txtModelo.Texts);
            int serieNF = int.Parse(txtSerie.Texts);
            int idFornecedorNF = int.Parse(txtCodFornecedor.Texts);
            int parcelaNF = int.Parse(txtParcela.Texts);
            string usuario = Program.usuarioLogado;

            bool incluindo = NumeroNota == -1 && Modelo == -1 && Serie == -1 && IdFornecedor == -1 && Parcela == -1;

            if (contasPagarController.JaCadastrado(numeroNF, modeloNF, serieNF, idFornecedorNF, parcelaNF, incluindo))
            {
                MessageBox.Show("Conta a Pagar já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
                {
                    int numeroNota = Convert.ToInt32(txtNroNota.Texts);
                    int modelo = Convert.ToInt32(txtModelo.Texts);
                    int serie = Convert.ToInt32(txtSerie.Texts);
                    int idFornecedor = Convert.ToInt32(txtCodFornecedor.Texts);
                    DateTime.TryParse(txtDataEmissao.Texts, out DateTime dataEmissao);
                    int idFormaPag = Convert.ToInt32(txtCodFormaPag.Texts);
                    int parcela = Convert.ToInt32(txtParcela.Texts);
                    decimal valorParcela = Convert.ToDecimal(txtValorParcela.Texts);
                    DateTime.TryParse(txtDataVencimento.Texts, out DateTime dataVencimento);
                    string dPagamento = new string(txtDataPagamento.Texts.Where(char.IsDigit).ToArray());
                    DateTime? dataPagamento = string.IsNullOrEmpty(dPagamento) || dPagamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataPagamento.Texts, "dd/MM/yyyy", null);
                    decimal valorPago = string.IsNullOrEmpty(txtValorPago.Texts) ? 0 : Convert.ToDecimal(txtValorPago.Texts);
                    string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
                    DateTime? dataCancelamento = string.IsNullOrEmpty(dCancelamento) || dCancelamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataCancelamento.Texts, "dd/MM/yyyy", null);
                    string observacao = txtObservacao.Texts;
                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    ContasPagarModel novaContaPagar = new ContasPagarModel
                    {
                        numeroNota = numeroNota,
                        modelo = modelo,
                        serie = serie,
                        dataEmissao = dataEmissao,
                        idFornecedor = idFornecedor,
                        idFormaPagamento = idFormaPag,
                        parcela = parcela,
                        valorParcela = valorParcela,
                        dataVencimento = dataVencimento,
                        dataPagamento = dataPagamento,
                        valorPago = valorPago,
                        dataCancelamento = dataCancelamento,
                        desconto = porcentagemDesconto,
                        juros = porcentagemJuros,
                        multa = porcentagemMulta,
                        observacao = observacao,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        usuario = usuario,
                    };
                if (NumeroNota != -1 && Modelo != -1 && Serie != -1 && IdFornecedor != -1 && Parcela != -1)
                {
                    contasPagarController.Alterar(novaContaPagar);
                }
                else
                {
                    contasPagarController.Salvar(novaContaPagar);
                }
                this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        protected bool VerificaCamposObrigatorios()
        {
            string dEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            string dVencimento = new string(txtDataVencimento.Texts.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(txtNroNota.Texts))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroNota.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtModelo.Texts))
            {
                MessageBox.Show("Campo Modelo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelo.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtSerie.Texts))
            {
                MessageBox.Show("Campo Série é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSerie.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodFornecedor.Texts))
            {
                MessageBox.Show("Campo Código Fornecedor é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFornecedor.Focus();
                return false;
            }
            if (!CampoObrigatorio(dEmissao))
            {
                MessageBox.Show("Campo Data Emissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataEmissao.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodFormaPag.Texts))
            {
                MessageBox.Show("Campo Código Forma Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFormaPag.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtParcela.Texts))
            {
                MessageBox.Show("Campo Nº Parcela é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParcela.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtValorParcela.Texts))
            {
                MessageBox.Show("Campo Valor Parcela é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorParcela.Focus();
                return false;
            }
            if (!CampoObrigatorio(dVencimento))
            {
                MessageBox.Show("Campo Data Vencimento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataVencimento.Focus();
                return false;
            }
            return true;
        }
        private void calcularJuros()
        {
            if(DataValida(txtDataVencimento.Texts))
            {
                DateTime dataVencimento = DateTime.Parse(txtDataVencimento.Texts);
                DateTime dataAtual = DateTime.Now;

                int diasAtraso = (dataAtual - dataVencimento).Days;
                decimal valorJuros = 0;

                if (diasAtraso > 0 && porcentagemJuros.HasValue)
                {
                    valorJuros = (diasAtraso * porcentagemJuros.Value / 100) * Convert.ToDecimal(txtValorParcela.Texts);
                }
                txtJuros.Texts = valorJuros.ToString("N2");
            }
        }
        private void calcularMulta()
        {
            if (DataValida(txtDataVencimento.Texts))
            {
                DateTime dataVencimento = DateTime.Parse(txtDataVencimento.Texts);
                DateTime dataAtual = DateTime.Now;

                int diasAtraso = (dataAtual - dataVencimento).Days;
                decimal valorMulta = 0;

                if (diasAtraso > 0 && porcentagemJuros.HasValue)
                {
                    valorMulta = (diasAtraso * porcentagemMulta.Value / 100) * Convert.ToDecimal(txtValorParcela.Texts);
                }
                txtMulta.Texts = valorMulta.ToString("N2");
            }
        }
        private void calcularDesconto()
        {
            if (DataValida(txtDataVencimento.Texts))
            {
                if (porcentagemDesconto.HasValue && !string.IsNullOrWhiteSpace(txtValorParcela.Texts))
                {
                    decimal valorParcela = Convert.ToDecimal(txtValorParcela.Texts);
                    decimal valorDesconto = (porcentagemDesconto.Value / 100) * valorParcela;

                    txtDesconto.Texts = valorDesconto.ToString("N2");
                }
                else
                {
                    txtDesconto.Texts = "0.00";
                }
            }
        }

        private void calculaTotalPagar()
        {
            decimal valorDesconto = string.IsNullOrWhiteSpace(txtDesconto.Texts) ? 0 : Convert.ToDecimal(txtDesconto.Texts);
            decimal valorJuros = string.IsNullOrWhiteSpace(txtJuros.Texts) ? 0 : Convert.ToDecimal(txtJuros.Texts);
            decimal valorMulta = string.IsNullOrWhiteSpace(txtMulta.Texts) ? 0 : Convert.ToDecimal(txtMulta.Texts);
            decimal valorParcela = string.IsNullOrWhiteSpace(txtValorParcela.Texts) ? 0 : Convert.ToDecimal(txtValorParcela.Texts);

            decimal totalPagar = valorParcela + valorJuros + valorMulta - valorDesconto;
            txtTotalPagar.Texts = totalPagar.ToString("N2");
        }


        private void CadastroContasPagar_Load(object sender, EventArgs e)
        {
            if (NumeroNota != -1 && Modelo != -1 && Serie != -1 && IdFornecedor != -1 && Parcela != -1)
            {
                btnPagar.Visible = true;
                btnSalvar.Visible = true;
            }
            if (Program.permissaoLogado == "ATENDENTE")
            {
                btnConsultaFornecedor.Enabled = false;
                txtCodFornecedor.Enabled = false;
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
        }

        private void btnConsultaFormaPag_Click(object sender, EventArgs e)
        {
            consultaFormasPagamento.btnSair.Text = "Selecionar";

            if (consultaFormasPagamento.ShowDialog() == DialogResult.OK)
            {
                var infosFormaPag = consultaFormasPagamento.Tag as Tuple<int, string>;
                if (infosFormaPag != null)
                {
                    int idFormaPag = infosFormaPag.Item1;
                    string formaPag = infosFormaPag.Item2;

                    txtCodFormaPag.Texts = idFormaPag.ToString();
                    txtFormaPag.Texts = formaPag;
                }
            }
        }

        private void txtCodFormaPag_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFormaPag.Texts))
            {
                FormaPagamentoModel formaPag = formaPagamentoController.GetById(int.Parse(txtCodFormaPag.Texts));
                if (formaPag != null)
                {
                    txtFormaPag.Texts = formaPag.formaPagamento;
                }
                else
                {
                    MessageBox.Show("Forma de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodFormaPag.Focus();
                    txtCodFormaPag.Clear();
                    txtFormaPag.Clear();
                }
            }
        }

        private void CadastroContasPagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaContasPagar)this.Owner).AtualizarConsultaContasPagar(false);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string dPagamento = new string(txtDataPagamento.Texts.Where(char.IsDigit).ToArray());
            string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dCancelamento))
            {
                MessageBox.Show("Nota Cancelada! Não é possível efetuar o pagamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(dPagamento))
            {
                MessageBox.Show("Pagamento já foi realizado dia " + txtDataPagamento.Texts, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //parcela atual
            int parcelaAtual = Convert.ToInt32(txtParcela.Texts);
            string numeroNota = txtNroNota.Texts;
            string modelo = txtModelo.Texts;
            string serie = txtSerie.Texts;
            int idFornecedor = Convert.ToInt32(txtCodFornecedor.Texts);

            //verificar se existe uma parcela menor não paga
            bool parcelaNaoPaga = contasPagarController.VerificarParcelasNaoPagas(numeroNota, modelo, serie, idFornecedor, parcelaAtual);

            if (parcelaNaoPaga)
            {
                MessageBox.Show("Existem parcelas anteriores que não foram pagas. Pague as parcelas anteriores antes de pagar esta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //se não existe parcelas menor não pagas, permitir o pagamento
            if (MessageBox.Show("Deseja realizar o pagamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Salvar();
                txtDataPagamento.Texts = DateTime.Now.ToString();
                txtValorPago.Texts = txtTotalPagar.Texts;
                Salvar();
            }
        }

        private void txtDataVencimento_Leave(object sender, EventArgs e)
        {
            string dVencimento = new string(txtDataVencimento.Texts.Where(char.IsDigit).ToArray());
            string dEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            if (!string.IsNullOrEmpty(dVencimento) && !string.IsNullOrEmpty(dEmissao))
            {
                if (DataValida(txtDataEmissao.Texts) && DataValida(txtDataVencimento.Texts))
                {
                    DateTime dataEmissao;
                    DateTime dataVencimento;

                    bool dataEmissaoValida = DateTime.TryParseExact(txtDataEmissao.Texts, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataEmissao);
                    bool dataVencimentoValida = DateTime.TryParseExact(txtDataVencimento.Texts, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataVencimento);

                    if (dataEmissaoValida && dataVencimentoValida)
                    {
                        if (dataVencimento < dataEmissao)
                        {
                            MessageBox.Show("Data de vencimento inválida! A data de vencimento deve ser maior ou igual à data de emissão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDataVencimento.Focus();
                            return;
                        }
                    }
                    calcularJuros();
                    calcularMulta();
                    calcularDesconto();
                }
                else
                {
                    MessageBox.Show("Data de emissão ou data de vencimento inválida! Verifique os valores inseridos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataVencimento.Focus();
                }
            }         
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            txtValorPago.Texts = FormataPreco(txtValorPago.Texts);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string dPagamento = new string(txtDataPagamento.Texts.Where(char.IsDigit).ToArray());
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar esta conta a pagar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(dPagamento))
                {
                    try
                    {
                        ContasPagarModel contaPagar = new ContasPagarModel
                        {
                            numeroNota = NumeroNota,
                            modelo = Modelo,
                            serie = Serie,
                            idFornecedor = IdFornecedor,
                            parcela = Parcela,
                            dataCancelamento = DateTime.Now
                        };
                        bool cancelamentoRealizado = contasPagarController.CancelarConta(contaPagar);

                        if (cancelamentoRealizado)
                        {
                            txtDataCancelamento.Texts = contaPagar.dataCancelamento?.ToString("dd/MM/yyyy");
                            lblDataCancelamento.Visible = true;
                            txtDataCancelamento.Visible = true;
                            BloqueiaTudo();

                            MessageBox.Show("Conta a pagar cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cancelar a conta, pois ela está associada a uma nota de compra.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao cancelar a conta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Não é possível cancelar uma conta que o pagamento já foi realizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            DateTime dataEmissao;
            DateTime dataHoje = DateTime.Now;
            bool dataValida = DateTime.TryParse(txtDataEmissao.Texts, out dataEmissao);

            string dataE = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dataE))
            {
                if (DataValida(txtDataEmissao.Texts))
                {
                    if (!string.IsNullOrWhiteSpace(dataE) && dataValida)
                    {
                        if (dataEmissao > dataHoje)
                        {
                            MessageBox.Show("Data de emissão inválida! A data deve ser menor ou igual a hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDataEmissao.Focus();
                            return;
                        }
                    }
                } else
                {
                    MessageBox.Show("Data de emissão inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataEmissao.Focus();
                    return;
                }
            }
        }
    }
}
