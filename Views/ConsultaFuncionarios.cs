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
    public partial class ConsultaFuncionarios : Sistema_Vendas.ConsultaPai
    {
        FuncionarioController<FuncionarioModel> funcionarioController;
        public ConsultaFuncionarios()
        {
            InitializeComponent();
            funcionarioController = new FuncionarioController<FuncionarioModel>();
        }
        public override void Incluir()
        {
            CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
            cadastroFuncionarios.Owner = this;
            cadastroFuncionarios.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewFuncionarios.SelectedRows.Count > 0)
            {
                int idFuncionario = (int)dataGridViewFuncionarios.SelectedRows[0].Cells["Código"].Value;
                CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios(idFuncionario);
                cadastroFuncionarios.Owner = this;
                cadastroFuncionarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Excluir()
        {
            if (dataGridViewFuncionarios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este funcionário?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idFuncinario = (int)dataGridViewFuncionarios.SelectedRows[0].Cells["Código"].Value;
                    funcionarioController.Delete(idFuncinario);
                    dataGridViewFuncionarios.DataSource = funcionarioController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Text.Trim();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<FuncionarioModel> resultadosPesquisa = funcionarioController.GetAll(cbBuscaInativos.Checked).Where(p => p.funcionario.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewFuncionarios.DataSource = resultadosPesquisa; 
                    txtPesquisar.Text = string.Empty; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar funcionários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaFuncionarios(cbBuscaInativos.Checked);
            }
        }

        public void AtualizarConsultaFuncionarios(bool incluirInativos)
        {
            try
            {
                dataGridViewFuncionarios.DataSource = funcionarioController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de funcionários: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaFuncionarios_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
                cadastroFuncionarios.FormClosed += (s, args) => AtualizarConsultaFuncionarios(cbBuscaInativos.Checked);

                dataGridViewFuncionarios.AutoGenerateColumns = false;
                dataGridViewFuncionarios.Columns["Código"].DataPropertyName = "idFuncionario";
                dataGridViewFuncionarios.Columns["Funcionário"].DataPropertyName = "funcionario";
                dataGridViewFuncionarios.Columns["Cargo"].DataPropertyName = "cargo";
                dataGridViewFuncionarios.Columns["Celular"].DataPropertyName = "celular";

                AtualizarConsultaFuncionarios(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar funcionários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idFuncionario = (int)dataGridViewFuncionarios.Rows[e.RowIndex].Cells["Código"].Value;

                CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios(idFuncionario);
                cadastroFuncionarios.Owner = this;
                cadastroFuncionarios.ShowDialog();
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaFuncionarios(incluirInativos);
        }

        private void dataGridViewFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFuncionarios.Columns["Celular"].Index && e.Value != null)
            {
                //formata o número de celular
                string celular = e.Value.ToString();
                if (celular.Length == 11)
                {
                    e.Value = string.Format("({0}) {1}-{2}", celular.Substring(0, 2), celular.Substring(2, 5), celular.Substring(7));
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
