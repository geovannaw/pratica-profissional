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
    public partial class ConsultaOS : Sistema_Vendas.ConsultaPai
    {
        private OSController<OrdemServicoModel> ordemServicoController;
        private CadastroOS cadastroOS;
        private ClienteController<ClienteModel> clienteController;
        private ProdutoController<ProdutoModel> produtoController;
        public ConsultaOS()
        {
            InitializeComponent();
            cadastroOS = new CadastroOS();
            ordemServicoController = new OSController<OrdemServicoModel>();
            clienteController = new ClienteController<ClienteModel>();
            produtoController = new ProdutoController<ProdutoModel>();
            cadastroOS.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroOS.txtCodCliente.Focus();
            cadastroOS.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewOS.SelectedRows.Count > 0)
            {
                int idOS = (int)dataGridViewOS.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idOS);
                cadastroOS.txtCodCliente.Focus();
                cadastroOS.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma Ordem de Serviço para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //public override void Excluir()
        //{
        //    if (dataGridViewOS.SelectedRows.Count > 0)
        //    {
        //        string status = dataGridViewOS.SelectedRows[0].Cells["Status"].Value.ToString();

        //        if (status == "CANCELADO")
        //        {
        //            if (MessageBox.Show("Tem certeza de que deseja excluir esta Ordem de Serviço?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                int idOS = (int)dataGridViewOS.SelectedRows[0].Cells["Código"].Value;

        //                List<ProdutoModel> produtos = ordemServicoController.GetProdutosByOS(idOS);

        //                foreach (var produto in produtos)
        //                {
        //                    produtoController.AtualizarSaldo(produto.idProduto, produto.Saldo);
        //                }
        //                ordemServicoController.Delete(idOS);
        //                dataGridViewOS.DataSource = ordemServicoController.GetAll(cbBuscaInativos.Checked);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("A Ordem de Serviço só pode ser excluída se estiver com status CANCELADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Selecione uma Ordem de Serviço para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<OrdemServicoModel> resultadosPesquisa = new List<OrdemServicoModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (rbNome.Checked)
                    {   
                        resultadosPesquisa = ordemServicoController.GetAll(buscaInativos)
                                                           .Where(p => p.status.Contains(pesquisa))
                                                           .ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = ordemServicoController.GetAll(buscaInativos).Where(p => p.idOrdemServico == codigoPesquisa).ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewOS.DataSource = resultadosPesquisa;
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaOS(cbBuscaInativos.Checked);
            }
        }

        private void ResetCadastro()
        {
            cadastroOS.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroOS.SetID(id);
            cadastroOS.limpaCamposProdutos();
            cadastroOS.limpaCamposServicos();
            cadastroOS.Carrega();
        }

        public void AtualizarConsultaOS(bool incluirInativos)
        {
            try
            {
                dataGridViewOS.DataSource = ordemServicoController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de Ordem de Serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaOS_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroOS.FormClosed += (s, args) => AtualizarConsultaOS(cbBuscaInativos.Checked); //quando aciona o Form Closed chama o AtualizarConsulta

                dataGridViewOS.AutoGenerateColumns = false;
                dataGridViewOS.Columns["Código"].DataPropertyName = "idOrdemServico";
                dataGridViewOS.Columns["Status"].DataPropertyName = "status";
                dataGridViewOS.Columns["DataPrevista"].DataPropertyName = "dataPrevista";
                dataGridViewOS.Columns["DataPrevista"].DefaultCellStyle.Format = "dd/MM/yyyy";

                AtualizarConsultaOS(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as Ordens de Serviço: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaOS(incluirInativos);
        }

        private void dataGridViewOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idOS = (int)dataGridViewOS.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idOS);
                cadastroOS.ShowDialog();
            }
        }

        private void dataGridViewOS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewOS.Columns[e.ColumnIndex].Name == "Status" && e.RowIndex >= 0)
            {
                string status = dataGridViewOS.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                if (status == "CANCELADO")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
            if (e.ColumnIndex == dataGridViewOS.Columns["Cliente"].Index && e.RowIndex >= 0)
            {
                // recupera o idOrdemServico da linha atual
                var idOS = (int)dataGridViewOS.Rows[e.RowIndex].Cells["Código"].Value;

                // chama o método para obter o nome do cliente
                string cliente = ordemServicoController.GetClienteByOSid(idOS);

                e.Value = cliente;
                e.FormattingApplied = true;
            }
        }
    }
}
