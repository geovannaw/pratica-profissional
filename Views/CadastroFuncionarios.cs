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
    public partial class CadastroFuncionarios : Sistema_Vendas.Views.CadastroPaiCEP
    {
        private FuncionarioController<FuncionarioModel> funcionarioController;
        private ConsultaCidades consultaCidades;
        public CadastroFuncionarios()
        {
            InitializeComponent();
            funcionarioController = new FuncionarioController<FuncionarioModel>();
            consultaCidades = new ConsultaCidades();
        }

        public CadastroFuncionarios(int idFuncionario) : this()
        {
            idAlterar = idFuncionario;
            Carrega();
        }

        public override void Salvar()
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }
            int idAtual = idAlterar != -1 ? idAlterar : -1;
            string cpf = new string(txtCPF.Text.Where(char.IsDigit).ToArray());

            if (funcionarioController.JaCadastrado(cpf, idAtual))
            {
                MessageBox.Show("Funcionário já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Focus();
            }
            else
            {
                try
                {
                    string funcionario = txtFuncionario.Text;
                    string apelido = txtApelido.Text;
                    string endereco = txtEndereco.Text;
                    string bairro = txtBairro.Text;
                    int numero = Convert.ToInt32(txtNumero.Text);
                    string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());
                    string complemento = txtComplemento.Text;
                    string email = txtEmail.Text;
                    string telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
                    string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());
                    string rg = new string(txtRG.Text.Where(char.IsDigit).ToArray());
                    string cargo = txtCargo.Text;
                    decimal salario = decimal.Parse(FormataPreco(txtSalario.Text));
                    string pis = new string(txtPis.Text.Where(char.IsDigit).ToArray());
                    int idCidade = int.Parse(txtCodCidade.Text);
                    string sexo = txtSexo.SelectedItem.ToString();

                    AtualizarCampoComDataPadrao(txtDataNasc, out DateTime data_nasc);
                    AtualizarCampoComDataPadrao(txtDataAdmissao, out DateTime data_admissao);
                    AtualizarCampoComDataPadrao(txtDataDemissao, out DateTime data_demissao);

                    DateTime.TryParse(txtDataCadastro.Text, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Text, out DateTime result) ? result : DateTime.MinValue;

                    FuncionarioModel novoFuncionario = new FuncionarioModel
                    {
                        funcionario = funcionario,
                        apelido = apelido,
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
                        cpf = cpf,
                        rg = rg,
                        cargo = cargo,
                        salario = salario,
                        pis = pis,
                        data_admissao = data_admissao,
                        data_demissao = data_demissao,
                        Ativo = isAtivo,
                        dataCadastro = dataCadastro,
                        dataUltAlt = dataUltAlt,
                        idCidade = idCidade
                    };

                    if (idAlterar == -1)
                    {
                        funcionarioController.Salvar(novoFuncionario);
                    }
                    else
                    {
                        novoFuncionario.idFuncionario = idAlterar;
                        funcionarioController.Alterar(novoFuncionario);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public override void LimparCampos()
        {
            idAlterar = -1;
            txtCodigo.Clear();
            txtFuncionario.Clear();
            txtApelido.Clear();
            txtSexo.SelectedIndex = -1;
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCodCidade.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtPais.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtDataNasc.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            txtPis.Clear();
            txtDataAdmissao.Clear();
            txtDataDemissao.Clear();
            txtDataCadastro.Clear();
            txtDataUltAlt.Clear();
            rbAtivo.Checked = true;
        }

        public void SetID(int id)
        {
            idAlterar = id;
        }
        public override void Carrega()
        {
            if (idAlterar != -1)
            {
                FuncionarioModel funcionario = funcionarioController.GetById(idAlterar);
                if (funcionario != null)
                {
                    txtCodigo.Text = funcionario.idFuncionario.ToString();
                    txtFuncionario.Text = funcionario.funcionario;
                    txtApelido.Text = funcionario.apelido;
                    txtEndereco.Text = funcionario.endereco;
                    txtBairro.Text = funcionario.bairro;
                    txtNumero.Text = funcionario.numero.ToString();
                    txtCEP.Text = funcionario.cep;
                    txtComplemento.Text = funcionario.complemento;
                    txtCodCidade.Text = funcionario.idCidade.ToString();
                    txtSexo.Text = funcionario.sexo;
                    txtEmail.Text = funcionario.email;
                    txtTelefone.Text = funcionario.telefone;
                    txtCelular.Text = funcionario.celular;
                    txtCPF.Text = funcionario.cpf;
                    txtRG.Text = funcionario.rg;
                    txtCargo.Text = funcionario.cargo;
                    txtSalario.Text = funcionario.salario.ToString("N2");
                    txtPis.Text = funcionario.pis;
                    txtDataCadastro.Text = funcionario.dataCadastro.ToString();
                    txtDataUltAlt.Text = funcionario.dataUltAlt.ToString();
                    rbAtivo.Checked = funcionario.Ativo;
                    rbInativo.Checked = !funcionario.Ativo;

                    AtualizarCampoData(funcionario.data_nasc, txtDataNasc);
                    AtualizarCampoData(funcionario.data_admissao, txtDataAdmissao);
                    AtualizarCampoData(funcionario.data_demissao, txtDataDemissao);

                    List<string> cidadeEstadoPais = funcionarioController.GetCEPByIdCidade(funcionario.idCidade);

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
                    MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    List<string> cidadeEstadoPais = funcionarioController.GetCEPByIdCidade(cidadeID);

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

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCidade.Text))
            {
                if (!VerificaNumeros(txtCodCidade.Text))
                {
                    MessageBox.Show("Cód. Cidade inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodCidade.Focus();
                }
                else
                {
                    List<string> cidadeEstadoPais = funcionarioController.GetCEPByIdCidade(int.Parse(txtCodCidade.Text));

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
                    else
                    {
                        txtCodCidade.Clear();
                        txtCidade.Clear();
                        txtUF.Clear();
                        txtPais.Clear();
                        txtCodCidade.Focus();
                        MessageBox.Show("Código Cidade não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {
        }

        private void CadastroFuncionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaFuncionarios)this.Owner).AtualizarConsultaFuncionarios(false);
        }

        protected bool VerificaCamposObrigatorios()
        {
            string cpf = new string(txtCPF.Text.Where(char.IsDigit).ToArray());
            string pais = txtPais.Text;
            if (pais == "BRASIL")
            {
                if (!CampoObrigatorio(cpf))
                {
                    MessageBox.Show("CPF obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Focus();
                    return false;
                }
            }
            if (!CampoObrigatorio(txtFuncionario.Text))
            {
                MessageBox.Show("Campo Funcionário é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFuncionario.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtSexo.Text))
            {
                MessageBox.Show("Campo Sexo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSexo.Focus();
                return false;
            }
            string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(celular))
            {
                MessageBox.Show("Campo Celular é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtEmail.Text))
            {
                MessageBox.Show("Campo Email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            string cep = new string(txtCEP.Text.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(cep))
            {
                MessageBox.Show("Campo CEP é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCEP.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtEndereco.Text))
            {
                MessageBox.Show("Campo Endereço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtNumero.Text))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtBairro.Text))
            {
                MessageBox.Show("Campo Bairro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodCidade.Text))
            {
                MessageBox.Show("Campo Código Cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCidade.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCargo.Text))
            {
                MessageBox.Show("Campo Cargo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCargo.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtSalario.Text))
            {
                MessageBox.Show("Campo Salário é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtPis.Text))
            {
                MessageBox.Show("Campo PIS é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPis.Focus();
                return false;
            }
            string dataAdmissao = new string(txtDataAdmissao.Text.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(dataAdmissao))
            {
                MessageBox.Show("Campo Data Admissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataAdmissao.Focus();
                return false;
            }
            return true;
        }

        private void txtFuncionario_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtFuncionario.Text))
            {
                MessageBox.Show("Funcionário inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFuncionario.Focus();
            }
            int idAtual = idAlterar != -1 ? idAlterar : -1;
            if (funcionarioController.BuscaNome(txtFuncionario.Text, idAtual))
            {
                MessageBox.Show("Funcionário já existe no cadastro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            string cpf = new string(txtCPF.Text.Where(char.IsDigit).ToArray());
            if (!ValidaCPF(cpf))
            {
                MessageBox.Show("CPF inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Focus();
            }
            
        }

        private void txtApelido_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtApelido.Text))
            {
                MessageBox.Show("Apelido inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApelido.Focus();
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            string telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
            if (!VerificaNumeros(telefone))
            {
                MessageBox.Show("Telefone inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone.Focus();
            }
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            string celular = new string(txtCelular.Text.Where(char.IsDigit).ToArray());
            if (!VerificaNumeros(celular))
            {
                MessageBox.Show("Celular inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidaEmail(txtEmail.Text))
            {
                MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtNumero.Text))
            {
                MessageBox.Show("Número inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
            }
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {

        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtRG.Text))
            {
                MessageBox.Show("RG inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRG.Focus();
            }
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtCargo.Text))
            {
                MessageBox.Show("Cargo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCargo.Focus();
            }
        }

        private void txtPis_Leave(object sender, EventArgs e)
        {
            string pis = new string(txtPis.Text.Where(char.IsDigit).ToArray());
            if (!VerificaNumeros(pis))
            {
                MessageBox.Show("PIS inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPis.Focus();
            }
            if (!ValidaPis(pis))
            {
                MessageBox.Show("PIS inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPis.Focus();
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            try
            {
                txtSalario.Text = FormataPreco(txtSalario.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números, pontos, vírgulas e teclas de controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
