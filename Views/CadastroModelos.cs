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
        public override void Carrega()
        {
            if (idAlterar != -1)
            {
                ModeloModel modelo = modeloController.GetById(idAlterar);
                if (modelo != null)
                {
                    txtCodigo.Texts = modelo.idModelo.ToString();
                    txtModelo.Texts = modelo.Modelo;
                    txtMarca.Texts = modelo.Marca;
                    txtObservacao.Texts = modelo.Observacao;
                    txtDataCadastro.Texts = modelo.dataCadastro.ToString();
                    txtDataUltAlt.Texts = modelo.dataUltAlt.ToString();
                    rbAtivo.Checked = modelo.Ativo;
                    rbInativo.Checked = !modelo.Ativo;
                }
                else
                {
                    MessageBox.Show("Modelo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void LimparCampos()
        {
            idAlterar = -1;
            txtCodigo.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtObservacao.Clear();
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
            int idAtual = idAlterar != -1 ? idAlterar : -1;
            if (modeloController.JaCadastrado(txtModelo.Texts, txtMarca.Texts, idAtual))
            {
                MessageBox.Show("Modelo já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelo.Focus();
            } else
            {
                if (!CampoObrigatorio(txtModelo.Texts))
                {
                    MessageBox.Show("Campo Modelo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelo.Focus();
                }
                else if (!CampoObrigatorio(txtMarca.Texts))
                {
                    MessageBox.Show("Campo Marca é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMarca.Focus();
                }
                else 
                {
                    try
                    {
                        string modelo = txtModelo.Texts;
                        string marca = txtMarca.Texts;
                        string observacao = txtObservacao.Texts;

                        DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                        DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

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
    }
}
