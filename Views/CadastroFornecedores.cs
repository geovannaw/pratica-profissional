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
    public partial class CadastroFornecedores : Sistema_Vendas.Views.CadastroPessoasPai
    {
        private FornecedorController<FornecedorModel> fornecedorController;
        private ConsultaCidades consultaCidades;
        public CadastroFornecedores()
        {
            InitializeComponent();
            fornecedorController = new FornecedorController<FornecedorModel>();
            consultaCidades = new ConsultaCidades();    
        }
        public CadastroFornecedores(int idFornecedor) : this()
        {
            idAlterar = idFornecedor;
            rbFisica.Enabled = false;
            rbJuridica.Enabled = false;
            Carrega();
        }

        public override void Salvar()
        {
            try
            {
                string cliente_razao_social = txtCliente_razao_social.Text;
                string apelido_nome_fantasia = txtApelido_nome_fantasia.Text;
                string endereco = txtEndereco.Text;
                string bairro = txtBairro.Text;
                int numero = Convert.ToInt32(txtNumero.Text);
                string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());
                string complemento = txtComplemento.Text;
                string email = txtEmail.Text;
                string telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
                string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());
                string cpf_cnpj = new string(txtCPF_CNPJ.Text.Where(char.IsDigit).ToArray());
                string rg_ie = new string(txtIE_RG.Text.Where(char.IsDigit).ToArray());
                int idCidade = int.Parse(txtCodCidade.Text);

                DateTime data_nasc;
                DateTime.TryParse(txtDataNasc.Text, out data_nasc);

                DateTime dataCadastro;
                DateTime dataUltAlt;

                DateTime.TryParse(txtDataCadastro.Text, out dataCadastro);

                string sexo;
                if (isFisico)
                {
                    sexo = txtSexo.SelectedItem.ToString();
                }
                else
                {
                    sexo = "Outro"; //quando for jurídico não tem
                }

                if (idAlterar != -1)
                {
                    DateTime.TryParse(DateTime.Now.ToString(), out dataUltAlt);
                }
                else
                {
                    DateTime.TryParse(txtDataUltAlt.Text, out dataUltAlt);
                }

                FornecedorModel novoFornecedor = new FornecedorModel
                {
                    tipo_pessoa = isFisico,
                    cliente_razao_social = cliente_razao_social,
                    apelido_nome_fantasia = apelido_nome_fantasia,
                    endereco = endereco,
                    bairro = bairro,
                    numero = numero,
                    cep = cep,
                    complemento = complemento,
                    sexo = sexo,
                    email = email,
                    telefone = telefone,
                    celular = celular,
                    data_nasc = data_nasc,
                    cpf_cnpj = cpf_cnpj,
                    rg_ie = rg_ie,
                    Ativo = isAtivo,
                    dataCadastro = dataCadastro,
                    dataUltAlt = dataUltAlt,
                    idCidade = idCidade
                };

                MessageBox.Show("TIPO PESSOA: " + isFisico +
                " CLIENTE: " + cliente_razao_social +
                " APELIDO: " + apelido_nome_fantasia +
                " ENDERECO: " + endereco +
                " BAIRRO: " + bairro +
                " NRO: " + numero +
                " CEP: " + cep +
                " COMP: " + complemento +
                " SEXO: " + sexo +
                " TEL: " + telefone +
                " CEL: " + celular +
                " DATA_NASC: " + data_nasc +
                " CPF: " + cpf_cnpj +
                " RG IE: " + rg_ie +
                " ATIVO: " + isAtivo +
                " DATA CAD: " + dataCadastro +
                " DATA ULT ALT: " + dataUltAlt +
                " ID CIDADE: " + idCidade
                , "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (idAlterar == -1)
                {
                    fornecedorController.Salvar(novoFornecedor);
                }
                else
                {
                    novoFornecedor.idFornecedor = idAlterar;
                    fornecedorController.Alterar(novoFornecedor);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Carrega()
        {
            if (idAlterar != -1)
            {
                FornecedorModel fornecedor = fornecedorController.GetById(idAlterar);
                if (fornecedor != null)
                {
                    txtCodigo.Text = fornecedor.idFornecedor.ToString();
                    rbFisica.Checked = fornecedor.tipo_pessoa;
                    rbJuridica.Checked = !fornecedor.tipo_pessoa;
                    txtCliente_razao_social.Text = fornecedor.cliente_razao_social;
                    txtApelido_nome_fantasia.Text = fornecedor.apelido_nome_fantasia;
                    txtEndereco.Text = fornecedor.endereco;
                    txtBairro.Text = fornecedor.bairro;
                    txtNumero.Text = fornecedor.numero.ToString();
                    txtCEP.Text = fornecedor.cep;
                    txtComplemento.Text = fornecedor.complemento;
                    txtCodCidade.Text = fornecedor.idCidade.ToString();
                    txtSexo.Text = fornecedor.sexo;
                    txtEmail.Text = fornecedor.email;
                    txtTelefone.Text = fornecedor.telefone;
                    txtCelular.Text = fornecedor.celular;
                    txtDataNasc.Text = fornecedor.data_nasc.ToString();
                    txtCPF_CNPJ.Text = fornecedor.cpf_cnpj;
                    txtIE_RG.Text = fornecedor.rg_ie;
                    txtDataCadastro.Text = fornecedor.dataCadastro.ToString();
                    txtDataUltAlt.Text = fornecedor.dataUltAlt.ToString();
                    rbAtivo.Checked = fornecedor.Ativo;
                    rbInativo.Checked = !fornecedor.Ativo;

                    List<string> cidadeEstadoPais = fornecedorController.GetCEPByCidadeId(fornecedor.idCidade);

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
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    List<string> cidadeEstadoPais = fornecedorController.GetCEPByCidadeId(cidadeID);

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

        private void CadastroFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaFornecedores)this.Owner).AtualizarConsultaFornecedores(false);
        }

        private void CadastroFornecedores_Load(object sender, EventArgs e)
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

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCidade.Text))
            {
                List<string> cidadeEstadoPais = fornecedorController.GetCEPByCidadeId(int.Parse(txtCodCidade.Text));

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
        }
    }
}
