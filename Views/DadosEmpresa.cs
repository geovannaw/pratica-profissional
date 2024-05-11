using MySqlX.XDevAPI;
using Sistema_Vendas.Controller;
using Sistema_Vendas.Models;
using Sistema_Vendas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas
{
    public partial class DadosEmpresa : Form
    {
        private DadosEmpresaController<DadosEmpresaModel> dadosEmpresaController;
        private ConsultaCidades consultaCidades;
        int idDadosEmp;
        public DadosEmpresa()
        {
            InitializeComponent();
            dadosEmpresaController = new DadosEmpresaController<DadosEmpresaModel>();
            consultaCidades = new ConsultaCidades();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Desbloqueia();
        }

        private void DadosEmpresa_Load(object sender, EventArgs e)
        {
            Bloqueia();
            List<DadosEmpresaModel> empresas = dadosEmpresaController.GetAll(false);
            if (empresas.Count > 0)
            {
                DadosEmpresaModel empresa = empresas[0]; 
                Carrega(empresa);
            }
        }

        public void Salvar()
        {
            string cnpj = new string(txtCNPJ.Text.Where(char.IsDigit).ToArray());
            string ie = new string(txtIE.Text.Where(char.IsDigit).ToArray());
            string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());
            string telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
            string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());

            DadosEmpresaModel empresa = new DadosEmpresaModel
            {
                idDadosEmpresa = idDadosEmp,
                razao_social = txtRazaoSocial.Text,
                nome_fantasia = txtNomeFantasia.Text,
                endereco = txtEndereco.Text,
                bairro = txtBairro.Text,
                numero = Convert.ToInt32(txtNumero.Text),
                cep = cep,
                complemento = txtComplemento.Text,
                idCidade = Convert.ToInt32(txtCodCidade.Text),
                email = txtEmail.Text,
                telefone = telefone,
                celular = celular,
                cnpj = cnpj,
                ie = ie,
                nome_responsavel = txtNomeResponsavel.Text
            };

            dadosEmpresaController.Alterar(empresa);

            MessageBox.Show("Dados atualizados com sucesso!");

            Bloqueia();
        }

        public void Bloqueia() 
        {
            txtRazaoSocial.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtCEP.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCodCidade.Enabled = false;
            btnConsultaCidades.Enabled = true;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            txtPais.Enabled = false;
            txtCNPJ.Enabled = false;
            txtIE.Enabled = false;
            txtNomeResponsavel.Enabled = false;
        }
        public void Desbloqueia() 
        {
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtCEP.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCodCidade.Enabled = true;
            btnConsultaCidades.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            txtPais.Enabled = true;
            txtCNPJ.Enabled = true;
            txtIE.Enabled = true;
            txtNomeResponsavel.Enabled = true;
        }

        public void Carrega(DadosEmpresaModel empresa)
        {
            idDadosEmp = empresa.idDadosEmpresa;
            txtRazaoSocial.Text = empresa.razao_social;
            txtNomeFantasia.Text = empresa.nome_fantasia;
            txtEndereco.Text = empresa.endereco;
            txtBairro.Text = empresa.bairro;
            txtNumero.Text = empresa.numero.ToString();
            txtCEP.Text = empresa.cep;
            txtComplemento.Text = empresa.complemento;
            txtCodCidade.Text = empresa.idCidade.ToString();
            txtEmail.Text = empresa.email;
            txtTelefone.Text = empresa.telefone;
            txtCelular.Text = empresa.celular;
            txtCNPJ.Text = empresa.cnpj;
            txtIE.Text = empresa.ie;
            txtNomeResponsavel.Text = empresa.nome_responsavel;

            List<string> cidadeEstadoPais = dadosEmpresaController.GetCEPByCidadeId(empresa.idCidade);

            if (cidadeEstadoPais.Count > 0)
            {
                string[] info = cidadeEstadoPais[0].Split(',');
                if (info.Length >= 3)
                {
                    txtCidade.Text = info[0].Trim();
                    txtUF.Text = info[1].Trim();
                    txtPais.Text = info[2].Trim();
                }
            }
        }

        private void btnConsultaCidades_Click(object sender, EventArgs e)
        {
            consultaCidades.btnSair.Text = "Selecionar";

            if (consultaCidades.ShowDialog() == DialogResult.OK)
            {
                var cidadeDetalhes = consultaCidades.Tag as Tuple<int, string>;

                if (cidadeDetalhes != null)
                {
                    int cidadeID = cidadeDetalhes.Item1;
                    string cidadeNome = cidadeDetalhes.Item2;

                    txtCodCidade.Text = cidadeID.ToString();
                    txtCidade.Text = cidadeNome;

                    List<string> cidadeEstadoPais = dadosEmpresaController.GetCEPByCidadeId(cidadeID);

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtUF.Text = info[1].Trim();
                            txtPais.Text = info[2].Trim();
                        }
                    }
                }
            }
        }
    }
}
