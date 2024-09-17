namespace Sistema_Vendas.Views
{
    partial class CadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProdutos));
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblUN = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodFornecedor = new System.Windows.Forms.Label();
            this.lblCodModelol = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblCustoMedio = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblPrecoUltCompra = new System.Windows.Forms.Label();
            this.lblDataUltCompra = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtProduto = new Sistema_Vendas.GControls.GTextBox();
            this.txtUN = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodModelo = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaModelos = new Sistema_Vendas.GButtons();
            this.btnConsultaFornecedor = new Sistema_Vendas.GButtons();
            this.txtCodFornecedor = new Sistema_Vendas.GControls.GTextBox();
            this.txtModelo = new Sistema_Vendas.GControls.GTextBox();
            this.txtMarca = new Sistema_Vendas.GControls.GTextBox();
            this.txtFornecedor = new Sistema_Vendas.GControls.GTextBox();
            this.txtObservacao = new Sistema_Vendas.GControls.GTextBox();
            this.txtPrecoVenda = new Sistema_Vendas.GControls.GTextBox();
            this.txtCustoMedio = new Sistema_Vendas.GControls.GTextBox();
            this.txtSaldo = new Sistema_Vendas.GControls.GTextBox();
            this.txtPrecoUltCompra = new Sistema_Vendas.GControls.GTextBox();
            this.txtDataUltCompra = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(14, 391);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(102, 391);
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 13;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(444, 14);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(432, 407);
            this.btnSalvar.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(513, 407);
            this.btnSair.TabIndex = 10;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(17, 407);
            this.txtDataCadastro.Texts = "04/07/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(105, 407);
            this.txtDataUltAlt.Texts = "04/07/2024";
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(193, 407);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(190, 391);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(13, 79);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(51, 13);
            this.lblProduto.TabIndex = 16;
            this.lblProduto.Text = "Produto *";
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Location = new System.Drawing.Point(523, 79);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(30, 13);
            this.lblUN.TabIndex = 23;
            this.lblUN.Text = "UN *";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(144, 139);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 24;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(331, 139);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 25;
            this.lblMarca.Text = "Marca";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(144, 200);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 31;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblCodFornecedor
            // 
            this.lblCodFornecedor.AutoSize = true;
            this.lblCodFornecedor.Location = new System.Drawing.Point(13, 200);
            this.lblCodFornecedor.Name = "lblCodFornecedor";
            this.lblCodFornecedor.Size = new System.Drawing.Size(93, 13);
            this.lblCodFornecedor.TabIndex = 30;
            this.lblCodFornecedor.Text = "Cód. Fornecedor *";
            // 
            // lblCodModelol
            // 
            this.lblCodModelol.AutoSize = true;
            this.lblCodModelol.Location = new System.Drawing.Point(13, 139);
            this.lblCodModelol.Name = "lblCodModelol";
            this.lblCodModelol.Size = new System.Drawing.Size(74, 13);
            this.lblCodModelol.TabIndex = 33;
            this.lblCodModelol.Text = "Cód. Modelo *";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(13, 259);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 37;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblCustoMedio
            // 
            this.lblCustoMedio.AutoSize = true;
            this.lblCustoMedio.Location = new System.Drawing.Point(136, 259);
            this.lblCustoMedio.Name = "lblCustoMedio";
            this.lblCustoMedio.Size = new System.Drawing.Size(66, 13);
            this.lblCustoMedio.TabIndex = 38;
            this.lblCustoMedio.Text = "Custo Médio";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(257, 259);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(76, 13);
            this.lblPrecoVenda.TabIndex = 39;
            this.lblPrecoVenda.Text = "Preço Venda *";
            // 
            // lblPrecoUltCompra
            // 
            this.lblPrecoUltCompra.AutoSize = true;
            this.lblPrecoUltCompra.Location = new System.Drawing.Point(377, 259);
            this.lblPrecoUltCompra.Name = "lblPrecoUltCompra";
            this.lblPrecoUltCompra.Size = new System.Drawing.Size(93, 13);
            this.lblPrecoUltCompra.TabIndex = 41;
            this.lblPrecoUltCompra.Text = "Preço Últ. Compra";
            // 
            // lblDataUltCompra
            // 
            this.lblDataUltCompra.AutoSize = true;
            this.lblDataUltCompra.Location = new System.Drawing.Point(497, 259);
            this.lblDataUltCompra.Name = "lblDataUltCompra";
            this.lblDataUltCompra.Size = new System.Drawing.Size(88, 13);
            this.lblDataUltCompra.TabIndex = 43;
            this.lblDataUltCompra.Text = "Data Últ. Compra";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(13, 316);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 45;
            this.lblObservacao.Text = "Observação";
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
            this.txtProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtProduto.Location = new System.Drawing.Point(16, 95);
            this.txtProduto.MaxLength = 200;
            this.txtProduto.Multiline = false;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtProduto.PasswordChar = false;
            this.txtProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProduto.PlaceholderText = "";
            this.txtProduto.Size = new System.Drawing.Size(493, 28);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProduto.Texts = "";
            this.txtProduto.UnderlinedStyle = false;
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
            this.txtUN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtUN.Location = new System.Drawing.Point(524, 95);
            this.txtUN.MaxLength = 5;
            this.txtUN.Multiline = false;
            this.txtUN.Name = "txtUN";
            this.txtUN.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUN.PasswordChar = false;
            this.txtUN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUN.PlaceholderText = "";
            this.txtUN.Size = new System.Drawing.Size(64, 28);
            this.txtUN.TabIndex = 2;
            this.txtUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUN.Texts = "";
            this.txtUN.UnderlinedStyle = false;
            this.txtUN.Leave += new System.EventHandler(this.txtUN_Leave);
            // 
            // txtCodModelo
            // 
            this.txtCodModelo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodModelo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodModelo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodModelo.BorderRadius = 5;
            this.txtCodModelo.BorderSize = 1;
            this.txtCodModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodModelo.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodModelo.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodModelo.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodModelo.Location = new System.Drawing.Point(16, 155);
            this.txtCodModelo.MaxLength = 5;
            this.txtCodModelo.Multiline = false;
            this.txtCodModelo.Name = "txtCodModelo";
            this.txtCodModelo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodModelo.PasswordChar = false;
            this.txtCodModelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodModelo.PlaceholderText = "";
            this.txtCodModelo.Size = new System.Drawing.Size(83, 28);
            this.txtCodModelo.TabIndex = 3;
            this.txtCodModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodModelo.Texts = "";
            this.txtCodModelo.UnderlinedStyle = false;
            this.txtCodModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodModelo_KeyPress);
            this.txtCodModelo.Leave += new System.EventHandler(this.txtCodModelo_Leave);
            // 
            // btnConsultaModelos
            // 
            this.btnConsultaModelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaModelos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaModelos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaModelos.BorderRadius = 5;
            this.btnConsultaModelos.BorderSize = 1;
            this.btnConsultaModelos.FlatAppearance.BorderSize = 0;
            this.btnConsultaModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaModelos.ForeColor = System.Drawing.Color.White;
            this.btnConsultaModelos.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaModelos.Image")));
            this.btnConsultaModelos.Location = new System.Drawing.Point(105, 155);
            this.btnConsultaModelos.Name = "btnConsultaModelos";
            this.btnConsultaModelos.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaModelos.TabIndex = 4;
            this.btnConsultaModelos.TextColor = System.Drawing.Color.White;
            this.btnConsultaModelos.UseVisualStyleBackColor = false;
            this.btnConsultaModelos.Click += new System.EventHandler(this.btnConsultaModelos_Click);
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
            this.btnConsultaFornecedor.Location = new System.Drawing.Point(105, 216);
            this.btnConsultaFornecedor.Name = "btnConsultaFornecedor";
            this.btnConsultaFornecedor.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaFornecedor.TabIndex = 6;
            this.btnConsultaFornecedor.TextColor = System.Drawing.Color.White;
            this.btnConsultaFornecedor.UseVisualStyleBackColor = false;
            this.btnConsultaFornecedor.Click += new System.EventHandler(this.btnConsultaFornecedor_Click);
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
            this.txtCodFornecedor.Location = new System.Drawing.Point(16, 216);
            this.txtCodFornecedor.MaxLength = 5;
            this.txtCodFornecedor.Multiline = false;
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodFornecedor.PasswordChar = false;
            this.txtCodFornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodFornecedor.PlaceholderText = "";
            this.txtCodFornecedor.Size = new System.Drawing.Size(83, 28);
            this.txtCodFornecedor.TabIndex = 5;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodFornecedor.Texts = "";
            this.txtCodFornecedor.UnderlinedStyle = false;
            this.txtCodFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFornecedor_KeyPress);
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
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
            this.txtModelo.Enabled = false;
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtModelo.Location = new System.Drawing.Point(147, 155);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Multiline = false;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtModelo.PasswordChar = false;
            this.txtModelo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModelo.PlaceholderText = "";
            this.txtModelo.Size = new System.Drawing.Size(175, 28);
            this.txtModelo.TabIndex = 52;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtModelo.Texts = "";
            this.txtModelo.UnderlinedStyle = false;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.Window;
            this.txtMarca.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMarca.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtMarca.BorderRadius = 5;
            this.txtMarca.BorderSize = 1;
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.DisabledBackColor = System.Drawing.Color.White;
            this.txtMarca.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtMarca.DisabledForeColor = System.Drawing.Color.White;
            this.txtMarca.Enabled = false;
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtMarca.Location = new System.Drawing.Point(334, 155);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.Multiline = false;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtMarca.PasswordChar = false;
            this.txtMarca.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMarca.PlaceholderText = "";
            this.txtMarca.Size = new System.Drawing.Size(175, 28);
            this.txtMarca.TabIndex = 53;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMarca.Texts = "";
            this.txtMarca.UnderlinedStyle = false;
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
            this.txtFornecedor.Location = new System.Drawing.Point(147, 216);
            this.txtFornecedor.MaxLength = 32767;
            this.txtFornecedor.Multiline = false;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFornecedor.PasswordChar = false;
            this.txtFornecedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFornecedor.PlaceholderText = "";
            this.txtFornecedor.Size = new System.Drawing.Size(362, 28);
            this.txtFornecedor.TabIndex = 54;
            this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFornecedor.Texts = "";
            this.txtFornecedor.UnderlinedStyle = false;
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
            this.txtObservacao.Location = new System.Drawing.Point(16, 332);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Multiline = false;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservacao.PlaceholderText = "";
            this.txtObservacao.Size = new System.Drawing.Size(572, 28);
            this.txtObservacao.TabIndex = 8;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacao.Texts = "";
            this.txtObservacao.UnderlinedStyle = false;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecoVenda.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrecoVenda.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtPrecoVenda.BorderRadius = 5;
            this.txtPrecoVenda.BorderSize = 1;
            this.txtPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoVenda.DisabledBackColor = System.Drawing.Color.White;
            this.txtPrecoVenda.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPrecoVenda.DisabledForeColor = System.Drawing.Color.White;
            this.txtPrecoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPrecoVenda.Location = new System.Drawing.Point(260, 275);
            this.txtPrecoVenda.MaxLength = 32767;
            this.txtPrecoVenda.Multiline = false;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPrecoVenda.PasswordChar = false;
            this.txtPrecoVenda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecoVenda.PlaceholderText = "";
            this.txtPrecoVenda.Size = new System.Drawing.Size(100, 28);
            this.txtPrecoVenda.TabIndex = 7;
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoVenda.Texts = "";
            this.txtPrecoVenda.UnderlinedStyle = false;
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVenda_KeyPress);
            this.txtPrecoVenda.Leave += new System.EventHandler(this.txtPrecoVenda_Leave);
            // 
            // txtCustoMedio
            // 
            this.txtCustoMedio.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustoMedio.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCustoMedio.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCustoMedio.BorderRadius = 5;
            this.txtCustoMedio.BorderSize = 1;
            this.txtCustoMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustoMedio.DisabledBackColor = System.Drawing.Color.White;
            this.txtCustoMedio.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCustoMedio.DisabledForeColor = System.Drawing.Color.White;
            this.txtCustoMedio.Enabled = false;
            this.txtCustoMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCustoMedio.Location = new System.Drawing.Point(139, 275);
            this.txtCustoMedio.MaxLength = 32767;
            this.txtCustoMedio.Multiline = false;
            this.txtCustoMedio.Name = "txtCustoMedio";
            this.txtCustoMedio.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCustoMedio.PasswordChar = false;
            this.txtCustoMedio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustoMedio.PlaceholderText = "";
            this.txtCustoMedio.Size = new System.Drawing.Size(100, 28);
            this.txtCustoMedio.TabIndex = 57;
            this.txtCustoMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustoMedio.Texts = "";
            this.txtCustoMedio.UnderlinedStyle = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.Window;
            this.txtSaldo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSaldo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtSaldo.BorderRadius = 5;
            this.txtSaldo.BorderSize = 1;
            this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldo.DisabledBackColor = System.Drawing.Color.White;
            this.txtSaldo.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtSaldo.DisabledForeColor = System.Drawing.Color.White;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSaldo.Location = new System.Drawing.Point(16, 275);
            this.txtSaldo.MaxLength = 32767;
            this.txtSaldo.Multiline = false;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSaldo.PasswordChar = false;
            this.txtSaldo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSaldo.PlaceholderText = "";
            this.txtSaldo.Size = new System.Drawing.Size(100, 28);
            this.txtSaldo.TabIndex = 58;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaldo.Texts = "";
            this.txtSaldo.UnderlinedStyle = false;
            // 
            // txtPrecoUltCompra
            // 
            this.txtPrecoUltCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecoUltCompra.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrecoUltCompra.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtPrecoUltCompra.BorderRadius = 5;
            this.txtPrecoUltCompra.BorderSize = 1;
            this.txtPrecoUltCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoUltCompra.DisabledBackColor = System.Drawing.Color.White;
            this.txtPrecoUltCompra.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPrecoUltCompra.DisabledForeColor = System.Drawing.Color.White;
            this.txtPrecoUltCompra.Enabled = false;
            this.txtPrecoUltCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPrecoUltCompra.Location = new System.Drawing.Point(380, 275);
            this.txtPrecoUltCompra.MaxLength = 32767;
            this.txtPrecoUltCompra.Multiline = false;
            this.txtPrecoUltCompra.Name = "txtPrecoUltCompra";
            this.txtPrecoUltCompra.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPrecoUltCompra.PasswordChar = false;
            this.txtPrecoUltCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecoUltCompra.PlaceholderText = "";
            this.txtPrecoUltCompra.Size = new System.Drawing.Size(100, 28);
            this.txtPrecoUltCompra.TabIndex = 59;
            this.txtPrecoUltCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoUltCompra.Texts = "";
            this.txtPrecoUltCompra.UnderlinedStyle = false;
            // 
            // txtDataUltCompra
            // 
            this.txtDataUltCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataUltCompra.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataUltCompra.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataUltCompra.BorderRadius = 5;
            this.txtDataUltCompra.BorderSize = 1;
            this.txtDataUltCompra.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataUltCompra.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataUltCompra.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataUltCompra.Enabled = false;
            this.txtDataUltCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataUltCompra.Location = new System.Drawing.Point(500, 276);
            this.txtDataUltCompra.Mask = "00/00/0000";
            this.txtDataUltCompra.MaxLength = 32767;
            this.txtDataUltCompra.Multiline = false;
            this.txtDataUltCompra.Name = "txtDataUltCompra";
            this.txtDataUltCompra.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataUltCompra.PasswordChar = false;
            this.txtDataUltCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataUltCompra.PlaceholderText = "";
            this.txtDataUltCompra.Size = new System.Drawing.Size(88, 27);
            this.txtDataUltCompra.TabIndex = 60;
            this.txtDataUltCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataUltCompra.Texts = "  /  /";
            this.txtDataUltCompra.UnderlinedStyle = false;
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(608, 454);
            this.Controls.Add(this.txtDataUltCompra);
            this.Controls.Add(this.txtPrecoUltCompra);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCustoMedio);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.btnConsultaFornecedor);
            this.Controls.Add(this.btnConsultaModelos);
            this.Controls.Add(this.txtCodModelo);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblDataUltCompra);
            this.Controls.Add(this.lblPrecoUltCompra);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.lblCustoMedio);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCodModelol);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCodFornecedor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblUN);
            this.Controls.Add(this.lblProduto);
            this.Name = "CadastroProdutos";
            this.Text = "Cadastro de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroProdutos_FormClosed);
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            this.Controls.SetChildIndex(this.txtUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.lblUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblProduto, 0);
            this.Controls.SetChildIndex(this.lblUN, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.lblCodFornecedor, 0);
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.lblCodModelol, 0);
            this.Controls.SetChildIndex(this.lblSaldo, 0);
            this.Controls.SetChildIndex(this.lblCustoMedio, 0);
            this.Controls.SetChildIndex(this.lblPrecoVenda, 0);
            this.Controls.SetChildIndex(this.lblPrecoUltCompra, 0);
            this.Controls.SetChildIndex(this.lblDataUltCompra, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.txtProduto, 0);
            this.Controls.SetChildIndex(this.txtUN, 0);
            this.Controls.SetChildIndex(this.txtCodModelo, 0);
            this.Controls.SetChildIndex(this.btnConsultaModelos, 0);
            this.Controls.SetChildIndex(this.btnConsultaFornecedor, 0);
            this.Controls.SetChildIndex(this.txtCodFornecedor, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.txtPrecoVenda, 0);
            this.Controls.SetChildIndex(this.txtCustoMedio, 0);
            this.Controls.SetChildIndex(this.txtSaldo, 0);
            this.Controls.SetChildIndex(this.txtPrecoUltCompra, 0);
            this.Controls.SetChildIndex(this.txtDataUltCompra, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblCodFornecedor;
        private System.Windows.Forms.Label lblCodModelol;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblCustoMedio;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Label lblPrecoUltCompra;
        private System.Windows.Forms.Label lblDataUltCompra;
        private System.Windows.Forms.Label lblObservacao;
        private GControls.GTextBox txtUN;
        private GControls.GTextBox txtCodModelo;
        private GButtons btnConsultaModelos;
        private GButtons btnConsultaFornecedor;
        private GControls.GTextBox txtCodFornecedor;
        private GControls.GTextBox txtModelo;
        private GControls.GTextBox txtMarca;
        private GControls.GTextBox txtFornecedor;
        private GControls.GTextBox txtObservacao;
        private GControls.GTextBox txtPrecoVenda;
        private GControls.GTextBox txtCustoMedio;
        private GControls.GTextBox txtSaldo;
        private GControls.GTextBox txtPrecoUltCompra;
        protected GControls.GMaskedTextBox txtDataUltCompra;
        public GControls.GTextBox txtProduto;
    }
}
