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
    public partial class ConsultaUsuarios : Sistema_Vendas.ConsultaPai
    {
        private UsuarioController<UsuarioModel> usuarioController;
        private CadastroUsuarios cadastroUsuarios;
        public ConsultaUsuarios()
        {
            InitializeComponent();
            cadastroUsuarios = new CadastroUsuarios();
            usuarioController = new UsuarioController<UsuarioModel>();
            cadastroUsuarios.Owner = this;
        }

        public override void Incluir()
        {
            ResetCadastro();
            cadastroUsuarios.txtUsuario.Focus();
            cadastroUsuarios.ShowDialog();
        }
        public override void Alterar()
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = (int)dataGridViewUsuarios.SelectedRows[0].Cells["Código"].Value;
                ResetCadastro(idUsuario);
                cadastroUsuarios.txtUsuario.Focus();
                cadastroUsuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public override void Excluir()
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este usuário?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idUsuario = (int)dataGridViewUsuarios.SelectedRows[0].Cells["Código"].Value;
                    usuarioController.Delete(idUsuario);
                    dataGridViewUsuarios.DataSource = usuarioController.GetAll(cbBuscaInativos.Checked);
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override void Pesquisar()
        {
            string pesquisa = txtPesquisa.Texts.Trim();
            if (!string.IsNullOrEmpty(pesquisa))
            {
                try
                {
                    List<UsuarioModel> resultadosPesquisa = new List<UsuarioModel>();
                    bool buscaInativos = cbBuscaInativos.Checked;

                    if (rbNome.Checked)
                    {
                        resultadosPesquisa = usuarioController.GetAll(buscaInativos)
                                                           .Where(p => p.usuario.Contains(pesquisa))
                                                           .ToList();
                    }
                    else if (rbCodigo.Checked)
                    {
                        if (int.TryParse(pesquisa, out int codigoPesquisa))
                        {
                            resultadosPesquisa = usuarioController.GetAll(buscaInativos)
                                                               .Where(p => p.idUsuario == codigoPesquisa)
                                                               .ToList();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um código válido.", "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    dataGridViewUsuarios.DataSource = resultadosPesquisa; 
                    txtPesquisa.Texts = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AtualizarConsultaUsuarios(cbBuscaInativos.Checked);
            }
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                cadastroUsuarios.FormClosed += (s, args) => AtualizarConsultaUsuarios(cbBuscaInativos.Checked);
                dataGridViewUsuarios.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewUsuarios.AutoGenerateColumns = false;
                dataGridViewUsuarios.Columns["Código"].DataPropertyName = "idUsuario";
                dataGridViewUsuarios.Columns["usuario"].DataPropertyName = "usuario";

                AtualizarConsultaUsuarios(cbBuscaInativos.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os usuarios: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetCadastro()
        {
            cadastroUsuarios.LimparCampos();
        }

        private void ResetCadastro(int id)
        {
            cadastroUsuarios.SetID(id);
            cadastroUsuarios.Carrega();
        }

        public void AtualizarConsultaUsuarios(bool incluirInativos)
        {
            try
            {
                dataGridViewUsuarios.DataSource = usuarioController.GetAll(incluirInativos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a consulta de usuários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idUsuario = (int)dataGridViewUsuarios.Rows[e.RowIndex].Cells["Código"].Value;
                ResetCadastro(idUsuario);
                cadastroUsuarios.ShowDialog();
            }
        }

        private void cbBuscaInativos_CheckedChanged(object sender, EventArgs e)
        {
            bool incluirInativos = cbBuscaInativos.Checked;
            AtualizarConsultaUsuarios(incluirInativos);
        }
    }
}
