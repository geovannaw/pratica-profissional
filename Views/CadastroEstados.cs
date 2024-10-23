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
    public partial class CadastroEstados : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private EstadoController<EstadoModel> estadoController;
        private ConsultaPaises consultaPaises;
        private PaisController<PaisModel> paisController;
        public CadastroEstados()
        {
            InitializeComponent();
            estadoController = new EstadoController<EstadoModel>();
            consultaPaises = new ConsultaPaises();
            paisController = new PaisController<PaisModel>();
        }
        public override void Bloqueia()
        {
            txtEstado.Enabled = false;
            txtUF.Enabled = false;
            txtPais.Enabled = false;
            txtCodPais.Enabled = false;
            btnConsultaPais.Enabled = false;
        }

        public override void Carrega()
        {
            base.Carrega();
            if (idAlterar != -1)
            {
                EstadoModel estado = estadoController.GetById(idAlterar);
                if (estado != null)
                {
                    txtCodigo.Texts = estado.idEstado.ToString();
                    txtEstado.Texts = estado.Estado;
                    txtUF.Texts = estado.UF;
                    txtCodPais.Texts = estado.idPais.ToString();
                    txtUsuarioUltAlt.Texts = estado.usuario;
                    txtDataCadastro.Texts = estado.dataCadastro.ToString();
                    txtDataUltAlt.Texts = estado.dataUltAlt.ToString();
                    rbAtivo.Checked = estado.Ativo;
                    rbInativo.Checked = !estado.Ativo;

                    string nomePais = estadoController.GetNomePaisByEstadoId(estado.idEstado);

                    if (!string.IsNullOrEmpty(nomePais))
                    {
                        txtPais.Texts = nomePais;
                    }
                }
                else
                {
                    MessageBox.Show("Estado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void LimparCampos()
        {
            base.LimparCampos();
            idAlterar = -1;
            txtCodigo.Clear();
            txtEstado.Clear();
            txtUF.Clear();
            txtCodPais.Clear();
            txtPais.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            txtUsuarioUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        public override void Salvar()
        {
            if (!CampoObrigatorio(txtEstado.Texts))
            {
                MessageBox.Show("Campo Estado é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstado.Focus();
            }
            else if (!CampoObrigatorio(txtUF.Texts))
            {
                MessageBox.Show("Campo UF é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUF.Focus();
            }
            else if (!CampoObrigatorio(txtCodPais.Texts))
            {
                MessageBox.Show("Campo Código País é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodPais.Focus();
            }
            else
            {
                int idAtual = idAlterar != -1 ? idAlterar : -1;

                if (estadoController.JaCadastrado(txtEstado.Texts, idAtual))
                {
                    MessageBox.Show("Estado já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEstado.Focus();
                }
                else
                {
                    try
                    {
                        string estado = txtEstado.Texts;
                        string UF = txtUF.Texts;
                        int idPais = int.Parse(txtCodPais.Texts);
                        string usuario = Program.usuarioLogado;

                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                        EstadoModel novoEstado = new EstadoModel
                        {
                            Estado = estado,
                            UF = UF,
                            idPais = idPais,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = isAtivo,
                            usuario = usuario
                        };

                        if (idAlterar == -1)
                        {
                            estadoController.Salvar(novoEstado);
                        }
                        else
                        {
                            novoEstado.idEstado = idAlterar;
                            estadoController.Alterar(novoEstado);
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

        private void CadastroEstados_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaEstados)this.Owner).AtualizarConsultaEstados(false);
        }

        private void CadastroEstados_Load(object sender, EventArgs e)
        {
            if (idAlterar == -1)
            {
                int novoCodigo = estadoController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            isAtivo = rbAtivo.Checked;
        }

        private void rbInativo_CheckedChanged(object sender, EventArgs e)
        {
            isAtivo = !rbInativo.Checked;
        }

        private void txtUF_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetrasSemEspaco(txtUF.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUF.Focus();
            }
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtEstado.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstado.Focus();
            }
        }

        private void txtCodPais_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodPais.Texts))
            {
                 string pais = paisController.getPais(int.Parse(txtCodPais.Texts));
                 if (pais != null)
                 {
                     txtPais.Texts = pais;
                 }
                 else
                 {
                     MessageBox.Show("País não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     txtCodPais.Focus();
                     txtCodPais.Clear();
                     txtPais.Clear();
                 }
                }
        }

        private void txtCodPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConsultaPais_Click(object sender, EventArgs e)
        {
            consultaPaises.btnSair.Text = "Selecionar";
            consultaPaises.cbBuscaInativos.Visible = false;

            if (consultaPaises.ShowDialog() == DialogResult.OK)
            {
                //receber os detalhes do país selecionado
                var paisDetalhes = consultaPaises.Tag as Tuple<int, string>;
                if (paisDetalhes != null)
                {
                    int paisID = paisDetalhes.Item1;
                    string paisNome = paisDetalhes.Item2;

                    //atualizar o campo txtPais com o nome do país selecionado
                    txtCodPais.Texts = paisID.ToString();
                    txtPais.Texts = paisNome;
                }
            }
        }
    }
}
