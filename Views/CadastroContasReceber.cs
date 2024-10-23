using Sistema_Vendas.Controller;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Vendas.Views
{
    public partial class CadastroContasReceber : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private ConsultaFormasPagamento consultaFormasPagamento;
        private FormaPagamentoController<FormaPagamentoModel> formaPagamentoController;
        private ConsultaClientes consultaClientes;
        private ClienteController<ClienteModel> clienteController;
        private ContasReceberController<ContasReceberModel> contasReceberController;

        int NumeroNota;
        int Modelo;
        int Serie;
        int IdCliente;
        int Parcela;

        decimal? porcentagemJuros;
        decimal? porcentagemMulta;
        decimal? porcentagemDesconto;
        public CadastroContasReceber()
        {
            InitializeComponent();
            contasReceberController = new ContasReceberController<ContasReceberModel>();
            consultaFormasPagamento = new ConsultaFormasPagamento();
            consultaClientes = new ConsultaClientes();
            clienteController = new ClienteController<ClienteModel>();
            formaPagamentoController = new FormaPagamentoController<FormaPagamentoModel>();
        }

        public void SetID(int numero, int modelo, int serie, int idCliente, int parcela)
        {
            NumeroNota = numero;
            Modelo = modelo;
            Serie = serie;
            IdCliente = idCliente;
            Parcela = parcela;
        }
        public override void LimparCampos()
        {
            base.LimparCampos();

            NumeroNota = -1;
            Modelo = -1;
            Serie = -1;
            IdCliente = -1;
            Parcela = -1;

            txtNroNota.Clear();
            txtSerie.Clear();
            txtModelo.Clear();
            txtCodCliente.Clear();
            txtDataEmissao.Clear();
            txtCliente.Clear();
            txtCodFormaPag.Clear();
            txtFormaPag.Clear();
            txtParcela.Clear();
            txtValorParcela.Clear();
            txtDataVencimento.Clear();
            txtJuros.Clear();
            txtMulta.Clear();
            txtDesconto.Clear();
            txtTotalReceber.Clear();
            txtValorRecebido.Clear();
            txtDataRecebimento.Clear();
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
            txtCodCliente.Enabled = false;
            txtDataEmissao.Enabled = false;
            txtCodFormaPag.Enabled = false;
            txtParcela.Enabled = false;
            txtValorParcela.Enabled = false;

            btnConsultaFormaPag.Enabled = false;
            btnConsultaCliente.Enabled = false;
        }

        public void BloqueiaTudo()
        {
            //usado quando a conta já está paga ou está cancelada
            txtJuros.Enabled = false;
            txtMulta.Enabled = false;
            txtDesconto.Enabled = false;
            txtValorRecebido.Enabled = false;
            txtDataVencimento.Enabled = false;
        }
        public void DesbloqueiaTudo()
        {
            txtJuros.Enabled = true;
            txtMulta.Enabled = true;
            txtDesconto.Enabled = true;
            txtValorRecebido.Enabled = true;
            txtDataVencimento.Enabled = true;
        }
        public override void Desbloqueia()
        {
            base.Desbloqueia();

            btnReceber.Visible = false;
            btnSalvar.Visible = true;

            txtNroNota.Enabled = true;
            txtModelo.Enabled = true;
            txtSerie.Enabled = true;
            txtCodCliente.Enabled = true;
            txtDataEmissao.Enabled = true;
            txtCodFormaPag.Enabled = true;
            txtParcela.Enabled = true;
            txtValorParcela.Enabled = true;

            txtJuros.Enabled = true;
            txtMulta.Enabled = true;
            txtDesconto.Enabled = true;
            txtValorRecebido.Enabled = true;
            txtDataVencimento.Enabled = true;

            btnConsultaFormaPag.Enabled = true;
            btnConsultaCliente.Enabled = true;
        }
        public override void Carrega()
        {
            base.Carrega();
            var contasReceber = contasReceberController.GetContaById(NumeroNota, Modelo, Serie, IdCliente, Parcela);
            if (contasReceber != null)
            {
                txtNroNota.Texts = contasReceber.numeroNota.ToString();
                txtModelo.Texts = contasReceber.modelo.ToString();
                txtSerie.Texts = contasReceber.serie.ToString();
                txtCodCliente.Texts = contasReceber.idCliente.ToString();
                txtDataEmissao.Texts = contasReceber.dataEmissao.ToString();
                txtCodFormaPag.Texts = contasReceber.idFormaPagamento.ToString();
                txtParcela.Texts = contasReceber.parcela.ToString();
                txtValorParcela.Texts = contasReceber.valorParcela.ToString();
                txtDataVencimento.Texts = contasReceber.dataVencimento.ToString();
                porcentagemJuros = contasReceber.juros;
                porcentagemMulta = contasReceber.multa;
                porcentagemDesconto = contasReceber.desconto;
                txtValorRecebido.Texts = contasReceber.valorRecebido.ToString();
                txtDataRecebimento.Texts = contasReceber.dataRecebimento.ToString();
                txtObservacao.Texts = contasReceber.observacao.ToString();
                txtDataCancelamento.Texts = contasReceber.dataCancelamento.ToString();
                txtDataCadastro.Texts = contasReceber.dataCadastro.ToString();
                txtDataUltAlt.Texts = contasReceber.dataUltAlt.ToString();
                txtUsuarioUltAlt.Texts = contasReceber.usuario;

                ClienteModel cliente = clienteController.GetById(int.Parse(txtCodCliente.Texts));
                FormaPagamentoModel formaPagamento = formaPagamentoController.GetById(int.Parse(txtCodFormaPag.Texts));

                if (cliente != null)
                    txtCliente.Texts = cliente.cliente_razao_social;
                if (formaPagamento != null)
                    txtFormaPag.Texts = formaPagamento.formaPagamento;

                if (contasReceber.dataCancelamento != null) //se estiver cancelado, aparece as infos de cancelamento e bloqueia todos os campos
                {
                    lblDataCancelamento.Visible = true;
                    txtDataCancelamento.Visible = true;
                    btnCancelar.Visible = false;
                    BloqueiaTudo();
                }
                else //se nao estiver cancelado, fica padrao
                {
                    lblDataCancelamento.Visible = false;
                    txtDataCancelamento.Visible = false;
                    btnCancelar.Visible = true;
                    DesbloqueiaTudo();
                }
                if (contasReceber.dataRecebimento == null)
                {
                    calcularJuros();
                    calcularMulta();
                    calcularDesconto();
                }
                else
                {
                    BloqueiaTudo();
                }
                calculaTotalReceber();
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
            int idClienteNF = int.Parse(txtCodCliente.Texts);
            int parcelaNF = int.Parse(txtParcela.Texts);
            string usuario = Program.usuarioLogado;

            bool incluindo = NumeroNota == -1 && Modelo == -1 && Serie == -1 && IdCliente == -1 && Parcela == -1;

            if (contasReceberController.JaCadastrado(numeroNF, modeloNF, serieNF, idClienteNF, parcelaNF, incluindo))
            {
                MessageBox.Show("Conta a Receber já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
                {
                    int numeroNota = Convert.ToInt32(txtNroNota.Texts);
                    int modelo = Convert.ToInt32(txtModelo.Texts);
                    int serie = Convert.ToInt32(txtSerie.Texts);
                    int idCliente = Convert.ToInt32(txtCodCliente.Texts);
                    DateTime.TryParse(txtDataEmissao.Texts, out DateTime dataEmissao);
                    int idFormaPag = Convert.ToInt32(txtCodFormaPag.Texts);
                    int parcela = Convert.ToInt32(txtParcela.Texts);
                    decimal valorParcela = Convert.ToDecimal(txtValorParcela.Texts);
                    DateTime.TryParse(txtDataVencimento.Texts, out DateTime dataVencimento);
                    string dRecebimento = new string(txtDataRecebimento.Texts.Where(char.IsDigit).ToArray());
                    DateTime? dataRecebimento = string.IsNullOrEmpty(dRecebimento) || dRecebimento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataRecebimento.Texts, "dd/MM/yyyy", null);
                    decimal valorRecebido = string.IsNullOrEmpty(txtValorRecebido.Texts) ? 0 : Convert.ToDecimal(txtValorRecebido.Texts);
                    string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());
                    DateTime? dataCancelamento = string.IsNullOrEmpty(dCancelamento) || dCancelamento.Length != 8 ? (DateTime?)null : DateTime.ParseExact(txtDataCancelamento.Texts, "dd/MM/yyyy", null);
                    string observacao = txtObservacao.Texts;
                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    ContasReceberModel novaContaReceber = new ContasReceberModel
                    {
                        numeroNota = numeroNota,
                        modelo = modelo,
                        serie = serie,
                        dataEmissao = dataEmissao,
                        idCliente = idCliente,
                        idFormaPagamento = idFormaPag,
                        parcela = parcela,
                        valorParcela = valorParcela,
                        dataVencimento = dataVencimento,
                        dataRecebimento = dataRecebimento,
                        valorRecebido = valorRecebido,
                        dataCancelamento = dataCancelamento,
                        desconto = porcentagemDesconto,
                        juros = porcentagemJuros,
                        multa = porcentagemMulta,
                        observacao = observacao,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        usuario = usuario,
                    };
                if (NumeroNota != -1 && Modelo != -1 && Serie != -1 && IdCliente != -1 && Parcela != -1)
                {
                    contasReceberController.Alterar(novaContaReceber);
                }
                else
                {
                    contasReceberController.Salvar(novaContaReceber);
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
            if (!CampoObrigatorio(txtCodCliente.Texts))
            {
                MessageBox.Show("Campo Código Cliente é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCliente.Focus();
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
            if (DataValida(txtDataVencimento.Texts))
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

                //verifica se a data de vencimento menor que data atual
                if (dataVencimento < dataAtual && porcentagemMulta.HasValue)
                {
                    //aplica a porcentagem da multa ao valor da parcela
                    decimal valorParcela = Convert.ToDecimal(txtValorParcela.Texts);
                    decimal valorMulta = (porcentagemMulta.Value / 100) * valorParcela;

                    txtMulta.Texts = valorMulta.ToString("N2");
                }
                else
                {
                    //se não houver atraso, a multa é zero
                    txtMulta.Texts = "0.00";
                }
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

        private void calculaTotalReceber()
        {
            decimal valorDesconto = string.IsNullOrWhiteSpace(txtDesconto.Texts) ? 0 : Convert.ToDecimal(txtDesconto.Texts);
            decimal valorJuros = string.IsNullOrWhiteSpace(txtJuros.Texts) ? 0 : Convert.ToDecimal(txtJuros.Texts);
            decimal valorMulta = string.IsNullOrWhiteSpace(txtMulta.Texts) ? 0 : Convert.ToDecimal(txtMulta.Texts);
            decimal valorParcela = string.IsNullOrWhiteSpace(txtValorParcela.Texts) ? 0 : Convert.ToDecimal(txtValorParcela.Texts);

            decimal totalPagar = valorParcela + valorJuros + valorMulta - valorDesconto;
            txtTotalReceber.Texts = totalPagar.ToString("N2");
        }

        private void CadastroContasReceber_Load(object sender, EventArgs e)
        {
            if (NumeroNota != -1 && Modelo != -1 && Serie != -1 && IdCliente != -1 && Parcela != -1)
            {
                btnReceber.Visible = true;
                btnSalvar.Visible = true;
            }
        }
        private void CadastroContasReceber_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaContasReceber)this.Owner).AtualizarConsultaContasReceber(false);
        }

        private void btnConsultaFormaPag_Click(object sender, EventArgs e)
        {
            consultaFormasPagamento.btnSair.Text = "Selecionar";
            consultaFormasPagamento.cbBuscaInativos.Visible = false;

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

        private void btnConsultaFormaPag_Leave(object sender, EventArgs e)
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
                }
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
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCliente.Focus();
                    txtCodCliente.Clear();
                    txtCliente.Clear();
                }
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

        private void txtValorRecebido_Leave(object sender, EventArgs e)
        {
            txtValorRecebido.Texts = FormataPreco(txtValorRecebido.Texts);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string dRecebimento = new string(txtDataRecebimento.Texts.Where(char.IsDigit).ToArray());
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar esta conta a receber?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(dRecebimento))
                {
                    try
                    {
                        ContasReceberModel contaReceber = new ContasReceberModel
                        {
                            numeroNota = NumeroNota,
                            modelo = Modelo,
                            serie = Serie,
                            idCliente = IdCliente,
                            parcela = Parcela,
                            dataCancelamento = DateTime.Now
                        };
                        bool cancelamentoRealizado = contasReceberController.CancelarConta(contaReceber);

                        if (cancelamentoRealizado)
                        {
                            txtDataCancelamento.Texts = contaReceber.dataCancelamento?.ToString("dd/MM/yyyy");
                            lblDataCancelamento.Visible = true;
                            txtDataCancelamento.Visible = true;
                            BloqueiaTudo();

                            MessageBox.Show("Conta a receber cancelada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível cancelar a conta, pois ela está associada a uma nota de venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao cancelar a conta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível cancelar uma conta que o pagamento já foi realizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            string dRecebimento = new string(txtDataRecebimento.Texts.Where(char.IsDigit).ToArray());
            string dCancelamento = new string(txtDataCancelamento.Texts.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(dCancelamento))
            {
                MessageBox.Show("Nota Cancelada! Não é possível efetuar o pagamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(dRecebimento))
            {
                MessageBox.Show("Pagamento já foi realizado dia " + txtDataRecebimento.Texts, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //parcela atual
            int parcelaAtual = Convert.ToInt32(txtParcela.Texts);
            string numeroNota = txtNroNota.Texts;
            string modelo = txtModelo.Texts;
            string serie = txtSerie.Texts;
            int idCliente = Convert.ToInt32(txtCodCliente.Texts);

            //verificar se existe uma parcela menor não paga
            bool parcelaNaoPaga = contasReceberController.VerificarParcelasNaoPagas(numeroNota, modelo, serie, idCliente, parcelaAtual);

            if (parcelaNaoPaga)
            {
                MessageBox.Show("Existem parcelas anteriores que não foram pagas. Pague as parcelas anteriores antes de pagar esta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //se não existe parcelas menor não pagas, permitir o pagamento
            if (MessageBox.Show("Deseja realizar o pagamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Salvar();
                txtDataRecebimento.Texts = DateTime.Now.ToString();
                txtValorRecebido.Texts = txtTotalReceber.Texts;
                Salvar();
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
                }
                else
                {
                    MessageBox.Show("Data de emissão inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDataEmissao.Focus();
                    return;
                }
            }
        }

        private void txtCodFormaPag_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFormaPag.Texts))
            {
                string formaPag = formaPagamentoController.getFormaPag(int.Parse(txtCodFormaPag.Texts));
                if (formaPag != null)
                {
                    txtFormaPag.Texts = formaPag;
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
    }
}
