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
    public partial class ConsultaPaises : Sistema_Vendas.ConsultaPai
    {
        private PaisController<PaisModel> paisController;
        private CadastroPaises cadastroPaises;
        public ConsultaPaises()
        {
            InitializeComponent();
            paisController = new PaisController<PaisModel>();
            cadastroPaises = new CadastroPaises();
            cadastroPaises.Owner = this;
        }

        public override void Incluir() 
        {
            ResetCadastro();
            cadastroPaises.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewPaises.SelectedRows.Count > 0)
            {
                int idPais = (int)dataGridViewPaises.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idPais);
                cadastroPaises.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um país para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewPaises.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este país?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idPais = (int)dataGridViewPaises.SelectedRows[0].Cells["Código"].Value;
                    paisController.Delete(idPais);
                    dataGridViewPaises.DataSource = paisController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um país para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar() {
            string pesquisa = txtPesquisar.Text.Trim(); //obtem a pesquisa do txt

            //verifica se há um termo de pesquisa
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    //filtra os dados dos países
                    List<PaisModel> resultadosPesquisa = paisController.GetAll(cbBuscaInativos.Checked).Where(p => p.Pais.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewPaises.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar países: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //se não houver nada no txt, atualiza a consulta de países normalmente
                AtualizarConsultaPaises(cbBuscaInativos.Checked);
            }
        }

        private void ConsultaPaises_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroPaises.FormClosed += (s, args) => AtualizarConsultaPaises(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewPaises.AutoGenerateColumns = false;
                dataGridViewPaises.Columns["Código"].DataPropertyName = "idPais";
                dataGridViewPaises.Columns["País"].DataPropertyName = "Pais";
                dataGridViewPaises.Columns["Sigla"].DataPropertyName = "Sigla";
                dataGridViewPaises.Columns["DDI"].DataPropertyName = "DDI";

                AtualizarConsultaPaises(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os países: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetCadastro()
        {
            cadastroPaises.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroPaises.SetID(id);
            cadastroPaises.Carrega();
        }

        //atualizar a consulta de países
        public void AtualizarConsultaPaises(bool incluirInativos)
        {
            try
            {
                //recarrega os dados dos países na consulta de países
                dataGridViewPaises.DataSource = paisController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de países: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //abre o form de altera ao clicar 2x na linha
        private void dataGridViewPaises_CellDoubleClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //ID do país da linha selecionada
                int idPais = (int)dataGridViewPaises.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idPais);
                cadastroPaises.ShowDialog();
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewPaises.SelectedRows.Count > 0)
                {
                    // Capturar o ID e o nome do país selecionado
                    int paisID = Convert.ToInt32(dataGridViewPaises.SelectedRows[0].Cells["Código"].Value);
                    string paisNome = dataGridViewPaises.SelectedRows[0].Cells["País"].Value.ToString();

                    // Passar os detalhes do país selecionado de volta para a tela principal
                    this.Tag = new Tuple<int, string>(paisID, paisNome);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um país.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                Close();
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaPaises(incluirInativos);
        }
    }
}
