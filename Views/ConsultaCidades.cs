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
        private CadastroCidades cadastroCidades;
        public ConsultaCidades()
        {
            InitializeComponent();
            cidadeController = new CidadeController<CidadeModel>();
            cadastroCidades = new CadastroCidades();
            cadastroCidades.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroCidades.txtCidade.Focus();
            cadastroCidades.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewCidades.SelectedRows.Count > 0)
            {
                int idCidade = (int)dataGridViewCidades.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idCidade);
                cadastroCidades.txtCidade.Focus();
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

        private void ResetCadastro()
        {
            cadastroCidades.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroCidades.SetID(id);
            cadastroCidades.Carrega();
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<CidadeModel> resultadosPesquisa = new List<CidadeModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (rbNome.Checked)
                    {
                        resultadosPesquisa = cidadeController.GetAll(buscaInativos)
                                                           .Where(p => p.Cidade.Contains(pesquisa))
                                                           .ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = cidadeController.GetAll(buscaInativos)
                                                               .Where(p => p.idCidade == codigoPesquisa)
                                                               .ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewCidades.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
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
                ResetCadastro(idCidade);
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
