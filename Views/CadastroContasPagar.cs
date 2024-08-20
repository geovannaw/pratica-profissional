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

        decimal porcentagemJuros;
        decimal porcentagemMulta;
        decimal porcentagemDesconto;
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
            txtValorPago.Clear();
            txtDataPagamento.Clear();
            txtDataCancelamento.Clear();

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
                txtJuros.Texts = contasPagar.juros.ToString();
                txtMulta.Texts = contasPagar.multa.ToString();
                txtDesconto.Texts = contasPagar.desconto.ToString();
                txtValorPago.Texts = contasPagar.valorPago.ToString();
                txtDataPagamento.Texts = contasPagar.dataPagamento.ToString();
                txtObservacao.Texts = contasPagar.observacao.ToString();
                txtDataCancelamento.Texts = contasPagar.dataCancelamento.ToString();
                txtDataCadastro.Texts = contasPagar.dataCadastro.ToString();
                txtDataUltAlt.Texts = contasPagar.dataUltAlt.ToString();

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
                }
                else
                {
                    lblDataCancelamento.Visible = false;
                    txtDataCancelamento.Visible = false;
                }
                //calculaTotalPagar();
            }
        }
        public override void Salvar()
        {
            string dEmissao = new string(txtDataEmissao.Texts.Where(char.IsDigit).ToArray());
            string dVencimento = new string(txtDataVencimento.Texts.Where(char.IsDigit).ToArray());
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
            else if (!CampoObrigatorio(txtCodFormaPag.Texts))
            {
                MessageBox.Show("Campo Código Forma Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFormaPag.Focus();
            }
            else if (!CampoObrigatorio(txtParcela.Texts))
            {
                MessageBox.Show("Campo Nº Parcela é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParcela.Focus();
            }
            else if (!CampoObrigatorio(txtValorParcela.Texts))
            {
                MessageBox.Show("Campo Valor Parcela é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorParcela.Focus();
            }
            else if (!CampoObrigatorio(dVencimento))
            {
                MessageBox.Show("Campo Data Vencimento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataVencimento.Focus();
            }
            else
            {
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
                    decimal desconto = string.IsNullOrEmpty(txtDesconto.Texts) ? 0 : Convert.ToDecimal(txtDesconto.Texts);
                    decimal juros = string.IsNullOrEmpty(txtJuros.Texts) ? 0 : Convert.ToDecimal(txtJuros.Texts);
                    decimal multa = string.IsNullOrEmpty(txtMulta.Texts) ? 0 : Convert.ToDecimal(txtMulta.Texts);
                    DateTime? dataPagamento = string.IsNullOrEmpty(txtDataPagamento.Texts) ? (DateTime?)null : Convert.ToDateTime(txtDataPagamento.Texts);
                    decimal valorPago = string.IsNullOrEmpty(txtValorPago.Texts) ? 0 : Convert.ToDecimal(txtValorPago.Texts); //se nao for null
                    DateTime? dataCancelamento = string.IsNullOrEmpty(txtDataCancelamento.Texts) ? (DateTime?)null : Convert.ToDateTime(txtDataCancelamento.Texts);
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
                        desconto = desconto,
                        juros = juros,
                        multa = multa,
                        observacao = observacao,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt
                    };
                    if (idAlterar == -1)
                    {
                        contasPagarController.Salvar(novaContaPagar);
                    }
                    else
                    {
                        novaContaPagar.numeroNota = NumeroNota;
                        novaContaPagar.modelo = Modelo;
                        novaContaPagar.serie = Serie;
                        novaContaPagar.idFornecedor = IdFornecedor;
                        novaContaPagar.parcela = Parcela;
                        contasPagarController.Alterar(novaContaPagar);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void calculaTotalPagar()
        //{
        //    decimal valorDesconto = Convert.ToDecimal(txtDesconto.Texts);
        //    decimal valorJuros = Convert.ToDecimal(txtJuros.Texts);
        //    decimal valorMulta = Convert.ToDecimal(txtMulta.Texts);
        //    decimal valorParcela = Convert.ToDecimal(txtValorParcela.Texts);
        //    decimal totalPagar = valorDesconto + valorJuros + valorMulta + valorParcela;
        //    txtTotalPagar.Texts = totalPagar.ToString();
        //}

        private void CadastroContasPagar_Load(object sender, EventArgs e)
        {
            if (NumeroNota != -1 && Modelo != -1 && Serie != -1 && IdFornecedor != -1 && Parcela != -1)
            {
                btnPagar.Visible = true;
                btnSalvar.Visible = true;
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
    }
}
