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
    public partial class ConsultaFornecedores : Sistema_Vendas.ConsultaPai
    {
        private FornecedorController<FornecedorModel> fornecedorController;
        private CadastroFornecedores cadastroFornecedores;
        public ConsultaFornecedores()
        {
            InitializeComponent();
            fornecedorController = new FornecedorController<FornecedorModel>();
            cadastroFornecedores = new CadastroFornecedores();
            cadastroFornecedores.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroFornecedores.txtCliente_razao_social.Focus();
            cadastroFornecedores.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewFornecedores.SelectedRows.Count > 0)
            {
                int idFornecedor = (int)dataGridViewFornecedores.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idFornecedor);
                cadastroFornecedores.txtCliente_razao_social.Focus();
                cadastroFornecedores.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewFornecedores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este fornecedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idFornecedor = (int)dataGridViewFornecedores.SelectedRows[0].Cells["Código"].Value;
                    fornecedorController.Delete(idFornecedor);
                    dataGridViewFornecedores.DataSource = fornecedorController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<FornecedorModel> resultadosPesquisa = new List<FornecedorModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (rbNome.Checked)
                    {
                        resultadosPesquisa = fornecedorController.GetAll(buscaInativos)
                                                           .Where(p => p.fornecedor_razao_social.Contains(pesquisa))
                                                           .ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = fornecedorController.GetAll(buscaInativos)
                                                               .Where(p => p.idFornecedor == codigoPesquisa)
                                                               .ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewFornecedores.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaFornecedores(cbBuscaInativos.Checked);
            }
        }

        public void AtualizarConsultaFornecedores(bool incluirInativos)
        {
            try
            {
                dataGridViewFornecedores.DataSource = fornecedorController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de fornecedores: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaFornecedores_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroFornecedores.FormClosed += (s, args) => AtualizarConsultaFornecedores(cbBuscaInativos.Checked);

                dataGridViewFornecedores.AutoGenerateColumns = false;
                dataGridViewFornecedores.Columns["Código"].DataPropertyName = "idFornecedor";
                dataGridViewFornecedores.Columns["Fornecedor"].DataPropertyName = "fornecedor_razao_social";
                dataGridViewFornecedores.Columns["Tipo"].DataPropertyName = "tipo_pessoa";
                dataGridViewFornecedores.Columns["Celular"].DataPropertyName = "celular";

                AtualizarConsultaFornecedores(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar fornecedores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idFornecedor = (int)dataGridViewFornecedores.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idFornecedor);
                cadastroFornecedores.ShowDialog();
            }
        }

        private void ResetCadastro()
        {
            cadastroFornecedores.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroFornecedores.SetID(id);
            cadastroFornecedores.Carrega();
        }
        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaFornecedores(incluirInativos);
        }

        private void dataGridViewFornecedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFornecedores.Columns["Celular"].Index && e.Value != null)
            {
                // Formata o número de celular
                string celular = e.Value.ToString();
                if (celular.Length == 11)
                {
                    e.Value = string.Format("({0}) {1}-{2}", celular.Substring(0, 2), celular.Substring(2, 5), celular.Substring(7));
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == dataGridViewFornecedores.Columns["Tipo"].Index && e.Value != null)
            {
                // Converte o valor bool em uma string "Físico" ou "Jurídico"
                bool tipoPessoa = (bool)e.Value;
                e.Value = tipoPessoa ? "FÍSICO" : "JURÍDICO";
                e.FormattingApplied = true;
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.Focus();
                if (dataGridViewFornecedores.SelectedRows.Count > 0)
                {
                    int idFornecedor = Convert.ToInt32(dataGridViewFornecedores.SelectedRows[0].Cells["Código"].Value);
                    string nomeFornecedor = dataGridViewFornecedores.SelectedRows[0].Cells["Fornecedor"].Value.ToString();

                    this.Tag = new Tuple<int, string>(idFornecedor, nomeFornecedor);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um fornecedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }
    }
}
