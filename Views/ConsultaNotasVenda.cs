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
    public partial class ConsultaNotasVenda : Sistema_Vendas.ConsultaPai
    {
        private CadastroNotaVenda cadastroNotaVenda;
        private NotaVendaController<NotaVendaModel> notaVendaController;
        private ClienteController<ClienteModel> clienteController;
        public ConsultaNotasVenda()
        {
            InitializeComponent();
            cadastroNotaVenda = new CadastroNotaVenda();
            notaVendaController = new NotaVendaController<NotaVendaModel>();
            clienteController = new ClienteController<ClienteModel>();
            cadastroNotaVenda.Owner = this;
        }
        public override void Incluir()
        {
            ResetCadastro();
            cadastroNotaVenda.txtNroNota.Focus();
            cadastroNotaVenda.ShowDialog();
        }

        private void ResetCadastro()
        {
            cadastroNotaVenda.LimparCampos();
        }
        private void ResetCadastro(int numero, int modelo, int serie, int idFornecedor)
        {
            cadastroNotaVenda.SetID(numero, modelo, serie, idFornecedor);
            cadastroNotaVenda.BloqueiaTudo();
            cadastroNotaVenda.Carrega();
        }
        public void Visualizar()
        {
            if (dataGridViewNFVenda.SelectedRows.Count > 0)
            {
                int idNFVenda = (int)dataGridViewNFVenda.SelectedRows[0].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewNFVenda.SelectedRows[0].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewNFVenda.SelectedRows[0].Cells["serie"].Value;
                int idClienteNF = (int)dataGridViewNFVenda.SelectedRows[0].Cells["idCliente"].Value;
                ResetCadastro(idNFVenda, modeloNF, serieNF, idClienteNF);
                cadastroNotaVenda.txtNroNota.Focus();
                cadastroNotaVenda.ShowDialog();
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
        public void AtualizarConsultaNotaVenda(bool incluirInativos)
        {
            try
            {
                dataGridViewNFVenda.DataSource = notaVendaController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Notas de Venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaNotasVenda_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroNotaVenda.FormClosed += (s, args) => AtualizarConsultaNotaVenda(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta
                dataGridViewNFVenda.Columns["numeroNota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFVenda.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFVenda.Columns["serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFVenda.Columns["idCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFVenda.AutoGenerateColumns = false;
                dataGridViewNFVenda.Columns["numeroNota"].DataPropertyName = "numeroNota";
                dataGridViewNFVenda.Columns["modelo"].DataPropertyName = "modelo";
                dataGridViewNFVenda.Columns["serie"].DataPropertyName = "serie";
                dataGridViewNFVenda.Columns["idCliente"].DataPropertyName = "idCliente";
                dataGridViewNFVenda.Columns["dataEmissao"].DataPropertyName = "dataEmissao";
                dataGridViewNFVenda.Columns["dataEmissao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewNFVenda.Columns["DataCancelamento"].DataPropertyName = "DataCancelamento";
                dataGridViewNFVenda.Columns["DataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";

                AtualizarConsultaNotaVenda(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as Notas de Venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<NotaVendaModel> resultadosPesquisa = new List<NotaVendaModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (int.TryParse(pesquisa, out int numeroNotaPesquisa))
                    {
                        resultadosPesquisa = notaVendaController.GetAll(buscaInativos).Where(p => p.numeroNota == numeroNotaPesquisa).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de nota válido.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dataGridViewNFVenda.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaNotaVenda(cbBuscaInativos.Checked);
            }
        }

        private void dataGridViewNFVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int numeroNF = (int)dataGridViewNFVenda.Rows[e.RowIndex].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewNFVenda.Rows[e.RowIndex].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewNFVenda.Rows[e.RowIndex].Cells["serie"].Value;
                int idClienteNF = (int)dataGridViewNFVenda.Rows[e.RowIndex].Cells["idCliente"].Value;
                ResetCadastro(numeroNF, modeloNF, serieNF, idClienteNF);
                cadastroNotaVenda.ShowDialog();
            }
        }

        private void dataGridViewNFVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewNFVenda.Columns[e.ColumnIndex].Name == "cliente" && e.RowIndex >= 0)
            {
                //id do cliente na linha atual
                int idClienteNF = (int)dataGridViewNFVenda.Rows[e.RowIndex].Cells["idCliente"].Value;
                ClienteModel cliente = clienteController.GetById(idClienteNF);

                if (cliente != null)
                {
                    e.Value = cliente.cliente_razao_social;
                }
                else
                {
                    e.Value = "Cliente não encontrado";
                }

                e.FormattingApplied = true;
            }
            if (dataGridViewNFVenda.Columns[e.ColumnIndex].Name == "DataCancelamento" && e.RowIndex >= 0)
            {
                var dataCancelamento = dataGridViewNFVenda.Rows[e.RowIndex].Cells["DataCancelamento"].Value;
                if (dataCancelamento != DBNull.Value && dataCancelamento != null)
                {
                    dataGridViewNFVenda.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    dataGridViewNFVenda.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridViewNFVenda.DefaultCellStyle.ForeColor;
                }
            }
        }
    }
}
