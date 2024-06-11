using Sistema_Vendas.Controller;
using Sistema_Vendas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Vendas.Models
{
    public partial class ConsultaEstados : Sistema_Vendas.ConsultaPai
    {
        private EstadoController<EstadoModel> estadoController;
        private CadastroEstados cadastroEstados;
        public ConsultaEstados()
        {
            InitializeComponent();
            estadoController = new EstadoController<EstadoModel>();
            cadastroEstados = new CadastroEstados();
            cadastroEstados.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroEstados.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewEstados.SelectedRows.Count > 0)
            {
                int idEstado = (int)dataGridViewEstados.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idEstado);
                cadastroEstados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um estado para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewEstados.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este estado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idEstado = (int)dataGridViewEstados.SelectedRows[0].Cells["Código"].Value;
                    estadoController.Delete(idEstado);
                    dataGridViewEstados.DataSource = estadoController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um estado para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Text.Trim(); //obtem a pesquisa do txt

            //verifica se há um termo de pesquisa
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    //filtra os dados
                    List<EstadoModel> resultadosPesquisa = estadoController.GetAll(cbBuscaInativos.Checked).Where(p => p.Estado.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewEstados.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar estados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //se não houver nada no txt, atualiza a consulta de estados normalmente
                AtualizarConsultaEstados(cbBuscaInativos.Checked);
            }
        }

        private void ResetCadastro()
        {
            cadastroEstados.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroEstados.SetID(id);
            cadastroEstados.Carrega();
        }

        //atualizar a consulta de estados
        public void AtualizarConsultaEstados(bool incluirInativos)
        {
            try
            {
                //recarrega os dados dos estados na consulta de estados
                dataGridViewEstados.DataSource = estadoController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de estados: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaEstados_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroEstados.FormClosed += (s, args) => AtualizarConsultaEstados(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewEstados.AutoGenerateColumns = false;
                dataGridViewEstados.Columns["Código"].DataPropertyName = "idEstado";
                dataGridViewEstados.Columns["Estado"].DataPropertyName = "Estado";
                dataGridViewEstados.Columns["UF"].DataPropertyName = "UF";

                AtualizarConsultaEstados(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os estados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewEstados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //ID do estado da linha selecionada
                int idEstado = (int)dataGridViewEstados.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idEstado);
                cadastroEstados.ShowDialog();
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewEstados.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome do estado selecionado
                    int idEstado = Convert.ToInt32(dataGridViewEstados.SelectedRows[0].Cells["Código"].Value);
                    string nomeEstado = dataGridViewEstados.SelectedRows[0].Cells["Estado"].Value.ToString();

                    // Passar os detalhes do estado selecionado de volta para a tela de cadastro cidades
                    this.Tag = new Tuple<int, string>(idEstado, nomeEstado);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            AtualizarConsultaEstados(incluirInativos);
        }
    }
}
