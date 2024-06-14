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
    public partial class ConsultaFormasPagamento : Sistema_Vendas.ConsultaPai
    {
        private FormaPagamentoController<FormaPagamentoModel> formaPagamentoController;
        private CadastroFormaPagamento cadastroFormaPagamento;
        public ConsultaFormasPagamento()
        {
            InitializeComponent();
            formaPagamentoController = new FormaPagamentoController<FormaPagamentoModel> ();
            cadastroFormaPagamento = new CadastroFormaPagamento();
            cadastroFormaPagamento.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroFormaPagamento.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewFormaPag.SelectedRows.Count > 0)
            {
                int idFormaPag = (int)dataGridViewFormaPag.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idFormaPag);
                cadastroFormaPagamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewFormaPag.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta forma de pagamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idFormaPag = (int)dataGridViewFormaPag.SelectedRows[0].Cells["Código"].Value;
                    formaPagamentoController.Delete(idFormaPag);
                    dataGridViewFormaPag.DataSource = formaPagamentoController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Text.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<FormaPagamentoModel> resultadosPesquisa = new List<FormaPagamentoModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;
                    if (rbNome.Checked)
                    {
                        resultadosPesquisa = formaPagamentoController.GetAll(buscaInativos).Where(p => p.formaPagamento.ToLower().Contains(pesquisa.ToLower())).ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = formaPagamentoController.GetAll(buscaInativos).Where(p => p.idFormaPagamento == codigoPesquisa).ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewFormaPag.DataSource = resultadosPesquisa;
                    txtPesquisar.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar formas de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaFormasPag(cbBuscaInativos.Checked);
            }
        }
        private void ResetCadastro()
        {
            //reseta a instância para uma nova inclusão
            cadastroFormaPagamento.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            //reseta a instância para editar conforme o id
            cadastroFormaPagamento.SetID(id);
            cadastroFormaPagamento.Carrega();
        }

        private void ConsultaFormasPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroFormaPagamento.FormClosed += (s, args) => AtualizarConsultaFormasPag(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewFormaPag.AutoGenerateColumns = false;
                dataGridViewFormaPag.Columns["Código"].DataPropertyName = "idFormaPagamento";
                dataGridViewFormaPag.Columns["formaPagamento"].DataPropertyName = "formaPagamento";

                AtualizarConsultaFormasPag(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as formas de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizarConsultaFormasPag(bool incluirInativos)
        {
            try
            {
                dataGridViewFormaPag.DataSource = formaPagamentoController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de formas de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaFormasPag(incluirInativos);
        }

        private void dataGridViewFormaPag_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idFormaPag = (int)dataGridViewFormaPag.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idFormaPag);
                cadastroFormaPagamento.ShowDialog();
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewFormaPag.SelectedRows.Count > 0)
                {
                    int idFormaPag = Convert.ToInt32(dataGridViewFormaPag.SelectedRows[0].Cells["Código"].Value);
                    string formaPag = dataGridViewFormaPag.SelectedRows[0].Cells["formaPagamento"].Value.ToString();

                    this.Tag = new Tuple<int, string>(idFormaPag, formaPag);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma forma de pagamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }
    }
}
