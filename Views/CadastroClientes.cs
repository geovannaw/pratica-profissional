
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
        private ConsultaCondicaoPagamento consultaCondicaoPagamento;
        private CondicaoPagamentoController<CondicaoPagamentoModel> condicaoPagamentoController;
        public CadastroClientes()
        {
            InitializeComponent();
            clienteController = new ClienteController<ClienteModel>();
            consultaCidades = new ConsultaCidades();
            consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            condicaoPagamentoController = new CondicaoPagamentoController<CondicaoPagamentoModel>();
        }
        public override void Salvar() 
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }

            int idAtual = idAlterar != -1 ? idAlterar : -1;
            string cpf_cnpj = new string(txtCPF_CNPJ.Texts.Where(char.IsDigit).ToArray());

            if (clienteController.JaCadastrado(cpf_cnpj, idAtual))
            {
                MessageBox.Show("Cliente já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF_CNPJ.Focus();
            }
            else
            {
                try
                {
                    string cliente_razao_social = txtCliente_razao_social.Texts;
                    string apelido_nome_fantasia = txtApelido_nome_fantasia.Texts;
                    string endereco = txtEndereco.Texts;
                    string bairro = txtBairro.Texts;
                    string numero = txtNumero.Texts;
                    string cep = new string(txtCEP.Texts.Where(char.IsDigit).ToArray());
                    string complemento = txtComplemento.Texts;
                    string email = txtEmail.Texts;
                    string telefone = new string(txtTelefone.Texts.Where(char.IsDigit).ToArray());
                    string celular = new string(txtCelular.Texts.Where(char.IsDigit).ToArray());
                    string nome_contato = txtContato.Texts;
                    string rg_ie = new string(txtIE_RG.Texts.Where(char.IsDigit).ToArray());
                    int idCidade = int.Parse(txtCodCidade.Texts);
                    int idCondPagamento = int.Parse(txtCodCondPag.Texts);

                    AtualizarCampoComDataPadrao(txtDataNasc, out DateTime data_nasc);

                    if (rbFisica.Checked)
                    {
                        if (!VerificarDataMenorOuIgualHoje(data_nasc, "nascimento"))
                        {
                            txtDataNasc.Focus();
                            return;
                        }
                    }
                    else
                    {
                        if (!VerificarDataMenorOuIgualHoje(data_nasc, "fundação"))
                        {
                            txtDataNasc.Focus();
                            return;
                        }
                    }

                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

                    string sexo;
                    if (isFisico)
                    {
                        sexo = txtSexo.SelectedItem.ToString();
                    }
                    else
                    {
                        sexo = "Outro"; //quando for jurídico não tem
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
                        nome_contato = nome_contato,
                        data_nasc = data_nasc,
                        cpf_cnpj = cpf_cnpj,
                        rg_ie = rg_ie,
                        Ativo = isAtivo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        idCidade = idCidade,
                        idCondPagamento = idCondPagamento,
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
        }
        public override void Carrega()
        {
            base.Carrega();
            rbFisica.Enabled = false;
            rbJuridica.Enabled = false;
            if (idAlterar != -1)
            {
                ClienteModel cliente = clienteController.GetById(idAlterar);
                if (cliente != null)
                {
                    txtCodigo.Texts = cliente.idCliente.ToString();
                    rbFisica.Checked = cliente.tipo_pessoa;
                    rbJuridica.Checked = !cliente.tipo_pessoa;
                    txtCliente_razao_social.Texts = cliente.cliente_razao_social;
                    txtApelido_nome_fantasia.Texts = cliente.apelido_nome_fantasia;
                    txtEndereco.Texts = cliente.endereco;
                    txtBairro.Texts = cliente.bairro;
                    txtNumero.Texts = cliente.numero;
                    txtCEP.Texts = cliente.cep;
                    txtComplemento.Texts = cliente.complemento;
                    txtCodCidade.Texts = cliente.idCidade.ToString();
                    txtEmail.Texts = cliente.email;
                    txtTelefone.Texts = cliente.telefone;
                    txtCelular.Texts = cliente.celular;
                    txtContato.Texts = cliente.nome_contato;
                    txtCPF_CNPJ.Texts = cliente.cpf_cnpj;
                    txtIE_RG.Texts = cliente.rg_ie;
                    txtDataCadastro.Texts = cliente.dataCadastro.ToString();
                    txtDataUltAlt.Texts = cliente.dataUltAlt.ToString();
                    rbAtivo.Checked = cliente.Ativo;
                    rbInativo.Checked = !cliente.Ativo;
                    txtCodCondPag.Texts = cliente.idCondPagamento.ToString();

                    if (!txtSexo.Items.Contains(cliente.sexo))
                    {
                        txtSexo.Items.Add(cliente.sexo);
                    }
                    txtSexo.Texts = cliente.sexo;

                    string condPagamento = clienteController.GetCondPagamentoByClienteId(cliente.idCliente);

                    if (!string.IsNullOrEmpty(condPagamento))
                    {
                        txtCondPag.Texts = condPagamento;
                    }

                    AtualizarCampoData(cliente.data_nasc, txtDataNasc);

                    List<string> cidadeEstadoPais = clienteController.GetCEPByIdCidade(cliente.idCidade);

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtCidade.Texts = info[0].Trim();
                            txtUF.Texts = info[1].Trim();
                            txtPais.Texts = info[2].Trim();
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

                    txtCodCidade.Texts = cidadeID.ToString();
                    txtCidade.Texts = cidadeNome;

                    List<string> cidadeEstadoPais = clienteController.GetCEPByIdCidade(cidadeID);

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtUF.Texts = info[1].Trim();
                            txtPais.Texts = info[2].Trim();
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
            if (idAlterar == -1)
            {
                int novoCodigo = clienteController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCidade.Texts))
            {
                    List<string> cidadeEstadoPais = clienteController.GetCEPByIdCidade(int.Parse(txtCodCidade.Texts));

                    if (cidadeEstadoPais.Count > 0)
                    {
                        string[] info = cidadeEstadoPais[0].Split(',');
                        if (info.Length >= 3)
                        {
                            txtCidade.Texts = info[0].Trim();
                            txtUF.Texts = info[1].Trim();
                            txtPais.Texts = info[2].Trim();
                        }
                    } else
                    {
                        MessageBox.Show("Código Cidade não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodCidade.Focus();
                        txtCodCidade.Clear();
                        txtCidade.Clear();
                        txtUF.Clear();
                        txtPais.Clear();
                    }
            }            
        }

        private void txtCliente_razao_social_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtCliente_razao_social.Texts))
            {
                MessageBox.Show("Cliente inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCliente_razao_social.Focus();
            }
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCliente_razao_social.Text = "Cliente *";
        }

        private void txtCodCondPag_Leave(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(txtCodCondPag.Texts))
                {
                    CondicaoPagamentoModel condPagamento = condicaoPagamentoController.GetById(int.Parse(txtCodCondPag.Texts));
                    if (condPagamento != null)
                    {
                        txtCondPag.Texts = condPagamento.condicaoPagamento;
                    }
                    else
                    {
                        MessageBox.Show("Condição de Pagamento não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodCondPag.Focus();
                        txtCodCondPag.Clear();
                        txtCondPag.Clear();
                    }
                }
        }

        private void btnConsultaCondPag_Click(object sender, EventArgs e)
        {
            consultaCondicaoPagamento.btnSair.Text = "Selecionar";
            if (consultaCondicaoPagamento.ShowDialog() == DialogResult.OK)
            {
                var condPagamento = consultaCondicaoPagamento.Tag as Tuple<int, string>;
                if (condPagamento != null)
                {
                    int idCondPag = condPagamento.Item1;
                    string condicaoPagamento = condPagamento.Item2;

                    txtCodCondPag.Texts = idCondPag.ToString();
                    txtCondPag.Texts = condicaoPagamento;
                }
            }
        }
    }
}
