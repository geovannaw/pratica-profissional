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
    public partial class ConsultaContasPagar : Sistema_Vendas.ConsultaPai
    {
        private CadastroContasPagar cadastroContasPagar;
        private FornecedorController<FornecedorModel> fornecedorController;
        private ContasPagarController<ContasPagarModel> contasPagarController;
        public ConsultaContasPagar()
        {
            InitializeComponent();
            cadastroContasPagar = new CadastroContasPagar();
            fornecedorController = new FornecedorController<FornecedorModel>();
            cadastroContasPagar.Owner = this;
            contasPagarController = new ContasPagarController<ContasPagarModel>();
        }
        public override void Incluir()
        {
            ResetCadastro();
            cadastroContasPagar.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewContasPagar.SelectedRows.Count > 0)
            {
                int idNFCompra = (int)dataGridViewContasPagar.SelectedRows[0].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewContasPagar.SelectedRows[0].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewContasPagar.SelectedRows[0].Cells["serie"].Value;
                int idFornecedorNF = (int)dataGridViewContasPagar.SelectedRows[0].Cells["idFornecedor"].Value;
                int parcelaNF = (int)dataGridViewContasPagar.SelectedRows[0].Cells["parcela"].Value;
                ResetCadastro(idNFCompra, modeloNF, serieNF, idFornecedorNF, parcelaNF);
                cadastroContasPagar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma conta para visualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ResetCadastro()
        {
            cadastroContasPagar.LimparCampos();
        }
        private void ResetCadastro(int numero, int modelo, int serie, int idFornecedor, int parcela)
        {
            cadastroContasPagar.SetID(numero, modelo, serie, idFornecedor, parcela);
            cadastroContasPagar.Bloqueia();
            cadastroContasPagar.Carrega();
        }
        public void AtualizarConsultaContasPagar(bool incluirInativos)
        {
            try
            {
                dataGridViewContasPagar.DataSource = contasPagarController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Contas a Pagar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<ContasPagarModel> resultadosPesquisa = new List<ContasPagarModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (int.TryParse(pesquisa, out int numeroNotaPesquisa))
                    {
                        resultadosPesquisa = contasPagarController.GetAll(buscaInativos).Where(p => p.numeroNota == numeroNotaPesquisa).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de nota válido.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dataGridViewContasPagar.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaContasPagar(cbBuscaInativos.Checked);
            }
        }

        private void ConsultaContasPagar_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroContasPagar.FormClosed += (s, args) => AtualizarConsultaContasPagar(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta
                dataGridViewContasPagar.Columns["numeroNota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasPagar.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasPagar.Columns["serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasPagar.Columns["idFornecedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasPagar.Columns["parcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasPagar.Columns["valorParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasPagar.AutoGenerateColumns = false;
                dataGridViewContasPagar.Columns["numeroNota"].DataPropertyName = "numeroNota";
                dataGridViewContasPagar.Columns["modelo"].DataPropertyName = "modelo";
                dataGridViewContasPagar.Columns["serie"].DataPropertyName = "serie";
                dataGridViewContasPagar.Columns["idFornecedor"].DataPropertyName = "idFornecedor";
                dataGridViewContasPagar.Columns["parcela"].DataPropertyName = "parcela";
                dataGridViewContasPagar.Columns["valorParcela"].DataPropertyName = "valorParcela";
                dataGridViewContasPagar.Columns["dataVencimento"].DataPropertyName = "dataVencimento";
                dataGridViewContasPagar.Columns["dataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContasPagar.Columns["dataPagamento"].DataPropertyName = "dataPagamento";
                dataGridViewContasPagar.Columns["dataPagamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContasPagar.Columns["dataCancelamento"].DataPropertyName = "dataCancelamento";
                dataGridViewContasPagar.Columns["dataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";

                AtualizarConsultaContasPagar(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as Contas a Pagar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewContasPagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int numeroNF = (int)dataGridViewContasPagar.Rows[e.RowIndex].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewContasPagar.Rows[e.RowIndex].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewContasPagar.Rows[e.RowIndex].Cells["serie"].Value;
                int idFornecedorNF = (int)dataGridViewContasPagar.Rows[e.RowIndex].Cells["idFornecedor"].Value;
                int parcelaNF = (int)dataGridViewContasPagar.Rows[e.RowIndex].Cells["parcela"].Value;
                ResetCadastro(numeroNF, modeloNF, serieNF, idFornecedorNF, parcelaNF);
                cadastroContasPagar.ShowDialog();
            }
        }

        private void dataGridViewContasPagar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewContasPagar.Columns[e.ColumnIndex].Name == "fornecedor" && e.RowIndex >= 0)
            {
                int idFornecedorNF = (int)dataGridViewContasPagar.Rows[e.RowIndex].Cells["idFornecedor"].Value;
                FornecedorModel fornecedor = fornecedorController.GetById(idFornecedorNF);

                e.Value = fornecedor != null ? fornecedor.fornecedor_razao_social : "Fornecedor não encontrado";
                e.FormattingApplied = true;
            }

            //verifica se a coluna 'dataPagamento'
            if (dataGridViewContasPagar.Columns[e.ColumnIndex].Name == "dataPagamento" && e.RowIndex >= 0)
            {
                var dataPagamento = dataGridViewContasPagar.Rows[e.RowIndex].Cells["dataPagamento"].Value;
                if (dataPagamento != DBNull.Value && dataPagamento != null)
                {
                    dataGridViewContasPagar.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green; //se estiver pago fica verde
                }
                else
                {
                    dataGridViewContasPagar.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridViewContasPagar.DefaultCellStyle.ForeColor;
                }
            }

            //verifica data vencimento e cancelamento
            var dataVencimentoValue = dataGridViewContasPagar.Rows[e.RowIndex].Cells["dataVencimento"].Value;
            var pagamentoValue = dataGridViewContasPagar.Rows[e.RowIndex].Cells["dataPagamento"].Value;
            var dataCancelamentoValue = dataGridViewContasPagar.Rows[e.RowIndex].Cells["dataCancelamento"].Value;

            if (dataCancelamentoValue != DBNull.Value && dataCancelamentoValue != null)
            {
                e.CellStyle.ForeColor = Color.Red;
            }
            else
            {
                //verifica vencimento e pagamento
                if (dataVencimentoValue != null && DateTime.TryParse(dataVencimentoValue.ToString(), out DateTime dataVencimento))
                {
                    if (dataVencimento < DateTime.Now.Date && string.IsNullOrEmpty(pagamentoValue?.ToString()))
                    {
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#ff6400"); //se venceu fica laranja
                    }
                    else if (!string.IsNullOrEmpty(pagamentoValue?.ToString()))
                    {
                        e.CellStyle.ForeColor = Color.Green; //se ta pago verde
                    }
                    else
                    {
                        e.CellStyle.ForeColor = dataGridViewContasPagar.DefaultCellStyle.ForeColor; //se esta em dia fica a cor padrao
                    }
                }
            }
        }

        private void dataGridViewContasPagar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
