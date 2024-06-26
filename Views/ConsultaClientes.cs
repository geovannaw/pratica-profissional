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
    public partial class ConsultaClientes : Sistema_Vendas.ConsultaPai
    {
        private ClienteController<ClienteModel> clientesController;
        private CadastroClientes cadastroClientes;
        public ConsultaClientes()
        {
            InitializeComponent();
            clientesController = new ClienteController<ClienteModel>();
            cadastroClientes = new CadastroClientes();
            cadastroClientes.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroClientes.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int idCliente = (int)dataGridViewClientes.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idCliente);
                cadastroClientes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idCliente = (int)dataGridViewClientes.SelectedRows[0].Cells["Código"].Value;
                    clientesController.Delete(idCliente);
                    dataGridViewClientes.DataSource = clientesController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisar.Text.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<ClienteModel> resultadosPesquisa = new List<ClienteModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (rbNome.Checked)
                    {
                        resultadosPesquisa = clientesController.GetAll(buscaInativos)
                                                           .Where(p => p.cliente_razao_social.Contains(pesquisa))
                                                           .ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = clientesController.GetAll(buscaInativos)
                                                               .Where(p => p.idCliente == codigoPesquisa)
                                                               .ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewClientes.DataSource = resultadosPesquisa;
                    txtPesquisar.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaClientes(cbBuscaInativos.Checked);
            }
        }

        public void AtualizarConsultaClientes(bool incluirInativos)
        {
            try
            {
                dataGridViewClientes.DataSource = clientesController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de clientes: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroClientes.FormClosed += (s, args) => AtualizarConsultaClientes(cbBuscaInativos.Checked); 

                dataGridViewClientes.AutoGenerateColumns = false;
                dataGridViewClientes.Columns["Código"].DataPropertyName = "idCliente";
                dataGridViewClientes.Columns["Cliente"].DataPropertyName = "cliente_razao_social";
                dataGridViewClientes.Columns["Tipo"].DataPropertyName = "tipo_pessoa";
                dataGridViewClientes.Columns["Celular"].DataPropertyName = "celular";

                AtualizarConsultaClientes(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar clientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idCliente = (int)dataGridViewClientes.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idCliente);
                cadastroClientes.ShowDialog();
            }
        }

        private void ResetCadastro()
        {
            cadastroClientes.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroClientes.SetID(id);
            cadastroClientes.Carrega();
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaClientes(incluirInativos);
        }

        private void dataGridViewClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewClientes.Columns["Celular"].Index && e.Value != null)
            {
                // Formata o número de celular
                string celular = e.Value.ToString();
                if (celular.Length == 11)
                {
                    e.Value = string.Format("({0}) {1}-{2}", celular.Substring(0, 2), celular.Substring(2, 5), celular.Substring(7));
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == dataGridViewClientes.Columns["Tipo"].Index && e.Value != null)
            {
                // Converte o valor bool em uma string "Físico" ou "Jurídico"
                bool tipoPessoa = (bool)e.Value;
                e.Value = tipoPessoa ? "Físico" : "Jurídico";
                e.FormattingApplied = true;
            }
        }
    }
}
