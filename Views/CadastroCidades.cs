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

        public CadastroCidades(int idCidade) : this()
        {
            idAlterar = idCidade;
            Carrega();
        }

        public override void Carrega()
        {
            if (idAlterar != -1)
            {
                CidadeModel cidade = cidadeController.GetById(idAlterar);
                if (cidade != null)
                {
                    txtCodigo.Text = cidade.idCidade.ToString();
                    txtCidade.Text = cidade.Cidade;
                    txtDDD.Text = cidade.DDD.ToString();
                    txtCodEstado.Text = cidade.idEstado.ToString();
                    txtDataCadastro.Text = cidade.dataCadastro.ToString();
                    txtDataUltAlt.Text = cidade.dataUltAlt.ToString();
                    rbAtivo.Checked = cidade.Ativo;
                    rbInativo.Checked = !cidade.Ativo;

                    string nomeEstado = cidadeController.GetNomeEstadoByCidadeId(cidade.idCidade);

                    if (!string.IsNullOrEmpty(nomeEstado))
                    {
                        txtEstado.Text = nomeEstado;
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
            if (cidadeController.JaCadastrado(txtCidade.Text, int.Parse(txtCodEstado.Text)))
            {
                MessageBox.Show("Cidade já cadastrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
            }
            else 
            {
                if (!CampoObrigatorio(txtCidade.Text))
                {
                    MessageBox.Show("Campo Cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCidade.Focus();
                }
                else if (!CampoObrigatorio(txtDDD.Text))
                {
                    MessageBox.Show("Campo DDD é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDDD.Focus();
                }
                else if (!CampoObrigatorio(txtCodEstado.Text))
                {
                    MessageBox.Show("Campo Código Estado é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodEstado.Focus();
                }
                else
                {
                    try
                    {
                        string cidade = txtCidade.Text;
                        int DDD = int.Parse(txtDDD.Text);
                        int idEstado = int.Parse(txtCodEstado.Text);
                        DateTime dataCadastro;
                        DateTime dataUltAlt;

                        DateTime.TryParse(txtDataCadastro.Text, out dataCadastro);

                        if (idAlterar != -1)
                        {
                            DateTime.TryParse(DateTime.Now.ToString(), out dataUltAlt);
                        }
                        else
                        {
                            DateTime.TryParse(txtDataUltAlt.Text, out dataUltAlt);
                        }

                        CidadeModel novaCidade = new CidadeModel
                        {
                            Cidade = cidade,
                            DDD = DDD,
                            idEstado = idEstado,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = isAtivo
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

        private void CadastroCidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaCidades)this.Owner).AtualizarConsultaCidades(false);
        }

        private void btnConsultaEstado_Click(object sender, EventArgs e)
        {
            consultaEstados.btnSair.Text = "Selecionar";

            if (consultaEstados.ShowDialog() == DialogResult.OK)
            {
                // Receber os detalhes do estado selecionado
                var estadoDetalhes = consultaEstados.Tag as Tuple<int, string>;
                
                if (estadoDetalhes != null)
                {
                    int estadoID = estadoDetalhes.Item1;
                    string estadoNome = estadoDetalhes.Item2;

                    txtCodEstado.Text = estadoID.ToString();
                    txtEstado.Text = estadoNome;
                }
            }
        }

        private void CadastroCidades_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                txtCodigo.Text = "0";
            }
            if (idAlterar == -1)
            {
                txtDataCadastro.Text = DateTime.Now.ToString();
                txtDataUltAlt.Text = DateTime.Now.ToString();
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

        private void txtCodEstado_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtCodEstado.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodEstado.Focus();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtCodEstado.Text))
                {
                    EstadoModel estado = estadoController.GetById(int.Parse(txtCodEstado.Text));
                    if (estado != null)
                    {
                        txtEstado.Text = estado.Estado;
                    }
                    else
                    {
                        MessageBox.Show("Estado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodEstado.Focus();
                    }
                }
            }  
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtCidade.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
            }
        }

        private void txtDDD_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtDDD.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDD.Focus();
            }
        }
    }
}
