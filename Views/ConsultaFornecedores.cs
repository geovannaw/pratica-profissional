﻿using Sistema_Vendas.Controller;
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
    public partial class ConsultaFornecedores : Sistema_Vendas.ConsultaPai
    {
        private FornecedorController<FornecedorModel> fornecedorController;
        public ConsultaFornecedores()
        {
            InitializeComponent();
            fornecedorController = new FornecedorController<FornecedorModel>();
        }

        public override void Incluir()
        {
            CadastroFornecedores cadastroFornecedores = new CadastroFornecedores();
            cadastroFornecedores.Owner = this;
            cadastroFornecedores.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewFornecedores.SelectedRows.Count > 0)
            {
                int idFornecedor = (int)dataGridViewFornecedores.SelectedRows[0].Cells["Código"].Value;
                CadastroFornecedores cadastroFornecedores = new CadastroFornecedores(idFornecedor);
                cadastroFornecedores.Owner = this;
                cadastroFornecedores.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewFornecedores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este fornecedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idFornecedor = (int)dataGridViewFornecedores.SelectedRows[0].Cells["Código"].Value;
                    fornecedorController.Delete(idFornecedor);
                    dataGridViewFornecedores.DataSource = fornecedorController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Text.Trim();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    var fornecedores = fornecedorController.GetAll(cbBuscaInativos.Checked);

                    var resultadosPesquisa = fornecedores
                        .Where(p => p.fornecedor_razao_social.ToLower().Contains(pesquisa.ToLower()))
                        .Select(fornecedor => new
                        {
                            fornecedor.idFornecedor,
                            fornecedor.fornecedor_razao_social,
                            tipo_pessoa = fornecedor.tipo_pessoa ? "Físico" : "Jurídico",
                            fornecedor.celular
                        })
                        .ToList();

                    dataGridViewFornecedores.DataSource = resultadosPesquisa;
                    txtPesquisar.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaFornecedores(cbBuscaInativos.Checked);
            }
        }

        public void AtualizarConsultaFornecedores(bool incluirInativos)
        {
            try
            {
                var fornecedores = fornecedorController.GetAll(incluirInativos);

                // Converte o valor bool em uma string "Físico" ou "Jurídico"
                var fornecedoresFormatados = fornecedores.Select(fornecedor => new
                {
                    fornecedor.idFornecedor,
                    fornecedor.fornecedor_razao_social,
                    tipo_pessoa = fornecedor.tipo_pessoa ? "Físico" : "Jurídico",
                    fornecedor.celular
                }).ToList();

                dataGridViewFornecedores.DataSource = fornecedoresFormatados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de fornecedores: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaFornecedores_Load(object sender, EventArgs e)
        {
            try
            {
                CadastroFornecedores cadastroFornecedores = new CadastroFornecedores();
                cadastroFornecedores.FormClosed += (s, args) => AtualizarConsultaFornecedores(cbBuscaInativos.Checked);

                dataGridViewFornecedores.AutoGenerateColumns = false;
                dataGridViewFornecedores.Columns["Código"].DataPropertyName = "idFornecedor";
                dataGridViewFornecedores.Columns["Fornecedor"].DataPropertyName = "fornecedor_razao_social";
                dataGridViewFornecedores.Columns["Tipo"].DataPropertyName = "tipo_pessoa";
                dataGridViewFornecedores.Columns["Celular"].DataPropertyName = "celular";

                AtualizarConsultaFornecedores(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar fornecedores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idFornecedor = (int)dataGridViewFornecedores.Rows[e.RowIndex].Cells["Código"].Value;

                CadastroFornecedores cadastroFornecedores = new CadastroFornecedores(idFornecedor);
                cadastroFornecedores.Owner = this;
                cadastroFornecedores.ShowDialog();
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaFornecedores(incluirInativos);
        }

        private void dataGridViewFornecedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewFornecedores.Columns["Celular"].Index && e.Value != null)
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

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.Focus();
                if (dataGridViewFornecedores.SelectedRows.Count > 0)
                {
                    int idFornecedor = Convert.ToInt32(dataGridViewFornecedores.SelectedRows[0].Cells["Código"].Value);
                    string nomeFornecedor = dataGridViewFornecedores.SelectedRows[0].Cells["Fornecedor"].Value.ToString();

                    this.Tag = new Tuple<int, string>(idFornecedor, nomeFornecedor);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um fornecedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }
    }
}
