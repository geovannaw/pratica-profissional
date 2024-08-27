namespace Sistema_Vendas.Views
{
    partial class CadastroContasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroContasPagar));
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblNroNota = new System.Windows.Forms.Label();
            this.txtModelo = new Sistema_Vendas.GControls.GTextBox();
            this.txtFornecedor = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodFornecedor = new Sistema_Vendas.GControls.GTextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodFornecedor = new System.Windows.Forms.Label();
            this.txtSerie = new Sistema_Vendas.GControls.GTextBox();
            this.txtNroNota = new Sistema_Vendas.GControls.GTextBox();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.txtDataEmissao = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.txtFormaPag = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodFormaPag = new Sistema_Vendas.GControls.GTextBox();
            this.lblFormaPag = new System.Windows.Forms.Label();
            this.lblCodFormaPag = new System.Windows.Forms.Label();
            this.txtParcela = new Sistema_Vendas.GControls.GTextBox();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.txtValorParcela = new Sistema_Vendas.GControls.GTextBox();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.txtDataVencimento = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.txtDataPagamento = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.txtDesconto = new Sistema_Vendas.GControls.GTextBox();
            this.txtMulta = new Sistema_Vendas.GControls.GTextBox();
            this.txtJuros = new Sistema_Vendas.GControls.GTextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.txtValorPago = new Sistema_Vendas.GControls.GTextBox();
            this.btnPagar = new Sistema_Vendas.GButtons();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.txtDataCancelamento = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new Sistema_Vendas.GControls.GTextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new Sistema_Vendas.GControls.GTextBox();
            this.btnCancelar = new Sistema_Vendas.GButtons();
            this.btnConsultaFormaPag = new Sistema_Vendas.GButtons();
            this.btnConsultaFornecedor = new Sistema_Vendas.GButtons();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(9, 501);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(106, 501);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(541, 31);
            this.groupBox1.Size = new System.Drawing.Size(16, 49);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(547, 46);
            this.txtCodigo.Size = new System.Drawing.Size(37, 28);
            this.txtCodigo.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(365, 516);
            this.btnSalvar.TabIndex = 20;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(446, 516);
            this.btnSair.TabIndex = 21;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(12, 517);
            this.txtDataCadastro.Texts = "13/08/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(109, 517);
            this.txtDataUltAlt.Texts = "13/08/2024";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(544, 30);
            this.lblCodigo.Visible = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(292, 25);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 13);
            this.lblModelo.TabIndex = 75;
            this.lblModelo.Text = "Modelo *";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(390, 24);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(38, 13);
            this.lblSerie.TabIndex = 74;
            this.lblSerie.Text = "Série *";
            // 
            // lblNroNota
            // 
            this.lblNroNota.AutoSize = true;
            this.lblNroNota.Location = new System.Drawing.Point(137, 25);
            this.lblNroNota.Name = "lblNroNota";
            this.lblNroNota.Size = new System.Drawing.Size(51, 13);
            this.lblNroNota.TabIndex = 73;
            this.lblNroNota.Text = "Número *";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.SystemColors.Window;
            this.txtModelo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtModelo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtModelo.BorderRadius = 5;
            this.txtModelo.BorderSize = 1;
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.DisabledBackColor = System.Drawing.Color.White;
            this.txtModelo.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtModelo.DisabledForeColor = System.Drawing.Color.White;
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtModelo.Location = new System.Drawing.Point(295, 41);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Multiline = false;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtModelo.PasswordChar = false;
            this.txtModelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.Size = new System.Drawing.Size(75, 28);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModelo.Texts = "";
            this.txtModelo.UnderlinedStyle = false;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtFornecedor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFornecedor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtFornecedor.BorderRadius = 5;
            this.txtFornecedor.BorderSize = 1;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.DisabledBackColor = System.Drawing.Color.White;
            this.txtFornecedor.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtFornecedor.DisabledForeColor = System.Drawing.Color.White;
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFornecedor.Location = new System.Drawing.Point(168, 108);
            this.txtFornecedor.MaxLength = 32767;
            this.txtFornecedor.Multiline = false;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFornecedor.PasswordChar = false;
            this.txtFornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFornecedor.PlaceholderText = "";
            this.txtFornecedor.Size = new System.Drawing.Size(345, 28);
            this.txtFornecedor.TabIndex = 72;
            this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFornecedor.Texts = "";
            this.txtFornecedor.UnderlinedStyle = false;
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodFornecedor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodFornecedor.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodFornecedor.BorderRadius = 5;
            this.txtCodFornecedor.BorderSize = 1;
            this.txtCodFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFornecedor.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodFornecedor.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodFornecedor.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodFornecedor.Location = new System.Drawing.Point(23, 108);
            this.txtCodFornecedor.MaxLength = 5;
            this.txtCodFornecedor.Multiline = false;
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodFornecedor.PasswordChar = false;
            this.txtCodFornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodFornecedor.PlaceholderText = "";
            this.txtCodFornecedor.Size = new System.Drawing.Size(92, 28);
            this.txtCodFornecedor.TabIndex = 5;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFornecedor.Texts = "";
            this.txtCodFornecedor.UnderlinedStyle = false;
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(165, 92);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 71;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblCodFornecedor
            // 
            this.lblCodFornecedor.AutoSize = true;
            this.lblCodFornecedor.Location = new System.Drawing.Point(20, 92);
            this.lblCodFornecedor.Name = "lblCodFornecedor";
            this.lblCodFornecedor.Size = new System.Drawing.Size(93, 13);
            this.lblCodFornecedor.TabIndex = 70;
            this.lblCodFornecedor.Text = "Cód. Fornecedor *";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerie.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSerie.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtSerie.BorderRadius = 5;
            this.txtSerie.BorderSize = 1;
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.DisabledBackColor = System.Drawing.Color.White;
            this.txtSerie.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtSerie.DisabledForeColor = System.Drawing.Color.White;
            this.txtSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSerie.Location = new System.Drawing.Point(393, 40);
            this.txtSerie.MaxLength = 32767;
            this.txtSerie.Multiline = false;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSerie.PasswordChar = false;
            this.txtSerie.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSerie.PlaceholderText = "";
            this.txtSerie.Size = new System.Drawing.Size(75, 28);
            this.txtSerie.TabIndex = 4;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSerie.Texts = "";
            this.txtSerie.UnderlinedStyle = false;
            // 
            // txtNroNota
            // 
            this.txtNroNota.BackColor = System.Drawing.SystemColors.Window;
            this.txtNroNota.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNroNota.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtNroNota.BorderRadius = 5;
            this.txtNroNota.BorderSize = 1;
            this.txtNroNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroNota.DisabledBackColor = System.Drawing.Color.White;
            this.txtNroNota.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtNroNota.DisabledForeColor = System.Drawing.Color.White;
            this.txtNroNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtNroNota.Location = new System.Drawing.Point(140, 41);
            this.txtNroNota.MaxLength = 32767;
            this.txtNroNota.Multiline = false;
            this.txtNroNota.Name = "txtNroNota";
            this.txtNroNota.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtNroNota.PasswordChar = false;
            this.txtNroNota.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNroNota.PlaceholderText = "";
            this.txtNroNota.Size = new System.Drawing.Size(131, 28);
            this.txtNroNota.TabIndex = 2;
            this.txtNroNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroNota.Texts = "";
            this.txtNroNota.UnderlinedStyle = false;
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(20, 25);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(79, 13);
            this.lblDataEmissao.TabIndex = 77;
            this.lblDataEmissao.Text = "Data Emissão *";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEmissao.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataEmissao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataEmissao.BorderRadius = 5;
            this.txtDataEmissao.BorderSize = 1;
            this.txtDataEmissao.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataEmissao.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataEmissao.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataEmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataEmissao.Location = new System.Drawing.Point(23, 41);
            this.txtDataEmissao.Mask = "00/00/0000";
            this.txtDataEmissao.MaxLength = 32767;
            this.txtDataEmissao.Multiline = false;
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataEmissao.PasswordChar = false;
            this.txtDataEmissao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataEmissao.PlaceholderText = "";
            this.txtDataEmissao.Size = new System.Drawing.Size(92, 27);
            this.txtDataEmissao.TabIndex = 1;
            this.txtDataEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataEmissao.Texts = "  /  /";
            this.txtDataEmissao.UnderlinedStyle = false;
            this.txtDataEmissao.Leave += new System.EventHandler(this.txtDataEmissao_Leave);
            // 
            // txtFormaPag
            // 
            this.txtFormaPag.BackColor = System.Drawing.SystemColors.Window;
            this.txtFormaPag.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPag.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtFormaPag.BorderRadius = 5;
            this.txtFormaPag.BorderSize = 1;
            this.txtFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPag.DisabledBackColor = System.Drawing.Color.White;
            this.txtFormaPag.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtFormaPag.DisabledForeColor = System.Drawing.Color.White;
            this.txtFormaPag.Enabled = false;
            this.txtFormaPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFormaPag.Location = new System.Drawing.Point(168, 178);
            this.txtFormaPag.MaxLength = 12;
            this.txtFormaPag.Multiline = false;
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFormaPag.PasswordChar = false;
            this.txtFormaPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPag.PlaceholderText = "";
            this.txtFormaPag.Size = new System.Drawing.Size(345, 28);
            this.txtFormaPag.TabIndex = 82;
            this.txtFormaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFormaPag.Texts = "";
            this.txtFormaPag.UnderlinedStyle = false;
            // 
            // txtCodFormaPag
            // 
            this.txtCodFormaPag.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodFormaPag.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodFormaPag.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodFormaPag.BorderRadius = 5;
            this.txtCodFormaPag.BorderSize = 1;
            this.txtCodFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFormaPag.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodFormaPag.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodFormaPag.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodFormaPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodFormaPag.Location = new System.Drawing.Point(23, 178);
            this.txtCodFormaPag.MaxLength = 12;
            this.txtCodFormaPag.Multiline = false;
            this.txtCodFormaPag.Name = "txtCodFormaPag";
            this.txtCodFormaPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodFormaPag.PasswordChar = false;
            this.txtCodFormaPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodFormaPag.PlaceholderText = "";
            this.txtCodFormaPag.Size = new System.Drawing.Size(92, 28);
            this.txtCodFormaPag.TabIndex = 7;
            this.txtCodFormaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFormaPag.Texts = "";
            this.txtCodFormaPag.UnderlinedStyle = false;
            this.txtCodFormaPag.Leave += new System.EventHandler(this.txtCodFormaPag_Leave);
            // 
            // lblFormaPag
            // 
            this.lblFormaPag.AutoSize = true;
            this.lblFormaPag.Location = new System.Drawing.Point(165, 162);
            this.lblFormaPag.Name = "lblFormaPag";
            this.lblFormaPag.Size = new System.Drawing.Size(108, 13);
            this.lblFormaPag.TabIndex = 81;
            this.lblFormaPag.Text = "Forma de Pagamento";
            // 
            // lblCodFormaPag
            // 
            this.lblCodFormaPag.AutoSize = true;
            this.lblCodFormaPag.Location = new System.Drawing.Point(20, 162);
            this.lblCodFormaPag.Name = "lblCodFormaPag";
            this.lblCodFormaPag.Size = new System.Drawing.Size(101, 13);
            this.lblCodFormaPag.TabIndex = 80;
            this.lblCodFormaPag.Text = "Código Forma Pag.*";
            // 
            // txtParcela
            // 
            this.txtParcela.BackColor = System.Drawing.SystemColors.Window;
            this.txtParcela.BorderColor = System.Drawing.Color.DarkGray;
            this.txtParcela.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtParcela.BorderRadius = 5;
            this.txtParcela.BorderSize = 1;
            this.txtParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParcela.DisabledBackColor = System.Drawing.Color.White;
            this.txtParcela.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtParcela.DisabledForeColor = System.Drawing.Color.White;
            this.txtParcela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtParcela.Location = new System.Drawing.Point(23, 247);
            this.txtParcela.MaxLength = 12;
            this.txtParcela.Multiline = false;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtParcela.PasswordChar = false;
            this.txtParcela.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtParcela.PlaceholderText = "";
            this.txtParcela.Size = new System.Drawing.Size(92, 28);
            this.txtParcela.TabIndex = 9;
            this.txtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcela.Texts = "";
            this.txtParcela.UnderlinedStyle = false;
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(20, 231);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(65, 13);
            this.lblParcela.TabIndex = 84;
            this.lblParcela.Text = "Nº Parcela *";
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Location = new System.Drawing.Point(149, 232);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(77, 13);
            this.lblValorParcela.TabIndex = 102;
            this.lblValorParcela.Text = "Valor Parcela *";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorParcela.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorParcela.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtValorParcela.BorderRadius = 5;
            this.txtValorParcela.BorderSize = 1;
            this.txtValorParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorParcela.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorParcela.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorParcela.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorParcela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorParcela.Location = new System.Drawing.Point(152, 248);
            this.txtValorParcela.MaxLength = 32767;
            this.txtValorParcela.Multiline = false;
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorParcela.PasswordChar = false;
            this.txtValorParcela.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorParcela.PlaceholderText = "";
            this.txtValorParcela.Size = new System.Drawing.Size(92, 28);
            this.txtValorParcela.TabIndex = 10;
            this.txtValorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorParcela.Texts = "0";
            this.txtValorParcela.UnderlinedStyle = false;
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(275, 232);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(96, 13);
            this.lblDataVencimento.TabIndex = 104;
            this.lblDataVencimento.Text = "Data Vencimento *";
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataVencimento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataVencimento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataVencimento.BorderRadius = 5;
            this.txtDataVencimento.BorderSize = 1;
            this.txtDataVencimento.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataVencimento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataVencimento.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataVencimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataVencimento.Location = new System.Drawing.Point(278, 248);
            this.txtDataVencimento.Mask = "00/00/0000";
            this.txtDataVencimento.MaxLength = 32767;
            this.txtDataVencimento.Multiline = false;
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataVencimento.PasswordChar = false;
            this.txtDataVencimento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataVencimento.PlaceholderText = "";
            this.txtDataVencimento.Size = new System.Drawing.Size(92, 27);
            this.txtDataVencimento.TabIndex = 11;
            this.txtDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataVencimento.Texts = "  /  /";
            this.txtDataVencimento.UnderlinedStyle = false;
            this.txtDataVencimento.Leave += new System.EventHandler(this.txtDataVencimento_Leave);
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Location = new System.Drawing.Point(20, 366);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(87, 13);
            this.lblDataPagamento.TabIndex = 106;
            this.lblDataPagamento.Text = "Data Pagamento";
            // 
            // txtDataPagamento
            // 
            this.txtDataPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataPagamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataPagamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataPagamento.BorderRadius = 5;
            this.txtDataPagamento.BorderSize = 1;
            this.txtDataPagamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataPagamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataPagamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataPagamento.Enabled = false;
            this.txtDataPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataPagamento.Location = new System.Drawing.Point(23, 382);
            this.txtDataPagamento.Mask = "00/00/0000";
            this.txtDataPagamento.MaxLength = 32767;
            this.txtDataPagamento.Multiline = false;
            this.txtDataPagamento.Name = "txtDataPagamento";
            this.txtDataPagamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataPagamento.PasswordChar = false;
            this.txtDataPagamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataPagamento.PlaceholderText = "";
            this.txtDataPagamento.Size = new System.Drawing.Size(92, 27);
            this.txtDataPagamento.TabIndex = 15;
            this.txtDataPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataPagamento.Texts = "  /  /";
            this.txtDataPagamento.UnderlinedStyle = false;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesconto.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDesconto.BorderRadius = 5;
            this.txtDesconto.BorderSize = 1;
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.DisabledBackColor = System.Drawing.Color.White;
            this.txtDesconto.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDesconto.DisabledForeColor = System.Drawing.Color.White;
            this.txtDesconto.Enabled = false;
            this.txtDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDesconto.Location = new System.Drawing.Point(278, 315);
            this.txtDesconto.MaxLength = 12;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDesconto.PasswordChar = false;
            this.txtDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.PlaceholderText = "";
            this.txtDesconto.Size = new System.Drawing.Size(92, 28);
            this.txtDesconto.TabIndex = 14;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Texts = "";
            this.txtDesconto.UnderlinedStyle = false;
            // 
            // txtMulta
            // 
            this.txtMulta.BackColor = System.Drawing.SystemColors.Window;
            this.txtMulta.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMulta.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtMulta.BorderRadius = 5;
            this.txtMulta.BorderSize = 1;
            this.txtMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMulta.DisabledBackColor = System.Drawing.Color.White;
            this.txtMulta.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtMulta.DisabledForeColor = System.Drawing.Color.White;
            this.txtMulta.Enabled = false;
            this.txtMulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtMulta.Location = new System.Drawing.Point(152, 315);
            this.txtMulta.MaxLength = 12;
            this.txtMulta.Multiline = false;
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtMulta.PasswordChar = false;
            this.txtMulta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMulta.PlaceholderText = "";
            this.txtMulta.Size = new System.Drawing.Size(92, 28);
            this.txtMulta.TabIndex = 13;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMulta.Texts = "";
            this.txtMulta.UnderlinedStyle = false;
            // 
            // txtJuros
            // 
            this.txtJuros.BackColor = System.Drawing.SystemColors.Window;
            this.txtJuros.BorderColor = System.Drawing.Color.DarkGray;
            this.txtJuros.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtJuros.BorderRadius = 5;
            this.txtJuros.BorderSize = 1;
            this.txtJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJuros.DisabledBackColor = System.Drawing.Color.White;
            this.txtJuros.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtJuros.DisabledForeColor = System.Drawing.Color.White;
            this.txtJuros.Enabled = false;
            this.txtJuros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtJuros.Location = new System.Drawing.Point(23, 314);
            this.txtJuros.MaxLength = 12;
            this.txtJuros.Multiline = false;
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtJuros.PasswordChar = false;
            this.txtJuros.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtJuros.PlaceholderText = "";
            this.txtJuros.Size = new System.Drawing.Size(92, 28);
            this.txtJuros.TabIndex = 12;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.Texts = "";
            this.txtJuros.UnderlinedStyle = false;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(275, 299);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(70, 13);
            this.lblDesconto.TabIndex = 112;
            this.lblDesconto.Text = "R$ Desconto";
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(149, 299);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(50, 13);
            this.lblMulta.TabIndex = 111;
            this.lblMulta.Text = "R$ Multa";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(20, 298);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(49, 13);
            this.lblJuros.TabIndex = 110;
            this.lblJuros.Text = "R$ Juros";
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Location = new System.Drawing.Point(149, 367);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(59, 13);
            this.lblValorPago.TabIndex = 114;
            this.lblValorPago.Text = "Valor Pago";
            // 
            // txtValorPago
            // 
            this.txtValorPago.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorPago.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorPago.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtValorPago.BorderRadius = 5;
            this.txtValorPago.BorderSize = 1;
            this.txtValorPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorPago.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorPago.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorPago.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorPago.Location = new System.Drawing.Point(152, 383);
            this.txtValorPago.MaxLength = 32767;
            this.txtValorPago.Multiline = false;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorPago.PasswordChar = false;
            this.txtValorPago.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorPago.PlaceholderText = "";
            this.txtValorPago.Size = new System.Drawing.Size(92, 28);
            this.txtValorPago.TabIndex = 16;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPago.Texts = "0";
            this.txtValorPago.UnderlinedStyle = false;
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btnPagar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btnPagar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(154)))), ((int)(((byte)(0)))));
            this.btnPagar.BorderRadius = 5;
            this.btnPagar.BorderSize = 1;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(284, 516);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 28);
            this.btnPagar.TabIndex = 19;
            this.btnPagar.Text = "&Pagar";
            this.btnPagar.TextColor = System.Drawing.Color.White;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Visible = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataCancelamento.Location = new System.Drawing.Point(275, 368);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(101, 13);
            this.lblDataCancelamento.TabIndex = 131;
            this.lblDataCancelamento.Text = "Data Cancelamento";
            this.lblDataCancelamento.Visible = false;
            // 
            // txtDataCancelamento
            // 
            this.txtDataCancelamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataCancelamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDataCancelamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataCancelamento.BorderRadius = 5;
            this.txtDataCancelamento.BorderSize = 1;
            this.txtDataCancelamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataCancelamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataCancelamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataCancelamento.Enabled = false;
            this.txtDataCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataCancelamento.Location = new System.Drawing.Point(278, 384);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.MaxLength = 32767;
            this.txtDataCancelamento.Multiline = false;
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCancelamento.PasswordChar = false;
            this.txtDataCancelamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.PlaceholderText = "";
            this.txtDataCancelamento.Size = new System.Drawing.Size(93, 27);
            this.txtDataCancelamento.TabIndex = 130;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.Texts = "  /  /";
            this.txtDataCancelamento.UnderlinedStyle = false;
            this.txtDataCancelamento.Visible = false;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(20, 430);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 133;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacao.BorderColor = System.Drawing.Color.DarkGray;
            this.txtObservacao.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtObservacao.BorderRadius = 5;
            this.txtObservacao.BorderSize = 1;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.DisabledBackColor = System.Drawing.Color.White;
            this.txtObservacao.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtObservacao.DisabledForeColor = System.Drawing.Color.White;
            this.txtObservacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtObservacao.Location = new System.Drawing.Point(23, 446);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Multiline = false;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservacao.PlaceholderText = "";
            this.txtObservacao.Size = new System.Drawing.Size(490, 28);
            this.txtObservacao.TabIndex = 18;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacao.Texts = "";
            this.txtObservacao.UnderlinedStyle = false;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(403, 369);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagar.TabIndex = 135;
            this.lblTotalPagar.Text = "Total a Pagar ";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPagar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTotalPagar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtTotalPagar.BorderRadius = 5;
            this.txtTotalPagar.BorderSize = 1;
            this.txtTotalPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalPagar.DisabledBackColor = System.Drawing.Color.White;
            this.txtTotalPagar.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTotalPagar.DisabledForeColor = System.Drawing.Color.White;
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTotalPagar.Location = new System.Drawing.Point(406, 383);
            this.txtTotalPagar.MaxLength = 32767;
            this.txtTotalPagar.Multiline = false;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotalPagar.PasswordChar = false;
            this.txtTotalPagar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalPagar.PlaceholderText = "";
            this.txtTotalPagar.Size = new System.Drawing.Size(107, 28);
            this.txtTotalPagar.TabIndex = 17;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPagar.Texts = "";
            this.txtTotalPagar.UnderlinedStyle = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.White;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(203, 516);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 136;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultaFormaPag
            // 
            this.btnConsultaFormaPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaFormaPag.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaFormaPag.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaFormaPag.BorderRadius = 5;
            this.btnConsultaFormaPag.BorderSize = 1;
            this.btnConsultaFormaPag.FlatAppearance.BorderSize = 0;
            this.btnConsultaFormaPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaFormaPag.ForeColor = System.Drawing.Color.White;
            this.btnConsultaFormaPag.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaFormaPag.Image")));
            this.btnConsultaFormaPag.Location = new System.Drawing.Point(124, 178);
            this.btnConsultaFormaPag.Name = "btnConsultaFormaPag";
            this.btnConsultaFormaPag.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaFormaPag.TabIndex = 8;
            this.btnConsultaFormaPag.TextColor = System.Drawing.Color.White;
            this.btnConsultaFormaPag.UseVisualStyleBackColor = false;
            this.btnConsultaFormaPag.Click += new System.EventHandler(this.btnConsultaFormaPag_Click);
            // 
            // btnConsultaFornecedor
            // 
            this.btnConsultaFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaFornecedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaFornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaFornecedor.BorderRadius = 5;
            this.btnConsultaFornecedor.BorderSize = 1;
            this.btnConsultaFornecedor.FlatAppearance.BorderSize = 0;
            this.btnConsultaFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnConsultaFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaFornecedor.Image")));
            this.btnConsultaFornecedor.Location = new System.Drawing.Point(124, 108);
            this.btnConsultaFornecedor.Name = "btnConsultaFornecedor";
            this.btnConsultaFornecedor.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaFornecedor.TabIndex = 6;
            this.btnConsultaFornecedor.TextColor = System.Drawing.Color.White;
            this.btnConsultaFornecedor.UseVisualStyleBackColor = false;
            this.btnConsultaFornecedor.Click += new System.EventHandler(this.btnConsultaFornecedor_Click);
            // 
            // CadastroContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(533, 556);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblValorPago);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.lblDataPagamento);
            this.Controls.Add(this.txtDataPagamento);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.btnConsultaFormaPag);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.txtCodFormaPag);
            this.Controls.Add(this.lblFormaPag);
            this.Controls.Add(this.lblCodFormaPag);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblNroNota);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.btnConsultaFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCodFornecedor);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtNroNota);
            this.Name = "CadastroContasPagar";
            this.Text = "Cadastro Contas a Pagar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroContasPagar_FormClosed);
            this.Load += new System.EventHandler(this.CadastroContasPagar_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.txtNroNota, 0);
            this.Controls.SetChildIndex(this.txtSerie, 0);
            this.Controls.SetChildIndex(this.lblCodFornecedor, 0);
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.btnConsultaFornecedor, 0);
            this.Controls.SetChildIndex(this.txtCodFornecedor, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.lblNroNota, 0);
            this.Controls.SetChildIndex(this.lblSerie, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.txtDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblCodFormaPag, 0);
            this.Controls.SetChildIndex(this.lblFormaPag, 0);
            this.Controls.SetChildIndex(this.txtCodFormaPag, 0);
            this.Controls.SetChildIndex(this.txtFormaPag, 0);
            this.Controls.SetChildIndex(this.btnConsultaFormaPag, 0);
            this.Controls.SetChildIndex(this.lblParcela, 0);
            this.Controls.SetChildIndex(this.txtParcela, 0);
            this.Controls.SetChildIndex(this.txtValorParcela, 0);
            this.Controls.SetChildIndex(this.lblValorParcela, 0);
            this.Controls.SetChildIndex(this.txtDataVencimento, 0);
            this.Controls.SetChildIndex(this.lblDataVencimento, 0);
            this.Controls.SetChildIndex(this.txtDataPagamento, 0);
            this.Controls.SetChildIndex(this.lblDataPagamento, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.txtValorPago, 0);
            this.Controls.SetChildIndex(this.lblValorPago, 0);
            this.Controls.SetChildIndex(this.btnPagar, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.txtTotalPagar, 0);
            this.Controls.SetChildIndex(this.lblTotalPagar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblNroNota;
        private GControls.GTextBox txtModelo;
        private GControls.GTextBox txtFornecedor;
        private GControls.GTextBox txtCodFornecedor;
        private GButtons btnConsultaFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblCodFornecedor;
        private GControls.GTextBox txtSerie;
        public GControls.GTextBox txtNroNota;
        private System.Windows.Forms.Label lblDataEmissao;
        private GControls.GMaskedTextBox txtDataEmissao;
        private GButtons btnConsultaFormaPag;
        private GControls.GTextBox txtFormaPag;
        private GControls.GTextBox txtCodFormaPag;
        private System.Windows.Forms.Label lblFormaPag;
        private System.Windows.Forms.Label lblCodFormaPag;
        private GControls.GTextBox txtParcela;
        private System.Windows.Forms.Label lblParcela;
        protected System.Windows.Forms.Label lblValorParcela;
        private GControls.GTextBox txtValorParcela;
        private System.Windows.Forms.Label lblDataVencimento;
        private GControls.GMaskedTextBox txtDataVencimento;
        private System.Windows.Forms.Label lblDataPagamento;
        private GControls.GMaskedTextBox txtDataPagamento;
        private GControls.GTextBox txtDesconto;
        private GControls.GTextBox txtMulta;
        private GControls.GTextBox txtJuros;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblJuros;
        protected System.Windows.Forms.Label lblValorPago;
        private GControls.GTextBox txtValorPago;
        protected GButtons btnPagar;
        public System.Windows.Forms.Label lblDataCancelamento;
        public GControls.GMaskedTextBox txtDataCancelamento;
        protected System.Windows.Forms.Label lblObservacao;
        private GControls.GTextBox txtObservacao;
        protected System.Windows.Forms.Label lblTotalPagar;
        private GControls.GTextBox txtTotalPagar;
        protected GButtons btnCancelar;
    }
}
