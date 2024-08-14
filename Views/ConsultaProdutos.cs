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
    public partial class ConsultaProdutos : Sistema_Vendas.ConsultaPai
    {
        private ProdutoController<ProdutoModel> produtoController;
        private CadastroProdutos cadastroProdutos;

        public ConsultaProdutos()
        {
            InitializeComponent();
            produtoController = new ProdutoController<ProdutoModel>();
            cadastroProdutos = new CadastroProdutos();
            cadastroProdutos.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroProdutos.txtProduto.Focus();
            cadastroProdutos.ShowDialog();
        }

        public override void Alterar()
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                int idProduto = (int)dataGridViewProdutos.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idProduto);
                cadastroProdutos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um produto para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este produto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idProduto = (int)dataGridViewProdutos.SelectedRows[0].Cells["Código"].Value;
                    produtoController.Delete(idProduto);
                    dataGridViewProdutos.DataSource = produtoController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AtualizarConsultaProdutos(bool incluirInativos)
        {
            try
            { 
                dataGridViewProdutos.DataSource = produtoController.GetAll(incluirInativos); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<ProdutoModel> resultadosPesquisa = new List<ProdutoModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (rbNome.Checked)
                    {
                        resultadosPesquisa = produtoController.GetAll(buscaInativos)
                                                           .Where(p => p.Produto.Contains(pesquisa))
                                                           .ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = produtoController.GetAll(buscaInativos)
                                                               .Where(p => p.idProduto == codigoPesquisa)
                                                               .ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewProdutos.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaProdutos(cbBuscaInativos.Checked);
            }
        }

        private void ConsultaProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroProdutos.FormClosed += (s, args) => AtualizarConsultaProdutos(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewProdutos.AutoGenerateColumns = false;
                dataGridViewProdutos.Columns["Código"].DataPropertyName = "idProduto";
                dataGridViewProdutos.Columns["Produto"].DataPropertyName = "Produto";
                dataGridViewProdutos.Columns["Unidade"].DataPropertyName = "Unidade";
                dataGridViewProdutos.Columns["precoVenda"].DataPropertyName = "precoVenda";

                AtualizarConsultaProdutos(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetCadastro()
        {
            cadastroProdutos.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroProdutos.SetID(id);
            cadastroProdutos.Carrega();
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idProduto = (int)dataGridViewProdutos.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idProduto);
                cadastroProdutos.ShowDialog();
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaProdutos(incluirInativos);
        }

        private void dataGridViewProdutos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.Focus();
                if (dataGridViewProdutos.SelectedRows.Count > 0)
                {
                    int idProd = Convert.ToInt32(dataGridViewProdutos.SelectedRows[0].Cells["Código"].Value);
                    string produto = dataGridViewProdutos.SelectedRows[0].Cells["Produto"].Value.ToString();
                    decimal precoVenda = Convert.ToDecimal(dataGridViewProdutos.SelectedRows[0].Cells["precoVenda"].Value);
                    string unidade = dataGridViewProdutos.SelectedRows[0].Cells["Unidade"].Value.ToString();

                    this.Tag = new Tuple<int, string, decimal, string>(idProd, produto, precoVenda, unidade);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }
    }
}
