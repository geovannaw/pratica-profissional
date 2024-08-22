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
    public partial class ConsultaNotaCompra : Sistema_Vendas.ConsultaPai
    {
        private CadastroNotaCompra cadastroNotaCompra;
        private NotaCompraController<NotaCompraModel> notaCompraController;
        private FornecedorController<FornecedorModel> fornecedorController;

        public ConsultaNotaCompra()
        {
            InitializeComponent();
            cadastroNotaCompra = new CadastroNotaCompra();
            notaCompraController = new NotaCompraController<NotaCompraModel>();
            fornecedorController = new FornecedorController<FornecedorModel>();
            cadastroNotaCompra.Owner = this;
        }
        public override void Incluir()
        {
            ResetCadastro();
            cadastroNotaCompra.txtNroNota.Focus();
            cadastroNotaCompra.ShowDialog();
        }

        private void ResetCadastro()
        {
            cadastroNotaCompra.LimparCampos();
        }
        private void ResetCadastro(int numero, int modelo, int serie, int idFornecedor)
        {
            cadastroNotaCompra.SetID(numero, modelo, serie, idFornecedor);
            cadastroNotaCompra.BloqueiaTudo();
            cadastroNotaCompra.Carrega();
        }
        public void Visualizar()
        {
            if (dataGridViewNFCompra.SelectedRows.Count > 0)
            {
                int idNFCompra = (int)dataGridViewNFCompra.SelectedRows[0].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewNFCompra.SelectedRows[0].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewNFCompra.SelectedRows[0].Cells["serie"].Value;
                int idFornecedorNF = (int)dataGridViewNFCompra.SelectedRows[0].Cells["idFornecedor"].Value;
                ResetCadastro(idNFCompra, modeloNF, serieNF, idFornecedorNF);
                cadastroNotaCompra.txtNroNota.Focus();
                cadastroNotaCompra.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma nota para visualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Visualizar();
        }
        public void AtualizarConsultaNotaCompra(bool incluirInativos)
        {
            try
            {
                dataGridViewNFCompra.DataSource = notaCompraController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Notas de Compra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaNotaCompra_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroNotaCompra.FormClosed += (s, args) => AtualizarConsultaNotaCompra(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta
                dataGridViewNFCompra.Columns["numeroNota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFCompra.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFCompra.Columns["serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFCompra.Columns["idFornecedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFCompra.AutoGenerateColumns = false;
                dataGridViewNFCompra.Columns["numeroNota"].DataPropertyName = "numeroNota";
                dataGridViewNFCompra.Columns["modelo"].DataPropertyName = "modelo";
                dataGridViewNFCompra.Columns["serie"].DataPropertyName = "serie";
                dataGridViewNFCompra.Columns["idFornecedor"].DataPropertyName = "idFornecedor";
                dataGridViewNFCompra.Columns["dataChegada"].DataPropertyName = "dataChegada";
                dataGridViewNFCompra.Columns["dataChegada"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewNFCompra.Columns["DataCancelamento"].DataPropertyName = "dataCancelamento";
                dataGridViewNFCompra.Columns["DataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";

                AtualizarConsultaNotaCompra(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as Notas de Compra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<NotaCompraModel> resultadosPesquisa = new List<NotaCompraModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (int.TryParse(pesquisa, out int numeroNotaPesquisa))
                    {
                        resultadosPesquisa = notaCompraController.GetAll(buscaInativos).Where(p => p.numeroNota == numeroNotaPesquisa).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de nota válido.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dataGridViewNFCompra.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaNotaCompra(cbBuscaInativos.Checked);
            }
        }

        private void dataGridViewNFCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int numeroNF = (int)dataGridViewNFCompra.Rows[e.RowIndex].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewNFCompra.Rows[e.RowIndex].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewNFCompra.Rows[e.RowIndex].Cells["serie"].Value;
                int idFornecedorNF = (int)dataGridViewNFCompra.Rows[e.RowIndex].Cells["idFornecedor"].Value;
                ResetCadastro(numeroNF, modeloNF, serieNF, idFornecedorNF);
                cadastroNotaCompra.ShowDialog();
            }
        }

        private void dataGridViewNFCompra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewNFCompra.Columns[e.ColumnIndex].Name == "fornecedor" && e.RowIndex >= 0)
            {
                //id do fornecedor na linha atual
                int idFornecedorNF = (int)dataGridViewNFCompra.Rows[e.RowIndex].Cells["idFornecedor"].Value;
                FornecedorModel fornecedor = fornecedorController.GetById(idFornecedorNF);

                if (fornecedor != null)
                {
                    e.Value = fornecedor.fornecedor_razao_social;
                }
                else
                {
                    e.Value = "Fornecedor não encontrado";
                }

                e.FormattingApplied = true;
            }
            if (dataGridViewNFCompra.Columns[e.ColumnIndex].Name == "DataCancelamento" && e.RowIndex >= 0)
            {
                var dataCancelamento = dataGridViewNFCompra.Rows[e.RowIndex].Cells["DataCancelamento"].Value;
                if (dataCancelamento != DBNull.Value && dataCancelamento != null)
                {
                    dataGridViewNFCompra.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    dataGridViewNFCompra.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridViewNFCompra.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void dataGridViewNFCompra_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }
    }
}
