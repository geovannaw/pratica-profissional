namespace Sistema_Vendas.Views
{
    partial class CadastroFuncionarios
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCodCidade = new System.Windows.Forms.Label();
            this.txtCodCidade = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.btnConsultaCidades = new System.Windows.Forms.Button();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDataDemissao = new System.Windows.Forms.Label();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.txtDataDemissao = new System.Windows.Forms.MaskedTextBox();
            this.txtDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.lblPis = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtPis = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(598, 551);
            this.btnSalvar.TabIndex = 93;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(679, 551);
            this.btnSair.TabIndex = 94;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 554);
            this.txtDataCadastro.Text = "11062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(104, 554);
            this.txtDataUltAlt.Text = "11062024";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 538);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(101, 538);
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 97;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(605, 17);
            this.groupBox1.TabIndex = 95;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(120, 150);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(91, 20);
            this.txtCelular.TabIndex = 60;
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(16, 150);
            this.txtTelefone.MaxLength = 50;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 59;
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(653, 78);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 67;
            this.lblSexo.Text = "Sexo *";
            // 
            // txtSexo
            // 
            this.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outros"});
            this.txtSexo.Location = new System.Drawing.Point(656, 94);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(98, 21);
            this.txtSexo.TabIndex = 58;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(233, 150);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 20);
            this.txtEmail.TabIndex = 61;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(230, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 66;
            this.lblEmail.Text = "Email *";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(117, 134);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 65;
            this.lblCelular.Text = "Celular *";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 134);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 64;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(16, 95);
            this.txtFuncionario.MaxLength = 70;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(304, 20);
            this.txtFuncionario.TabIndex = 56;
            this.txtFuncionario.Leave += new System.EventHandler(this.txtFuncionario_Leave);
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(340, 95);
            this.txtApelido.MaxLength = 50;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(297, 20);
            this.txtApelido.TabIndex = 57;
            this.txtApelido.Leave += new System.EventHandler(this.txtApelido_Leave);
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(337, 79);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(42, 13);
            this.lblApelido.TabIndex = 63;
            this.lblApelido.Text = "Apelido";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(13, 79);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(69, 13);
            this.lblFuncionario.TabIndex = 62;
            this.lblFuncionario.Text = "Funcionário *";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCodCidade);
            this.groupBox2.Controls.Add(this.txtCodCidade);
            this.groupBox2.Controls.Add(this.lblPais);
            this.groupBox2.Controls.Add(this.txtPais);
            this.groupBox2.Controls.Add(this.lblUF);
            this.groupBox2.Controls.Add(this.txtUF);
            this.groupBox2.Controls.Add(this.btnConsultaCidades);
            this.groupBox2.Controls.Add(this.lblCidade);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.lblBairro);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.lblComplemento);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.lblEndereco);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(this.lblCEP);
            this.groupBox2.Controls.Add(this.txtCEP);
            this.groupBox2.Location = new System.Drawing.Point(16, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 137);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // lblCodCidade
            // 
            this.lblCodCidade.AutoSize = true;
            this.lblCodCidade.Location = new System.Drawing.Point(202, 78);
            this.lblCodCidade.Name = "lblCodCidade";
            this.lblCodCidade.Size = new System.Drawing.Size(72, 13);
            this.lblCodCidade.TabIndex = 57;
            this.lblCodCidade.Text = "Cód. Cidade *";
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.Location = new System.Drawing.Point(205, 94);
            this.txtCodCidade.Name = "txtCodCidade";
            this.txtCodCidade.Size = new System.Drawing.Size(62, 20);
            this.txtCodCidade.TabIndex = 16;
            this.txtCodCidade.Leave += new System.EventHandler(this.txtCodCidade_Leave);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(588, 78);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 25;
            this.lblPais.Text = "País";
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(591, 94);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(141, 20);
            this.txtPais.TabIndex = 20;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(515, 78);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 23;
            this.lblUF.Text = "UF";
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(518, 94);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(61, 20);
            this.txtUF.TabIndex = 19;
            // 
            // btnConsultaCidades
            // 
            this.btnConsultaCidades.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaCidades.Location = new System.Drawing.Point(277, 92);
            this.btnConsultaCidades.Name = "btnConsultaCidades";
            this.btnConsultaCidades.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaCidades.TabIndex = 17;
            this.btnConsultaCidades.UseVisualStyleBackColor = true;
            this.btnConsultaCidades.Click += new System.EventHandler(this.btnConsultaCidades_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(321, 78);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 13);
            this.lblCidade.TabIndex = 20;
            this.lblCidade.Text = "Cidade *";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(324, 94);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(180, 20);
            this.txtCidade.TabIndex = 18;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(9, 78);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(41, 13);
            this.lblBairro.TabIndex = 18;
            this.lblBairro.Text = "Bairro *";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 94);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(180, 20);
            this.txtBairro.TabIndex = 15;
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(463, 25);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 7;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(378, 25);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Número *";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(381, 41);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(67, 20);
            this.txtNumero.TabIndex = 13;
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(466, 41);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(266, 20);
            this.txtComplemento.TabIndex = 14;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(87, 22);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(60, 13);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço *";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(87, 41);
            this.txtEndereco.MaxLength = 150;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(277, 20);
            this.txtEndereco.TabIndex = 12;
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(9, 25);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 13);
            this.lblCEP.TabIndex = 1;
            this.lblCEP.Text = "CEP *";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(12, 41);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(59, 20);
            this.txtCEP.TabIndex = 11;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(142, 365);
            this.txtRG.MaxLength = 12;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(93, 20);
            this.txtRG.TabIndex = 70;
            this.txtRG.Leave += new System.EventHandler(this.txtRG_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(16, 365);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(107, 20);
            this.txtCPF.TabIndex = 69;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(250, 349);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(61, 13);
            this.lblDataNasc.TabIndex = 74;
            this.lblDataNasc.Text = "Data Nasc.";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(253, 365);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(67, 20);
            this.txtDataNasc.TabIndex = 71;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(139, 349);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 73;
            this.lblRG.Text = "RG";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(13, 349);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 72;
            this.lblCPF.Text = "CPF *";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDataDemissao);
            this.groupBox3.Controls.Add(this.lblDataAdmissao);
            this.groupBox3.Controls.Add(this.txtDataDemissao);
            this.groupBox3.Controls.Add(this.txtDataAdmissao);
            this.groupBox3.Controls.Add(this.lblPis);
            this.groupBox3.Controls.Add(this.lblSalario);
            this.groupBox3.Controls.Add(this.lblCargo);
            this.groupBox3.Controls.Add(this.txtPis);
            this.groupBox3.Controls.Add(this.txtSalario);
            this.groupBox3.Controls.Add(this.txtCargo);
            this.groupBox3.Location = new System.Drawing.Point(16, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(738, 80);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // lblDataDemissao
            // 
            this.lblDataDemissao.AutoSize = true;
            this.lblDataDemissao.Location = new System.Drawing.Point(642, 23);
            this.lblDataDemissao.Name = "lblDataDemissao";
            this.lblDataDemissao.Size = new System.Drawing.Size(53, 13);
            this.lblDataDemissao.TabIndex = 94;
            this.lblDataDemissao.Text = "Demissão";
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Location = new System.Drawing.Point(553, 23);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(59, 13);
            this.lblDataAdmissao.TabIndex = 93;
            this.lblDataAdmissao.Text = "Admissão *";
            // 
            // txtDataDemissao
            // 
            this.txtDataDemissao.Location = new System.Drawing.Point(645, 39);
            this.txtDataDemissao.Mask = "00/00/0000";
            this.txtDataDemissao.Name = "txtDataDemissao";
            this.txtDataDemissao.Size = new System.Drawing.Size(67, 20);
            this.txtDataDemissao.TabIndex = 92;
            this.txtDataDemissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataDemissao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataAdmissao
            // 
            this.txtDataAdmissao.Location = new System.Drawing.Point(556, 39);
            this.txtDataAdmissao.Mask = "00/00/0000";
            this.txtDataAdmissao.Name = "txtDataAdmissao";
            this.txtDataAdmissao.Size = new System.Drawing.Size(67, 20);
            this.txtDataAdmissao.TabIndex = 91;
            this.txtDataAdmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // lblPis
            // 
            this.lblPis.AutoSize = true;
            this.lblPis.Location = new System.Drawing.Point(427, 23);
            this.lblPis.Name = "lblPis";
            this.lblPis.Size = new System.Drawing.Size(31, 13);
            this.lblPis.TabIndex = 90;
            this.lblPis.Text = "PIS *";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(305, 23);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(46, 13);
            this.lblSalario.TabIndex = 89;
            this.lblSalario.Text = "Salário *";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(25, 23);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(42, 13);
            this.lblCargo.TabIndex = 88;
            this.lblCargo.Text = "Cargo *";
            // 
            // txtPis
            // 
            this.txtPis.Location = new System.Drawing.Point(430, 39);
            this.txtPis.MaxLength = 14;
            this.txtPis.Name = "txtPis";
            this.txtPis.Size = new System.Drawing.Size(100, 20);
            this.txtPis.TabIndex = 87;
            this.txtPis.Leave += new System.EventHandler(this.txtPis_Leave);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(308, 39);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 86;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(28, 39);
            this.txtCargo.MaxLength = 50;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(258, 20);
            this.txtCargo.TabIndex = 85;
            this.txtCargo.Leave += new System.EventHandler(this.txtCargo_Leave);
            // 
            // CadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(774, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblFuncionario);
            this.Name = "CadastroFuncionarios";
            this.Text = "Cadastro de Funcionários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFuncionarios_FormClosed);
            this.Load += new System.EventHandler(this.CadastroFuncionarios_Load);
            this.Controls.SetChildIndex(this.lblFuncionario, 0);
            this.Controls.SetChildIndex(this.lblApelido, 0);
            this.Controls.SetChildIndex(this.txtApelido, 0);
            this.Controls.SetChildIndex(this.txtFuncionario, 0);
            this.Controls.SetChildIndex(this.lblTelefone, 0);
            this.Controls.SetChildIndex(this.lblCelular, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtSexo, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.lblCPF, 0);
            this.Controls.SetChildIndex(this.lblRG, 0);
            this.Controls.SetChildIndex(this.txtDataNasc, 0);
            this.Controls.SetChildIndex(this.lblDataNasc, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.Controls.SetChildIndex(this.txtRG, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtCelular;
        protected System.Windows.Forms.TextBox txtTelefone;
        protected System.Windows.Forms.Label lblSexo;
        protected System.Windows.Forms.ComboBox txtSexo;
        protected System.Windows.Forms.TextBox txtEmail;
        protected System.Windows.Forms.Label lblEmail;
        protected System.Windows.Forms.Label lblCelular;
        protected System.Windows.Forms.Label lblTelefone;
        protected System.Windows.Forms.TextBox txtFuncionario;
        protected System.Windows.Forms.TextBox txtApelido;
        protected System.Windows.Forms.Label lblApelido;
        protected System.Windows.Forms.Label lblFuncionario;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Label lblCodCidade;
        protected System.Windows.Forms.TextBox txtCodCidade;
        protected System.Windows.Forms.Label lblPais;
        protected System.Windows.Forms.TextBox txtPais;
        protected System.Windows.Forms.Label lblUF;
        protected System.Windows.Forms.TextBox txtUF;
        protected System.Windows.Forms.Button btnConsultaCidades;
        protected System.Windows.Forms.Label lblCidade;
        protected System.Windows.Forms.TextBox txtCidade;
        protected System.Windows.Forms.Label lblBairro;
        protected System.Windows.Forms.TextBox txtBairro;
        protected System.Windows.Forms.Label lblComplemento;
        protected System.Windows.Forms.Label lblNumero;
        protected System.Windows.Forms.TextBox txtNumero;
        protected System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblEndereco;
        protected System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblCEP;
        protected System.Windows.Forms.MaskedTextBox txtCEP;
        protected System.Windows.Forms.TextBox txtRG;
        protected System.Windows.Forms.MaskedTextBox txtCPF;
        protected System.Windows.Forms.Label lblDataNasc;
        protected System.Windows.Forms.MaskedTextBox txtDataNasc;
        protected System.Windows.Forms.Label lblRG;
        protected System.Windows.Forms.Label lblCPF;
        protected System.Windows.Forms.MaskedTextBox txtDataDemissao;
        protected System.Windows.Forms.MaskedTextBox txtDataAdmissao;
        protected System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.Label lblDataDemissao;
        protected System.Windows.Forms.Label lblDataAdmissao;
        protected System.Windows.Forms.Label lblPis;
        protected System.Windows.Forms.Label lblSalario;
        protected System.Windows.Forms.Label lblCargo;
        protected System.Windows.Forms.TextBox txtPis;
        protected System.Windows.Forms.TextBox txtSalario;
        protected System.Windows.Forms.TextBox txtCargo;
    }
}
