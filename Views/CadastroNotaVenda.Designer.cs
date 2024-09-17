namespace Sistema_Vendas.Views
{
    partial class CadastroNotaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroNotaVenda));
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblNroNota = new System.Windows.Forms.Label();
            this.txtModelo = new Sistema_Vendas.GControls.GTextBox();
            this.txtCliente = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodCliente = new Sistema_Vendas.GControls.GTextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtSerie = new Sistema_Vendas.GControls.GTextBox();
            this.txtNroNota = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaCliente = new Sistema_Vendas.GButtons();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.txtDataEmissao = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.txtDataCancelamento = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblCancelada = new System.Windows.Forms.Label();
            this.btnAddCondPag = new Sistema_Vendas.GButtons();
            this.btnExcluirProduto = new Sistema_Vendas.GButtons();
            this.btnConsultaCondPag = new Sistema_Vendas.GButtons();
            this.txtCondPag = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodCondPag = new Sistema_Vendas.GControls.GTextBox();
            this.lblCondPag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.txtTotalProdutos = new Sistema_Vendas.GControls.GTextBox();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrecoProd = new System.Windows.Forms.Label();
            this.txtPrecoProd = new Sistema_Vendas.GControls.GTextBox();
            this.txtUN = new Sistema_Vendas.GControls.GTextBox();
            this.lblUN = new System.Windows.Forms.Label();
            this.lblQtdeProduto = new System.Windows.Forms.Label();
            this.txtQtdeProduto = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaProduto = new Sistema_Vendas.GButtons();
            this.txtProduto = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodProduto = new Sistema_Vendas.GControls.GTextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnAddProdutos = new Sistema_Vendas.GButtons();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new Sistema_Vendas.GControls.GTextBox();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.numeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPorcentagemDesconto = new Sistema_Vendas.GControls.GTextBox();
            this.txtTotalPagar = new Sistema_Vendas.GControls.GTextBox();
            this.txtDesconto = new Sistema_Vendas.GControls.GTextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.btnCancelar = new Sistema_Vendas.GButtons();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(9, 758);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(106, 758);
            // 
            // rbInativo
            // 
            this.rbInativo.Visible = false;
            // 
            // rbAtivo
            // 
            this.rbAtivo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(723, 444);
            this.groupBox1.Size = new System.Drawing.Size(10, 49);
            this.groupBox1.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(713, 459);
            this.txtCodigo.Size = new System.Drawing.Size(30, 28);
            this.txtCodigo.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(597, 774);
            this.btnSalvar.TabIndex = 16;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(683, 774);
            this.btnSair.TabIndex = 18;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(12, 774);
            this.txtDataCadastro.Texts = "27/08/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(109, 774);
            this.txtDataUltAlt.Texts = "27/08/2024";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(693, 468);
            this.lblCodigo.Visible = false;
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(209, 773);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(206, 757);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(225, 17);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 13);
            this.lblModelo.TabIndex = 75;
            this.lblModelo.Text = "Modelo *";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(322, 17);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(38, 13);
            this.lblSerie.TabIndex = 74;
            this.lblSerie.Text = "Série *";
            // 
            // lblNroNota
            // 
            this.lblNroNota.AutoSize = true;
            this.lblNroNota.Location = new System.Drawing.Point(118, 17);
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
            this.txtModelo.Location = new System.Drawing.Point(228, 33);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Multiline = false;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtModelo.PasswordChar = false;
            this.txtModelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.Size = new System.Drawing.Size(83, 28);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModelo.Texts = "";
            this.txtModelo.UnderlinedStyle = false;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtCliente.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCliente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCliente.BorderRadius = 5;
            this.txtCliente.BorderSize = 1;
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.DisabledBackColor = System.Drawing.Color.White;
            this.txtCliente.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCliente.DisabledForeColor = System.Drawing.Color.White;
            this.txtCliente.Enabled = false;
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCliente.Location = new System.Drawing.Point(160, 102);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCliente.PasswordChar = false;
            this.txtCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCliente.PlaceholderText = "";
            this.txtCliente.Size = new System.Drawing.Size(248, 28);
            this.txtCliente.TabIndex = 72;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCliente.Texts = "";
            this.txtCliente.UnderlinedStyle = false;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCliente.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodCliente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodCliente.BorderRadius = 5;
            this.txtCodCliente.BorderSize = 1;
            this.txtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCliente.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodCliente.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodCliente.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodCliente.Location = new System.Drawing.Point(12, 102);
            this.txtCodCliente.MaxLength = 5;
            this.txtCodCliente.Multiline = false;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodCliente.PasswordChar = false;
            this.txtCodCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodCliente.PlaceholderText = "";
            this.txtCodCliente.Size = new System.Drawing.Size(92, 28);
            this.txtCodCliente.TabIndex = 5;
            this.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCliente.Texts = "";
            this.txtCodCliente.UnderlinedStyle = false;
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(157, 86);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 71;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(9, 86);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(71, 13);
            this.lblCodCliente.TabIndex = 70;
            this.lblCodCliente.Text = "Cód. Cliente *";
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
            this.txtSerie.Location = new System.Drawing.Point(325, 33);
            this.txtSerie.MaxLength = 32767;
            this.txtSerie.Multiline = false;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSerie.PasswordChar = false;
            this.txtSerie.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSerie.PlaceholderText = "";
            this.txtSerie.Size = new System.Drawing.Size(83, 28);
            this.txtSerie.TabIndex = 4;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSerie.Texts = "";
            this.txtSerie.UnderlinedStyle = false;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
            this.txtSerie.Leave += new System.EventHandler(this.txtSerie_Leave);
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
            this.txtNroNota.Enabled = false;
            this.txtNroNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtNroNota.Location = new System.Drawing.Point(121, 33);
            this.txtNroNota.MaxLength = 32767;
            this.txtNroNota.Multiline = false;
            this.txtNroNota.Name = "txtNroNota";
            this.txtNroNota.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtNroNota.PasswordChar = false;
            this.txtNroNota.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNroNota.PlaceholderText = "";
            this.txtNroNota.Size = new System.Drawing.Size(92, 28);
            this.txtNroNota.TabIndex = 2;
            this.txtNroNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroNota.Texts = "";
            this.txtNroNota.UnderlinedStyle = false;
            this.txtNroNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroNota_KeyPress);
            this.txtNroNota.Leave += new System.EventHandler(this.txtNroNota_Leave);
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaCliente.BorderRadius = 5;
            this.btnConsultaCliente.BorderSize = 1;
            this.btnConsultaCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCliente.ForeColor = System.Drawing.Color.White;
            this.btnConsultaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaCliente.Image")));
            this.btnConsultaCliente.Location = new System.Drawing.Point(112, 101);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaCliente.TabIndex = 6;
            this.btnConsultaCliente.TextColor = System.Drawing.Color.White;
            this.btnConsultaCliente.UseVisualStyleBackColor = false;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(9, 17);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(79, 13);
            this.lblDataEmissao.TabIndex = 78;
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
            this.txtDataEmissao.Location = new System.Drawing.Point(12, 33);
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
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataCancelamento.Location = new System.Drawing.Point(617, 56);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(101, 13);
            this.lblDataCancelamento.TabIndex = 130;
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
            this.txtDataCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataCancelamento.Location = new System.Drawing.Point(620, 72);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.MaxLength = 32767;
            this.txtDataCancelamento.Multiline = false;
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCancelamento.PasswordChar = false;
            this.txtDataCancelamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.PlaceholderText = "";
            this.txtDataCancelamento.Size = new System.Drawing.Size(98, 27);
            this.txtDataCancelamento.TabIndex = 128;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.Texts = "  /  /";
            this.txtDataCancelamento.UnderlinedStyle = false;
            this.txtDataCancelamento.Visible = false;
            // 
            // lblCancelada
            // 
            this.lblCancelada.AutoSize = true;
            this.lblCancelada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCancelada.Location = new System.Drawing.Point(484, 81);
            this.lblCancelada.Name = "lblCancelada";
            this.lblCancelada.Size = new System.Drawing.Size(112, 13);
            this.lblCancelada.TabIndex = 129;
            this.lblCancelada.Text = "*NOTA CANCELADA*";
            this.lblCancelada.Visible = false;
            // 
            // btnAddCondPag
            // 
            this.btnAddCondPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddCondPag.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddCondPag.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddCondPag.BorderRadius = 5;
            this.btnAddCondPag.BorderSize = 1;
            this.btnAddCondPag.FlatAppearance.BorderSize = 0;
            this.btnAddCondPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCondPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCondPag.ForeColor = System.Drawing.Color.White;
            this.btnAddCondPag.Location = new System.Drawing.Point(409, 459);
            this.btnAddCondPag.Name = "btnAddCondPag";
            this.btnAddCondPag.Size = new System.Drawing.Size(75, 28);
            this.btnAddCondPag.TabIndex = 14;
            this.btnAddCondPag.Text = "&Adicionar";
            this.btnAddCondPag.TextColor = System.Drawing.Color.White;
            this.btnAddCondPag.UseVisualStyleBackColor = false;
            this.btnAddCondPag.Click += new System.EventHandler(this.btnAddCondPag_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.White;
            this.btnExcluirProduto.BackgroundColor = System.Drawing.Color.White;
            this.btnExcluirProduto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirProduto.BorderRadius = 5;
            this.btnExcluirProduto.BorderSize = 1;
            this.btnExcluirProduto.FlatAppearance.BorderSize = 0;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirProduto.Location = new System.Drawing.Point(12, 385);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(86, 28);
            this.btnExcluirProduto.TabIndex = 161;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnConsultaCondPag
            // 
            this.btnConsultaCondPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaCondPag.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaCondPag.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaCondPag.BorderRadius = 5;
            this.btnConsultaCondPag.BorderSize = 1;
            this.btnConsultaCondPag.Enabled = false;
            this.btnConsultaCondPag.FlatAppearance.BorderSize = 0;
            this.btnConsultaCondPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCondPag.ForeColor = System.Drawing.Color.White;
            this.btnConsultaCondPag.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaCondPag.Image")));
            this.btnConsultaCondPag.Location = new System.Drawing.Point(112, 458);
            this.btnConsultaCondPag.Name = "btnConsultaCondPag";
            this.btnConsultaCondPag.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaCondPag.TabIndex = 13;
            this.btnConsultaCondPag.TextColor = System.Drawing.Color.White;
            this.btnConsultaCondPag.UseVisualStyleBackColor = false;
            this.btnConsultaCondPag.Click += new System.EventHandler(this.btnConsultaCondPag_Click);
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
            this.txtCondPag.Enabled = false;
            this.txtCondPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCondPag.Location = new System.Drawing.Point(157, 459);
            this.txtCondPag.MaxLength = 14;
            this.txtCondPag.Multiline = false;
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCondPag.PasswordChar = false;
            this.txtCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCondPag.PlaceholderText = "";
            this.txtCondPag.Size = new System.Drawing.Size(236, 28);
            this.txtCondPag.TabIndex = 160;
            this.txtCondPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCondPag.Texts = "";
            this.txtCondPag.UnderlinedStyle = false;
            // 
            // txtCodCondPag
            // 
            this.txtCodCondPag.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCondPag.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodCondPag.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodCondPag.BorderRadius = 5;
            this.txtCodCondPag.BorderSize = 1;
            this.txtCodCondPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCondPag.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodCondPag.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodCondPag.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodCondPag.Enabled = false;
            this.txtCodCondPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodCondPag.Location = new System.Drawing.Point(12, 459);
            this.txtCodCondPag.MaxLength = 14;
            this.txtCodCondPag.Multiline = false;
            this.txtCodCondPag.Name = "txtCodCondPag";
            this.txtCodCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodCondPag.PasswordChar = false;
            this.txtCodCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodCondPag.PlaceholderText = "";
            this.txtCodCondPag.Size = new System.Drawing.Size(92, 28);
            this.txtCodCondPag.TabIndex = 12;
            this.txtCodCondPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCondPag.Texts = "";
            this.txtCodCondPag.UnderlinedStyle = false;
            this.txtCodCondPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCondPag_KeyPress);
            this.txtCodCondPag.Leave += new System.EventHandler(this.txtCodCondPag_Leave);
            // 
            // lblCondPag
            // 
            this.lblCondPag.AutoSize = true;
            this.lblCondPag.Location = new System.Drawing.Point(9, 443);
            this.lblCondPag.Name = "lblCondPag";
            this.lblCondPag.Size = new System.Drawing.Size(44, 13);
            this.lblCondPag.TabIndex = 159;
            this.lblCondPag.Text = "Código*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 158;
            this.label3.Text = "Condição de Pagamento";
            // 
            // lblTotalProdutos
            // 
            this.lblTotalProdutos.AutoSize = true;
            this.lblTotalProdutos.Location = new System.Drawing.Point(404, 385);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(79, 13);
            this.lblTotalProdutos.TabIndex = 155;
            this.lblTotalProdutos.Text = "Total Produtos ";
            // 
            // txtTotalProdutos
            // 
            this.txtTotalProdutos.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalProdutos.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTotalProdutos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtTotalProdutos.BorderRadius = 5;
            this.txtTotalProdutos.BorderSize = 1;
            this.txtTotalProdutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalProdutos.DisabledBackColor = System.Drawing.Color.White;
            this.txtTotalProdutos.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTotalProdutos.DisabledForeColor = System.Drawing.Color.White;
            this.txtTotalProdutos.Enabled = false;
            this.txtTotalProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTotalProdutos.Location = new System.Drawing.Point(408, 400);
            this.txtTotalProdutos.MaxLength = 32767;
            this.txtTotalProdutos.Multiline = false;
            this.txtTotalProdutos.Name = "txtTotalProdutos";
            this.txtTotalProdutos.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotalProdutos.PasswordChar = false;
            this.txtTotalProdutos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalProdutos.PlaceholderText = "";
            this.txtTotalProdutos.Size = new System.Drawing.Size(85, 28);
            this.txtTotalProdutos.TabIndex = 154;
            this.txtTotalProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalProdutos.Texts = "";
            this.txtTotalProdutos.UnderlinedStyle = false;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.AllowUserToResizeColumns = false;
            this.dataGridViewProdutos.AllowUserToResizeRows = false;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.produto,
            this.UNProd,
            this.quantidadeProduto,
            this.PrecoUN,
            this.precoTotal});
            this.dataGridViewProdutos.Enabled = false;
            this.dataGridViewProdutos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(746, 141);
            this.dataGridViewProdutos.TabIndex = 150;
            this.dataGridViewProdutos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewProdutos_RowsAdded);
            this.dataGridViewProdutos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewProdutos_RowsRemoved);
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "Código";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Width = 80;
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // UNProd
            // 
            this.UNProd.HeaderText = "Unidade";
            this.UNProd.Name = "UNProd";
            this.UNProd.ReadOnly = true;
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.HeaderText = "Quantidade";
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.ReadOnly = true;
            this.quantidadeProduto.Width = 80;
            // 
            // PrecoUN
            // 
            this.PrecoUN.HeaderText = "Preço UN";
            this.PrecoUN.Name = "PrecoUN";
            this.PrecoUN.ReadOnly = true;
            // 
            // precoTotal
            // 
            this.precoTotal.HeaderText = "Preço Total";
            this.precoTotal.Name = "precoTotal";
            this.precoTotal.ReadOnly = true;
            // 
            // lblPrecoProd
            // 
            this.lblPrecoProd.AutoSize = true;
            this.lblPrecoProd.Location = new System.Drawing.Point(509, 160);
            this.lblPrecoProd.Name = "lblPrecoProd";
            this.lblPrecoProd.Size = new System.Drawing.Size(69, 13);
            this.lblPrecoProd.TabIndex = 149;
            this.lblPrecoProd.Text = "Preço Venda";
            // 
            // txtPrecoProd
            // 
            this.txtPrecoProd.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecoProd.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrecoProd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtPrecoProd.BorderRadius = 5;
            this.txtPrecoProd.BorderSize = 1;
            this.txtPrecoProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoProd.DisabledBackColor = System.Drawing.Color.White;
            this.txtPrecoProd.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPrecoProd.DisabledForeColor = System.Drawing.Color.White;
            this.txtPrecoProd.Enabled = false;
            this.txtPrecoProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPrecoProd.Location = new System.Drawing.Point(512, 176);
            this.txtPrecoProd.MaxLength = 32767;
            this.txtPrecoProd.Multiline = false;
            this.txtPrecoProd.Name = "txtPrecoProd";
            this.txtPrecoProd.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPrecoProd.PasswordChar = false;
            this.txtPrecoProd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecoProd.PlaceholderText = "";
            this.txtPrecoProd.Size = new System.Drawing.Size(66, 28);
            this.txtPrecoProd.TabIndex = 133;
            this.txtPrecoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoProd.Texts = "";
            this.txtPrecoProd.UnderlinedStyle = false;
            // 
            // txtUN
            // 
            this.txtUN.BackColor = System.Drawing.SystemColors.Window;
            this.txtUN.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUN.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtUN.BorderRadius = 5;
            this.txtUN.BorderSize = 1;
            this.txtUN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUN.DisabledBackColor = System.Drawing.Color.White;
            this.txtUN.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtUN.DisabledForeColor = System.Drawing.Color.White;
            this.txtUN.Enabled = false;
            this.txtUN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtUN.Location = new System.Drawing.Point(425, 176);
            this.txtUN.MaxLength = 32767;
            this.txtUN.Multiline = false;
            this.txtUN.Name = "txtUN";
            this.txtUN.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUN.PasswordChar = false;
            this.txtUN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUN.PlaceholderText = "";
            this.txtUN.Size = new System.Drawing.Size(68, 28);
            this.txtUN.TabIndex = 148;
            this.txtUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUN.Texts = "";
            this.txtUN.UnderlinedStyle = false;
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Location = new System.Drawing.Point(422, 160);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(47, 13);
            this.lblUN.TabIndex = 147;
            this.lblUN.Text = "Unidade";
            // 
            // lblQtdeProduto
            // 
            this.lblQtdeProduto.AutoSize = true;
            this.lblQtdeProduto.Location = new System.Drawing.Point(595, 160);
            this.lblQtdeProduto.Name = "lblQtdeProduto";
            this.lblQtdeProduto.Size = new System.Drawing.Size(69, 13);
            this.lblQtdeProduto.TabIndex = 146;
            this.lblQtdeProduto.Text = "Quantidade *";
            // 
            // txtQtdeProduto
            // 
            this.txtQtdeProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtQtdeProduto.BorderColor = System.Drawing.Color.DarkGray;
            this.txtQtdeProduto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtQtdeProduto.BorderRadius = 5;
            this.txtQtdeProduto.BorderSize = 1;
            this.txtQtdeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeProduto.DisabledBackColor = System.Drawing.Color.White;
            this.txtQtdeProduto.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtQtdeProduto.DisabledForeColor = System.Drawing.Color.White;
            this.txtQtdeProduto.Enabled = false;
            this.txtQtdeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtQtdeProduto.Location = new System.Drawing.Point(598, 176);
            this.txtQtdeProduto.MaxLength = 32767;
            this.txtQtdeProduto.Multiline = false;
            this.txtQtdeProduto.Name = "txtQtdeProduto";
            this.txtQtdeProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtQtdeProduto.PasswordChar = false;
            this.txtQtdeProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQtdeProduto.PlaceholderText = "";
            this.txtQtdeProduto.Size = new System.Drawing.Size(66, 28);
            this.txtQtdeProduto.TabIndex = 9;
            this.txtQtdeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtdeProduto.Texts = "";
            this.txtQtdeProduto.UnderlinedStyle = false;
            this.txtQtdeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeProduto_KeyPress);
            // 
            // btnConsultaProduto
            // 
            this.btnConsultaProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaProduto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaProduto.BorderRadius = 5;
            this.btnConsultaProduto.BorderSize = 1;
            this.btnConsultaProduto.Enabled = false;
            this.btnConsultaProduto.FlatAppearance.BorderSize = 0;
            this.btnConsultaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaProduto.ForeColor = System.Drawing.Color.White;
            this.btnConsultaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaProduto.Image")));
            this.btnConsultaProduto.Location = new System.Drawing.Point(112, 176);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaProduto.TabIndex = 8;
            this.btnConsultaProduto.TextColor = System.Drawing.Color.White;
            this.btnConsultaProduto.UseVisualStyleBackColor = false;
            this.btnConsultaProduto.Click += new System.EventHandler(this.btnConsultaProduto_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtProduto.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProduto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtProduto.BorderRadius = 5;
            this.txtProduto.BorderSize = 1;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.DisabledBackColor = System.Drawing.Color.White;
            this.txtProduto.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtProduto.DisabledForeColor = System.Drawing.Color.White;
            this.txtProduto.Enabled = false;
            this.txtProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtProduto.Location = new System.Drawing.Point(157, 176);
            this.txtProduto.MaxLength = 32767;
            this.txtProduto.Multiline = false;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtProduto.PasswordChar = false;
            this.txtProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProduto.PlaceholderText = "";
            this.txtProduto.Size = new System.Drawing.Size(251, 28);
            this.txtProduto.TabIndex = 145;
            this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProduto.Texts = "";
            this.txtProduto.UnderlinedStyle = false;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodProduto.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodProduto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodProduto.BorderRadius = 5;
            this.txtCodProduto.BorderSize = 1;
            this.txtCodProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodProduto.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodProduto.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodProduto.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodProduto.Location = new System.Drawing.Point(12, 176);
            this.txtCodProduto.MaxLength = 32767;
            this.txtCodProduto.Multiline = false;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodProduto.PasswordChar = false;
            this.txtCodProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodProduto.PlaceholderText = "";
            this.txtCodProduto.Size = new System.Drawing.Size(92, 28);
            this.txtCodProduto.TabIndex = 7;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodProduto.Texts = "";
            this.txtCodProduto.UnderlinedStyle = false;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(9, 160);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(76, 13);
            this.lblCodProduto.TabIndex = 144;
            this.lblCodProduto.Text = "Cód. Produto *";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(154, 160);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 143;
            this.lblProduto.Text = "Produto";
            // 
            // btnAddProdutos
            // 
            this.btnAddProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddProdutos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddProdutos.BorderRadius = 5;
            this.btnAddProdutos.BorderSize = 1;
            this.btnAddProdutos.FlatAppearance.BorderSize = 0;
            this.btnAddProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProdutos.ForeColor = System.Drawing.Color.White;
            this.btnAddProdutos.Location = new System.Drawing.Point(683, 176);
            this.btnAddProdutos.Name = "btnAddProdutos";
            this.btnAddProdutos.Size = new System.Drawing.Size(75, 28);
            this.btnAddProdutos.TabIndex = 10;
            this.btnAddProdutos.Text = "&Adicionar";
            this.btnAddProdutos.TextColor = System.Drawing.Color.White;
            this.btnAddProdutos.UseVisualStyleBackColor = false;
            this.btnAddProdutos.Click += new System.EventHandler(this.btnAddProdutos_Click);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(9, 672);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 164;
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
            this.txtObservacao.Location = new System.Drawing.Point(12, 688);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservacao.PlaceholderText = "";
            this.txtObservacao.Size = new System.Drawing.Size(746, 43);
            this.txtObservacao.TabIndex = 15;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacao.Texts = "";
            this.txtObservacao.UnderlinedStyle = false;
            // 
            // dataGridViewParcelas
            // 
            this.dataGridViewParcelas.AllowUserToAddRows = false;
            this.dataGridViewParcelas.AllowUserToDeleteRows = false;
            this.dataGridViewParcelas.AllowUserToResizeColumns = false;
            this.dataGridViewParcelas.AllowUserToResizeRows = false;
            this.dataGridViewParcelas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroParcela,
            this.idFormaPagamento,
            this.FormaPagamento,
            this.dataVencimento,
            this.valorParcela});
            this.dataGridViewParcelas.Enabled = false;
            this.dataGridViewParcelas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewParcelas.Location = new System.Drawing.Point(12, 507);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.ReadOnly = true;
            this.dataGridViewParcelas.Size = new System.Drawing.Size(746, 146);
            this.dataGridViewParcelas.TabIndex = 163;
            // 
            // numeroParcela
            // 
            this.numeroParcela.HeaderText = "Parcela";
            this.numeroParcela.Name = "numeroParcela";
            this.numeroParcela.ReadOnly = true;
            this.numeroParcela.Width = 120;
            // 
            // idFormaPagamento
            // 
            this.idFormaPagamento.HeaderText = "Cód. Forma Pagamento";
            this.idFormaPagamento.Name = "idFormaPagamento";
            this.idFormaPagamento.ReadOnly = true;
            this.idFormaPagamento.Width = 80;
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormaPagamento.HeaderText = "Forma de Pagamento";
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.ReadOnly = true;
            // 
            // dataVencimento
            // 
            this.dataVencimento.HeaderText = "Data Vencimento";
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.ReadOnly = true;
            this.dataVencimento.Width = 150;
            // 
            // valorParcela
            // 
            this.valorParcela.HeaderText = "Valor Parcela";
            this.valorParcela.Name = "valorParcela";
            this.valorParcela.ReadOnly = true;
            this.valorParcela.Width = 153;
            // 
            // txtPorcentagemDesconto
            // 
            this.txtPorcentagemDesconto.BackColor = System.Drawing.SystemColors.Window;
            this.txtPorcentagemDesconto.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagemDesconto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtPorcentagemDesconto.BorderRadius = 5;
            this.txtPorcentagemDesconto.BorderSize = 1;
            this.txtPorcentagemDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcentagemDesconto.DisabledBackColor = System.Drawing.Color.White;
            this.txtPorcentagemDesconto.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPorcentagemDesconto.DisabledForeColor = System.Drawing.Color.White;
            this.txtPorcentagemDesconto.Enabled = false;
            this.txtPorcentagemDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPorcentagemDesconto.Location = new System.Drawing.Point(512, 400);
            this.txtPorcentagemDesconto.MaxLength = 32767;
            this.txtPorcentagemDesconto.Multiline = false;
            this.txtPorcentagemDesconto.Name = "txtPorcentagemDesconto";
            this.txtPorcentagemDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPorcentagemDesconto.PasswordChar = false;
            this.txtPorcentagemDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagemDesconto.PlaceholderText = "";
            this.txtPorcentagemDesconto.Size = new System.Drawing.Size(66, 28);
            this.txtPorcentagemDesconto.TabIndex = 11;
            this.txtPorcentagemDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentagemDesconto.Texts = "0";
            this.txtPorcentagemDesconto.UnderlinedStyle = false;
            this.txtPorcentagemDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentagemDesconto_KeyPress);
            this.txtPorcentagemDesconto.Leave += new System.EventHandler(this.txtPorcentagemDesconto_Leave);
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
            this.txtTotalPagar.Location = new System.Drawing.Point(673, 400);
            this.txtTotalPagar.MaxLength = 32767;
            this.txtTotalPagar.Multiline = false;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotalPagar.PasswordChar = false;
            this.txtTotalPagar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalPagar.PlaceholderText = "";
            this.txtTotalPagar.Size = new System.Drawing.Size(85, 28);
            this.txtTotalPagar.TabIndex = 169;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPagar.Texts = "";
            this.txtTotalPagar.UnderlinedStyle = false;
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
            this.txtDesconto.Location = new System.Drawing.Point(593, 400);
            this.txtDesconto.MaxLength = 32767;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDesconto.PasswordChar = false;
            this.txtDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.PlaceholderText = "";
            this.txtDesconto.Size = new System.Drawing.Size(66, 28);
            this.txtDesconto.TabIndex = 173;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Texts = "";
            this.txtDesconto.UnderlinedStyle = false;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(669, 384);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagar.TabIndex = 170;
            this.lblTotalPagar.Text = "Total a Pagar ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 172;
            this.label1.Text = "% Desconto";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(595, 385);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(52, 13);
            this.lblDesconto.TabIndex = 171;
            this.lblDesconto.Text = "R$ Desc.";
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
            this.btnCancelar.Location = new System.Drawing.Point(565, 774);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar Venda";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroNotaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(774, 813);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPorcentagemDesconto);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.dataGridViewParcelas);
            this.Controls.Add(this.btnAddCondPag);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnConsultaCondPag);
            this.Controls.Add(this.txtCondPag);
            this.Controls.Add(this.txtCodCondPag);
            this.Controls.Add(this.lblCondPag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalProdutos);
            this.Controls.Add(this.txtTotalProdutos);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.lblPrecoProd);
            this.Controls.Add(this.txtPrecoProd);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.lblUN);
            this.Controls.Add(this.lblQtdeProduto);
            this.Controls.Add(this.txtQtdeProduto);
            this.Controls.Add(this.btnConsultaProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.lblCodProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnAddProdutos);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.lblCancelada);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblNroNota);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.btnConsultaCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtNroNota);
            this.Name = "CadastroNotaVenda";
            this.Text = "Cadastro Nota de Venda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroNotaVenda_FormClosed);
            this.Load += new System.EventHandler(this.CadastroNotaVenda_Load);
            this.Controls.SetChildIndex(this.txtUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.lblUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.txtNroNota, 0);
            this.Controls.SetChildIndex(this.txtSerie, 0);
            this.Controls.SetChildIndex(this.lblCodCliente, 0);
            this.Controls.SetChildIndex(this.lblCliente, 0);
            this.Controls.SetChildIndex(this.btnConsultaCliente, 0);
            this.Controls.SetChildIndex(this.txtCodCliente, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.lblNroNota, 0);
            this.Controls.SetChildIndex(this.lblSerie, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.txtDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblCancelada, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.btnAddProdutos, 0);
            this.Controls.SetChildIndex(this.lblProduto, 0);
            this.Controls.SetChildIndex(this.lblCodProduto, 0);
            this.Controls.SetChildIndex(this.txtCodProduto, 0);
            this.Controls.SetChildIndex(this.txtProduto, 0);
            this.Controls.SetChildIndex(this.btnConsultaProduto, 0);
            this.Controls.SetChildIndex(this.txtQtdeProduto, 0);
            this.Controls.SetChildIndex(this.lblQtdeProduto, 0);
            this.Controls.SetChildIndex(this.lblUN, 0);
            this.Controls.SetChildIndex(this.txtUN, 0);
            this.Controls.SetChildIndex(this.txtPrecoProd, 0);
            this.Controls.SetChildIndex(this.lblPrecoProd, 0);
            this.Controls.SetChildIndex(this.dataGridViewProdutos, 0);
            this.Controls.SetChildIndex(this.txtTotalProdutos, 0);
            this.Controls.SetChildIndex(this.lblTotalProdutos, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblCondPag, 0);
            this.Controls.SetChildIndex(this.txtCodCondPag, 0);
            this.Controls.SetChildIndex(this.txtCondPag, 0);
            this.Controls.SetChildIndex(this.btnConsultaCondPag, 0);
            this.Controls.SetChildIndex(this.btnExcluirProduto, 0);
            this.Controls.SetChildIndex(this.btnAddCondPag, 0);
            this.Controls.SetChildIndex(this.dataGridViewParcelas, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTotalPagar, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.txtTotalPagar, 0);
            this.Controls.SetChildIndex(this.txtPorcentagemDesconto, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblNroNota;
        private GControls.GTextBox txtModelo;
        private GControls.GTextBox txtCliente;
        private GControls.GTextBox txtCodCliente;
        private GButtons btnConsultaCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCodCliente;
        private GControls.GTextBox txtSerie;
        public GControls.GTextBox txtNroNota;
        private System.Windows.Forms.Label lblDataEmissao;
        private GControls.GMaskedTextBox txtDataEmissao;
        public System.Windows.Forms.Label lblDataCancelamento;
        public GControls.GMaskedTextBox txtDataCancelamento;
        public System.Windows.Forms.Label lblCancelada;
        protected GButtons btnAddCondPag;
        public GButtons btnExcluirProduto;
        protected GButtons btnConsultaCondPag;
        protected GControls.GTextBox txtCondPag;
        protected GControls.GTextBox txtCodCondPag;
        protected System.Windows.Forms.Label lblCondPag;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label lblTotalProdutos;
        private GControls.GTextBox txtTotalProdutos;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        protected System.Windows.Forms.Label lblPrecoProd;
        private GControls.GTextBox txtPrecoProd;
        private GControls.GTextBox txtUN;
        protected System.Windows.Forms.Label lblUN;
        protected System.Windows.Forms.Label lblQtdeProduto;
        private GControls.GTextBox txtQtdeProduto;
        private GButtons btnConsultaProduto;
        private GControls.GTextBox txtProduto;
        private GControls.GTextBox txtCodProduto;
        protected System.Windows.Forms.Label lblCodProduto;
        protected System.Windows.Forms.Label lblProduto;
        protected GButtons btnAddProdutos;
        protected System.Windows.Forms.Label lblObservacao;
        private GControls.GTextBox txtObservacao;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        private GControls.GTextBox txtPorcentagemDesconto;
        private GControls.GTextBox txtTotalPagar;
        private GControls.GTextBox txtDesconto;
        protected System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesconto;
        protected GButtons btnCancelar;
    }
}
