namespace Sistema_Vendas.Views
{
    partial class CadastroCondicaoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCondicaoPagamento));
            this.lblCondPag = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.lblPorcentagemTotal = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblCodFormaPag = new System.Windows.Forms.Label();
            this.lblFormaPag = new System.Windows.Forms.Label();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.numeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CódFormaPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCondPag = new Sistema_Vendas.GControls.GTextBox();
            this.txtJuros = new Sistema_Vendas.GControls.GTextBox();
            this.txtMulta = new Sistema_Vendas.GControls.GTextBox();
            this.txtDesconto = new Sistema_Vendas.GControls.GTextBox();
            this.txtParcela = new Sistema_Vendas.GControls.GTextBox();
            this.txtDias = new Sistema_Vendas.GControls.GTextBox();
            this.txtPorcentagem = new Sistema_Vendas.GControls.GTextBox();
            this.txtPorcentagemTotal = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodFormaPag = new Sistema_Vendas.GControls.GTextBox();
            this.txtFormaPag = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaFormaPag = new Sistema_Vendas.GButtons();
            this.btnAddParcela = new Sistema_Vendas.GButtons();
            this.btnExcluirParcela = new Sistema_Vendas.GButtons();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 444);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(101, 444);
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 18;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(505, 18);
            this.groupBox1.TabIndex = 16;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(498, 459);
            this.btnSalvar.TabIndex = 14;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(579, 459);
            this.btnSair.TabIndex = 15;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 460);
            this.txtDataCadastro.Texts = "04/07/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(104, 460);
            this.txtDataUltAlt.Texts = "04/07/2024";
            // 
            // lblCondPag
            // 
            this.lblCondPag.AutoSize = true;
            this.lblCondPag.Location = new System.Drawing.Point(13, 82);
            this.lblCondPag.Name = "lblCondPag";
            this.lblCondPag.Size = new System.Drawing.Size(131, 13);
            this.lblCondPag.TabIndex = 13;
            this.lblCondPag.Text = "Condição de Pagamento *";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(13, 143);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(65, 13);
            this.lblParcela.TabIndex = 15;
            this.lblParcela.Text = "Nº Parcela *";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(91, 143);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 13);
            this.lblDias.TabIndex = 17;
            this.lblDias.Text = "Dias *";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(185, 143);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(22, 13);
            this.lblPorcentagem.TabIndex = 19;
            this.lblPorcentagem.Text = "% *";
            // 
            // lblPorcentagemTotal
            // 
            this.lblPorcentagemTotal.AutoSize = true;
            this.lblPorcentagemTotal.Location = new System.Drawing.Point(233, 143);
            this.lblPorcentagemTotal.Name = "lblPorcentagemTotal";
            this.lblPorcentagemTotal.Size = new System.Drawing.Size(42, 13);
            this.lblPorcentagemTotal.TabIndex = 21;
            this.lblPorcentagemTotal.Text = "% Total";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(577, 82);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(64, 13);
            this.lblDesconto.TabIndex = 28;
            this.lblDesconto.Text = "% Desconto";
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(485, 82);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(44, 13);
            this.lblMulta.TabIndex = 26;
            this.lblMulta.Text = "% Multa";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(393, 82);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(43, 13);
            this.lblJuros.TabIndex = 24;
            this.lblJuros.Text = "% Juros";
            // 
            // lblCodFormaPag
            // 
            this.lblCodFormaPag.AutoSize = true;
            this.lblCodFormaPag.Location = new System.Drawing.Point(297, 143);
            this.lblCodFormaPag.Name = "lblCodFormaPag";
            this.lblCodFormaPag.Size = new System.Drawing.Size(47, 13);
            this.lblCodFormaPag.TabIndex = 30;
            this.lblCodFormaPag.Text = "Código *";
            // 
            // lblFormaPag
            // 
            this.lblFormaPag.AutoSize = true;
            this.lblFormaPag.Location = new System.Drawing.Point(393, 143);
            this.lblFormaPag.Name = "lblFormaPag";
            this.lblFormaPag.Size = new System.Drawing.Size(108, 13);
            this.lblFormaPag.TabIndex = 32;
            this.lblFormaPag.Text = "Forma de Pagamento";
            // 
            // dataGridViewParcelas
            // 
            this.dataGridViewParcelas.AllowUserToAddRows = false;
            this.dataGridViewParcelas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroParcela,
            this.dias,
            this.porcentagem,
            this.CódFormaPag,
            this.formaPagamento});
            this.dataGridViewParcelas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewParcelas.Location = new System.Drawing.Point(16, 211);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.ReadOnly = true;
            this.dataGridViewParcelas.Size = new System.Drawing.Size(638, 189);
            this.dataGridViewParcelas.TabIndex = 12;
            // 
            // numeroParcela
            // 
            this.numeroParcela.HeaderText = "Nº Parcela";
            this.numeroParcela.Name = "numeroParcela";
            this.numeroParcela.ReadOnly = true;
            // 
            // dias
            // 
            this.dias.HeaderText = "Dias";
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            // 
            // porcentagem
            // 
            this.porcentagem.HeaderText = "             %";
            this.porcentagem.Name = "porcentagem";
            this.porcentagem.ReadOnly = true;
            // 
            // CódFormaPag
            // 
            this.CódFormaPag.HeaderText = "Cód. Forma Pagamento";
            this.CódFormaPag.Name = "CódFormaPag";
            this.CódFormaPag.ReadOnly = true;
            this.CódFormaPag.Width = 80;
            // 
            // formaPagamento
            // 
            this.formaPagamento.HeaderText = "Forma de Pagamento";
            this.formaPagamento.Name = "formaPagamento";
            this.formaPagamento.ReadOnly = true;
            this.formaPagamento.Width = 215;
            // 
            // txtCondPag
            // 
            this.txtCondPag.BackColor = System.Drawing.SystemColors.Window;
            this.txtCondPag.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCondPag.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCondPag.BorderRadius = 5;
            this.txtCondPag.BorderSize = 1;
            this.txtCondPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondPag.DisabledBackColor = System.Drawing.Color.White;
            this.txtCondPag.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCondPag.DisabledForeColor = System.Drawing.Color.White;
            this.txtCondPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCondPag.Location = new System.Drawing.Point(16, 98);
            this.txtCondPag.MaxLength = 50;
            this.txtCondPag.Multiline = false;
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCondPag.PasswordChar = false;
            this.txtCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCondPag.PlaceholderText = "";
            this.txtCondPag.Size = new System.Drawing.Size(363, 28);
            this.txtCondPag.TabIndex = 1;
            this.txtCondPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCondPag.Texts = "";
            this.txtCondPag.UnderlinedStyle = false;
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
            this.txtJuros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtJuros.Location = new System.Drawing.Point(396, 98);
            this.txtJuros.MaxLength = 12;
            this.txtJuros.Multiline = false;
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtJuros.PasswordChar = false;
            this.txtJuros.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtJuros.PlaceholderText = "";
            this.txtJuros.Size = new System.Drawing.Size(74, 28);
            this.txtJuros.TabIndex = 2;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.Texts = "";
            this.txtJuros.UnderlinedStyle = false;
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
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
            this.txtMulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtMulta.Location = new System.Drawing.Point(488, 98);
            this.txtMulta.MaxLength = 12;
            this.txtMulta.Multiline = false;
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtMulta.PasswordChar = false;
            this.txtMulta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMulta.PlaceholderText = "";
            this.txtMulta.Size = new System.Drawing.Size(74, 28);
            this.txtMulta.TabIndex = 3;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMulta.Texts = "";
            this.txtMulta.UnderlinedStyle = false;
            this.txtMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMulta_KeyPress);
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
            this.txtDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDesconto.Location = new System.Drawing.Point(580, 98);
            this.txtDesconto.MaxLength = 12;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDesconto.PasswordChar = false;
            this.txtDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.PlaceholderText = "";
            this.txtDesconto.Size = new System.Drawing.Size(74, 28);
            this.txtDesconto.TabIndex = 4;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Texts = "";
            this.txtDesconto.UnderlinedStyle = false;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
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
            this.txtParcela.Location = new System.Drawing.Point(16, 159);
            this.txtParcela.MaxLength = 12;
            this.txtParcela.Multiline = false;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtParcela.PasswordChar = false;
            this.txtParcela.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtParcela.PlaceholderText = "";
            this.txtParcela.Size = new System.Drawing.Size(62, 28);
            this.txtParcela.TabIndex = 5;
            this.txtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcela.Texts = "";
            this.txtParcela.UnderlinedStyle = false;
            this.txtParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcela_KeyPress);
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.SystemColors.Window;
            this.txtDias.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDias.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDias.BorderRadius = 5;
            this.txtDias.BorderSize = 1;
            this.txtDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDias.DisabledBackColor = System.Drawing.Color.White;
            this.txtDias.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDias.DisabledForeColor = System.Drawing.Color.White;
            this.txtDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDias.Location = new System.Drawing.Point(94, 159);
            this.txtDias.MaxLength = 12;
            this.txtDias.Multiline = false;
            this.txtDias.Name = "txtDias";
            this.txtDias.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDias.PasswordChar = false;
            this.txtDias.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDias.PlaceholderText = "";
            this.txtDias.Size = new System.Drawing.Size(62, 28);
            this.txtDias.TabIndex = 6;
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDias.Texts = "";
            this.txtDias.UnderlinedStyle = false;
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.BackColor = System.Drawing.SystemColors.Window;
            this.txtPorcentagem.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagem.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtPorcentagem.BorderRadius = 5;
            this.txtPorcentagem.BorderSize = 1;
            this.txtPorcentagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcentagem.DisabledBackColor = System.Drawing.Color.White;
            this.txtPorcentagem.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPorcentagem.DisabledForeColor = System.Drawing.Color.White;
            this.txtPorcentagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPorcentagem.Location = new System.Drawing.Point(172, 159);
            this.txtPorcentagem.MaxLength = 12;
            this.txtPorcentagem.Multiline = false;
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPorcentagem.PasswordChar = false;
            this.txtPorcentagem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagem.PlaceholderText = "";
            this.txtPorcentagem.Size = new System.Drawing.Size(48, 28);
            this.txtPorcentagem.TabIndex = 7;
            this.txtPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentagem.Texts = "";
            this.txtPorcentagem.UnderlinedStyle = false;
            this.txtPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentagem_KeyPress);
            this.txtPorcentagem.Leave += new System.EventHandler(this.txtPorcentagem_Leave);
            // 
            // txtPorcentagemTotal
            // 
            this.txtPorcentagemTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtPorcentagemTotal.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagemTotal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtPorcentagemTotal.BorderRadius = 5;
            this.txtPorcentagemTotal.BorderSize = 1;
            this.txtPorcentagemTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcentagemTotal.DisabledBackColor = System.Drawing.Color.White;
            this.txtPorcentagemTotal.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPorcentagemTotal.DisabledForeColor = System.Drawing.Color.White;
            this.txtPorcentagemTotal.Enabled = false;
            this.txtPorcentagemTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPorcentagemTotal.Location = new System.Drawing.Point(236, 159);
            this.txtPorcentagemTotal.MaxLength = 12;
            this.txtPorcentagemTotal.Multiline = false;
            this.txtPorcentagemTotal.Name = "txtPorcentagemTotal";
            this.txtPorcentagemTotal.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPorcentagemTotal.PasswordChar = false;
            this.txtPorcentagemTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagemTotal.PlaceholderText = "";
            this.txtPorcentagemTotal.Size = new System.Drawing.Size(48, 28);
            this.txtPorcentagemTotal.TabIndex = 8;
            this.txtPorcentagemTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentagemTotal.Texts = "";
            this.txtPorcentagemTotal.UnderlinedStyle = false;
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
            this.txtCodFormaPag.Location = new System.Drawing.Point(300, 159);
            this.txtCodFormaPag.MaxLength = 12;
            this.txtCodFormaPag.Multiline = false;
            this.txtCodFormaPag.Name = "txtCodFormaPag";
            this.txtCodFormaPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodFormaPag.PasswordChar = false;
            this.txtCodFormaPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodFormaPag.PlaceholderText = "";
            this.txtCodFormaPag.Size = new System.Drawing.Size(48, 28);
            this.txtCodFormaPag.TabIndex = 9;
            this.txtCodFormaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFormaPag.Texts = "";
            this.txtCodFormaPag.UnderlinedStyle = false;
            this.txtCodFormaPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFormaPag_KeyPress);
            this.txtCodFormaPag.Leave += new System.EventHandler(this.txtCodFormaPag_Leave);
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
            this.txtFormaPag.Location = new System.Drawing.Point(396, 159);
            this.txtFormaPag.MaxLength = 12;
            this.txtFormaPag.Multiline = false;
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFormaPag.PasswordChar = false;
            this.txtFormaPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPag.PlaceholderText = "";
            this.txtFormaPag.Size = new System.Drawing.Size(183, 28);
            this.txtFormaPag.TabIndex = 44;
            this.txtFormaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFormaPag.Texts = "";
            this.txtFormaPag.UnderlinedStyle = false;
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
            this.btnConsultaFormaPag.Location = new System.Drawing.Point(354, 159);
            this.btnConsultaFormaPag.Name = "btnConsultaFormaPag";
            this.btnConsultaFormaPag.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaFormaPag.TabIndex = 10;
            this.btnConsultaFormaPag.TextColor = System.Drawing.Color.White;
            this.btnConsultaFormaPag.UseVisualStyleBackColor = false;
            this.btnConsultaFormaPag.Click += new System.EventHandler(this.btnConsultaFormaPag_Click);
            // 
            // btnAddParcela
            // 
            this.btnAddParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddParcela.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddParcela.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddParcela.BorderRadius = 5;
            this.btnAddParcela.BorderSize = 1;
            this.btnAddParcela.FlatAppearance.BorderSize = 0;
            this.btnAddParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParcela.ForeColor = System.Drawing.Color.White;
            this.btnAddParcela.Location = new System.Drawing.Point(585, 159);
            this.btnAddParcela.Name = "btnAddParcela";
            this.btnAddParcela.Size = new System.Drawing.Size(69, 28);
            this.btnAddParcela.TabIndex = 1;
            this.btnAddParcela.Text = "Adicionar";
            this.btnAddParcela.TextColor = System.Drawing.Color.White;
            this.btnAddParcela.UseVisualStyleBackColor = false;
            this.btnAddParcela.Click += new System.EventHandler(this.btnAddParcela_Click);
            // 
            // btnExcluirParcela
            // 
            this.btnExcluirParcela.BackColor = System.Drawing.Color.White;
            this.btnExcluirParcela.BackgroundColor = System.Drawing.Color.White;
            this.btnExcluirParcela.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirParcela.BorderRadius = 5;
            this.btnExcluirParcela.BorderSize = 1;
            this.btnExcluirParcela.FlatAppearance.BorderSize = 0;
            this.btnExcluirParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirParcela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirParcela.Location = new System.Drawing.Point(564, 406);
            this.btnExcluirParcela.Name = "btnExcluirParcela";
            this.btnExcluirParcela.Size = new System.Drawing.Size(90, 28);
            this.btnExcluirParcela.TabIndex = 13;
            this.btnExcluirParcela.Text = "Excluir Parcela";
            this.btnExcluirParcela.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirParcela.UseVisualStyleBackColor = false;
            this.btnExcluirParcela.Click += new System.EventHandler(this.btnExcluirParcela_Click);
            // 
            // CadastroCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 500);
            this.Controls.Add(this.btnExcluirParcela);
            this.Controls.Add(this.btnAddParcela);
            this.Controls.Add(this.btnConsultaFormaPag);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.txtCodFormaPag);
            this.Controls.Add(this.txtPorcentagemTotal);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtCondPag);
            this.Controls.Add(this.dataGridViewParcelas);
            this.Controls.Add(this.lblFormaPag);
            this.Controls.Add(this.lblCodFormaPag);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.lblPorcentagemTotal);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblCondPag);
            this.Name = "CadastroCondicaoPagamento";
            this.Text = "Cadastro de Condição de Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCondicaoPagamento_FormClosed);
            this.Load += new System.EventHandler(this.CadastroCondicaoPagamento_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblCondPag, 0);
            this.Controls.SetChildIndex(this.lblParcela, 0);
            this.Controls.SetChildIndex(this.lblDias, 0);
            this.Controls.SetChildIndex(this.lblPorcentagem, 0);
            this.Controls.SetChildIndex(this.lblPorcentagemTotal, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.lblCodFormaPag, 0);
            this.Controls.SetChildIndex(this.lblFormaPag, 0);
            this.Controls.SetChildIndex(this.dataGridViewParcelas, 0);
            this.Controls.SetChildIndex(this.txtCondPag, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.txtParcela, 0);
            this.Controls.SetChildIndex(this.txtDias, 0);
            this.Controls.SetChildIndex(this.txtPorcentagem, 0);
            this.Controls.SetChildIndex(this.txtPorcentagemTotal, 0);
            this.Controls.SetChildIndex(this.txtCodFormaPag, 0);
            this.Controls.SetChildIndex(this.txtFormaPag, 0);
            this.Controls.SetChildIndex(this.btnConsultaFormaPag, 0);
            this.Controls.SetChildIndex(this.btnAddParcela, 0);
            this.Controls.SetChildIndex(this.btnExcluirParcela, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCondPag;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblPorcentagemTotal;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Label lblCodFormaPag;
        private System.Windows.Forms.Label lblFormaPag;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódFormaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
        private GControls.GTextBox txtCondPag;
        private GControls.GTextBox txtJuros;
        private GControls.GTextBox txtMulta;
        private GControls.GTextBox txtDesconto;
        private GControls.GTextBox txtParcela;
        private GControls.GTextBox txtDias;
        private GControls.GTextBox txtPorcentagem;
        private GControls.GTextBox txtPorcentagemTotal;
        private GControls.GTextBox txtCodFormaPag;
        private GControls.GTextBox txtFormaPag;
        private GButtons btnConsultaFormaPag;
        protected GButtons btnAddParcela;
        public GButtons btnExcluirParcela;
    }
}
