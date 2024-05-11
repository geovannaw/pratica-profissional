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
    public partial class ConsultaCidades : Sistema_Vendas.ConsultaPai
    {
        private CidadeController<CidadeModel> cidadeController;
        public ConsultaCidades()
        {
            InitializeComponent();
            cidadeController = new CidadeController<CidadeModel>();
        }

        public override void Incluir()
        {
            CadastroCidades cadastroCidades = new CadastroCidades();
            cadastroCidades.Owner = this;
            cadastroCidades.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewCidades.SelectedRows.Count > 0)
            {
                int idCidade = (int)dataGridViewCidades.SelectedRows[0].Cells["Código"].Value;
                CadastroCidades cadastroCidades = new CadastroCidades(idCidade);
                cadastroCidades.Owner = this;
                cadastroCidades.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma cidade para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewCidades.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir esta cidade?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idCidade = (int)dataGridViewCidades.SelectedRows[0].Cells["Código"].Value;
                    cidadeController.Delete(idCidade);
                    dataGridViewCidades.DataSource = cidadeController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma cidade para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    List<CidadeModel> resultadosPesquisa = cidadeController.GetAll(cbBuscaInativos.Checked).Where(p => p.Cidade.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewCidades.DataSource = resultadosPesquisa; //atualiza o DataSource do DataGridView com os resultados da pesquisa
                    txtPesquisar.Text = string.Empty; //limpa o txt pesquisa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar cidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //se não houver nada no txt, atualiza a consulta de cidades normalmente
                AtualizarConsultaCidades(cbBuscaInativos.Checked);
            }
        }

        //atualizar a consulta de cidades
        public void AtualizarConsultaCidades(bool incluirInativos)
        {
            try
            {
                //recarrega os dados das cidades na consulta 
                dataGridViewCidades.DataSource = cidadeController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de cidades: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaCidades_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroCidades cadastroCidades = new CadastroCidades();
                cadastroCidades.FormClosed += (s, args) => AtualizarConsultaCidades(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewCidades.AutoGenerateColumns = false;
                dataGridViewCidades.Columns["Código"].DataPropertyName = "idCidade";
                dataGridViewCidades.Columns["Cidade"].DataPropertyName = "Cidade";
                dataGridViewCidades.Columns["DDD"].DataPropertyName = "DDD";

                AtualizarConsultaCidades(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as cidades: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //ID da cidade da linha selecionada
                int idCidade = (int)dataGridViewCidades.Rows[e.RowIndex].Cells["Código"].Value;

                CadastroCidades cadastroCidades = new CadastroCidades(idCidade);
                cadastroCidades.Owner = this;
                cadastroCidades.ShowDialog();
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaCidades(incluirInativos);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                if (dataGridViewCidades.SelectedRows.Count > 0)
                {
                    int idCidade = Convert.ToInt32(dataGridViewCidades.SelectedRows[0].Cells["Código"].Value);
                    string nomeCidade = dataGridViewCidades.SelectedRows[0].Cells["Cidade"].Value.ToString();
                    this.Tag = new Tuple<int, string>(idCidade, nomeCidade);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma cidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }
    }
}
