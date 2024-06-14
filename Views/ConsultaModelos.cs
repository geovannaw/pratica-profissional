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
    public partial class ConsultaModelos : Sistema_Vendas.ConsultaPai
    {
        private ModeloController<ModeloModel> modeloController;
        private CadastroModelos cadastroModelos;
        public ConsultaModelos()
        {
            InitializeComponent();
            modeloController = new ModeloController<ModeloModel>();
            cadastroModelos = new CadastroModelos();
            cadastroModelos.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroModelos.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewModelos.SelectedRows.Count > 0)
            {
                int idModelo = (int)dataGridViewModelos.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idModelo);
                cadastroModelos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um modelo para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewModelos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este modelo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idModelo = (int)dataGridViewModelos.SelectedRows[0].Cells["Código"].Value;
                    modeloController.Delete(idModelo);
                    dataGridViewModelos.DataSource = modeloController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um modelo para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Text.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<ModeloModel> resultadosPesquisa = new List<ModeloModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;
                    if (rbNome.Checked)
                    {
                        resultadosPesquisa = modeloController.GetAll(buscaInativos).Where(p => p.Modelo.ToLower().Contains(pesquisa.ToLower())).ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = modeloController.GetAll(buscaInativos).Where(p => p.idModelo == codigoPesquisa).ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewModelos.DataSource = resultadosPesquisa;
                    txtPesquisar.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar modelos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaModelos(cbBuscaInativos.Checked);
            }
        }

        public void AtualizarConsultaModelos(bool incluirInativos)
        {
            try
            {
                dataGridViewModelos.DataSource = modeloController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de modelos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaModelos_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroModelos.FormClosed += (s, args) => AtualizarConsultaModelos(cbBuscaInativos.Checked); 

                dataGridViewModelos.AutoGenerateColumns = false;
                dataGridViewModelos.Columns["Código"].DataPropertyName = "idModelo";
                dataGridViewModelos.Columns["Modelo"].DataPropertyName = "Modelo";
                dataGridViewModelos.Columns["Marca"].DataPropertyName = "Marca";

                AtualizarConsultaModelos(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os modelos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewModelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idModelo = (int)dataGridViewModelos.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idModelo);
                cadastroModelos.ShowDialog();
            }
        }

        private void ResetCadastro()
        {
            cadastroModelos.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroModelos.SetID(id);
            cadastroModelos.Carrega();
        }
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewModelos.SelectedRows.Count > 0)
                {
                    int modeloID = Convert.ToInt32(dataGridViewModelos.SelectedRows[0].Cells["Código"].Value);
                    string modeloNome = dataGridViewModelos.SelectedRows[0].Cells["Modelo"].Value.ToString();

                    this.Tag = new Tuple<int, string>(modeloID, modeloNome);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaModelos(incluirInativos);
        }
    }
}
