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
    public partial class CadastroModelos : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private ModeloController<ModeloModel> modeloController;
        public CadastroModelos() 
        {
            InitializeComponent();
            modeloController = new ModeloController<ModeloModel>();
            idAlterar = -1;
        }

        public CadastroModelos(int idModelo) : this()
        {
            idAlterar = idModelo;
            Carrega();
        }

        public override void Carrega()
        {
            if (idAlterar != -1)
            {
                ModeloModel modelo = modeloController.GetById(idAlterar);
                if (modelo != null)
                {
                    txtCodigo.Text = modelo.idModelo.ToString();
                    txtModelo.Text = modelo.Modelo;
                    txtMarca.Text = modelo.Marca;
                    txtObservacao.Text = modelo.Observacao;
                    txtDataCadastro.Text = modelo.dataCadastro.ToString();
                    txtDataUltAlt.Text = modelo.dataUltAlt.ToString();
                    rbAtivo.Checked = modelo.Ativo;
                    rbInativo.Checked = !modelo.Ativo;
                }
                else
                {
                    MessageBox.Show("Modelo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void Salvar()
        {
            int idAtual = idAlterar != -1 ? idAlterar : -1;
            if (modeloController.JaCadastrado(txtModelo.Text, txtMarca.Text, idAtual))
            {
                MessageBox.Show("Modelo já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelo.Focus();
            } else
            {
                if (!CampoObrigatorio(txtModelo.Text))
                {
                    MessageBox.Show("Campo Modelo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelo.Focus();
                }
                else if (!CampoObrigatorio(txtMarca.Text))
                {
                    MessageBox.Show("Campo Marca é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMarca.Focus();
                }
                else 
                {
                    try
                    {
                        string modelo = txtModelo.Text;
                        string marca = txtMarca.Text;
                        string observacao = txtObservacao.Text;

                        DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                        ModeloModel novoModelo = new ModeloModel
                        {
                            Modelo = modelo,
                            Marca = marca,
                            Observacao = observacao,
                            dataCadastro = dataCadastro,
                            dataUltAlt = dataUltAlt,
                            Ativo = isAtivo
                        };

                        if (idAlterar == -1)
                        {
                            modeloController.Salvar(novoModelo);
                        }
                        else
                        {
                            novoModelo.idModelo = idAlterar;
                            modeloController.Alterar(novoModelo);
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

        private void CadastroModelos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaModelos)this.Owner).AtualizarConsultaModelos(false);
        }

        private void CadastroModelos_Load(object sender, EventArgs e)
        {
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtMarca.Text))
            {
                MessageBox.Show("Campo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarca.Focus();
            }
        }
    }
}
