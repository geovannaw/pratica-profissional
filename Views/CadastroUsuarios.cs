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
    public partial class CadastroUsuarios : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private UsuarioController<UsuarioModel> usuarioController;
        public CadastroUsuarios()
        {
            InitializeComponent();
            usuarioController = new UsuarioController<UsuarioModel>();
        }
        public override void Carrega()
        {
            base.Carrega();
            if (idAlterar != -1)
            {
                UsuarioModel usuario = usuarioController.GetById(idAlterar);
                if (usuario != null)
                {
                    txtCodigo.Texts = usuario.idUsuario.ToString();
                    txtUsuario.Texts = usuario.usuario;
                    txtSenha.Texts = usuario.senha;
                    txtDataCadastro.Texts = usuario.dataCadastro.ToString();
                    txtDataUltAlt.Texts = usuario.dataUltAlt.ToString();
                    rbAtivo.Checked = usuario.Ativo;
                    rbInativo.Checked = !usuario.Ativo;
                    txtUsuarioUltAlt.Texts = usuario.usuarioUltAlt;
                    if (!cbPermissao.Items.Contains(usuario.permissao))
                    {
                        cbPermissao.Items.Add(usuario.permissao);
                    }
                    cbPermissao.Texts = usuario.permissao;
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override void Salvar()
        {
            if (!CampoObrigatorio(txtUsuario.Texts))
            {
                MessageBox.Show("Campo Usuário é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
            else if (!CampoObrigatorio(txtSenha.Texts))
            {
                MessageBox.Show("Campo Senha é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (!CampoObrigatorio(cbPermissao.Texts))
            {
                MessageBox.Show("Campo Permissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbPermissao.Focus();
            }
            else
            {
                int idAtual = idAlterar != -1 ? idAlterar : -1;

                if (usuarioController.JaCadastrado(txtUsuario.Texts, idAtual))
                {
                    MessageBox.Show("Usuário já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                }
                else
                {
                    try
                    {
                        string usuario = txtUsuario.Texts;
                        string senha = txtSenha.Texts;
                        string permissao = cbPermissao.Texts.ToString();
                        string usuarioUltAlt = Program.usuarioLogado;

                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                        UsuarioModel novoUser = new UsuarioModel
                        {
                            usuario = usuario,
                            senha = senha,
                            permissao = permissao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = isAtivo,
                            usuarioUltAlt = usuarioUltAlt
                        };

                        if (idAlterar == -1)
                        {
                            usuarioController.Salvar(novoUser);
                        }
                        else
                        {
                            novoUser.idUsuario = idAlterar; 
                            usuarioController.Alterar(novoUser);
                        }

                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public override void LimparCampos()
        {
            base.LimparCampos();
            idAlterar = -1;
            txtCodigo.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
            cbPermissao.SelectedIndex = 0;
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtUsuarioUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        private void CadastroUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaUsuarios)this.Owner).AtualizarConsultaUsuarios(false);
        }

        private void CadastroUsuarios_Load(object sender, EventArgs e)
        {
            if (idAlterar == -1)
            {
                int novoCodigo = usuarioController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }
    }
}
