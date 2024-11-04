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
        public override void LimparCampos()
        {
            base.LimparCampos();
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
            txtUsuarioUltAlt.Clear();
            limpaCamposParcelas();
        }

        public void limpaCamposParcelas()
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
            if (!string.IsNullOrEmpty(txtPorcentagemTotal.Texts))
            {
                decimal porcentagem = Convert.ToDecimal(txtPorcentagemTotal.Texts);
                if (porcentagem != 100)
                {
                    MessageBox.Show("A porcentagem total deve ser igual a 100%.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!CampoObrigatorio(txtCondPag.Texts))
            {
                MessageBox.Show("Campo Condição de Pagamento é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCondPag.Focus();
            }
            else if (dataGridViewParcelas.Rows.Count == 0) //verifica se tem pelo menos uma parcela
            {
                MessageBox.Show("É necessário adicionar pelo menos uma parcela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string condPagamento = txtCondPag.Texts;
                    decimal desconto = Convert.ToDecimal(txtDesconto.Texts);
                    decimal juros = Convert.ToDecimal(txtJuros.Texts);
                    decimal multa = Convert.ToDecimal(txtMulta.Texts);
                    string usuario = Program.usuarioLogado;
                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    CondicaoPagamentoModel NovaCondPagamento = new CondicaoPagamentoModel
                    {
                        condicaoPagamento = condPagamento,
                        desconto = desconto,
                        juros = juros,
                        multa = multa,
                        Ativo = isAtivo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        usuario = usuario,
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
            base.Carrega();
            var condicaoPagamento = condPagamentoController.GetById(idAlterar);
            if (condicaoPagamento != null)
            {
                txtCodigo.Texts = condicaoPagamento.idCondPagamento.ToString();
                txtUsuarioUltAlt.Texts = condicaoPagamento.usuario.ToString();
                txtCondPag.Texts = condicaoPagamento.condicaoPagamento;
                txtJuros.Texts = condicaoPagamento.juros.ToString();
                txtMulta.Texts = condicaoPagamento.multa.ToString();
                txtDesconto.Texts = condicaoPagamento.desconto.ToString();
                txtDataCadastro.Texts = condicaoPagamento.dataCadastro.ToString();
                txtDataUltAlt.Texts = condicaoPagamento.dataUltAlt.ToString();
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
            dataGridViewParcelas.Sort(dataGridViewParcelas.Columns["numeroParcela"], ListSortDirection.Ascending); 
        }
        private bool verificaNumeroParcela(int numeroParcela)
        {
            foreach (DataGridViewRow row in dataGridViewParcelas.Rows)
            {
                if (Convert.ToInt32(row.Cells["numeroParcela"].Value) == numeroParcela)
                {
                    return true;
                }
            }
            return false;
        }
        private void atualizaPorcentagemTotal()
        {
            decimal porcentagemTotal = 0;

            foreach (DataGridViewRow row in dataGridViewParcelas.Rows) //percorre as linhas do dgv
            {
                porcentagemTotal += Convert.ToDecimal(row.Cells["porcentagem"].Value); //add os valores da coluna porcentagem a variavel
            }
            txtPorcentagemTotal.Texts = porcentagemTotal.ToString("F2"); //att o campo com 2 casas decimais
        }

        private void CadastroCondicaoPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaCondicaoPagamento)this.Owner).AtualizarConsultaCondPag(false);
        }
        private void CadastroCondicaoPagamento_Load(object sender, EventArgs e)
        {
            if (idAlterar == -1)
            {
                int novoCodigo = condPagamentoController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
                txtParcela.Texts = "1";
                txtJuros.Texts = "0";
                txtMulta.Texts = "0";
                txtDesconto.Texts = "0";
            }
            dataGridViewParcelas.Columns["numeroParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewParcelas.Columns["dias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewParcelas.Columns["porcentagem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewParcelas.Columns["CódFormaPag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void txtPorcentagem_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPorcentagem.Texts) && decimal.Parse(txtPorcentagem.Texts) == 0)
            {
                MessageBox.Show("A porcentagem deve ser maior que zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPorcentagem.Focus();
            }
            else
            {
                try
                {
                    txtPorcentagem.Texts = FormataPreco(txtPorcentagem.Texts);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Formato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPorcentagem.Focus();
                }
            }
            
        }

        private void txtCodFormaPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddParcela_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio(txtParcela.Texts))
            {
                MessageBox.Show("Campo Nº Parcela é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParcela.Focus();
            }
            else if (!CampoObrigatorio(txtDias.Texts))
            {
                MessageBox.Show("Campo Dias é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDias.Focus();
            }
            else if (!CampoObrigatorio(txtPorcentagem.Texts))
            {
                MessageBox.Show("Campo % é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPorcentagem.Focus();
            }
            else if (!CampoObrigatorio(txtCodFormaPag.Texts))
            {
                MessageBox.Show("Campo Código Forma Pagamento é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodFormaPag.Focus();
            }
            else
            {
                try
                {
                    int numeroParcela = Convert.ToInt32(txtParcela.Texts);
                    if (verificaNumeroParcela(numeroParcela))
                    {
                        MessageBox.Show("Número de parcela já existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtParcela.Focus();
                        return;
                    }

                    int dias = Convert.ToInt32(txtDias.Texts);
                    decimal porcentagem = Convert.ToDecimal(txtPorcentagem.Texts);
                    int idFormaPag = Convert.ToInt32(txtCodFormaPag.Texts);
                    string formaPagamento = txtFormaPag.Texts;

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

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtMulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtParcela_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParcela.Texts))
            {
                return;
            }
            //remove os zeros à esquerda e verifica se o valor é 0 ou se foi digitado apenas zeros
            if (string.IsNullOrWhiteSpace(txtParcela.Texts.TrimStart('0')))
            {
                MessageBox.Show("O número da parcela não pode ser 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParcela.Focus();
            }
        }

        private void txtJuros_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJuros.Texts))
            {
                txtJuros.Texts = "0,00";
            }
            else
            {
                try
                {
                    txtJuros.Texts = FormataPreco(txtJuros.Texts);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Formato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtJuros.Focus();
                }
            }
        }

        private void txtMulta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMulta.Texts))
            {
                txtMulta.Texts = "0,00";
            }
            else
            {
                try
                {
                    txtMulta.Texts = FormataPreco(txtMulta.Texts);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Formato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMulta.Focus();
                }
            }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesconto.Texts))
            {
                txtDesconto.Texts = "0,00";
            }
            else
            {
                try
                {
                    txtDesconto.Texts = FormataPreco(txtDesconto.Texts);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Formato inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDesconto.Focus();
                }
            }
        }

        private void dataGridViewParcelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
