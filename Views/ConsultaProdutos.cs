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

        public ConsultaProdutos()
        {
            InitializeComponent();
            produtoController = new ProdutoController<ProdutoModel>();
        }

        public override void Incluir()
        {
            CadastroProdutos cadastroProdutos = new CadastroProdutos();
            cadastroProdutos.Owner = this;
            cadastroProdutos.ShowDialog();
        }

        public override void Alterar()
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                int idProduto = (int)dataGridViewProdutos.SelectedRows[0].Cells["Código"].Value;
                CadastroProdutos cadastroProdutos = new CadastroProdutos(idProduto);
                cadastroProdutos.Owner = this;
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
            string pesquisa = txtPesquisar.Text.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<ProdutoModel> resultadosPesquisa = produtoController.GetAll(cbBuscaInativos.Checked).Where(p => p.Descricao.ToLower().Contains(pesquisa.ToLower())).ToList();
                    dataGridViewProdutos.DataSource = resultadosPesquisa;
                    txtPesquisar.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CadastroProdutos cadastroProdutos = new CadastroProdutos();
                cadastroProdutos.FormClosed += (s, args) => AtualizarConsultaProdutos(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewProdutos.AutoGenerateColumns = false;
                dataGridViewProdutos.Columns["Código"].DataPropertyName = "idProduto";
                dataGridViewProdutos.Columns["Descrição"].DataPropertyName = "Descricao";
                dataGridViewProdutos.Columns["Unidade"].DataPropertyName = "Unidade";
                dataGridViewProdutos.Columns["Preco_venda"].DataPropertyName = "Preco_venda";

                AtualizarConsultaProdutos(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idProduto = (int)dataGridViewProdutos.Rows[e.RowIndex].Cells["Código"].Value;

                CadastroProdutos cadastroProdutos = new CadastroProdutos(idProduto);
                cadastroProdutos.Owner = this;
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
    }
}
