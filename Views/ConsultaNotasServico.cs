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
    public partial class ConsultaNotasServico : Sistema_Vendas.ConsultaPai
    {
        private ClienteController<ClienteModel> clienteController;
        private CadastroNotasServico cadastroNotaServico;
        private NotaServicoController<NotaServicoModel> notaServicoController;
        public ConsultaNotasServico()
        {
            InitializeComponent();
            cadastroNotaServico = new CadastroNotasServico();
            notaServicoController = new NotaServicoController<NotaServicoModel>();
            clienteController = new ClienteController<ClienteModel>();
            cadastroNotaServico.Owner = this;
        }
        public override void Incluir()
        {
            ResetCadastro();
            cadastroNotaServico.txtNroNota.Focus();
            cadastroNotaServico.ShowDialog();
        }

        private void ResetCadastro()
        {
            cadastroNotaServico.LimparCampos();
        }
        private void ResetCadastro(int numero, int modelo, int serie, int idFornecedor)
        {
            cadastroNotaServico.SetID(numero, modelo, serie, idFornecedor);
            cadastroNotaServico.BloqueiaTudo();
            cadastroNotaServico.Carrega();
        }
        public void Visualizar()
        {
            if (dataGridViewNFServico.SelectedRows.Count > 0)
            {
                int idNFVenda = (int)dataGridViewNFServico.SelectedRows[0].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewNFServico.SelectedRows[0].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewNFServico.SelectedRows[0].Cells["serie"].Value;
                int idClienteNF = (int)dataGridViewNFServico.SelectedRows[0].Cells["idCliente"].Value;
                ResetCadastro(idNFVenda, modeloNF, serieNF, idClienteNF);
                cadastroNotaServico.txtNroNota.Focus();
                cadastroNotaServico.ShowDialog();
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
        public void AtualizarConsultaNotaServico(bool incluirInativos)
        {
            try
            {
                dataGridViewNFServico.DataSource = notaServicoController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Notas de Serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaNotasServico_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroNotaServico.FormClosed += (s, args) => AtualizarConsultaNotaServico(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta
                dataGridViewNFServico.Columns["numeroNota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFServico.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFServico.Columns["serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFServico.Columns["idCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewNFServico.AutoGenerateColumns = false;
                dataGridViewNFServico.Columns["numeroNota"].DataPropertyName = "numeroNota";
                dataGridViewNFServico.Columns["modelo"].DataPropertyName = "modelo";
                dataGridViewNFServico.Columns["serie"].DataPropertyName = "serie";
                dataGridViewNFServico.Columns["idCliente"].DataPropertyName = "idCliente";
                dataGridViewNFServico.Columns["dataEmissao"].DataPropertyName = "dataEmissao";
                dataGridViewNFServico.Columns["dataEmissao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewNFServico.Columns["DataCancelamento"].DataPropertyName = "DataCancelamento";
                dataGridViewNFServico.Columns["DataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";

                AtualizarConsultaNotaServico(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as Notas de Serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<NotaServicoModel> resultadosPesquisa = new List<NotaServicoModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (int.TryParse(pesquisa, out int numeroNotaPesquisa))
                    {
                        resultadosPesquisa = notaServicoController.GetAll(buscaInativos).Where(p => p.numeroNota == numeroNotaPesquisa).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de nota válido.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dataGridViewNFServico.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaNotaServico(cbBuscaInativos.Checked);
            }
        }

        private void dataGridViewNFVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int numeroNF = (int)dataGridViewNFServico.Rows[e.RowIndex].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewNFServico.Rows[e.RowIndex].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewNFServico.Rows[e.RowIndex].Cells["serie"].Value;
                int idClienteNF = (int)dataGridViewNFServico.Rows[e.RowIndex].Cells["idCliente"].Value;
                ResetCadastro(numeroNF, modeloNF, serieNF, idClienteNF);
                cadastroNotaServico.ShowDialog();
            }
        }

        private void dataGridViewNFVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewNFServico.Columns[e.ColumnIndex].Name == "cliente" && e.RowIndex >= 0)
            {
                //id do cliente na linha atual
                int idClienteNF = (int)dataGridViewNFServico.Rows[e.RowIndex].Cells["idCliente"].Value;
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
            if (dataGridViewNFServico.Columns[e.ColumnIndex].Name == "DataCancelamento" && e.RowIndex >= 0)
            {
                var dataCancelamento = dataGridViewNFServico.Rows[e.RowIndex].Cells["DataCancelamento"].Value;
                if (dataCancelamento != DBNull.Value && dataCancelamento != null)
                {
                    dataGridViewNFServico.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    dataGridViewNFServico.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridViewNFServico.DefaultCellStyle.ForeColor;
                }
            }
        }
    }
}
