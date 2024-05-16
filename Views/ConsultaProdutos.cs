using Sistema_Vendas.Controller;
using Sistema_Vendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
