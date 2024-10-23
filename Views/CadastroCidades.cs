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
    public partial class CadastroCidades : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private CidadeController<CidadeModel> cidadeController;
        private ConsultaEstados consultaEstados;
        private EstadoController<EstadoModel> estadoController;
        public CadastroCidades()
        {
            InitializeComponent();
            cidadeController = new CidadeController<CidadeModel>();
            consultaEstados = new ConsultaEstados();
            estadoController = new EstadoController<EstadoModel>();
        }
        public override void Carrega()
        {
            base.Carrega();
            if (idAlterar != -1)
            {
                CidadeModel cidade = cidadeController.GetById(idAlterar);
                if (cidade != null)
                {
                    txtCodigo.Texts = cidade.idCidade.ToString();
                    txtCidade.Texts = cidade.Cidade;
                    txtDDD.Texts = cidade.DDD.ToString();
                    txtCodEstado.Texts = cidade.idEstado.ToString();
                    txtDataCadastro.Texts = cidade.dataCadastro.ToString();
                    txtUsuarioUltAlt.Texts = cidade.usuario;
                    txtDataUltAlt.Texts = cidade.dataUltAlt.ToString();
                    rbAtivo.Checked = cidade.Ativo;
                    rbInativo.Checked = !cidade.Ativo;

                    string nomeEstado = cidadeController.GetNomeEstadoByCidadeId(cidade.idCidade);

                    if (!string.IsNullOrEmpty(nomeEstado))
                    {
                        txtEstado.Texts = nomeEstado;
                    }
                }
                else
                {
                    MessageBox.Show("Cidade não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void Salvar()
        {
            if (!CampoObrigatorio(txtCidade.Texts))
            {
                MessageBox.Show("Campo Cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
            }
            else if (!CampoObrigatorio(txtDDD.Texts))
            {
                MessageBox.Show("Campo DDD é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDD.Focus();
            }
            else if (!CampoObrigatorio(txtCodEstado.Texts))
            {
                MessageBox.Show("Campo Código Estado é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodEstado.Focus();
            }
            else
            {
                int idAtual = idAlterar != -1 ? idAlterar : -1;
                if (cidadeController.JaCadastrado(txtCidade.Texts, int.Parse(txtCodEstado.Texts), idAtual))
                {
                    MessageBox.Show("Cidade já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCidade.Focus();
                }
                else 
                {
                
                    try
                    {
                        string cidade = txtCidade.Texts;
                        int DDD = int.Parse(txtDDD.Texts);
                        int idEstado = int.Parse(txtCodEstado.Texts);
                        string usuario = Program.usuarioLogado;

                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                        CidadeModel novaCidade = new CidadeModel
                        {
                            Cidade = cidade,
                            DDD = DDD,
                            idEstado = idEstado,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = isAtivo,
                            usuario = usuario
                        };

                        if (idAlterar == -1)
                        {
                            cidadeController.Salvar(novaCidade);
                        }
                        else
                        {
                            novaCidade.idCidade = idAlterar;
                            cidadeController.Alterar(novaCidade);
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
            txtCidade.Clear();
            txtCodEstado.Clear();
            txtEstado.Clear();
            txtDDD.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }

        private void CadastroCidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaCidades)this.Owner).AtualizarConsultaCidades(false);
        }

        private void CadastroCidades_Load(object sender, EventArgs e)
        {
            if (idAlterar == -1)
            {
                int novoCodigo = cidadeController.GetUltimoCodigo() + 1;
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

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtCidade.Texts))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
            }
        }

        private void txtDDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodEstado_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodEstado.Texts))
            {
                string estado = estadoController.getEstado(int.Parse(txtCodEstado.Texts));
                if (estado != null)
                {
                    txtEstado.Texts = estado;
                }
                else
                {
                    MessageBox.Show("Estado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodEstado.Focus();
                    txtCodEstado.Clear();
                    txtEstado.Clear();
                }
            }
        }

        private void btnConsultaEstado_Click(object sender, EventArgs e)
        {
            consultaEstados.btnSair.Text = "Selecionar";
            consultaEstados.cbBuscaInativos.Visible = false;

            if (consultaEstados.ShowDialog() == DialogResult.OK)
            {
                //receber os detalhes do estado selecionado
                var estadoDetalhes = consultaEstados.Tag as Tuple<int, string>;

                if (estadoDetalhes != null)
                {
                    int estadoID = estadoDetalhes.Item1;
                    string estadoNome = estadoDetalhes.Item2;

                    txtCodEstado.Texts = estadoID.ToString();
                    txtEstado.Texts = estadoNome;
                }
            }
        }
    }
}
