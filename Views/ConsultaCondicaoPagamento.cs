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
    public partial class ConsultaCondicaoPagamento : Sistema_Vendas.ConsultaPai
    {
        private CondicaoPagamentoController<CondicaoPagamentoModel> condicaoPagamentoController;
        private CadastroCondicaoPagamento cadastroCondicaoPagamento;
        public ConsultaCondicaoPagamento()
        {
            InitializeComponent();
            condicaoPagamentoController = new CondicaoPagamentoController<CondicaoPagamentoModel>();
            cadastroCondicaoPagamento = new CadastroCondicaoPagamento();
            cadastroCondicaoPagamento.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroCondicaoPagamento.txtCondPag.Focus();
            cadastroCondicaoPagamento.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewCondPag.SelectedRows.Count > 0)
            {
                int idCondPag = (int)dataGridViewCondPag.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idCondPag);
                cadastroCondicaoPagamento.txtCondPag.Focus();
                cadastroCondicaoPagamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma condição de pagamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewCondPag.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta condição de pagamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idCondPag = (int)dataGridViewCondPag.SelectedRows[0].Cells["Código"].Value;
                    condicaoPagamentoController.Delete(idCondPag);
                    dataGridViewCondPag.DataSource = condicaoPagamentoController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma condição de pagamento para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<CondicaoPagamentoModel> resultadosPesquisa = new List<CondicaoPagamentoModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (rbNome.Checked)
                    {
                        resultadosPesquisa = condicaoPagamentoController.GetAll(buscaInativos)
                                                           .Where(p => p.condicaoPagamento.Contains(pesquisa))
                                                           .ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = condicaoPagamentoController.GetAll(buscaInativos)
                                                               .Where(p => p.idCondPagamento == codigoPesquisa)
                                                               .ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewCondPag.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaCondPag(cbBuscaInativos.Checked);
            }
        }

        private void ResetCadastro()
        {
            cadastroCondicaoPagamento.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroCondicaoPagamento.SetID(id);
            cadastroCondicaoPagamento.limpaCamposParcelas();
            cadastroCondicaoPagamento.Carrega();
        }

        public void AtualizarConsultaCondPag(bool incluirInativos)
        {
            try
            {
                dataGridViewCondPag.DataSource = condicaoPagamentoController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de condições de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaCondicaoPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroCondicaoPagamento.FormClosed += (s, args) => AtualizarConsultaCondPag(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta
                dataGridViewCondPag.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewCondPag.AutoGenerateColumns = false;
                dataGridViewCondPag.Columns["Código"].DataPropertyName = "idCondPagamento";
                dataGridViewCondPag.Columns["Condição"].DataPropertyName = "condicaoPagamento";

                AtualizarConsultaCondPag(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as condições de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaCondPag(incluirInativos);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewCondPag.SelectedRows.Count > 0)
                {
                    int idCondPag = Convert.ToInt32(dataGridViewCondPag.SelectedRows[0].Cells["Código"].Value);
                    string condPag = dataGridViewCondPag.SelectedRows[0].Cells["Condição"].Value.ToString();

                    this.Tag = new Tuple<int, string>(idCondPag, condPag);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma condição de pagamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void dataGridViewCondPag_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idCondPag = (int)dataGridViewCondPag.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idCondPag);
                cadastroCondicaoPagamento.ShowDialog();
            }
        }
    }
}
