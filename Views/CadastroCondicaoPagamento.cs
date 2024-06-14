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
    public partial class CadastroCondicaoPagamento : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private CondicaoPagamentoController<CondicaoPagamentoModel> condPagamentoController;
        private ConsultaFormasPagamento consultaFormasPagamento;
        private FormaPagamentoController<FormaPagamentoModel> formaPagamentoController;
        public CadastroCondicaoPagamento()
        {
            InitializeComponent();
            condPagamentoController = new CondicaoPagamentoController<CondicaoPagamentoModel>();
            consultaFormasPagamento = new ConsultaFormasPagamento();
            formaPagamentoController = new FormaPagamentoController<FormaPagamentoModel>();
        }

        public CadastroCondicaoPagamento(int idCondPag) : this()
        {
            idAlterar = idCondPag;
            Carrega();
        }

        public override void LimparCampos()
        {
            idAlterar = -1;
            txtCodigo.Clear();
            txtCondPag.Clear();
            txtJuros.Clear();
            txtMulta.Clear();
            txtDesconto.Clear();
            txtParcela.Clear();
            txtDias.Clear();
            txtPorcentagem.Clear();
            txtPorcentagemTotal.Clear();
            txtCodFormaPag.Clear();
            txtFormaPag.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            rbAtivo.Checked = true;
            dataGridViewParcelas.Rows.Clear();
        }

        private void limpaCamposParcelas()
        {
            txtParcela.Clear();
            txtDias.Clear();
            txtPorcentagem.Clear();
            txtCodFormaPag.Clear();
            txtFormaPag.Clear();
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        public override void Salvar()
        {
            if (!string.IsNullOrEmpty(txtPorcentagemTotal.Text))
            {
                decimal porcentagem = Convert.ToDecimal(txtPorcentagemTotal.Text);
                if (porcentagem != 100)
                {
                    MessageBox.Show("A porcentagem total deve ser igual a 100%.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!CampoObrigatorio(txtCondPag.Text))
            {
                MessageBox.Show("Campo Condição de Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCondPag.Focus();
            }
            else if (dataGridViewParcelas.Rows.Count == 0) //verifica se tem pelo menos uma parcela
            {
                MessageBox.Show("É necessário adicionar pelo menos uma parcela.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string condPagamento = txtCondPag.Text;
                    decimal desconto = Convert.ToDecimal(txtDesconto.Text);
                    decimal juros = Convert.ToDecimal(txtJuros.Text);
                    decimal multa = Convert.ToDecimal(txtMulta.Text);
                    DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                    CondicaoPagamentoModel NovaCondPagamento = new CondicaoPagamentoModel
                    {
                        condicaoPagamento = condPagamento,
                        desconto = desconto,
                        juros = juros,
                        multa = multa,
                        Ativo = isAtivo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        Parcelas = obtemParcelas()
                    };
                    if (idAlterar == -1)
                    {
                        condPagamentoController.Salvar(NovaCondPagamento);
                    }
                    else
                    {
                        NovaCondPagamento.idCondPagamento = idAlterar;
                        condPagamentoController.Alterar(NovaCondPagamento);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void Carrega()
        {
            var condicaoPagamento = condPagamentoController.GetById(idAlterar);
            if (condicaoPagamento != null)
            {
                txtCodigo.Text = condicaoPagamento.idCondPagamento.ToString();
                txtCondPag.Text = condicaoPagamento.condicaoPagamento;
                txtJuros.Text = condicaoPagamento.juros.ToString();
                txtMulta.Text = condicaoPagamento.multa.ToString();
                txtDesconto.Text = condicaoPagamento.desconto.ToString();
                txtDataCadastro.Text = condicaoPagamento.dataCadastro.ToString();
                txtDataUltAlt.Text = condicaoPagamento.dataUltAlt.ToString();
                rbAtivo.Checked = condicaoPagamento.Ativo;

                exibirParcelasDGV(condicaoPagamento.Parcelas);
                atualizaPorcentagemTotal();
            }
        }

        private List<ParcelaModel> obtemParcelas()
        {
            List<ParcelaModel> parcelas = new List<ParcelaModel>(); //lista para armazenar as parcelas

            foreach (DataGridViewRow row in dataGridViewParcelas.Rows) //percorrendo o dgv de parcelas
            {
                ParcelaModel parcela = new ParcelaModel //armazena os valores das linhas
                {
                    numeroParcela = Convert.ToInt32(row.Cells["numeroParcela"].Value),
                    dias = Convert.ToInt32(row.Cells["dias"].Value),
                    porcentagem = Convert.ToDecimal(row.Cells["porcentagem"].Value),
                    idFormaPagamento = Convert.ToInt32(row.Cells["CódFormaPag"].Value)
                };
                parcelas.Add(parcela);
            }

            return parcelas;
        }

        private void exibirParcelasDGV(List<ParcelaModel> parcelas)
        {
            dataGridViewParcelas.Rows.Clear(); //limpa as linhas do dgv

            foreach (var parcela in parcelas) //vai adicionando as parcelas
            {
                string formaPagamento = condPagamentoController.GetFormaPagByParcelaId(parcela.idParcela);

                dataGridViewParcelas.Rows.Add(
                    parcela.numeroParcela,
                    parcela.dias,
                    parcela.porcentagem,
                    parcela.idFormaPagamento,
                    formaPagamento
                );
            }
            dataGridViewParcelas.Sort(dataGridViewParcelas.Columns["numeroParcela"], ListSortDirection.Ascending); dataGridViewParcelas.Sort(dataGridViewParcelas.Columns["numeroParcela"], ListSortDirection.Ascending);
        }

        private void btnAddParcela_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio(txtParcela.Text))
            {
                MessageBox.Show("Campo Nº Parcela é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParcela.Focus();
            }
            else if (!CampoObrigatorio(txtDias.Text))
            {
                MessageBox.Show("Campo Dias é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDias.Focus();
            }
            else if (!CampoObrigatorio(txtPorcentagem.Text))
            {
                MessageBox.Show("Campo % é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPorcentagem.Focus();
            }
            else if (!CampoObrigatorio(txtCodFormaPag.Text))
            {
                MessageBox.Show("Campo Código Forma Pagamento é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFormaPag.Focus();
            }
            else
            {
                try
                {
                    int numeroParcela = Convert.ToInt32(txtParcela.Text);
                    int dias = Convert.ToInt32(txtDias.Text);
                    decimal porcentagem = Convert.ToDecimal(txtPorcentagem.Text);
                    int idFormaPag = Convert.ToInt32(txtCodFormaPag.Text);
                    string formaPagamento = txtFormaPag.Text;

                    dataGridViewParcelas.Rows.Add(numeroParcela, dias, porcentagem, idFormaPag, formaPagamento); //add nova linha com os valores 

                    atualizaPorcentagemTotal();
                    dataGridViewParcelas.Sort(dataGridViewParcelas.Columns["numeroParcela"], ListSortDirection.Ascending);
                    limpaCamposParcelas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar parcela: " + ex.Message);
                }
            }
        }

        private void atualizaPorcentagemTotal()
        {
            decimal porcentagemTotal = 0;

            foreach (DataGridViewRow row in dataGridViewParcelas.Rows) //percorre as linhas do dgv
            {
                porcentagemTotal += Convert.ToDecimal(row.Cells["porcentagem"].Value); //add os valores da coluna porcentagem a variavel
            }
            txtPorcentagemTotal.Text = porcentagemTotal.ToString("F2"); //att o campo com 2 casas decimais
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

                    txtCodFormaPag.Text = idFormaPag.ToString();
                    txtFormaPag.Text = formaPag;
                }
            }
        }

        private void txtCodFormaPag_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtCodFormaPag.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodFormaPag.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCodFormaPag.Text))
                {
                    FormaPagamentoModel formaPag = formaPagamentoController.GetById(int.Parse(txtCodFormaPag.Text));
                    if (formaPag != null)
                    {
                        txtFormaPag.Text = formaPag.formaPagamento;
                    }
                    else
                    {
                        MessageBox.Show("Forma de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodFormaPag.Focus();
                    }
                }
            }
        }

        private void txtPorcentagem_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtPorcentagem.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPorcentagem.Focus();
            }
        }

        private void CadastroCondicaoPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaCondicaoPagamento)this.Owner).AtualizarConsultaCondPag(false);
        }

        private void btnExcluirParcela_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewParcelas.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewParcelas.SelectedRows)
                    {
                        dataGridViewParcelas.Rows.Remove(row);
                    }
                    atualizaPorcentagemTotal();
                }
                else
                {
                    MessageBox.Show("Selecione uma parcela para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir parcela: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtJuros_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtJuros.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJuros.Focus();
            }
        }

        private void txtMulta_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtMulta.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMulta.Focus();
            }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtDesconto.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesconto.Focus();
            }
        }

        private void txtParcela_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtParcela.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParcela.Focus();
            }
        }

        private void txtDias_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtDias.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDias.Focus();
            }
        }

        private void CadastroCondicaoPagamento_Load(object sender, EventArgs e)
        {
            if (idAlterar == -1)
            {
                txtParcela.Text = "1";
                txtJuros.Text = "0";
                txtMulta.Text = "0";
                txtDesconto.Text = "0";
            }                
        }
    }
}
