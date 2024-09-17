namespace Sistema_Vendas.Views
{
    partial class CadastroNotaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroNotaCompra));
            this.txtNroNota = new Sistema_Vendas.GControls.GTextBox();
            this.txtSerie = new Sistema_Vendas.GControls.GTextBox();
            this.txtFornecedor = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodFornecedor = new Sistema_Vendas.GControls.GTextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodFornecedor = new System.Windows.Forms.Label();
            this.txtModelo = new Sistema_Vendas.GControls.GTextBox();
            this.txtDataEmissao = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblNroNota = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.txtDataChegada = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblQtdeProduto = new System.Windows.Forms.Label();
            this.txtQtdeProduto = new Sistema_Vendas.GControls.GTextBox();
            this.txtProduto = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodProduto = new Sistema_Vendas.GControls.GTextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnAddProdutos = new Sistema_Vendas.GButtons();
            this.txtUN = new Sistema_Vendas.GControls.GTextBox();
            this.lblUN = new System.Windows.Forms.Label();
            this.lblPrecoProd = new System.Windows.Forms.Label();
            this.txtPrecoProd = new Sistema_Vendas.GControls.GTextBox();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFOB = new System.Windows.Forms.RadioButton();
            this.rbCIF = new System.Windows.Forms.RadioButton();
            this.lblValorSeguro = new System.Windows.Forms.Label();
            this.txtValorSeguro = new Sistema_Vendas.GControls.GTextBox();
            this.lblValorFrete = new System.Windows.Forms.Label();
            this.txtValorFrete = new Sistema_Vendas.GControls.GTextBox();
            this.lblOutrasDespesas = new System.Windows.Forms.Label();
            this.txtOutrasDespesas = new Sistema_Vendas.GControls.GTextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new Sistema_Vendas.GControls.GTextBox();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.txtTotalProdutos = new Sistema_Vendas.GControls.GTextBox();
            this.txtCondPag = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodCondPag = new Sistema_Vendas.GControls.GTextBox();
            this.lblCondPag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.numeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new Sistema_Vendas.GControls.GTextBox();
            this.btnCancelar = new Sistema_Vendas.GButtons();
            this.btnConsultaCondPag = new Sistema_Vendas.GButtons();
            this.btnConsultaProduto = new Sistema_Vendas.GButtons();
            this.btnConsultaFornecedor = new Sistema_Vendas.GButtons();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.txtDataCancelamento = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblCancelada = new System.Windows.Forms.Label();
            this.btnExcluirProduto = new Sistema_Vendas.GButtons();
            this.btnAddCondPag = new Sistema_Vendas.GButtons();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(284, 116);
            this.txtCodigo.Size = new System.Drawing.Size(21, 28);
            this.txtCodigo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(299, 95);
            this.groupBox1.Size = new System.Drawing.Size(42, 49);
            this.groupBox1.Visible = false;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 800);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(110, 800);
            // 
            // rbInativo
            // 
            this.rbInativo.Location = new System.Drawing.Point(-23, 32);
            this.rbInativo.Visible = false;
            // 
            // rbAtivo
            // 
            this.rbAtivo.Location = new System.Drawing.Point(-15, 12);
            this.rbAtivo.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(601, 815);
            this.btnSalvar.TabIndex = 23;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(687, 815);
            this.btnSair.TabIndex = 24;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 816);
            this.txtDataCadastro.Texts = "01/08/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(113, 816);
            this.txtDataUltAlt.Texts = "01/08/2024";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(296, 107);
            this.lblCodigo.Visible = false;
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(211, 816);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(208, 800);
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
            this.txtNroNota.Location = new System.Drawing.Point(16, 40);
            this.txtNroNota.MaxLength = 32767;
            this.txtNroNota.Multiline = false;
            this.txtNroNota.Name = "txtNroNota";
            this.txtNroNota.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtNroNota.PasswordChar = false;
            this.txtNroNota.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNroNota.PlaceholderText = "";
            this.txtNroNota.Size = new System.Drawing.Size(131, 28);
            this.txtNroNota.TabIndex = 1;
            this.txtNroNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroNota.Texts = "";
            this.txtNroNota.UnderlinedStyle = false;
            this.txtNroNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroNota_KeyPress);
            this.txtNroNota.Leave += new System.EventHandler(this.txtNroNota_Leave);
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
            this.txtSerie.Location = new System.Drawing.Point(240, 41);
            this.txtSerie.MaxLength = 32767;
            this.txtSerie.Multiline = false;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSerie.PasswordChar = false;
            this.txtSerie.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSerie.PlaceholderText = "";
            this.txtSerie.Size = new System.Drawing.Size(65, 28);
            this.txtSerie.TabIndex = 3;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSerie.Texts = "";
            this.txtSerie.UnderlinedStyle = false;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
            this.txtSerie.Leave += new System.EventHandler(this.txtSerie_Leave);
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
            this.txtFornecedor.Location = new System.Drawing.Point(466, 42);
            this.txtFornecedor.MaxLength = 32767;
            this.txtFornecedor.Multiline = false;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFornecedor.PasswordChar = false;
            this.txtFornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFornecedor.PlaceholderText = "";
            this.txtFornecedor.Size = new System.Drawing.Size(296, 28);
            this.txtFornecedor.TabIndex = 59;
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
            this.txtCodFornecedor.Location = new System.Drawing.Point(321, 42);
            this.txtCodFornecedor.MaxLength = 5;
            this.txtCodFornecedor.Multiline = false;
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodFornecedor.PasswordChar = false;
            this.txtCodFornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodFornecedor.PlaceholderText = "";
            this.txtCodFornecedor.Size = new System.Drawing.Size(83, 28);
            this.txtCodFornecedor.TabIndex = 4;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFornecedor.Texts = "";
            this.txtCodFornecedor.UnderlinedStyle = false;
            this.txtCodFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFornecedor_KeyPress);
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(463, 26);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 58;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblCodFornecedor
            // 
            this.lblCodFornecedor.AutoSize = true;
            this.lblCodFornecedor.Location = new System.Drawing.Point(318, 26);
            this.lblCodFornecedor.Name = "lblCodFornecedor";
            this.lblCodFornecedor.Size = new System.Drawing.Size(93, 13);
            this.lblCodFornecedor.TabIndex = 57;
            this.lblCodFornecedor.Text = "Cód. Fornecedor *";
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
            this.txtModelo.Location = new System.Drawing.Point(161, 41);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Multiline = false;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtModelo.PasswordChar = false;
            this.txtModelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.Size = new System.Drawing.Size(65, 28);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModelo.Texts = "";
            this.txtModelo.UnderlinedStyle = false;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
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
            this.txtDataEmissao.Enabled = false;
            this.txtDataEmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataEmissao.Location = new System.Drawing.Point(16, 108);
            this.txtDataEmissao.Mask = "00/00/0000";
            this.txtDataEmissao.MaxLength = 32767;
            this.txtDataEmissao.Multiline = false;
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataEmissao.PasswordChar = false;
            this.txtDataEmissao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataEmissao.PlaceholderText = "";
            this.txtDataEmissao.Size = new System.Drawing.Size(92, 27);
            this.txtDataEmissao.TabIndex = 5;
            this.txtDataEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataEmissao.Texts = "  /  /";
            this.txtDataEmissao.UnderlinedStyle = false;
            this.txtDataEmissao.Leave += new System.EventHandler(this.txtDataEmissao_Leave);
            // 
            // lblNroNota
            // 
            this.lblNroNota.AutoSize = true;
            this.lblNroNota.Location = new System.Drawing.Point(13, 24);
            this.lblNroNota.Name = "lblNroNota";
            this.lblNroNota.Size = new System.Drawing.Size(51, 13);
            this.lblNroNota.TabIndex = 62;
            this.lblNroNota.Text = "Número *";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(237, 25);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(38, 13);
            this.lblSerie.TabIndex = 63;
            this.lblSerie.Text = "Série *";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(158, 25);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 13);
            this.lblModelo.TabIndex = 64;
            this.lblModelo.Text = "Modelo *";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(13, 92);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(79, 13);
            this.lblDataEmissao.TabIndex = 65;
            this.lblDataEmissao.Text = "Data Emissão *";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Location = new System.Drawing.Point(122, 92);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(83, 13);
            this.lblDataChegada.TabIndex = 67;
            this.lblDataChegada.Text = "Data Chegada *";
            // 
            // txtDataChegada
            // 
            this.txtDataChegada.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataChegada.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataChegada.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataChegada.BorderRadius = 5;
            this.txtDataChegada.BorderSize = 1;
            this.txtDataChegada.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataChegada.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataChegada.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataChegada.Enabled = false;
            this.txtDataChegada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataChegada.Location = new System.Drawing.Point(125, 108);
            this.txtDataChegada.Mask = "00/00/0000";
            this.txtDataChegada.MaxLength = 32767;
            this.txtDataChegada.Multiline = false;
            this.txtDataChegada.Name = "txtDataChegada";
            this.txtDataChegada.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataChegada.PasswordChar = false;
            this.txtDataChegada.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataChegada.PlaceholderText = "";
            this.txtDataChegada.Size = new System.Drawing.Size(92, 27);
            this.txtDataChegada.TabIndex = 6;
            this.txtDataChegada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataChegada.Texts = "  /  /";
            this.txtDataChegada.UnderlinedStyle = false;
            this.txtDataChegada.Leave += new System.EventHandler(this.txtDataChegada_Leave);
            // 
            // lblQtdeProduto
            // 
            this.lblQtdeProduto.AutoSize = true;
            this.lblQtdeProduto.Location = new System.Drawing.Point(512, 160);
            this.lblQtdeProduto.Name = "lblQtdeProduto";
            this.lblQtdeProduto.Size = new System.Drawing.Size(69, 13);
            this.lblQtdeProduto.TabIndex = 92;
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
            this.txtQtdeProduto.Location = new System.Drawing.Point(515, 176);
            this.txtQtdeProduto.MaxLength = 32767;
            this.txtQtdeProduto.Multiline = false;
            this.txtQtdeProduto.Name = "txtQtdeProduto";
            this.txtQtdeProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtQtdeProduto.PasswordChar = false;
            this.txtQtdeProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQtdeProduto.PlaceholderText = "";
            this.txtQtdeProduto.Size = new System.Drawing.Size(66, 28);
            this.txtQtdeProduto.TabIndex = 10;
            this.txtQtdeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtdeProduto.Texts = "";
            this.txtQtdeProduto.UnderlinedStyle = false;
            this.txtQtdeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeProduto_KeyPress);
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
            this.txtProduto.Location = new System.Drawing.Point(161, 176);
            this.txtProduto.MaxLength = 32767;
            this.txtProduto.Multiline = false;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtProduto.PasswordChar = false;
            this.txtProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProduto.PlaceholderText = "";
            this.txtProduto.Size = new System.Drawing.Size(251, 28);
            this.txtProduto.TabIndex = 91;
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
            this.txtCodProduto.Location = new System.Drawing.Point(16, 176);
            this.txtCodProduto.MaxLength = 32767;
            this.txtCodProduto.Multiline = false;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodProduto.PasswordChar = false;
            this.txtCodProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodProduto.PlaceholderText = "";
            this.txtCodProduto.Size = new System.Drawing.Size(83, 28);
            this.txtCodProduto.TabIndex = 8;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodProduto.Texts = "";
            this.txtCodProduto.UnderlinedStyle = false;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(13, 160);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(76, 13);
            this.lblCodProduto.TabIndex = 90;
            this.lblCodProduto.Text = "Cód. Produto *";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(158, 160);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 89;
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
            this.btnAddProdutos.Location = new System.Drawing.Point(687, 176);
            this.btnAddProdutos.Name = "btnAddProdutos";
            this.btnAddProdutos.Size = new System.Drawing.Size(75, 28);
            this.btnAddProdutos.TabIndex = 12;
            this.btnAddProdutos.Text = "&Adicionar";
            this.btnAddProdutos.TextColor = System.Drawing.Color.White;
            this.btnAddProdutos.UseVisualStyleBackColor = false;
            this.btnAddProdutos.Click += new System.EventHandler(this.btnAddProdutos_Click);
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
            this.txtUN.Location = new System.Drawing.Point(429, 176);
            this.txtUN.MaxLength = 32767;
            this.txtUN.Multiline = false;
            this.txtUN.Name = "txtUN";
            this.txtUN.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUN.PasswordChar = false;
            this.txtUN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUN.PlaceholderText = "";
            this.txtUN.Size = new System.Drawing.Size(68, 28);
            this.txtUN.TabIndex = 94;
            this.txtUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUN.Texts = "";
            this.txtUN.UnderlinedStyle = false;
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Location = new System.Drawing.Point(426, 160);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(47, 13);
            this.lblUN.TabIndex = 93;
            this.lblUN.Text = "Unidade";
            // 
            // lblPrecoProd
            // 
            this.lblPrecoProd.AutoSize = true;
            this.lblPrecoProd.Location = new System.Drawing.Point(598, 160);
            this.lblPrecoProd.Name = "lblPrecoProd";
            this.lblPrecoProd.Size = new System.Drawing.Size(42, 13);
            this.lblPrecoProd.TabIndex = 96;
            this.lblPrecoProd.Text = "Preço *";
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
            this.txtPrecoProd.Location = new System.Drawing.Point(601, 176);
            this.txtPrecoProd.MaxLength = 32767;
            this.txtPrecoProd.Multiline = false;
            this.txtPrecoProd.Name = "txtPrecoProd";
            this.txtPrecoProd.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPrecoProd.PasswordChar = false;
            this.txtPrecoProd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecoProd.PlaceholderText = "";
            this.txtPrecoProd.Size = new System.Drawing.Size(66, 28);
            this.txtPrecoProd.TabIndex = 11;
            this.txtPrecoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoProd.Texts = "";
            this.txtPrecoProd.UnderlinedStyle = false;
            this.txtPrecoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoProd_KeyPress);
            this.txtPrecoProd.Leave += new System.EventHandler(this.txtPrecoProd_Leave);
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
            this.dataGridViewProdutos.Location = new System.Drawing.Point(16, 230);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(746, 141);
            this.dataGridViewProdutos.TabIndex = 97;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFOB);
            this.groupBox2.Controls.Add(this.rbCIF);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(16, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 49);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Frete";
            // 
            // rbFOB
            // 
            this.rbFOB.AutoSize = true;
            this.rbFOB.Enabled = false;
            this.rbFOB.Location = new System.Drawing.Point(80, 20);
            this.rbFOB.Name = "rbFOB";
            this.rbFOB.Size = new System.Drawing.Size(46, 17);
            this.rbFOB.TabIndex = 15;
            this.rbFOB.TabStop = true;
            this.rbFOB.Text = "FOB";
            this.rbFOB.UseVisualStyleBackColor = true;
            this.rbFOB.CheckedChanged += new System.EventHandler(this.rbFOB_CheckedChanged);
            // 
            // rbCIF
            // 
            this.rbCIF.AutoSize = true;
            this.rbCIF.Checked = true;
            this.rbCIF.Enabled = false;
            this.rbCIF.Location = new System.Drawing.Point(16, 20);
            this.rbCIF.Name = "rbCIF";
            this.rbCIF.Size = new System.Drawing.Size(41, 17);
            this.rbCIF.TabIndex = 14;
            this.rbCIF.TabStop = true;
            this.rbCIF.Text = "CIF";
            this.rbCIF.UseVisualStyleBackColor = true;
            this.rbCIF.CheckedChanged += new System.EventHandler(this.rbCIF_CheckedChanged);
            // 
            // lblValorSeguro
            // 
            this.lblValorSeguro.AutoSize = true;
            this.lblValorSeguro.Location = new System.Drawing.Point(296, 437);
            this.lblValorSeguro.Name = "lblValorSeguro";
            this.lblValorSeguro.Size = new System.Drawing.Size(68, 13);
            this.lblValorSeguro.TabIndex = 102;
            this.lblValorSeguro.Text = "Valor Seguro";
            // 
            // txtValorSeguro
            // 
            this.txtValorSeguro.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorSeguro.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorSeguro.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtValorSeguro.BorderRadius = 5;
            this.txtValorSeguro.BorderSize = 1;
            this.txtValorSeguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorSeguro.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorSeguro.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorSeguro.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorSeguro.Enabled = false;
            this.txtValorSeguro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorSeguro.Location = new System.Drawing.Point(299, 452);
            this.txtValorSeguro.MaxLength = 32767;
            this.txtValorSeguro.Multiline = false;
            this.txtValorSeguro.Name = "txtValorSeguro";
            this.txtValorSeguro.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorSeguro.PasswordChar = false;
            this.txtValorSeguro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorSeguro.PlaceholderText = "";
            this.txtValorSeguro.Size = new System.Drawing.Size(85, 28);
            this.txtValorSeguro.TabIndex = 17;
            this.txtValorSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorSeguro.Texts = "0";
            this.txtValorSeguro.UnderlinedStyle = false;
            this.txtValorSeguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorSeguro_KeyPress);
            this.txtValorSeguro.Leave += new System.EventHandler(this.txtValorSeguro_Leave);
            // 
            // lblValorFrete
            // 
            this.lblValorFrete.AutoSize = true;
            this.lblValorFrete.Location = new System.Drawing.Point(187, 436);
            this.lblValorFrete.Name = "lblValorFrete";
            this.lblValorFrete.Size = new System.Drawing.Size(58, 13);
            this.lblValorFrete.TabIndex = 100;
            this.lblValorFrete.Text = "Valor Frete";
            // 
            // txtValorFrete
            // 
            this.txtValorFrete.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorFrete.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorFrete.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtValorFrete.BorderRadius = 5;
            this.txtValorFrete.BorderSize = 1;
            this.txtValorFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorFrete.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorFrete.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorFrete.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorFrete.Enabled = false;
            this.txtValorFrete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorFrete.Location = new System.Drawing.Point(190, 452);
            this.txtValorFrete.MaxLength = 32767;
            this.txtValorFrete.Multiline = false;
            this.txtValorFrete.Name = "txtValorFrete";
            this.txtValorFrete.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorFrete.PasswordChar = false;
            this.txtValorFrete.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorFrete.PlaceholderText = "";
            this.txtValorFrete.Size = new System.Drawing.Size(85, 28);
            this.txtValorFrete.TabIndex = 16;
            this.txtValorFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorFrete.Texts = "0";
            this.txtValorFrete.UnderlinedStyle = false;
            this.txtValorFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorFrete_KeyPress);
            this.txtValorFrete.Leave += new System.EventHandler(this.txtValorFrete_Leave);
            // 
            // lblOutrasDespesas
            // 
            this.lblOutrasDespesas.AutoSize = true;
            this.lblOutrasDespesas.Location = new System.Drawing.Point(409, 436);
            this.lblOutrasDespesas.Name = "lblOutrasDespesas";
            this.lblOutrasDespesas.Size = new System.Drawing.Size(88, 13);
            this.lblOutrasDespesas.TabIndex = 104;
            this.lblOutrasDespesas.Text = "Outras Despesas";
            // 
            // txtOutrasDespesas
            // 
            this.txtOutrasDespesas.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutrasDespesas.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOutrasDespesas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtOutrasDespesas.BorderRadius = 5;
            this.txtOutrasDespesas.BorderSize = 1;
            this.txtOutrasDespesas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutrasDespesas.DisabledBackColor = System.Drawing.Color.White;
            this.txtOutrasDespesas.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtOutrasDespesas.DisabledForeColor = System.Drawing.Color.White;
            this.txtOutrasDespesas.Enabled = false;
            this.txtOutrasDespesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtOutrasDespesas.Location = new System.Drawing.Point(412, 452);
            this.txtOutrasDespesas.MaxLength = 32767;
            this.txtOutrasDespesas.Multiline = false;
            this.txtOutrasDespesas.Name = "txtOutrasDespesas";
            this.txtOutrasDespesas.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtOutrasDespesas.PasswordChar = false;
            this.txtOutrasDespesas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOutrasDespesas.PlaceholderText = "";
            this.txtOutrasDespesas.Size = new System.Drawing.Size(85, 28);
            this.txtOutrasDespesas.TabIndex = 18;
            this.txtOutrasDespesas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutrasDespesas.Texts = "0";
            this.txtOutrasDespesas.UnderlinedStyle = false;
            this.txtOutrasDespesas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutrasDespesas_KeyPress);
            this.txtOutrasDespesas.Leave += new System.EventHandler(this.txtOutrasDespesas_Leave);
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(674, 384);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagar.TabIndex = 108;
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
            this.txtTotalPagar.Location = new System.Drawing.Point(677, 400);
            this.txtTotalPagar.MaxLength = 32767;
            this.txtTotalPagar.Multiline = false;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotalPagar.PasswordChar = false;
            this.txtTotalPagar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalPagar.PlaceholderText = "";
            this.txtTotalPagar.Size = new System.Drawing.Size(85, 28);
            this.txtTotalPagar.TabIndex = 107;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPagar.Texts = "";
            this.txtTotalPagar.UnderlinedStyle = false;
            // 
            // lblTotalProdutos
            // 
            this.lblTotalProdutos.AutoSize = true;
            this.lblTotalProdutos.Location = new System.Drawing.Point(568, 385);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(79, 13);
            this.lblTotalProdutos.TabIndex = 106;
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
            this.txtTotalProdutos.Location = new System.Drawing.Point(571, 400);
            this.txtTotalProdutos.MaxLength = 32767;
            this.txtTotalProdutos.Multiline = false;
            this.txtTotalProdutos.Name = "txtTotalProdutos";
            this.txtTotalProdutos.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotalProdutos.PasswordChar = false;
            this.txtTotalProdutos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalProdutos.PlaceholderText = "";
            this.txtTotalProdutos.Size = new System.Drawing.Size(85, 28);
            this.txtTotalProdutos.TabIndex = 105;
            this.txtTotalProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalProdutos.Texts = "";
            this.txtTotalProdutos.UnderlinedStyle = false;
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
            this.txtCondPag.Location = new System.Drawing.Point(147, 515);
            this.txtCondPag.MaxLength = 14;
            this.txtCondPag.Multiline = false;
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCondPag.PasswordChar = false;
            this.txtCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCondPag.PlaceholderText = "";
            this.txtCondPag.Size = new System.Drawing.Size(265, 28);
            this.txtCondPag.TabIndex = 120;
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
            this.txtCodCondPag.Location = new System.Drawing.Point(16, 515);
            this.txtCodCondPag.MaxLength = 14;
            this.txtCodCondPag.Multiline = false;
            this.txtCodCondPag.Name = "txtCodCondPag";
            this.txtCodCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodCondPag.PasswordChar = false;
            this.txtCodCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodCondPag.PlaceholderText = "";
            this.txtCodCondPag.Size = new System.Drawing.Size(83, 28);
            this.txtCodCondPag.TabIndex = 19;
            this.txtCodCondPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCondPag.Texts = "";
            this.txtCodCondPag.UnderlinedStyle = false;
            this.txtCodCondPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCondPag_KeyPress);
            this.txtCodCondPag.Leave += new System.EventHandler(this.txtCodCondPag_Leave);
            // 
            // lblCondPag
            // 
            this.lblCondPag.AutoSize = true;
            this.lblCondPag.Location = new System.Drawing.Point(13, 499);
            this.lblCondPag.Name = "lblCondPag";
            this.lblCondPag.Size = new System.Drawing.Size(44, 13);
            this.lblCondPag.TabIndex = 118;
            this.lblCondPag.Text = "Código*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Condição de Pagamento";
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
            this.dataGridViewParcelas.Location = new System.Drawing.Point(16, 561);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.ReadOnly = true;
            this.dataGridViewParcelas.Size = new System.Drawing.Size(746, 150);
            this.dataGridViewParcelas.TabIndex = 122;
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
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(13, 726);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 124;
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
            this.txtObservacao.Location = new System.Drawing.Point(16, 742);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservacao.PlaceholderText = "";
            this.txtObservacao.Size = new System.Drawing.Size(746, 43);
            this.txtObservacao.TabIndex = 22;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacao.Texts = "";
            this.txtObservacao.UnderlinedStyle = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(569, 815);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar Compra";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnConsultaCondPag.Location = new System.Drawing.Point(105, 515);
            this.btnConsultaCondPag.Name = "btnConsultaCondPag";
            this.btnConsultaCondPag.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaCondPag.TabIndex = 20;
            this.btnConsultaCondPag.TextColor = System.Drawing.Color.White;
            this.btnConsultaCondPag.UseVisualStyleBackColor = false;
            this.btnConsultaCondPag.Click += new System.EventHandler(this.btnConsultaCondPag_Click);
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
            this.btnConsultaProduto.Location = new System.Drawing.Point(111, 176);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaProduto.TabIndex = 26;
            this.btnConsultaProduto.TextColor = System.Drawing.Color.White;
            this.btnConsultaProduto.UseVisualStyleBackColor = false;
            this.btnConsultaProduto.Click += new System.EventHandler(this.btnConsultaProduto_Click);
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
            this.btnConsultaFornecedor.Location = new System.Drawing.Point(416, 42);
            this.btnConsultaFornecedor.Name = "btnConsultaFornecedor";
            this.btnConsultaFornecedor.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaFornecedor.TabIndex = 25;
            this.btnConsultaFornecedor.TextColor = System.Drawing.Color.White;
            this.btnConsultaFornecedor.UseVisualStyleBackColor = false;
            this.btnConsultaFornecedor.Click += new System.EventHandler(this.btnConsultaFornecedor_Click);
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataCancelamento.Location = new System.Drawing.Point(661, 91);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(101, 13);
            this.lblDataCancelamento.TabIndex = 127;
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
            this.txtDataCancelamento.Location = new System.Drawing.Point(664, 107);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.MaxLength = 32767;
            this.txtDataCancelamento.Multiline = false;
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCancelamento.PasswordChar = false;
            this.txtDataCancelamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.PlaceholderText = "";
            this.txtDataCancelamento.Size = new System.Drawing.Size(98, 27);
            this.txtDataCancelamento.TabIndex = 126;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.Texts = "  /  /";
            this.txtDataCancelamento.UnderlinedStyle = false;
            this.txtDataCancelamento.Visible = false;
            // 
            // lblCancelada
            // 
            this.lblCancelada.AutoSize = true;
            this.lblCancelada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCancelada.Location = new System.Drawing.Point(528, 116);
            this.lblCancelada.Name = "lblCancelada";
            this.lblCancelada.Size = new System.Drawing.Size(112, 13);
            this.lblCancelada.TabIndex = 126;
            this.lblCancelada.Text = "*NOTA CANCELADA*";
            this.lblCancelada.Visible = false;
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
            this.btnExcluirProduto.Location = new System.Drawing.Point(16, 385);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(86, 28);
            this.btnExcluirProduto.TabIndex = 127;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
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
            this.btnAddCondPag.Location = new System.Drawing.Point(422, 515);
            this.btnAddCondPag.Name = "btnAddCondPag";
            this.btnAddCondPag.Size = new System.Drawing.Size(75, 28);
            this.btnAddCondPag.TabIndex = 21;
            this.btnAddCondPag.Text = "&Adicionar";
            this.btnAddCondPag.TextColor = System.Drawing.Color.White;
            this.btnAddCondPag.UseVisualStyleBackColor = false;
            this.btnAddCondPag.Click += new System.EventHandler(this.btnAddCondPag_Click);
            // 
            // CadastroNotaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(778, 855);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.btnAddCondPag);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.lblCancelada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.dataGridViewParcelas);
            this.Controls.Add(this.btnConsultaCondPag);
            this.Controls.Add(this.txtCondPag);
            this.Controls.Add(this.txtCodCondPag);
            this.Controls.Add(this.lblCondPag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalProdutos);
            this.Controls.Add(this.txtTotalProdutos);
            this.Controls.Add(this.lblOutrasDespesas);
            this.Controls.Add(this.txtOutrasDespesas);
            this.Controls.Add(this.lblValorSeguro);
            this.Controls.Add(this.txtValorSeguro);
            this.Controls.Add(this.lblValorFrete);
            this.Controls.Add(this.txtValorFrete);
            this.Controls.Add(this.groupBox2);
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
            this.Controls.Add(this.lblDataChegada);
            this.Controls.Add(this.txtDataChegada);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.lblNroNota);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.btnConsultaFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCodFornecedor);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtNroNota);
            this.Name = "CadastroNotaCompra";
            this.Text = "Cadastro Nota de Compra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroNotaCompra_FormClosed);
            this.Load += new System.EventHandler(this.CadastroNotaCompra_Load);
            this.Controls.SetChildIndex(this.txtUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.lblUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.txtNroNota, 0);
            this.Controls.SetChildIndex(this.txtSerie, 0);
            this.Controls.SetChildIndex(this.lblCodFornecedor, 0);
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.btnConsultaFornecedor, 0);
            this.Controls.SetChildIndex(this.txtCodFornecedor, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.txtDataEmissao, 0);
            this.Controls.SetChildIndex(this.lblNroNota, 0);
            this.Controls.SetChildIndex(this.lblSerie, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.lblDataEmissao, 0);
            this.Controls.SetChildIndex(this.txtDataChegada, 0);
            this.Controls.SetChildIndex(this.lblDataChegada, 0);
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
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.txtValorFrete, 0);
            this.Controls.SetChildIndex(this.lblValorFrete, 0);
            this.Controls.SetChildIndex(this.txtValorSeguro, 0);
            this.Controls.SetChildIndex(this.lblValorSeguro, 0);
            this.Controls.SetChildIndex(this.txtOutrasDespesas, 0);
            this.Controls.SetChildIndex(this.lblOutrasDespesas, 0);
            this.Controls.SetChildIndex(this.txtTotalProdutos, 0);
            this.Controls.SetChildIndex(this.lblTotalProdutos, 0);
            this.Controls.SetChildIndex(this.txtTotalPagar, 0);
            this.Controls.SetChildIndex(this.lblTotalPagar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblCondPag, 0);
            this.Controls.SetChildIndex(this.txtCodCondPag, 0);
            this.Controls.SetChildIndex(this.txtCondPag, 0);
            this.Controls.SetChildIndex(this.btnConsultaCondPag, 0);
            this.Controls.SetChildIndex(this.dataGridViewParcelas, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCancelada, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.btnExcluirProduto, 0);
            this.Controls.SetChildIndex(this.btnAddCondPag, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GControls.GTextBox txtSerie;
        private GControls.GTextBox txtFornecedor;
        private GControls.GTextBox txtCodFornecedor;
        private GButtons btnConsultaFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblCodFornecedor;
        private GControls.GTextBox txtModelo;
        private GControls.GMaskedTextBox txtDataEmissao;
        private System.Windows.Forms.Label lblNroNota;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblDataChegada;
        private GControls.GMaskedTextBox txtDataChegada;
        protected System.Windows.Forms.Label lblQtdeProduto;
        private GControls.GTextBox txtQtdeProduto;
        private GButtons btnConsultaProduto;
        private GControls.GTextBox txtProduto;
        private GControls.GTextBox txtCodProduto;
        protected System.Windows.Forms.Label lblCodProduto;
        protected System.Windows.Forms.Label lblProduto;
        protected GButtons btnAddProdutos;
        private GControls.GTextBox txtUN;
        protected System.Windows.Forms.Label lblUN;
        protected System.Windows.Forms.Label lblPrecoProd;
        private GControls.GTextBox txtPrecoProd;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.RadioButton rbFOB;
        protected System.Windows.Forms.RadioButton rbCIF;
        protected System.Windows.Forms.Label lblValorSeguro;
        private GControls.GTextBox txtValorSeguro;
        protected System.Windows.Forms.Label lblValorFrete;
        private GControls.GTextBox txtValorFrete;
        protected System.Windows.Forms.Label lblOutrasDespesas;
        private GControls.GTextBox txtOutrasDespesas;
        protected System.Windows.Forms.Label lblTotalPagar;
        private GControls.GTextBox txtTotalPagar;
        protected System.Windows.Forms.Label lblTotalProdutos;
        private GControls.GTextBox txtTotalProdutos;
        protected GButtons btnConsultaCondPag;
        protected GControls.GTextBox txtCondPag;
        protected GControls.GTextBox txtCodCondPag;
        protected System.Windows.Forms.Label lblCondPag;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        protected System.Windows.Forms.Label lblObservacao;
        private GControls.GTextBox txtObservacao;
        protected GButtons btnCancelar;
        public GControls.GTextBox txtNroNota;
        public GButtons btnExcluirProduto;
        protected GButtons btnAddCondPag;
        public System.Windows.Forms.Label lblDataCancelamento;
        public GControls.GMaskedTextBox txtDataCancelamento;
        public System.Windows.Forms.Label lblCancelada;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
    }
}
