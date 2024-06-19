namespace Sistema_Vendas.Views
{
    partial class CadastroPessoasPai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIE_RG = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCliente_razao_social = new System.Windows.Forms.TextBox();
            this.txtApelido_nome_fantasia = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblApelido_nome_fantasia = new System.Windows.Forms.Label();
            this.lblCliente_razao_social = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.lblDataUltAlt = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtDataUltAlt = new System.Windows.Forms.MaskedTextBox();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtIE_RG = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCondPag = new System.Windows.Forms.Label();
            this.txtCondPag = new System.Windows.Forms.TextBox();
            this.txtCodCondPag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultaCondPag = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIE_RG
            // 
            this.lblIE_RG.AutoSize = true;
            this.lblIE_RG.Location = new System.Drawing.Point(150, 360);
            this.lblIE_RG.Name = "lblIE_RG";
            this.lblIE_RG.Size = new System.Drawing.Size(23, 13);
            this.lblIE_RG.TabIndex = 40;
            this.lblIE_RG.Text = "RG";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(27, 150);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(24, 360);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCPF_CNPJ.TabIndex = 37;
            this.lblCPF_CNPJ.Text = "CPF *";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodCidade);
            this.groupBox1.Controls.Add(this.txtCodCidade);
            this.groupBox1.Controls.Add(this.lblPais);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Controls.Add(this.lblUF);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.btnConsultaCidades);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.lblComplemento);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.lblCEP);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Location = new System.Drawing.Point(27, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 137);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
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
            this.txtPais.Size = new System.Drawing.Size(147, 20);
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
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(321, 78);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 20;
            this.lblCidade.Text = "Cidade";
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
            this.txtComplemento.Size = new System.Drawing.Size(272, 20);
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
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(347, 134);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 34;
            this.lblCelular.Text = "Celular *";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(243, 134);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 31;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtCliente_razao_social
            // 
            this.txtCliente_razao_social.Location = new System.Drawing.Point(27, 95);
            this.txtCliente_razao_social.MaxLength = 70;
            this.txtCliente_razao_social.Name = "txtCliente_razao_social";
            this.txtCliente_razao_social.Size = new System.Drawing.Size(304, 20);
            this.txtCliente_razao_social.TabIndex = 4;
            this.txtCliente_razao_social.Leave += new System.EventHandler(this.txtCliente_razao_social_Leave);
            // 
            // txtApelido_nome_fantasia
            // 
            this.txtApelido_nome_fantasia.Location = new System.Drawing.Point(351, 95);
            this.txtApelido_nome_fantasia.MaxLength = 70;
            this.txtApelido_nome_fantasia.Name = "txtApelido_nome_fantasia";
            this.txtApelido_nome_fantasia.Size = new System.Drawing.Size(297, 20);
            this.txtApelido_nome_fantasia.TabIndex = 5;
            this.txtApelido_nome_fantasia.Leave += new System.EventHandler(this.txtApelido_nome_fantasia_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(27, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 20);
            this.txtCodigo.TabIndex = 28;
            this.txtCodigo.Text = "0";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblApelido_nome_fantasia
            // 
            this.lblApelido_nome_fantasia.AutoSize = true;
            this.lblApelido_nome_fantasia.Location = new System.Drawing.Point(348, 79);
            this.lblApelido_nome_fantasia.Name = "lblApelido_nome_fantasia";
            this.lblApelido_nome_fantasia.Size = new System.Drawing.Size(42, 13);
            this.lblApelido_nome_fantasia.TabIndex = 27;
            this.lblApelido_nome_fantasia.Text = "Apelido";
            // 
            // lblCliente_razao_social
            // 
            this.lblCliente_razao_social.AutoSize = true;
            this.lblCliente_razao_social.Location = new System.Drawing.Point(24, 79);
            this.lblCliente_razao_social.Name = "lblCliente_razao_social";
            this.lblCliente_razao_social.Size = new System.Drawing.Size(46, 13);
            this.lblCliente_razao_social.TabIndex = 26;
            this.lblCliente_razao_social.Text = "Cliente *";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbInativo);
            this.groupBox3.Controls.Add(this.rbAtivo);
            this.groupBox3.Location = new System.Drawing.Point(614, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 49);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(82, 19);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 32;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbInativo_CheckedChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(18, 19);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 31;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.AutoSize = true;
            this.lblDataUltAlt.Location = new System.Drawing.Point(112, 434);
            this.lblDataUltAlt.Name = "lblDataUltAlt";
            this.lblDataUltAlt.Size = new System.Drawing.Size(67, 13);
            this.lblDataUltAlt.TabIndex = 48;
            this.lblDataUltAlt.Text = "Data Últ. Alt.";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(24, 434);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDataCadastro.TabIndex = 47;
            this.lblDataCadastro.Text = "Data Cadastro";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Enabled = false;
            this.txtDataUltAlt.Location = new System.Drawing.Point(115, 450);
            this.txtDataUltAlt.Mask = "00/00/0000";
            this.txtDataUltAlt.Name = "txtDataUltAlt";
            this.txtDataUltAlt.Size = new System.Drawing.Size(67, 20);
            this.txtDataUltAlt.TabIndex = 46;
            this.txtDataUltAlt.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Location = new System.Drawing.Point(27, 450);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(67, 20);
            this.txtDataCadastro.TabIndex = 45;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(696, 447);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(615, 447);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(261, 360);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(61, 13);
            this.lblDataNasc.TabIndex = 53;
            this.lblDataNasc.Text = "Data Nasc.";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(264, 376);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(67, 20);
            this.txtDataNasc.TabIndex = 23;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtSexo
            // 
            this.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outros"});
            this.txtSexo.Location = new System.Drawing.Point(667, 94);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(98, 21);
            this.txtSexo.TabIndex = 6;
            this.txtSexo.Leave += new System.EventHandler(this.txtSexo_Leave);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(664, 78);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 55;
            this.lblSexo.Text = "Sexo *";
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(27, 376);
            this.txtCPF_CNPJ.Mask = "000.000.000-00";
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(107, 20);
            this.txtCPF_CNPJ.TabIndex = 21;
            this.txtCPF_CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF_CNPJ.Leave += new System.EventHandler(this.txtCPF_CNPJ_Leave);
            // 
            // txtIE_RG
            // 
            this.txtIE_RG.Location = new System.Drawing.Point(153, 376);
            this.txtIE_RG.MaxLength = 14;
            this.txtIE_RG.Name = "txtIE_RG";
            this.txtIE_RG.Size = new System.Drawing.Size(93, 20);
            this.txtIE_RG.TabIndex = 22;
            this.txtIE_RG.Leave += new System.EventHandler(this.txtIE_RG_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(246, 150);
            this.txtTelefone.MaxLength = 50;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(350, 150);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(91, 20);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(16, 20);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(54, 17);
            this.rbFisica.TabIndex = 2;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Location = new System.Drawing.Point(80, 20);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbJuridica.TabIndex = 3;
            this.rbJuridica.TabStop = true;
            this.rbJuridica.Text = "Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbJuridica);
            this.groupBox2.Controls.Add(this.rbFisica);
            this.groupBox2.Location = new System.Drawing.Point(147, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pessoa";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(458, 150);
            this.txtContato.MaxLength = 70;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(190, 20);
            this.txtContato.TabIndex = 56;
            this.txtContato.Visible = false;
            this.txtContato.Leave += new System.EventHandler(this.txtContato_Leave);
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(455, 134);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(96, 13);
            this.lblContato.TabIndex = 57;
            this.lblContato.Text = "Nome do contato *";
            this.lblContato.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCondPag);
            this.groupBox4.Controls.Add(this.txtCondPag);
            this.groupBox4.Controls.Add(this.txtCodCondPag);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnConsultaCondPag);
            this.groupBox4.Location = new System.Drawing.Point(351, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 75);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pagamento";
            // 
            // lblCondPag
            // 
            this.lblCondPag.AutoSize = true;
            this.lblCondPag.Location = new System.Drawing.Point(17, 23);
            this.lblCondPag.Name = "lblCondPag";
            this.lblCondPag.Size = new System.Drawing.Size(44, 13);
            this.lblCondPag.TabIndex = 63;
            this.lblCondPag.Text = "Código*";
            // 
            // txtCondPag
            // 
            this.txtCondPag.Enabled = false;
            this.txtCondPag.Location = new System.Drawing.Point(133, 39);
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Size = new System.Drawing.Size(266, 20);
            this.txtCondPag.TabIndex = 27;
            // 
            // txtCodCondPag
            // 
            this.txtCodCondPag.Location = new System.Drawing.Point(20, 39);
            this.txtCodCondPag.Name = "txtCodCondPag";
            this.txtCodCondPag.Size = new System.Drawing.Size(62, 20);
            this.txtCodCondPag.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Condição de Pagamento";
            // 
            // btnConsultaCondPag
            // 
            this.btnConsultaCondPag.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaCondPag.Location = new System.Drawing.Point(88, 37);
            this.btnConsultaCondPag.Name = "btnConsultaCondPag";
            this.btnConsultaCondPag.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaCondPag.TabIndex = 26;
            this.btnConsultaCondPag.UseVisualStyleBackColor = true;
            // 
            // CadastroPessoasPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtIE_RG);
            this.Controls.Add(this.txtCPF_CNPJ);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblDataUltAlt);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.txtDataUltAlt);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblIE_RG);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCPF_CNPJ);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtCliente_razao_social);
            this.Controls.Add(this.txtApelido_nome_fantasia);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblApelido_nome_fantasia);
            this.Controls.Add(this.lblCliente_razao_social);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroPessoasPai";
            this.Text = "CadastroPessoasPai";
            this.Load += new System.EventHandler(this.CadastroPessoasPai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCEP;
        protected System.Windows.Forms.Label lblDataUltAlt;
        protected System.Windows.Forms.Label lblDataCadastro;
        protected System.Windows.Forms.MaskedTextBox txtDataUltAlt;
        protected System.Windows.Forms.MaskedTextBox txtDataCadastro;
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.TextBox txtCodigo;
        protected System.Windows.Forms.Label lblIE_RG;
        protected System.Windows.Forms.TextBox txtEmail;
        protected System.Windows.Forms.Label lblCPF_CNPJ;
        protected System.Windows.Forms.Label lblEmail;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Label lblCelular;
        protected System.Windows.Forms.Label lblTelefone;
        protected System.Windows.Forms.TextBox txtCliente_razao_social;
        protected System.Windows.Forms.TextBox txtApelido_nome_fantasia;
        protected System.Windows.Forms.Label lblApelido_nome_fantasia;
        protected System.Windows.Forms.Label lblCliente_razao_social;
        protected System.Windows.Forms.Label lblCodigo;
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
        protected System.Windows.Forms.TextBox txtEndereco;
        protected System.Windows.Forms.MaskedTextBox txtCEP;
        protected System.Windows.Forms.Label lblDataNasc;
        protected System.Windows.Forms.MaskedTextBox txtDataNasc;
        protected System.Windows.Forms.Label lblSexo;
        protected System.Windows.Forms.ComboBox txtSexo;
        protected System.Windows.Forms.Label lblCodCidade;
        protected System.Windows.Forms.TextBox txtCodCidade;
        protected System.Windows.Forms.MaskedTextBox txtCPF_CNPJ;
        protected System.Windows.Forms.TextBox txtIE_RG;
        protected System.Windows.Forms.TextBox txtTelefone;
        protected System.Windows.Forms.TextBox txtCelular;
        public System.Windows.Forms.RadioButton rbInativo;
        public System.Windows.Forms.RadioButton rbAtivo;
        public System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.RadioButton rbFisica;
        protected System.Windows.Forms.RadioButton rbJuridica;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.TextBox txtContato;
        protected System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.Label lblCondPag;
        protected System.Windows.Forms.TextBox txtCondPag;
        protected System.Windows.Forms.TextBox txtCodCondPag;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Button btnConsultaCondPag;
    }
}