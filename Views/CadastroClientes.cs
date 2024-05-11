using MySqlX.XDevAPI;
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
    public partial class CadastroClientes : Sistema_Vendas.Views.CadastroPessoasPai
    {
        private ClienteController<ClienteModel> clienteController;
        private ConsultaCidades consultaCidades;
        public CadastroClientes()
        {
            InitializeComponent();
            clienteController = new ClienteController<ClienteModel>();
            consultaCidades = new ConsultaCidades();
        }
        public CadastroClientes(int idCliente) : this()
        {
            idAlterar = idCliente;
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
                DateTime.TryParse(txtDataCadastro.Text, out dataCadastro);

                DateTime dataUltAlt;

                string sexo;
                if (isFisico) 
                {
                    sexo = txtSexo.SelectedItem.ToString();
                } else
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

                ClienteModel novoCliente = new ClienteModel
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

                if (idAlterar == -1)
                {
                    clienteController.Salvar(novoCliente);
                }
                else
                {
                    novoCliente.idCliente = idAlterar;
                    clienteController.Alterar(novoCliente);
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
                ClienteModel cliente = clienteController.GetById(idAlterar);
                if (cliente != null)
                {
                    txtCodigo.Text = cliente.idCliente.ToString();
                    rbFisica.Checked = cliente.tipo_pessoa;
                    rbJuridica.Checked = !cliente.tipo_pessoa;
                    txtCliente_razao_social.Text = cliente.cliente_razao_social;
                    txtApelido_nome_fantasia.Text = cliente.apelido_nome_fantasia;
                    txtEndereco.Text = cliente.endereco;
                    txtBairro.Text = cliente.bairro;
                    txtNumero.Text = cliente.numero.ToString();
                    txtCEP.Text = cliente.cep;
                    txtComplemento.Text = cliente.complemento;
                    txtCodCidade.Text = cliente.idCidade.ToString();
                    txtSexo.Text = cliente.sexo;
                    txtEmail.Text = cliente.email;
                    txtTelefone.Text = cliente.telefone;
                    txtCelular.Text = cliente.celular;
                    txtDataNasc.Text = cliente.data_nasc.ToString();
                    txtCPF_CNPJ.Text = cliente.cpf_cnpj;
                    txtIE_RG.Text = cliente.rg_ie;
                    txtDataCadastro.Text = cliente.dataCadastro.ToString();
                    txtDataUltAlt.Text = cliente.dataUltAlt.ToString();
                    rbAtivo.Checked = cliente.Ativo;
                    rbInativo.Checked = !cliente.Ativo;

                    List<string> cidadeEstadoPais = clienteController.GetCEPByCidadeId(cliente.idCidade);

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
                    MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    List<string> cidadeEstadoPais = clienteController.GetCEPByCidadeId(cidadeID);

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

        private void CadastroClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaClientes)this.Owner).AtualizarConsultaClientes(false);
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
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
                List<string> cidadeEstadoPais = clienteController.GetCEPByCidadeId(int.Parse(txtCodCidade.Text));

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
