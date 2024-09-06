namespace Sistema_Vendas.Views
{
    partial class CadastroOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroOS));
            this.gpTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new Sistema_Vendas.GControls.GTextBox();
            this.txtPorcentagemDesconto = new Sistema_Vendas.GControls.GTextBox();
            this.txtDesconto = new Sistema_Vendas.GControls.GTextBox();
            this.txtSubtotalServicos = new Sistema_Vendas.GControls.GTextBox();
            this.txtSubtotalProdutos = new Sistema_Vendas.GControls.GTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubTotalServicos = new System.Windows.Forms.Label();
            this.lblSubTotalProdutos = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.lblQtdeProduto = new System.Windows.Forms.Label();
            this.txtQtdeProduto = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaProduto = new Sistema_Vendas.GButtons();
            this.txtProduto = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodProduto = new Sistema_Vendas.GControls.GTextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUNProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProdutos = new Sistema_Vendas.GButtons();
            this.btnExcluirServico = new Sistema_Vendas.GButtons();
            this.tabDadosPrincipais = new System.Windows.Forms.TabPage();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new Sistema_Vendas.GControls.GTextBox();
            this.txtObservacao = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaFuncionario = new Sistema_Vendas.GButtons();
            this.txtFuncionario = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodFuncionario = new Sistema_Vendas.GControls.GTextBox();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.btnConsultaCliente = new Sistema_Vendas.GButtons();
            this.txtCliente = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodCliente = new Sistema_Vendas.GControls.GTextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabServicos = new System.Windows.Forms.TabPage();
            this.lblQtdeServico = new System.Windows.Forms.Label();
            this.txtQtdeServico = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaServico = new Sistema_Vendas.GButtons();
            this.txtServico = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodServico = new Sistema_Vendas.GControls.GTextBox();
            this.lblCodServico = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.dataGridViewServicos = new System.Windows.Forms.DataGridView();
            this.idServiço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serviço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUNServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddServico = new Sistema_Vendas.GButtons();
            this.tabCondPagamento = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddCondPag = new Sistema_Vendas.GButtons();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.numeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultaCondPag = new Sistema_Vendas.GButtons();
            this.txtCondPag = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodCondPag = new Sistema_Vendas.GControls.GTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataOS = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblDataOS = new System.Windows.Forms.Label();
            this.cbSituacao = new Sistema_Vendas.GControls.GComboBox();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.txtDataEntrega = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorPendente = new Sistema_Vendas.GControls.GTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorRetirada = new Sistema_Vendas.GControls.GTextBox();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.txtDataCancelamento = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblDataPrevista = new System.Windows.Forms.Label();
            this.txtDataPrevista = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.txtValorEntrada = new Sistema_Vendas.GControls.GTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcluirProduto = new Sistema_Vendas.GButtons();
            this.btnExcluirServicos = new Sistema_Vendas.GButtons();
            this.groupBox1.SuspendLayout();
            this.gpTotal.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.tabDadosPrincipais.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicos)).BeginInit();
            this.tabCondPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 431);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(101, 431);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(628, 18);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(16, 27);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(621, 447);
            this.btnSalvar.TabIndex = 23;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(702, 447);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 447);
            this.txtDataCadastro.Texts = "15/07/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(104, 447);
            this.txtDataUltAlt.Texts = "15/07/2024";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(13, 11);
            // 
            // gpTotal
            // 
            this.gpTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.gpTotal.Controls.Add(this.txtTotal);
            this.gpTotal.Controls.Add(this.txtPorcentagemDesconto);
            this.gpTotal.Controls.Add(this.txtDesconto);
            this.gpTotal.Controls.Add(this.txtSubtotalServicos);
            this.gpTotal.Controls.Add(this.txtSubtotalProdutos);
            this.gpTotal.Controls.Add(this.label1);
            this.gpTotal.Controls.Add(this.lblDesconto);
            this.gpTotal.Controls.Add(this.lblTotal);
            this.gpTotal.Controls.Add(this.lblSubTotalServicos);
            this.gpTotal.Controls.Add(this.lblSubTotalProdutos);
            this.gpTotal.Location = new System.Drawing.Point(628, 90);
            this.gpTotal.Name = "gpTotal";
            this.gpTotal.Size = new System.Drawing.Size(149, 334);
            this.gpTotal.TabIndex = 13;
            this.gpTotal.TabStop = false;
            this.gpTotal.Text = "Total Ordem de Serviço";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTotal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtTotal.BorderRadius = 5;
            this.txtTotal.BorderSize = 1;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.DisabledBackColor = System.Drawing.Color.White;
            this.txtTotal.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTotal.DisabledForeColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTotal.Location = new System.Drawing.Point(13, 250);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotal.PasswordChar = false;
            this.txtTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.Size = new System.Drawing.Size(124, 28);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.Texts = "";
            this.txtTotal.UnderlinedStyle = false;
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
            this.txtPorcentagemDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPorcentagemDesconto.Location = new System.Drawing.Point(13, 190);
            this.txtPorcentagemDesconto.MaxLength = 32767;
            this.txtPorcentagemDesconto.Multiline = false;
            this.txtPorcentagemDesconto.Name = "txtPorcentagemDesconto";
            this.txtPorcentagemDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPorcentagemDesconto.PasswordChar = false;
            this.txtPorcentagemDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPorcentagemDesconto.PlaceholderText = "";
            this.txtPorcentagemDesconto.Size = new System.Drawing.Size(56, 28);
            this.txtPorcentagemDesconto.TabIndex = 22;
            this.txtPorcentagemDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentagemDesconto.Texts = "";
            this.txtPorcentagemDesconto.UnderlinedStyle = false;
            this.txtPorcentagemDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentagemDesconto_KeyPress);
            this.txtPorcentagemDesconto.Leave += new System.EventHandler(this.txtPorcentagemDesconto_Leave);
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
            this.txtDesconto.Location = new System.Drawing.Point(81, 190);
            this.txtDesconto.MaxLength = 32767;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDesconto.PasswordChar = false;
            this.txtDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.PlaceholderText = "";
            this.txtDesconto.Size = new System.Drawing.Size(56, 28);
            this.txtDesconto.TabIndex = 14;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Texts = "";
            this.txtDesconto.UnderlinedStyle = false;
            // 
            // txtSubtotalServicos
            // 
            this.txtSubtotalServicos.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubtotalServicos.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSubtotalServicos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtSubtotalServicos.BorderRadius = 5;
            this.txtSubtotalServicos.BorderSize = 1;
            this.txtSubtotalServicos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubtotalServicos.DisabledBackColor = System.Drawing.Color.White;
            this.txtSubtotalServicos.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtSubtotalServicos.DisabledForeColor = System.Drawing.Color.White;
            this.txtSubtotalServicos.Enabled = false;
            this.txtSubtotalServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSubtotalServicos.Location = new System.Drawing.Point(13, 130);
            this.txtSubtotalServicos.MaxLength = 32767;
            this.txtSubtotalServicos.Multiline = false;
            this.txtSubtotalServicos.Name = "txtSubtotalServicos";
            this.txtSubtotalServicos.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSubtotalServicos.PasswordChar = false;
            this.txtSubtotalServicos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSubtotalServicos.PlaceholderText = "";
            this.txtSubtotalServicos.Size = new System.Drawing.Size(124, 28);
            this.txtSubtotalServicos.TabIndex = 13;
            this.txtSubtotalServicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotalServicos.Texts = "";
            this.txtSubtotalServicos.UnderlinedStyle = false;
            // 
            // txtSubtotalProdutos
            // 
            this.txtSubtotalProdutos.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubtotalProdutos.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSubtotalProdutos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtSubtotalProdutos.BorderRadius = 5;
            this.txtSubtotalProdutos.BorderSize = 1;
            this.txtSubtotalProdutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubtotalProdutos.DisabledBackColor = System.Drawing.Color.White;
            this.txtSubtotalProdutos.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtSubtotalProdutos.DisabledForeColor = System.Drawing.Color.White;
            this.txtSubtotalProdutos.Enabled = false;
            this.txtSubtotalProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSubtotalProdutos.Location = new System.Drawing.Point(13, 73);
            this.txtSubtotalProdutos.MaxLength = 32767;
            this.txtSubtotalProdutos.Multiline = false;
            this.txtSubtotalProdutos.Name = "txtSubtotalProdutos";
            this.txtSubtotalProdutos.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSubtotalProdutos.PasswordChar = false;
            this.txtSubtotalProdutos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSubtotalProdutos.PlaceholderText = "";
            this.txtSubtotalProdutos.Size = new System.Drawing.Size(124, 28);
            this.txtSubtotalProdutos.TabIndex = 12;
            this.txtSubtotalProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotalProdutos.Texts = "";
            this.txtSubtotalProdutos.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "% Desconto";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(78, 174);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(52, 13);
            this.lblDesconto.TabIndex = 8;
            this.lblDesconto.Text = "R$ Desc.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(10, 234);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // lblSubTotalServicos
            // 
            this.lblSubTotalServicos.AutoSize = true;
            this.lblSubTotalServicos.Location = new System.Drawing.Point(10, 114);
            this.lblSubTotalServicos.Name = "lblSubTotalServicos";
            this.lblSubTotalServicos.Size = new System.Drawing.Size(90, 13);
            this.lblSubTotalServicos.TabIndex = 4;
            this.lblSubTotalServicos.Text = "Subtotal Serviços";
            // 
            // lblSubTotalProdutos
            // 
            this.lblSubTotalProdutos.AutoSize = true;
            this.lblSubTotalProdutos.Location = new System.Drawing.Point(10, 57);
            this.lblSubTotalProdutos.Name = "lblSubTotalProdutos";
            this.lblSubTotalProdutos.Size = new System.Drawing.Size(91, 13);
            this.lblSubTotalProdutos.TabIndex = 2;
            this.lblSubTotalProdutos.Text = "Subtotal Produtos";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(437, 11);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(56, 13);
            this.lblSituacao.TabIndex = 15;
            this.lblSituacao.Text = "Situação *";
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.btnExcluirProduto);
            this.tabProdutos.Controls.Add(this.lblQtdeProduto);
            this.tabProdutos.Controls.Add(this.txtQtdeProduto);
            this.tabProdutos.Controls.Add(this.btnConsultaProduto);
            this.tabProdutos.Controls.Add(this.txtProduto);
            this.tabProdutos.Controls.Add(this.txtCodProduto);
            this.tabProdutos.Controls.Add(this.lblCodProduto);
            this.tabProdutos.Controls.Add(this.lblProduto);
            this.tabProdutos.Controls.Add(this.dataGridViewProdutos);
            this.tabProdutos.Controls.Add(this.btnAddProdutos);
            this.tabProdutos.Controls.Add(this.btnExcluirServico);
            this.tabProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdutos.Size = new System.Drawing.Size(591, 269);
            this.tabProdutos.TabIndex = 2;
            this.tabProdutos.Text = "Produtos";
            this.tabProdutos.UseVisualStyleBackColor = true;
            // 
            // lblQtdeProduto
            // 
            this.lblQtdeProduto.AutoSize = true;
            this.lblQtdeProduto.Location = new System.Drawing.Point(416, 15);
            this.lblQtdeProduto.Name = "lblQtdeProduto";
            this.lblQtdeProduto.Size = new System.Drawing.Size(69, 13);
            this.lblQtdeProduto.TabIndex = 111;
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
            this.txtQtdeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtQtdeProduto.Location = new System.Drawing.Point(419, 31);
            this.txtQtdeProduto.MaxLength = 32767;
            this.txtQtdeProduto.Multiline = false;
            this.txtQtdeProduto.Name = "txtQtdeProduto";
            this.txtQtdeProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtQtdeProduto.PasswordChar = false;
            this.txtQtdeProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQtdeProduto.PlaceholderText = "";
            this.txtQtdeProduto.Size = new System.Drawing.Size(66, 28);
            this.txtQtdeProduto.TabIndex = 105;
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
            this.btnConsultaProduto.FlatAppearance.BorderSize = 0;
            this.btnConsultaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaProduto.ForeColor = System.Drawing.Color.White;
            this.btnConsultaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaProduto.Image")));
            this.btnConsultaProduto.Location = new System.Drawing.Point(94, 31);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaProduto.TabIndex = 104;
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
            this.txtProduto.Location = new System.Drawing.Point(136, 31);
            this.txtProduto.MaxLength = 32767;
            this.txtProduto.Multiline = false;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtProduto.PasswordChar = false;
            this.txtProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProduto.PlaceholderText = "";
            this.txtProduto.Size = new System.Drawing.Size(270, 28);
            this.txtProduto.TabIndex = 110;
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
            this.txtCodProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodProduto.Location = new System.Drawing.Point(22, 31);
            this.txtCodProduto.MaxLength = 32767;
            this.txtCodProduto.Multiline = false;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodProduto.PasswordChar = false;
            this.txtCodProduto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodProduto.PlaceholderText = "";
            this.txtCodProduto.Size = new System.Drawing.Size(66, 28);
            this.txtCodProduto.TabIndex = 103;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodProduto.Texts = "";
            this.txtCodProduto.UnderlinedStyle = false;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(19, 15);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(69, 13);
            this.lblCodProduto.TabIndex = 109;
            this.lblCodProduto.Text = "Cód. Produto";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(133, 15);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 108;
            this.lblProduto.Text = "Produto";
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
            this.precoUNProd,
            this.quantidadeProduto,
            this.precoProduto});
            this.dataGridViewProdutos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(22, 68);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(550, 161);
            this.dataGridViewProdutos.TabIndex = 107;
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "Código";
            this.idProduto.Name = "idProduto";
            this.idProduto.Width = 80;
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.Width = 145;
            // 
            // precoUNProd
            // 
            this.precoUNProd.HeaderText = "Preço UN";
            this.precoUNProd.Name = "precoUNProd";
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.HeaderText = "Quantidade";
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.Width = 80;
            // 
            // precoProduto
            // 
            this.precoProduto.HeaderText = "Preço Total";
            this.precoProduto.Name = "precoProduto";
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
            this.btnAddProdutos.Location = new System.Drawing.Point(497, 31);
            this.btnAddProdutos.Name = "btnAddProdutos";
            this.btnAddProdutos.Size = new System.Drawing.Size(75, 28);
            this.btnAddProdutos.TabIndex = 106;
            this.btnAddProdutos.Text = "&Adicionar";
            this.btnAddProdutos.TextColor = System.Drawing.Color.White;
            this.btnAddProdutos.UseVisualStyleBackColor = false;
            this.btnAddProdutos.Click += new System.EventHandler(this.btnAddProdutos_Click);
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.BackColor = System.Drawing.Color.White;
            this.btnExcluirServico.BackgroundColor = System.Drawing.Color.White;
            this.btnExcluirServico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirServico.BorderRadius = 5;
            this.btnExcluirServico.BorderSize = 1;
            this.btnExcluirServico.FlatAppearance.BorderSize = 0;
            this.btnExcluirServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirServico.Location = new System.Drawing.Point(484, 279);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(86, 28);
            this.btnExcluirServico.TabIndex = 21;
            this.btnExcluirServico.Text = "Excluir Serviço";
            this.btnExcluirServico.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirServico.UseVisualStyleBackColor = false;
            this.btnExcluirServico.Click += new System.EventHandler(this.btnExcluirServico_Click);
            // 
            // tabDadosPrincipais
            // 
            this.tabDadosPrincipais.Controls.Add(this.lblCelular);
            this.tabDadosPrincipais.Controls.Add(this.txtCelular);
            this.tabDadosPrincipais.Controls.Add(this.txtObservacao);
            this.tabDadosPrincipais.Controls.Add(this.btnConsultaFuncionario);
            this.tabDadosPrincipais.Controls.Add(this.txtFuncionario);
            this.tabDadosPrincipais.Controls.Add(this.txtCodFuncionario);
            this.tabDadosPrincipais.Controls.Add(this.lblCodFuncionario);
            this.tabDadosPrincipais.Controls.Add(this.lblFuncionario);
            this.tabDadosPrincipais.Controls.Add(this.btnConsultaCliente);
            this.tabDadosPrincipais.Controls.Add(this.txtCliente);
            this.tabDadosPrincipais.Controls.Add(this.txtCodCliente);
            this.tabDadosPrincipais.Controls.Add(this.lblObservacao);
            this.tabDadosPrincipais.Controls.Add(this.lblCodCliente);
            this.tabDadosPrincipais.Controls.Add(this.lblCliente);
            this.tabDadosPrincipais.Location = new System.Drawing.Point(4, 22);
            this.tabDadosPrincipais.Name = "tabDadosPrincipais";
            this.tabDadosPrincipais.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosPrincipais.Size = new System.Drawing.Size(591, 269);
            this.tabDadosPrincipais.TabIndex = 0;
            this.tabDadosPrincipais.Text = "Dados Principais";
            this.tabDadosPrincipais.UseVisualStyleBackColor = true;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(417, 27);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 80;
            this.lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.Window;
            this.txtCelular.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCelular.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCelular.BorderRadius = 5;
            this.txtCelular.BorderSize = 1;
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.DisabledBackColor = System.Drawing.Color.White;
            this.txtCelular.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCelular.DisabledForeColor = System.Drawing.Color.White;
            this.txtCelular.Enabled = false;
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCelular.Location = new System.Drawing.Point(420, 43);
            this.txtCelular.MaxLength = 32767;
            this.txtCelular.Multiline = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCelular.PasswordChar = false;
            this.txtCelular.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCelular.PlaceholderText = "";
            this.txtCelular.Size = new System.Drawing.Size(144, 28);
            this.txtCelular.TabIndex = 79;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCelular.Texts = "";
            this.txtCelular.UnderlinedStyle = false;
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
            this.txtObservacao.Location = new System.Drawing.Point(27, 175);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtObservacao.PasswordChar = false;
            this.txtObservacao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservacao.PlaceholderText = "";
            this.txtObservacao.Size = new System.Drawing.Size(537, 63);
            this.txtObservacao.TabIndex = 9;
            this.txtObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacao.Texts = "";
            this.txtObservacao.UnderlinedStyle = false;
            // 
            // btnConsultaFuncionario
            // 
            this.btnConsultaFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaFuncionario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaFuncionario.BorderRadius = 5;
            this.btnConsultaFuncionario.BorderSize = 1;
            this.btnConsultaFuncionario.FlatAppearance.BorderSize = 0;
            this.btnConsultaFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnConsultaFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaFuncionario.Image")));
            this.btnConsultaFuncionario.Location = new System.Drawing.Point(124, 105);
            this.btnConsultaFuncionario.Name = "btnConsultaFuncionario";
            this.btnConsultaFuncionario.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaFuncionario.TabIndex = 8;
            this.btnConsultaFuncionario.TextColor = System.Drawing.Color.White;
            this.btnConsultaFuncionario.UseVisualStyleBackColor = false;
            this.btnConsultaFuncionario.Click += new System.EventHandler(this.btnConsultaFuncionario_Click);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.BackColor = System.Drawing.SystemColors.Window;
            this.txtFuncionario.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFuncionario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtFuncionario.BorderRadius = 5;
            this.txtFuncionario.BorderSize = 1;
            this.txtFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncionario.DisabledBackColor = System.Drawing.Color.White;
            this.txtFuncionario.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtFuncionario.DisabledForeColor = System.Drawing.Color.White;
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFuncionario.Location = new System.Drawing.Point(166, 105);
            this.txtFuncionario.MaxLength = 32767;
            this.txtFuncionario.Multiline = false;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFuncionario.PasswordChar = false;
            this.txtFuncionario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFuncionario.PlaceholderText = "";
            this.txtFuncionario.Size = new System.Drawing.Size(398, 28);
            this.txtFuncionario.TabIndex = 76;
            this.txtFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFuncionario.Texts = "";
            this.txtFuncionario.UnderlinedStyle = false;
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodFuncionario.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodFuncionario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodFuncionario.BorderRadius = 5;
            this.txtCodFuncionario.BorderSize = 1;
            this.txtCodFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFuncionario.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodFuncionario.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodFuncionario.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodFuncionario.Location = new System.Drawing.Point(27, 105);
            this.txtCodFuncionario.MaxLength = 32767;
            this.txtCodFuncionario.Multiline = false;
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodFuncionario.PasswordChar = false;
            this.txtCodFuncionario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodFuncionario.PlaceholderText = "";
            this.txtCodFuncionario.Size = new System.Drawing.Size(91, 28);
            this.txtCodFuncionario.TabIndex = 7;
            this.txtCodFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFuncionario.Texts = "";
            this.txtCodFuncionario.UnderlinedStyle = false;
            this.txtCodFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFuncionario_KeyPress);
            this.txtCodFuncionario.Leave += new System.EventHandler(this.txtCodFuncionario_Leave);
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Location = new System.Drawing.Point(24, 89);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(94, 13);
            this.lblCodFuncionario.TabIndex = 74;
            this.lblCodFuncionario.Text = "Cód. Funcionário *";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(163, 89);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 73;
            this.lblFuncionario.Text = "Funcionário";
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
            this.btnConsultaCliente.Location = new System.Drawing.Point(124, 43);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaCliente.TabIndex = 6;
            this.btnConsultaCliente.TextColor = System.Drawing.Color.White;
            this.btnConsultaCliente.UseVisualStyleBackColor = false;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
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
            this.txtCliente.Location = new System.Drawing.Point(166, 43);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCliente.PasswordChar = false;
            this.txtCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCliente.PlaceholderText = "";
            this.txtCliente.Size = new System.Drawing.Size(239, 28);
            this.txtCliente.TabIndex = 71;
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
            this.txtCodCliente.Location = new System.Drawing.Point(27, 43);
            this.txtCodCliente.MaxLength = 32767;
            this.txtCodCliente.Multiline = false;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodCliente.PasswordChar = false;
            this.txtCodCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodCliente.PlaceholderText = "";
            this.txtCodCliente.Size = new System.Drawing.Size(91, 28);
            this.txtCodCliente.TabIndex = 5;
            this.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCliente.Texts = "";
            this.txtCodCliente.UnderlinedStyle = false;
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(24, 159);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 68;
            this.lblObservacao.Text = "Observação";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(24, 27);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(71, 13);
            this.lblCodCliente.TabIndex = 62;
            this.lblCodCliente.Text = "Cód. Cliente *";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(163, 27);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 61;
            this.lblCliente.Text = "Cliente";
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabDadosPrincipais);
            this.tabPrincipal.Controls.Add(this.tabProdutos);
            this.tabPrincipal.Controls.Add(this.tabServicos);
            this.tabPrincipal.Controls.Add(this.tabCondPagamento);
            this.tabPrincipal.Location = new System.Drawing.Point(16, 73);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(599, 295);
            this.tabPrincipal.TabIndex = 16;
            // 
            // tabServicos
            // 
            this.tabServicos.Controls.Add(this.btnExcluirServicos);
            this.tabServicos.Controls.Add(this.lblQtdeServico);
            this.tabServicos.Controls.Add(this.txtQtdeServico);
            this.tabServicos.Controls.Add(this.btnConsultaServico);
            this.tabServicos.Controls.Add(this.txtServico);
            this.tabServicos.Controls.Add(this.txtCodServico);
            this.tabServicos.Controls.Add(this.lblCodServico);
            this.tabServicos.Controls.Add(this.lblServico);
            this.tabServicos.Controls.Add(this.dataGridViewServicos);
            this.tabServicos.Controls.Add(this.btnAddServico);
            this.tabServicos.Location = new System.Drawing.Point(4, 22);
            this.tabServicos.Name = "tabServicos";
            this.tabServicos.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicos.Size = new System.Drawing.Size(591, 269);
            this.tabServicos.TabIndex = 3;
            this.tabServicos.Text = "Serviços";
            this.tabServicos.UseVisualStyleBackColor = true;
            // 
            // lblQtdeServico
            // 
            this.lblQtdeServico.AutoSize = true;
            this.lblQtdeServico.Location = new System.Drawing.Point(416, 14);
            this.lblQtdeServico.Name = "lblQtdeServico";
            this.lblQtdeServico.Size = new System.Drawing.Size(69, 13);
            this.lblQtdeServico.TabIndex = 102;
            this.lblQtdeServico.Text = "Quantidade *";
            // 
            // txtQtdeServico
            // 
            this.txtQtdeServico.BackColor = System.Drawing.SystemColors.Window;
            this.txtQtdeServico.BorderColor = System.Drawing.Color.DarkGray;
            this.txtQtdeServico.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtQtdeServico.BorderRadius = 5;
            this.txtQtdeServico.BorderSize = 1;
            this.txtQtdeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeServico.DisabledBackColor = System.Drawing.Color.White;
            this.txtQtdeServico.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtQtdeServico.DisabledForeColor = System.Drawing.Color.White;
            this.txtQtdeServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtQtdeServico.Location = new System.Drawing.Point(419, 30);
            this.txtQtdeServico.MaxLength = 32767;
            this.txtQtdeServico.Multiline = false;
            this.txtQtdeServico.Name = "txtQtdeServico";
            this.txtQtdeServico.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtQtdeServico.PasswordChar = false;
            this.txtQtdeServico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQtdeServico.PlaceholderText = "";
            this.txtQtdeServico.Size = new System.Drawing.Size(66, 28);
            this.txtQtdeServico.TabIndex = 96;
            this.txtQtdeServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtdeServico.Texts = "";
            this.txtQtdeServico.UnderlinedStyle = false;
            this.txtQtdeServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeServico_KeyPress);
            // 
            // btnConsultaServico
            // 
            this.btnConsultaServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaServico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaServico.BorderRadius = 5;
            this.btnConsultaServico.BorderSize = 1;
            this.btnConsultaServico.FlatAppearance.BorderSize = 0;
            this.btnConsultaServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaServico.ForeColor = System.Drawing.Color.White;
            this.btnConsultaServico.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaServico.Image")));
            this.btnConsultaServico.Location = new System.Drawing.Point(94, 30);
            this.btnConsultaServico.Name = "btnConsultaServico";
            this.btnConsultaServico.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaServico.TabIndex = 95;
            this.btnConsultaServico.TextColor = System.Drawing.Color.White;
            this.btnConsultaServico.UseVisualStyleBackColor = false;
            this.btnConsultaServico.Click += new System.EventHandler(this.btnConsultaServico_Click);
            // 
            // txtServico
            // 
            this.txtServico.BackColor = System.Drawing.SystemColors.Window;
            this.txtServico.BorderColor = System.Drawing.Color.DarkGray;
            this.txtServico.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtServico.BorderRadius = 5;
            this.txtServico.BorderSize = 1;
            this.txtServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServico.DisabledBackColor = System.Drawing.Color.White;
            this.txtServico.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtServico.DisabledForeColor = System.Drawing.Color.White;
            this.txtServico.Enabled = false;
            this.txtServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtServico.Location = new System.Drawing.Point(136, 30);
            this.txtServico.MaxLength = 32767;
            this.txtServico.Multiline = false;
            this.txtServico.Name = "txtServico";
            this.txtServico.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtServico.PasswordChar = false;
            this.txtServico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtServico.PlaceholderText = "";
            this.txtServico.Size = new System.Drawing.Size(270, 28);
            this.txtServico.TabIndex = 101;
            this.txtServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServico.Texts = "";
            this.txtServico.UnderlinedStyle = false;
            // 
            // txtCodServico
            // 
            this.txtCodServico.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodServico.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodServico.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodServico.BorderRadius = 5;
            this.txtCodServico.BorderSize = 1;
            this.txtCodServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodServico.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodServico.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodServico.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodServico.Location = new System.Drawing.Point(22, 30);
            this.txtCodServico.MaxLength = 32767;
            this.txtCodServico.Multiline = false;
            this.txtCodServico.Name = "txtCodServico";
            this.txtCodServico.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodServico.PasswordChar = false;
            this.txtCodServico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodServico.PlaceholderText = "";
            this.txtCodServico.Size = new System.Drawing.Size(66, 28);
            this.txtCodServico.TabIndex = 94;
            this.txtCodServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodServico.Texts = "";
            this.txtCodServico.UnderlinedStyle = false;
            this.txtCodServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodServico_KeyPress);
            this.txtCodServico.Leave += new System.EventHandler(this.txtCodServico_Leave);
            // 
            // lblCodServico
            // 
            this.lblCodServico.AutoSize = true;
            this.lblCodServico.Location = new System.Drawing.Point(19, 14);
            this.lblCodServico.Name = "lblCodServico";
            this.lblCodServico.Size = new System.Drawing.Size(75, 13);
            this.lblCodServico.TabIndex = 100;
            this.lblCodServico.Text = "Cód. Serviço *";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(133, 14);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 99;
            this.lblServico.Text = "Serviço";
            // 
            // dataGridViewServicos
            // 
            this.dataGridViewServicos.AllowUserToAddRows = false;
            this.dataGridViewServicos.AllowUserToResizeColumns = false;
            this.dataGridViewServicos.AllowUserToResizeRows = false;
            this.dataGridViewServicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiço,
            this.Serviço,
            this.precoUNServ,
            this.quantidadeServico,
            this.precoServico});
            this.dataGridViewServicos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewServicos.Location = new System.Drawing.Point(22, 68);
            this.dataGridViewServicos.Name = "dataGridViewServicos";
            this.dataGridViewServicos.Size = new System.Drawing.Size(550, 161);
            this.dataGridViewServicos.TabIndex = 98;
            // 
            // idServiço
            // 
            this.idServiço.HeaderText = "Código";
            this.idServiço.Name = "idServiço";
            this.idServiço.Width = 80;
            // 
            // Serviço
            // 
            this.Serviço.HeaderText = "Serviço";
            this.Serviço.Name = "Serviço";
            this.Serviço.Width = 145;
            // 
            // precoUNServ
            // 
            this.precoUNServ.HeaderText = "Preço UN";
            this.precoUNServ.Name = "precoUNServ";
            // 
            // quantidadeServico
            // 
            this.quantidadeServico.HeaderText = "Quantidade";
            this.quantidadeServico.Name = "quantidadeServico";
            this.quantidadeServico.Width = 80;
            // 
            // precoServico
            // 
            this.precoServico.HeaderText = "Preço Total";
            this.precoServico.Name = "precoServico";
            // 
            // btnAddServico
            // 
            this.btnAddServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddServico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnAddServico.BorderRadius = 5;
            this.btnAddServico.BorderSize = 1;
            this.btnAddServico.FlatAppearance.BorderSize = 0;
            this.btnAddServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServico.ForeColor = System.Drawing.Color.White;
            this.btnAddServico.Location = new System.Drawing.Point(497, 30);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Size = new System.Drawing.Size(75, 28);
            this.btnAddServico.TabIndex = 97;
            this.btnAddServico.Text = "&Adicionar";
            this.btnAddServico.TextColor = System.Drawing.Color.White;
            this.btnAddServico.UseVisualStyleBackColor = false;
            this.btnAddServico.Click += new System.EventHandler(this.btnAddServico_Click);
            // 
            // tabCondPagamento
            // 
            this.tabCondPagamento.Controls.Add(this.label6);
            this.tabCondPagamento.Controls.Add(this.btnAddCondPag);
            this.tabCondPagamento.Controls.Add(this.dataGridViewParcelas);
            this.tabCondPagamento.Controls.Add(this.btnConsultaCondPag);
            this.tabCondPagamento.Controls.Add(this.txtCondPag);
            this.tabCondPagamento.Controls.Add(this.txtCodCondPag);
            this.tabCondPagamento.Controls.Add(this.label5);
            this.tabCondPagamento.Location = new System.Drawing.Point(4, 22);
            this.tabCondPagamento.Name = "tabCondPagamento";
            this.tabCondPagamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabCondPagamento.Size = new System.Drawing.Size(591, 269);
            this.tabCondPagamento.TabIndex = 4;
            this.tabCondPagamento.Text = "Condição de Pagamento";
            this.tabCondPagamento.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 137;
            this.label6.Text = "Código*";
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
            this.btnAddCondPag.Location = new System.Drawing.Point(500, 29);
            this.btnAddCondPag.Name = "btnAddCondPag";
            this.btnAddCondPag.Size = new System.Drawing.Size(75, 28);
            this.btnAddCondPag.TabIndex = 133;
            this.btnAddCondPag.Text = "&Adicionar";
            this.btnAddCondPag.TextColor = System.Drawing.Color.White;
            this.btnAddCondPag.UseVisualStyleBackColor = false;
            this.btnAddCondPag.Click += new System.EventHandler(this.btnAddCondPag_Click);
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
            this.dataGridViewParcelas.Location = new System.Drawing.Point(18, 69);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.ReadOnly = true;
            this.dataGridViewParcelas.Size = new System.Drawing.Size(557, 186);
            this.dataGridViewParcelas.TabIndex = 136;
            // 
            // numeroParcela
            // 
            this.numeroParcela.HeaderText = "Parcela";
            this.numeroParcela.Name = "numeroParcela";
            this.numeroParcela.ReadOnly = true;
            this.numeroParcela.Width = 80;
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
            this.dataVencimento.Width = 85;
            // 
            // valorParcela
            // 
            this.valorParcela.HeaderText = "Valor Parcela";
            this.valorParcela.Name = "valorParcela";
            this.valorParcela.ReadOnly = true;
            this.valorParcela.Width = 80;
            // 
            // btnConsultaCondPag
            // 
            this.btnConsultaCondPag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaCondPag.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaCondPag.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaCondPag.BorderRadius = 5;
            this.btnConsultaCondPag.BorderSize = 1;
            this.btnConsultaCondPag.FlatAppearance.BorderSize = 0;
            this.btnConsultaCondPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCondPag.ForeColor = System.Drawing.Color.White;
            this.btnConsultaCondPag.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaCondPag.Image")));
            this.btnConsultaCondPag.Location = new System.Drawing.Point(90, 29);
            this.btnConsultaCondPag.Name = "btnConsultaCondPag";
            this.btnConsultaCondPag.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaCondPag.TabIndex = 132;
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
            this.txtCondPag.Location = new System.Drawing.Point(132, 29);
            this.txtCondPag.MaxLength = 14;
            this.txtCondPag.Multiline = false;
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCondPag.PasswordChar = false;
            this.txtCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCondPag.PlaceholderText = "";
            this.txtCondPag.Size = new System.Drawing.Size(362, 28);
            this.txtCondPag.TabIndex = 135;
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
            this.txtCodCondPag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodCondPag.Location = new System.Drawing.Point(18, 29);
            this.txtCodCondPag.MaxLength = 14;
            this.txtCodCondPag.Multiline = false;
            this.txtCodCondPag.Name = "txtCodCondPag";
            this.txtCodCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodCondPag.PasswordChar = false;
            this.txtCodCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodCondPag.PlaceholderText = "";
            this.txtCodCondPag.Size = new System.Drawing.Size(66, 28);
            this.txtCodCondPag.TabIndex = 131;
            this.txtCodCondPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCondPag.Texts = "";
            this.txtCodCondPag.UnderlinedStyle = false;
            this.txtCodCondPag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCondPag_KeyPress);
            this.txtCodCondPag.Leave += new System.EventHandler(this.txtCodCondPag_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "Condição de Pagamento";
            // 
            // txtDataOS
            // 
            this.txtDataOS.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataOS.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataOS.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataOS.BorderRadius = 5;
            this.txtDataOS.BorderSize = 1;
            this.txtDataOS.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataOS.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataOS.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataOS.Location = new System.Drawing.Point(130, 28);
            this.txtDataOS.Mask = "00/00/0000";
            this.txtDataOS.MaxLength = 32767;
            this.txtDataOS.Multiline = false;
            this.txtDataOS.Name = "txtDataOS";
            this.txtDataOS.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataOS.PasswordChar = false;
            this.txtDataOS.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataOS.PlaceholderText = "";
            this.txtDataOS.Size = new System.Drawing.Size(92, 27);
            this.txtDataOS.TabIndex = 130;
            this.txtDataOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataOS.Texts = "  /  /";
            this.txtDataOS.UnderlinedStyle = false;
            this.txtDataOS.Leave += new System.EventHandler(this.txtDataOS_Leave);
            // 
            // lblDataOS
            // 
            this.lblDataOS.AutoSize = true;
            this.lblDataOS.Location = new System.Drawing.Point(127, 12);
            this.lblDataOS.Name = "lblDataOS";
            this.lblDataOS.Size = new System.Drawing.Size(37, 13);
            this.lblDataOS.TabIndex = 36;
            this.lblDataOS.Text = "Data *";
            // 
            // cbSituacao
            // 
            this.cbSituacao.BackColor = System.Drawing.Color.White;
            this.cbSituacao.BorderColor = System.Drawing.Color.DarkGray;
            this.cbSituacao.BorderRadius = 5;
            this.cbSituacao.BorderSize = 1;
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbSituacao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.cbSituacao.Items.AddRange(new object[] {
            "PENDENTE",
            "EM ANDAMENTO",
            "PRONTO",
            "RETIRADO",
            "CANCELADO"});
            this.cbSituacao.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cbSituacao.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbSituacao.Location = new System.Drawing.Point(440, 26);
            this.cbSituacao.MinimumSize = new System.Drawing.Size(100, 28);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.cbSituacao.Size = new System.Drawing.Size(171, 28);
            this.cbSituacao.TabIndex = 3;
            this.cbSituacao.Texts = "";
            this.cbSituacao.OnSelectedIndexChanged += new System.EventHandler(this.cbSituacao_OnSelectedIndexChanged);
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(329, 12);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(70, 13);
            this.lblDataEntrega.TabIndex = 123;
            this.lblDataEntrega.Text = "Data Entrega";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEntrega.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataEntrega.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataEntrega.BorderRadius = 5;
            this.txtDataEntrega.BorderSize = 1;
            this.txtDataEntrega.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataEntrega.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataEntrega.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataEntrega.Enabled = false;
            this.txtDataEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataEntrega.Location = new System.Drawing.Point(332, 28);
            this.txtDataEntrega.Mask = "00/00/0000";
            this.txtDataEntrega.MaxLength = 32767;
            this.txtDataEntrega.Multiline = false;
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataEntrega.PasswordChar = false;
            this.txtDataEntrega.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataEntrega.PlaceholderText = "";
            this.txtDataEntrega.Size = new System.Drawing.Size(92, 27);
            this.txtDataEntrega.TabIndex = 2;
            this.txtDataEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataEntrega.Texts = "  /  /";
            this.txtDataEntrega.UnderlinedStyle = false;
            this.txtDataEntrega.Leave += new System.EventHandler(this.txtDataEntrega_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Valor Retirada";
            // 
            // txtValorPendente
            // 
            this.txtValorPendente.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorPendente.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorPendente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtValorPendente.BorderRadius = 5;
            this.txtValorPendente.BorderSize = 1;
            this.txtValorPendente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorPendente.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorPendente.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorPendente.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorPendente.Enabled = false;
            this.txtValorPendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorPendente.Location = new System.Drawing.Point(518, 396);
            this.txtValorPendente.MaxLength = 32767;
            this.txtValorPendente.Multiline = false;
            this.txtValorPendente.Name = "txtValorPendente";
            this.txtValorPendente.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorPendente.PasswordChar = false;
            this.txtValorPendente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorPendente.PlaceholderText = "";
            this.txtValorPendente.Size = new System.Drawing.Size(97, 28);
            this.txtValorPendente.TabIndex = 125;
            this.txtValorPendente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPendente.Texts = "";
            this.txtValorPendente.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "Valor Pendente";
            // 
            // txtValorRetirada
            // 
            this.txtValorRetirada.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorRetirada.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorRetirada.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtValorRetirada.BorderRadius = 5;
            this.txtValorRetirada.BorderSize = 1;
            this.txtValorRetirada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorRetirada.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorRetirada.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorRetirada.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorRetirada.Enabled = false;
            this.txtValorRetirada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorRetirada.Location = new System.Drawing.Point(405, 396);
            this.txtValorRetirada.MaxLength = 32767;
            this.txtValorRetirada.Multiline = false;
            this.txtValorRetirada.Name = "txtValorRetirada";
            this.txtValorRetirada.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorRetirada.PasswordChar = false;
            this.txtValorRetirada.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorRetirada.PlaceholderText = "";
            this.txtValorRetirada.Size = new System.Drawing.Size(97, 28);
            this.txtValorRetirada.TabIndex = 126;
            this.txtValorRetirada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorRetirada.Texts = "";
            this.txtValorRetirada.UnderlinedStyle = false;
            this.txtValorRetirada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorRetirada_KeyPress);
            this.txtValorRetirada.Leave += new System.EventHandler(this.txtValorRetirada_Leave);
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataCancelamento.Location = new System.Drawing.Point(13, 380);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(101, 13);
            this.lblDataCancelamento.TabIndex = 129;
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
            this.txtDataCancelamento.Location = new System.Drawing.Point(16, 396);
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
            // lblDataPrevista
            // 
            this.lblDataPrevista.AutoSize = true;
            this.lblDataPrevista.Location = new System.Drawing.Point(229, 12);
            this.lblDataPrevista.Name = "lblDataPrevista";
            this.lblDataPrevista.Size = new System.Drawing.Size(78, 13);
            this.lblDataPrevista.TabIndex = 131;
            this.lblDataPrevista.Text = "Data Prevista *";
            // 
            // txtDataPrevista
            // 
            this.txtDataPrevista.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataPrevista.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataPrevista.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataPrevista.BorderRadius = 5;
            this.txtDataPrevista.BorderSize = 1;
            this.txtDataPrevista.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataPrevista.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDataPrevista.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataPrevista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDataPrevista.Location = new System.Drawing.Point(232, 28);
            this.txtDataPrevista.Mask = "00/00/0000";
            this.txtDataPrevista.MaxLength = 32767;
            this.txtDataPrevista.Multiline = false;
            this.txtDataPrevista.Name = "txtDataPrevista";
            this.txtDataPrevista.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataPrevista.PasswordChar = false;
            this.txtDataPrevista.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataPrevista.PlaceholderText = "";
            this.txtDataPrevista.Size = new System.Drawing.Size(92, 27);
            this.txtDataPrevista.TabIndex = 1;
            this.txtDataPrevista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataPrevista.Texts = "  /  /";
            this.txtDataPrevista.UnderlinedStyle = false;
            this.txtDataPrevista.Leave += new System.EventHandler(this.txtDataPrevista_Leave);
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorEntrada.BorderColor = System.Drawing.Color.DarkGray;
            this.txtValorEntrada.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtValorEntrada.BorderRadius = 5;
            this.txtValorEntrada.BorderSize = 1;
            this.txtValorEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorEntrada.DisabledBackColor = System.Drawing.Color.White;
            this.txtValorEntrada.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtValorEntrada.DisabledForeColor = System.Drawing.Color.White;
            this.txtValorEntrada.Enabled = false;
            this.txtValorEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtValorEntrada.Location = new System.Drawing.Point(291, 395);
            this.txtValorEntrada.MaxLength = 32767;
            this.txtValorEntrada.Multiline = false;
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtValorEntrada.PasswordChar = false;
            this.txtValorEntrada.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorEntrada.PlaceholderText = "";
            this.txtValorEntrada.Size = new System.Drawing.Size(97, 28);
            this.txtValorEntrada.TabIndex = 133;
            this.txtValorEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorEntrada.Texts = "";
            this.txtValorEntrada.UnderlinedStyle = false;
            this.txtValorEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorEntrada_KeyPress);
            this.txtValorEntrada.Leave += new System.EventHandler(this.txtValorEntrada_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 132;
            this.label4.Text = "Valor Entrada";
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
            this.btnExcluirProduto.Location = new System.Drawing.Point(486, 235);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(86, 28);
            this.btnExcluirProduto.TabIndex = 162;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnExcluirServicos
            // 
            this.btnExcluirServicos.BackColor = System.Drawing.Color.White;
            this.btnExcluirServicos.BackgroundColor = System.Drawing.Color.White;
            this.btnExcluirServicos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirServicos.BorderRadius = 5;
            this.btnExcluirServicos.BorderSize = 1;
            this.btnExcluirServicos.FlatAppearance.BorderSize = 0;
            this.btnExcluirServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirServicos.Location = new System.Drawing.Point(486, 235);
            this.btnExcluirServicos.Name = "btnExcluirServicos";
            this.btnExcluirServicos.Size = new System.Drawing.Size(86, 28);
            this.btnExcluirServicos.TabIndex = 214;
            this.btnExcluirServicos.Text = "Excluir Serviço";
            this.btnExcluirServicos.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirServicos.UseVisualStyleBackColor = false;
            this.btnExcluirServicos.Click += new System.EventHandler(this.btnExcluirServicos_Click);
            // 
            // CadastroOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDataPrevista);
            this.Controls.Add(this.txtDataPrevista);
            this.Controls.Add(this.lblDataCancelamento);
            this.Controls.Add(this.txtDataCancelamento);
            this.Controls.Add(this.txtValorRetirada);
            this.Controls.Add(this.txtValorPendente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.lblDataOS);
            this.Controls.Add(this.txtDataOS);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.gpTotal);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "CadastroOS";
            this.Text = "Cadastro Ordem de Serviço ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroOS_FormClosed);
            this.Load += new System.EventHandler(this.CadastroOS_Load);
            this.Controls.SetChildIndex(this.tabPrincipal, 0);
            this.Controls.SetChildIndex(this.gpTotal, 0);
            this.Controls.SetChildIndex(this.lblSituacao, 0);
            this.Controls.SetChildIndex(this.txtDataOS, 0);
            this.Controls.SetChildIndex(this.lblDataOS, 0);
            this.Controls.SetChildIndex(this.cbSituacao, 0);
            this.Controls.SetChildIndex(this.txtDataEntrega, 0);
            this.Controls.SetChildIndex(this.lblDataEntrega, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtValorPendente, 0);
            this.Controls.SetChildIndex(this.txtValorRetirada, 0);
            this.Controls.SetChildIndex(this.txtDataCancelamento, 0);
            this.Controls.SetChildIndex(this.lblDataCancelamento, 0);
            this.Controls.SetChildIndex(this.txtDataPrevista, 0);
            this.Controls.SetChildIndex(this.lblDataPrevista, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtValorEntrada, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
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
            this.gpTotal.ResumeLayout(false);
            this.gpTotal.PerformLayout();
            this.tabProdutos.ResumeLayout(false);
            this.tabProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.tabDadosPrincipais.ResumeLayout(false);
            this.tabDadosPrincipais.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.tabServicos.ResumeLayout(false);
            this.tabServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicos)).EndInit();
            this.tabCondPagamento.ResumeLayout(false);
            this.tabCondPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpTotal;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotalServicos;
        private System.Windows.Forms.Label lblSubTotalProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TabPage tabProdutos;
        private System.Windows.Forms.TabPage tabDadosPrincipais;
        protected System.Windows.Forms.Label lblObservacao;
        protected System.Windows.Forms.Label lblCodCliente;
        protected System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TabControl tabPrincipal;
        private GControls.GTextBox txtCliente;
        private GButtons btnConsultaCliente;
        private GButtons btnConsultaFuncionario;
        private GControls.GTextBox txtFuncionario;
        private GControls.GTextBox txtCodFuncionario;
        protected System.Windows.Forms.Label lblCodFuncionario;
        protected System.Windows.Forms.Label lblFuncionario;
        private GControls.GTextBox txtObservacao;
        private GControls.GMaskedTextBox txtDataOS;
        private System.Windows.Forms.Label lblDataOS;
        private GControls.GTextBox txtDesconto;
        private GControls.GTextBox txtSubtotalServicos;
        private GControls.GTextBox txtSubtotalProdutos;
        private GControls.GTextBox txtTotal;
        private GControls.GTextBox txtPorcentagemDesconto;
        private GControls.GTextBox txtCelular;
        protected System.Windows.Forms.Label lblCelular;
        protected GControls.GComboBox cbSituacao;
        private System.Windows.Forms.Label lblDataEntrega;
        private GControls.GMaskedTextBox txtDataEntrega;
        public GControls.GTextBox txtCodCliente;
        public GButtons btnExcluirServico;
        private System.Windows.Forms.Label label2;
        private GControls.GTextBox txtValorPendente;
        private System.Windows.Forms.Label label3;
        private GControls.GTextBox txtValorRetirada;
        public System.Windows.Forms.Label lblDataCancelamento;
        public GControls.GMaskedTextBox txtDataCancelamento;
        private System.Windows.Forms.Label lblDataPrevista;
        private GControls.GMaskedTextBox txtDataPrevista;
        private GControls.GTextBox txtValorEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabServicos;
        protected System.Windows.Forms.Label lblQtdeProduto;
        private GControls.GTextBox txtQtdeProduto;
        private GButtons btnConsultaProduto;
        private GControls.GTextBox txtProduto;
        private GControls.GTextBox txtCodProduto;
        protected System.Windows.Forms.Label lblCodProduto;
        protected System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUNProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProduto;
        protected GButtons btnAddProdutos;
        protected System.Windows.Forms.Label lblQtdeServico;
        private GControls.GTextBox txtQtdeServico;
        private GButtons btnConsultaServico;
        private GControls.GTextBox txtServico;
        private GControls.GTextBox txtCodServico;
        protected System.Windows.Forms.Label lblCodServico;
        protected System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.DataGridView dataGridViewServicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serviço;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUNServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoServico;
        protected GButtons btnAddServico;
        private System.Windows.Forms.TabPage tabCondPagamento;
        protected System.Windows.Forms.Label label6;
        protected GButtons btnAddCondPag;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        protected GButtons btnConsultaCondPag;
        protected GControls.GTextBox txtCondPag;
        protected GControls.GTextBox txtCodCondPag;
        protected System.Windows.Forms.Label label5;
        public GButtons btnExcluirProduto;
        public GButtons btnExcluirServicos;
    }
}
