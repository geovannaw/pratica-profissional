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

        public override void Salvar()
        {
            if (!VerificaCamposObrigatorios())
            {
                return;
            }
            int idAtual = idAlterar != -1 ? idAlterar : -1;
            string cpf = new string(txtCPF.Texts.Where(char.IsDigit).ToArray());

            if (funcionarioController.JaCadastrado(cpf, idAtual))
            {
                MessageBox.Show("Funcionário já cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Focus();
            }
            else
            {
                try
                {
                    string funcionario = txtFuncionario.Texts;
                    string apelido = txtApelido.Texts;
                    string endereco = txtEndereco.Texts;
                    string bairro = txtBairro.Texts;
                    string numero = txtNumero.Texts;
                    string cep = new string(txtCEP.Texts.Where(char.IsDigit).ToArray());
                    string complemento = txtComplemento.Texts;
                    string email = txtEmail.Texts;
                    string telefone = new string(txtTelefone.Texts.Where(char.IsDigit).ToArray());
                    string celular = new string(txtCelular.Texts.Where(char.IsDigit).ToArray());
                    string rg = new string(txtRG.Texts.Where(char.IsDigit).ToArray());
                    string cargo = txtCargo.Texts;
                    decimal salario = decimal.Parse(FormataPreco(txtSalario.Texts));
                    string pis = new string(txtPis.Texts.Where(char.IsDigit).ToArray());
                    int idCidade = int.Parse(txtCodCidade.Texts);
                    string sexo = txtSexo.SelectedItem.ToString();

                    AtualizarCampoComDataPadrao(txtDataNasc, out DateTime data_nasc);
                    if (!VerificarDataMenorOuIgualHoje(data_nasc, "nascimento"))
                    {
                        txtDataNasc.Focus();
                        return;
                    }

                    AtualizarCampoComDataPadrao(txtDataAdmissao, out DateTime data_admissao);
                    if (!VerificarDataMenorOuIgualHoje(data_admissao, "admissão"))
                    {
                        txtDataAdmissao.Focus();
                        return;
                    }
                    AtualizarCampoComDataPadrao(txtDataDemissao, out DateTime data_demissao);
                    if (!VerificarDataMenorOuIgualHoje(data_demissao, "demissão"))
                    {
                        txtDataDemissao.Focus();
                        return;
                    }

                    DateTime.TryParse(txtDataCadastro.Texts, out DateTime dataCadastro);
                    DateTime dataUltAlt = idAlterar != -1 ? DateTime.Now : DateTime.TryParse(txtDataUltAlt.Texts, out DateTime result) ? result : DateTime.MinValue;

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
                    txtCodigo.Texts = funcionario.idFuncionario.ToString();
                    txtFuncionario.Texts = funcionario.funcionario;
                    txtApelido.Texts = funcionario.apelido;
                    txtEndereco.Texts = funcionario.endereco;
                    txtBairro.Texts = funcionario.bairro;
                    txtNumero.Texts = funcionario.numero;
                    txtCEP.Texts = funcionario.cep;
                    txtComplemento.Texts = funcionario.complemento;
                    txtCodCidade.Texts = funcionario.idCidade.ToString();

                    if (!txtSexo.Items.Contains(funcionario.sexo))
                    {
                        txtSexo.Items.Add(funcionario.sexo);
                    }
                    txtSexo.Texts = funcionario.sexo;

                    txtEmail.Texts = funcionario.email;
                    txtTelefone.Texts = funcionario.telefone;
                    txtCelular.Texts = funcionario.celular;
                    txtCPF.Texts = funcionario.cpf;
                    txtRG.Texts = funcionario.rg;
                    txtCargo.Texts = funcionario.cargo;
                    txtSalario.Texts = funcionario.salario.ToString("N2");
                    txtPis.Texts = funcionario.pis;
                    txtDataCadastro.Texts = funcionario.dataCadastro.ToString();
                    txtDataUltAlt.Texts = funcionario.dataUltAlt.ToString();
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
                            txtCidade.Texts = info[0].Trim();
                            txtUF.Texts = info[1].Trim();
                            txtPais.Texts = info[2].Trim();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {
            if (idAlterar == -1)
            {
                int novoCodigo = funcionarioController.GetUltimoCodigo() + 1;
                txtCodigo.Texts = novoCodigo.ToString();
            }
        }

        private void CadastroFuncionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((ConsultaFuncionarios)this.Owner).AtualizarConsultaFuncionarios(false);
        }

        protected bool VerificaCamposObrigatorios()
        {
            string cpf = new string(txtCPF.Texts.Where(char.IsDigit).ToArray());
            string pais = txtPais.Texts;
            if (!CampoObrigatorio(cpf))
            {
                MessageBox.Show("CPF obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtFuncionario.Texts))
            {
                MessageBox.Show("Campo Funcionário é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFuncionario.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtSexo.Texts))
            {
                MessageBox.Show("Campo Sexo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSexo.Focus();
                return false;
            }
            string celular = new string(txtCelular.Texts.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(celular))
            {
                MessageBox.Show("Campo Celular é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtEmail.Texts))
            {
                MessageBox.Show("Campo Email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            string cep = new string(txtCEP.Texts.Where(char.IsDigit).ToArray());
            if (pais == "BRASIL")
            {
                if (!CampoObrigatorio(cep))
                {
                    MessageBox.Show("Campo CEP é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCEP.Focus();
                    return false;
                }
            }
            if (!CampoObrigatorio(txtEndereco.Texts))
            {
                MessageBox.Show("Campo Endereço é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtNumero.Texts))
            {
                MessageBox.Show("Campo Número é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtBairro.Texts))
            {
                MessageBox.Show("Campo Bairro é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCodCidade.Texts))
            {
                MessageBox.Show("Campo Código Cidade é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCidade.Focus();
                return false;
            }
            string dataNasc = new string(txtDataNasc.Texts.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(dataNasc))
            {
                MessageBox.Show("Campo Data Nasc. é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNasc.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtCargo.Texts))
            {
                MessageBox.Show("Campo Cargo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCargo.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtSalario.Texts))
            {
                MessageBox.Show("Campo Salário é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return false;
            }
            if (!CampoObrigatorio(txtPis.Texts))
            {
                MessageBox.Show("Campo PIS é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPis.Focus();
                return false;
            }
            string dataAdmissao = new string(txtDataAdmissao.Texts.Where(char.IsDigit).ToArray());
            if (!CampoObrigatorio(dataAdmissao))
            {
                MessageBox.Show("Campo Data Admissão é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataAdmissao.Focus();
                return false;
            }
            return true;
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

                    List<string> cidadeEstadoPais = funcionarioController.GetCEPByIdCidade(cidadeID);

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

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCodCidade.Texts)){
                List<string> cidadeEstadoPais = funcionarioController.GetCEPByIdCidade(int.Parse(txtCodCidade.Texts));

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
                else
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

        private void txtCodCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFuncionario_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtFuncionario.Texts))
            {
                MessageBox.Show("Funcionário inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFuncionario.Focus();
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            string cpf = new string(txtCPF.Texts.Where(char.IsDigit).ToArray());
            if (!ValidaCPF(cpf))
            {
                MessageBox.Show("CPF inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Focus();
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            string telefone = new string(txtTelefone.Texts.Where(char.IsDigit).ToArray());
            if (!VerificaNumeros(telefone))
            {
                MessageBox.Show("Telefone inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone.Focus();
            }
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            string celular = new string(txtCelular.Texts.Where(char.IsDigit).ToArray());
            if (!VerificaNumeros(celular))
            {
                MessageBox.Show("Celular inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCelular.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidaEmail(txtEmail.Texts))
            {
                MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
            if (!VerificaNumeros(txtRG.Texts))
            {
                MessageBox.Show("RG inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRG.Focus();
            }
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            if (!VerificaLetras(txtCargo.Texts))
            {
                MessageBox.Show("Cargo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCargo.Focus();
            }
        }

        private void txtPis_Leave(object sender, EventArgs e)
        {
            string pis = new string(txtPis.Texts.Where(char.IsDigit).ToArray());
            if (!ValidaPis(pis))
            {
                MessageBox.Show("PIS inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPis.Focus();
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalario.Texts))
            {
                try
                {
                    txtSalario.Texts = FormataPreco(txtSalario.Texts);

                    // Verifica se o valor é maior que zero
                    if (decimal.TryParse(txtSalario.Texts, out decimal preco) && preco > 0)
                    {
                        // Valor é válido e maior que zero
                    }
                    else
                    {
                        MessageBox.Show("O Salário deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSalario.Focus();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalario.Focus();
                }
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

        private void txtPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir apenas números, pontos, vírgulas e teclas de controle (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
