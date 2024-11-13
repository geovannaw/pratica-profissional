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
    public partial class ConsultaContasReceber : Sistema_Vendas.ConsultaPai
    {
        private CadastroContasReceber cadastroContasReceber;
        private ClienteController<ClienteModel> clienteController;
        private ContasReceberController<ContasReceberModel> contasReceberController;

        private int paginaAtual = 1;
        private const int registrosPorPagina = 10;
        private int totalPaginas;
        public ConsultaContasReceber()
        {
            InitializeComponent();
            cadastroContasReceber = new CadastroContasReceber();
            cadastroContasReceber.Owner = this;
            clienteController = new ClienteController<ClienteModel>();
            contasReceberController = new ContasReceberController<ContasReceberModel>();
        }
        public override void Incluir()
        {
            ResetCadastro();
            cadastroContasReceber.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewContasReceber.SelectedRows.Count > 0)
            {
                int idNFCompra = (int)dataGridViewContasReceber.SelectedRows[0].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewContasReceber.SelectedRows[0].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewContasReceber.SelectedRows[0].Cells["serie"].Value;
                int idClienteNF = (int)dataGridViewContasReceber.SelectedRows[0].Cells["idCliente"].Value;
                int parcelaNF = (int)dataGridViewContasReceber.SelectedRows[0].Cells["parcela"].Value;
                ResetCadastro(idNFCompra, modeloNF, serieNF, idClienteNF, parcelaNF);
                cadastroContasReceber.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma conta para visualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ResetCadastro()
        {
            cadastroContasReceber.LimparCampos();
        }
        private void ResetCadastro(int numero, int modelo, int serie, int idCliente, int parcela)
        {
            cadastroContasReceber.SetID(numero, modelo, serie, idCliente, parcela);
            cadastroContasReceber.Bloqueia();
            cadastroContasReceber.Carrega();
        }
        public void AtualizarConsultaContasReceber(bool incluirInativos)
        {
            try
            {
                List<ContasReceberModel> todasContas = contasReceberController.GetAll(incluirInativos);
                totalPaginas = (int)Math.Ceiling((double)todasContas.Count / registrosPorPagina);
                CarregarPagina(paginaAtual, todasContas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Contas a Receber: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarPagina(int pagina, List<ContasReceberModel> todasContas)
        {
            int inicio = (pagina - 1) * registrosPorPagina;
            var contasPagina = todasContas.Skip(inicio).Take(registrosPorPagina).ToList();

            dataGridViewContasReceber.DataSource = contasPagina;
            AtualizarEstadoBotoes();
        }

        private void AtualizarEstadoBotoes()
        {
            btnAnterior.Enabled = paginaAtual > 1;
            btnProximo.Enabled = paginaAtual < totalPaginas;
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<ContasReceberModel> resultadosPesquisa = new List<ContasReceberModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (int.TryParse(pesquisa, out int numeroNotaPesquisa))
                    {
                        resultadosPesquisa = contasReceberController.GetAll(buscaInativos).Where(p => p.numeroNota == numeroNotaPesquisa).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira um número de nota válido.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dataGridViewContasReceber.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaContasReceber(cbBuscaInativos.Checked);
            }
        }

        private void ConsultaContasReceber_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroContasReceber.FormClosed += (s, args) => AtualizarConsultaContasReceber(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta
                dataGridViewContasReceber.Columns["numeroNota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasReceber.Columns["modelo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasReceber.Columns["serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasReceber.Columns["idCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasReceber.Columns["parcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasReceber.Columns["valorParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewContasReceber.AutoGenerateColumns = false;
                dataGridViewContasReceber.Columns["numeroNota"].DataPropertyName = "numeroNota";
                dataGridViewContasReceber.Columns["modelo"].DataPropertyName = "modelo";
                dataGridViewContasReceber.Columns["serie"].DataPropertyName = "serie";
                dataGridViewContasReceber.Columns["idCliente"].DataPropertyName = "idCliente";
                dataGridViewContasReceber.Columns["parcela"].DataPropertyName = "parcela";
                dataGridViewContasReceber.Columns["valorParcela"].DataPropertyName = "valorParcela";
                dataGridViewContasReceber.Columns["dataVencimento"].DataPropertyName = "dataVencimento";
                dataGridViewContasReceber.Columns["dataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContasReceber.Columns["dataRecebimento"].DataPropertyName = "dataRecebimento";
                dataGridViewContasReceber.Columns["dataRecebimento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewContasReceber.Columns["dataCancelamento"].DataPropertyName = "dataCancelamento";
                dataGridViewContasReceber.Columns["dataCancelamento"].DefaultCellStyle.Format = "dd/MM/yyyy";

                AtualizarConsultaContasReceber(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as Contas a Receber: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewContasReceber_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int numeroNF = (int)dataGridViewContasReceber.Rows[e.RowIndex].Cells["numeroNota"].Value;
                int modeloNF = (int)dataGridViewContasReceber.Rows[e.RowIndex].Cells["modelo"].Value;
                int serieNF = (int)dataGridViewContasReceber.Rows[e.RowIndex].Cells["serie"].Value;
                int idclienteNF = (int)dataGridViewContasReceber.Rows[e.RowIndex].Cells["idCliente"].Value;
                int parcelaNF = (int)dataGridViewContasReceber.Rows[e.RowIndex].Cells["parcela"].Value;
                ResetCadastro(numeroNF, modeloNF, serieNF, idclienteNF, parcelaNF);
                cadastroContasReceber.ShowDialog();
            }
        }

        private void dataGridViewContasReceber_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewContasReceber.Columns[e.ColumnIndex].Name == "cliente" && e.RowIndex >= 0)
            {
                int idClienteNF = (int)dataGridViewContasReceber.Rows[e.RowIndex].Cells["idCliente"].Value;
                ClienteModel cliente = clienteController.GetById(idClienteNF);

                e.Value = cliente != null ? cliente.cliente_razao_social : "Cliente não encontrado";
                e.FormattingApplied = true;
            }

            //verifica se a coluna 'dataRecebimento'
            if (dataGridViewContasReceber.Columns[e.ColumnIndex].Name == "dataRecebimento" && e.RowIndex >= 0)
            {
                var dataRecebimento = dataGridViewContasReceber.Rows[e.RowIndex].Cells["dataRecebimento"].Value;
                if (dataRecebimento != DBNull.Value && dataRecebimento != null)
                {
                    dataGridViewContasReceber.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green; //se estiver pago fica verde
                }
                else
                {
                    dataGridViewContasReceber.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridViewContasReceber.DefaultCellStyle.ForeColor;
                }
            }

            //verifica data vencimento e cancelamento
            var dataVencimentoValue = dataGridViewContasReceber.Rows[e.RowIndex].Cells["dataVencimento"].Value;
            var recebimentoValue = dataGridViewContasReceber.Rows[e.RowIndex].Cells["dataRecebimento"].Value;
            var dataCancelamentoValue = dataGridViewContasReceber.Rows[e.RowIndex].Cells["dataCancelamento"].Value;

            if (dataCancelamentoValue != DBNull.Value && dataCancelamentoValue != null)
            {
                e.CellStyle.ForeColor = Color.Red;
            }
            else
            {
                //verifica vencimento e pagamento
                if (dataVencimentoValue != null && DateTime.TryParse(dataVencimentoValue.ToString(), out DateTime dataVencimento))
                {
                    if (dataVencimento < DateTime.Now.Date && string.IsNullOrEmpty(recebimentoValue?.ToString()))
                    {
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#ff6400"); //se venceu fica laranja
                    }
                    else if (!string.IsNullOrEmpty(recebimentoValue?.ToString()))
                    {
                        e.CellStyle.ForeColor = Color.Green; //se ta pago verde
                    }
                    else
                    {
                        e.CellStyle.ForeColor = dataGridViewContasReceber.DefaultCellStyle.ForeColor; //se esta em dia fica a cor padrao
                    }
                }
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (paginaAtual < totalPaginas)
            {
                paginaAtual++;
                AtualizarConsultaContasReceber(cbBuscaInativos.Checked);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 1)
            {
                paginaAtual--;
                AtualizarConsultaContasReceber(cbBuscaInativos.Checked);
            }
        }
    }
}
