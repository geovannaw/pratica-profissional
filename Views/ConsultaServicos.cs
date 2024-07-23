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
    public partial class ConsultaServicos : Sistema_Vendas.ConsultaPai
    {
        private ServicoController<ServicoModel> servicoController;
        private CadastroServicos cadastroServicos;
        public ConsultaServicos()
        {
            InitializeComponent();
            servicoController = new ServicoController<ServicoModel>();
            cadastroServicos = new CadastroServicos();
            cadastroServicos.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroServicos.txtServico.Focus();
            cadastroServicos.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewServicos.SelectedRows.Count > 0)
            {
                int idServico = (int)dataGridViewServicos.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idServico);
                cadastroServicos.txtServico.Focus();
                cadastroServicos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um serviço para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewServicos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este serviço?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idServico = (int)dataGridViewServicos.SelectedRows[0].Cells["Código"].Value;
                    servicoController.Delete(idServico);
                    dataGridViewServicos.DataSource = servicoController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um serviço para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<ServicoModel> resultadosPesquisa = new List<ServicoModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (rbNome.Checked)
                    {
                        resultadosPesquisa = servicoController.GetAll(buscaInativos)
                                                           .Where(p => p.servico.Contains(pesquisa))
                                                           .ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = servicoController.GetAll(buscaInativos)
                                                               .Where(p => p.idServico == codigoPesquisa)
                                                               .ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewServicos.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaServicos(cbBuscaInativos.Checked);
            }
        }

        private void ResetCadastro()
        {
            cadastroServicos.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroServicos.SetID(id);
            cadastroServicos.Carrega();
        }

        private void ConsultaServicos_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroServicos.FormClosed += (s, args) => AtualizarConsultaServicos(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewServicos.AutoGenerateColumns = false;
                dataGridViewServicos.Columns["Código"].DataPropertyName = "idServico";
                dataGridViewServicos.Columns["Serviço"].DataPropertyName = "servico";
                dataGridViewServicos.Columns["Preço"].DataPropertyName = "preco";

                AtualizarConsultaServicos(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os serviços: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizarConsultaServicos(bool incluirInativos)
        {
            try
            {
                dataGridViewServicos.DataSource = servicoController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de serviços: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaServicos(incluirInativos);
        }

        private void dataGridViewServicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idServico = (int)dataGridViewServicos.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idServico);
                cadastroServicos.ShowDialog();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.Focus();
                if (dataGridViewServicos.SelectedRows.Count > 0)
                {
                    int idServico = Convert.ToInt32(dataGridViewServicos.SelectedRows[0].Cells["Código"].Value);
                    string servico = dataGridViewServicos.SelectedRows[0].Cells["Serviço"].Value.ToString();
                    decimal preco = Convert.ToInt32(dataGridViewServicos.SelectedRows[0].Cells["Preço"].Value);

                    this.Tag = new Tuple<int, string, decimal>(idServico, servico, preco);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um serviço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }
    }
}
