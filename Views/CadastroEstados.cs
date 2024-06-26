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

        public CadastroEstados(int idEstado) : this()
        {
            idAlterar = idEstado;
            Carrega();
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
            if (idAlterar != -1)
            {
                EstadoModel estado = estadoController.GetById(idAlterar);
                if (estado != null)
                {
                    txtCodigo.Text = estado.idEstado.ToString();
                    txtEstado.Text = estado.Estado;
                    txtUF.Text = estado.UF;
                    txtCodPais.Text = estado.idPais.ToString();
                    txtDataCadastro.Text = estado.dataCadastro.ToString();
                    txtDataUltAlt.Text = estado.dataUltAlt.ToString();
                    rbAtivo.Checked = estado.Ativo;
                    rbInativo.Checked = !estado.Ativo;

                    string nomePais = estadoController.GetNomePaisByEstadoId(estado.idEstado);

                    if (!string.IsNullOrEmpty(nomePais))
                    {
                        txtPais.Text = nomePais;
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
            idAlterar = -1;
            txtCodigo.Clear();
            txtEstado.Clear();
            txtUF.Clear();
            txtCodPais.Clear();
            txtPais.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        public override void Salvar()
        {
            if (!CampoObrigatorio(txtEstado.Text))
            {
                MessageBox.Show("Campo Estado é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstado.Focus();
            }
            else if (!CampoObrigatorio(txtUF.Text))
            {
                MessageBox.Show("Campo UF é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUF.Focus();
            }
            else if (!CampoObrigatorio(txtCodPais.Text))
            {
                MessageBox.Show("Campo Código País é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodPais.Focus();
            }
            else
            {
                int idAtual = idAlterar != -1 ? idAlterar : -1;

                if (estadoController.JaCadastrado(txtEstado.Text, idAtual))
                {
                    MessageBox.Show("Estado já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEstado.Focus();
                }
                else
                {
                    try
                    {
                        string estado = txtEstado.Text;
                        string UF = txtUF.Text;
                        int idPais = int.Parse(txtCodPais.Text);

                        DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                        EstadoModel novoEstado = new EstadoModel
                        {
                            Estado = estado,
                            UF = UF,
                            idPais = idPais,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = isAtivo
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

        private void btnConsultaPais_Click(object sender, EventArgs e)
        {
            consultaPaises.btnSair.Text = "Selecionar";

            if (consultaPaises.ShowDialog() == DialogResult.OK)
            {
                // Receber os detalhes do país selecionado
                var paisDetalhes = consultaPaises.Tag as Tuple<int, string>;
                if (paisDetalhes != null)
                {
                    int paisID = paisDetalhes.Item1;
                    string paisNome = paisDetalhes.Item2;

                    // Atualizar o campo txtPais com o nome do país selecionado
                    txtCodPais.Text = paisID.ToString();
                    txtPais.Text = paisNome;
                }
            }

        }

        private void CadastroEstados_Load(object sender, EventArgs e)
        {
        }

        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            isAtivo = rbAtivo.Checked;
        }

        private void rbInativo_CheckedChanged(object sender, EventArgs e)
        {
            isAtivo = !rbInativo.Checked;
        }

        private void txtCodPais_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtCodPais.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodPais.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCodPais.Text))
                {
                    PaisModel pais = paisController.GetById(int.Parse(txtCodPais.Text));
                    if (pais != null)
                    {
                        txtPais.Text = pais.Pais;
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
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtEstado.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstado.Focus();
            }
        }

        private void txtUF_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetrasSemEspaco(txtUF.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUF.Focus();
            }
        }
    }
}
