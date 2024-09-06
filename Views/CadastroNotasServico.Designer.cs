namespace Sistema_Vendas.Views
{
    partial class CadastroNotasServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroNotasServico));
            this.txtPorcentagemDesconto = new Sistema_Vendas.GControls.GTextBox();
            this.txtTotalPagar = new Sistema_Vendas.GControls.GTextBox();
            this.txtDesconto = new Sistema_Vendas.GControls.GTextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new Sistema_Vendas.GControls.GTextBox();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.numeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCondPag = new Sistema_Vendas.GButtons();
            this.btnExcluirServico = new Sistema_Vendas.GButtons();
            this.btnConsultaCondPag = new Sistema_Vendas.GButtons();
            this.txtCondPag = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodCondPag = new Sistema_Vendas.GControls.GTextBox();
            this.lblCondPag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.txtTotalServicos = new Sistema_Vendas.GControls.GTextBox();
            this.dataGridViewServicos = new System.Windows.Forms.DataGridView();
            this.idServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrecoServico = new System.Windows.Forms.Label();
            this.txtPrecoServico = new Sistema_Vendas.GControls.GTextBox();
            this.lblQtdeServico = new System.Windows.Forms.Label();
            this.txtQtdeServico = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaServico = new Sistema_Vendas.GButtons();
            this.txtServico = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodServico = new Sistema_Vendas.GControls.GTextBox();
            this.lblCodServico = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.btnAddServico = new Sistema_Vendas.GButtons();
            this.lblDataCancelamento = new System.Windows.Forms.Label();
            this.txtDataCancelamento = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblCancelada = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.txtDataEmissao = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblNroNota = new System.Windows.Forms.Label();
            this.txtModelo = new Sistema_Vendas.GControls.GTextBox();
            this.txtCliente = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodCliente = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaCliente = new Sistema_Vendas.GButtons();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtSerie = new Sistema_Vendas.GControls.GTextBox();
            this.txtNroNota = new Sistema_Vendas.GControls.GTextBox();
            this.btnCancelar = new Sistema_Vendas.GButtons();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(9, 757);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(106, 757);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(773, 32);
            this.groupBox1.Size = new System.Drawing.Size(14, 49);
            this.groupBox1.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(743, 41);
            this.txtCodigo.Size = new System.Drawing.Size(24, 28);
            this.txtCodigo.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(601, 773);
            this.btnSalvar.TabIndex = 17;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(687, 773);
            this.btnSair.TabIndex = 18;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(12, 773);
            this.txtDataCadastro.Texts = "30/08/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(109, 773);
            this.txtDataUltAlt.Texts = "30/08/2024";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(727, 41);
            this.lblCodigo.Visible = false;
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
            this.txtPorcentagemDesconto.Location = new System.Drawing.Point(512, 399);
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
            this.txtTotalPagar.Location = new System.Drawing.Point(673, 399);
            this.txtTotalPagar.MaxLength = 32767;
            this.txtTotalPagar.Multiline = false;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotalPagar.PasswordChar = false;
            this.txtTotalPagar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalPagar.PlaceholderText = "";
            this.txtTotalPagar.Size = new System.Drawing.Size(85, 28);
            this.txtTotalPagar.TabIndex = 216;
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
            this.txtDesconto.Location = new System.Drawing.Point(593, 399);
            this.txtDesconto.MaxLength = 32767;
            this.txtDesconto.Multiline = false;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDesconto.PasswordChar = false;
            this.txtDesconto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDesconto.PlaceholderText = "";
            this.txtDesconto.Size = new System.Drawing.Size(66, 28);
            this.txtDesconto.TabIndex = 220;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Texts = "";
            this.txtDesconto.UnderlinedStyle = false;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(669, 383);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagar.TabIndex = 217;
            this.lblTotalPagar.Text = "Total a Pagar ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 219;
            this.label1.Text = "% Desconto";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(595, 384);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(52, 13);
            this.lblDesconto.TabIndex = 218;
            this.lblDesconto.Text = "R$ Desc.";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(9, 671);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 215;
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
            this.txtObservacao.Location = new System.Drawing.Point(12, 687);
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
            this.dataGridViewParcelas.Location = new System.Drawing.Point(12, 506);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.ReadOnly = true;
            this.dataGridViewParcelas.Size = new System.Drawing.Size(746, 146);
            this.dataGridViewParcelas.TabIndex = 214;
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
            this.btnAddCondPag.Location = new System.Drawing.Point(409, 458);
            this.btnAddCondPag.Name = "btnAddCondPag";
            this.btnAddCondPag.Size = new System.Drawing.Size(75, 28);
            this.btnAddCondPag.TabIndex = 14;
            this.btnAddCondPag.Text = "&Adicionar";
            this.btnAddCondPag.TextColor = System.Drawing.Color.White;
            this.btnAddCondPag.UseVisualStyleBackColor = false;
            this.btnAddCondPag.Click += new System.EventHandler(this.btnAddCondPag_Click);
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
            this.btnExcluirServico.Location = new System.Drawing.Point(12, 384);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(86, 28);
            this.btnExcluirServico.TabIndex = 213;
            this.btnExcluirServico.Text = "Excluir Serviço";
            this.btnExcluirServico.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnExcluirServico.UseVisualStyleBackColor = false;
            this.btnExcluirServico.Click += new System.EventHandler(this.btnExcluirServico_Click);
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
            this.btnConsultaCondPag.Location = new System.Drawing.Point(112, 457);
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
            this.txtCondPag.Location = new System.Drawing.Point(157, 458);
            this.txtCondPag.MaxLength = 14;
            this.txtCondPag.Multiline = false;
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCondPag.PasswordChar = false;
            this.txtCondPag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCondPag.PlaceholderText = "";
            this.txtCondPag.Size = new System.Drawing.Size(236, 28);
            this.txtCondPag.TabIndex = 212;
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
            this.txtCodCondPag.Location = new System.Drawing.Point(12, 458);
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
            this.lblCondPag.Location = new System.Drawing.Point(9, 442);
            this.lblCondPag.Name = "lblCondPag";
            this.lblCondPag.Size = new System.Drawing.Size(44, 13);
            this.lblCondPag.TabIndex = 211;
            this.lblCondPag.Text = "Código*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 210;
            this.label3.Text = "Condição de Pagamento";
            // 
            // lblTotalProdutos
            // 
            this.lblTotalProdutos.AutoSize = true;
            this.lblTotalProdutos.Location = new System.Drawing.Point(404, 384);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(75, 13);
            this.lblTotalProdutos.TabIndex = 209;
            this.lblTotalProdutos.Text = "Total Serviços";
            // 
            // txtTotalServicos
            // 
            this.txtTotalServicos.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalServicos.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTotalServicos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtTotalServicos.BorderRadius = 5;
            this.txtTotalServicos.BorderSize = 1;
            this.txtTotalServicos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalServicos.DisabledBackColor = System.Drawing.Color.White;
            this.txtTotalServicos.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtTotalServicos.DisabledForeColor = System.Drawing.Color.White;
            this.txtTotalServicos.Enabled = false;
            this.txtTotalServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTotalServicos.Location = new System.Drawing.Point(408, 399);
            this.txtTotalServicos.MaxLength = 32767;
            this.txtTotalServicos.Multiline = false;
            this.txtTotalServicos.Name = "txtTotalServicos";
            this.txtTotalServicos.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtTotalServicos.PasswordChar = false;
            this.txtTotalServicos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalServicos.PlaceholderText = "";
            this.txtTotalServicos.Size = new System.Drawing.Size(85, 28);
            this.txtTotalServicos.TabIndex = 208;
            this.txtTotalServicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalServicos.Texts = "";
            this.txtTotalServicos.UnderlinedStyle = false;
            // 
            // dataGridViewServicos
            // 
            this.dataGridViewServicos.AllowUserToAddRows = false;
            this.dataGridViewServicos.AllowUserToDeleteRows = false;
            this.dataGridViewServicos.AllowUserToResizeColumns = false;
            this.dataGridViewServicos.AllowUserToResizeRows = false;
            this.dataGridViewServicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServico,
            this.servico,
            this.quantidadeServico,
            this.PrecoUN,
            this.precoTotal});
            this.dataGridViewServicos.Enabled = false;
            this.dataGridViewServicos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewServicos.Location = new System.Drawing.Point(12, 229);
            this.dataGridViewServicos.Name = "dataGridViewServicos";
            this.dataGridViewServicos.ReadOnly = true;
            this.dataGridViewServicos.Size = new System.Drawing.Size(746, 141);
            this.dataGridViewServicos.TabIndex = 207;
            this.dataGridViewServicos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewServicos_RowsAdded);
            this.dataGridViewServicos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewServicos_RowsRemoved);
            // 
            // idServico
            // 
            this.idServico.HeaderText = "Código";
            this.idServico.Name = "idServico";
            this.idServico.ReadOnly = true;
            this.idServico.Width = 80;
            // 
            // servico
            // 
            this.servico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.servico.HeaderText = "Serviço";
            this.servico.Name = "servico";
            this.servico.ReadOnly = true;
            // 
            // quantidadeServico
            // 
            this.quantidadeServico.HeaderText = "Quantidade";
            this.quantidadeServico.Name = "quantidadeServico";
            this.quantidadeServico.ReadOnly = true;
            this.quantidadeServico.Width = 80;
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
            // lblPrecoServico
            // 
            this.lblPrecoServico.AutoSize = true;
            this.lblPrecoServico.Location = new System.Drawing.Point(509, 159);
            this.lblPrecoServico.Name = "lblPrecoServico";
            this.lblPrecoServico.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoServico.TabIndex = 206;
            this.lblPrecoServico.Text = "Preço";
            // 
            // txtPrecoServico
            // 
            this.txtPrecoServico.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecoServico.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrecoServico.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtPrecoServico.BorderRadius = 5;
            this.txtPrecoServico.BorderSize = 1;
            this.txtPrecoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoServico.DisabledBackColor = System.Drawing.Color.White;
            this.txtPrecoServico.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPrecoServico.DisabledForeColor = System.Drawing.Color.White;
            this.txtPrecoServico.Enabled = false;
            this.txtPrecoServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPrecoServico.Location = new System.Drawing.Point(512, 175);
            this.txtPrecoServico.MaxLength = 32767;
            this.txtPrecoServico.Multiline = false;
            this.txtPrecoServico.Name = "txtPrecoServico";
            this.txtPrecoServico.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPrecoServico.PasswordChar = false;
            this.txtPrecoServico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecoServico.PlaceholderText = "";
            this.txtPrecoServico.Size = new System.Drawing.Size(66, 28);
            this.txtPrecoServico.TabIndex = 199;
            this.txtPrecoServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoServico.Texts = "";
            this.txtPrecoServico.UnderlinedStyle = false;
            // 
            // lblQtdeServico
            // 
            this.lblQtdeServico.AutoSize = true;
            this.lblQtdeServico.Location = new System.Drawing.Point(595, 159);
            this.lblQtdeServico.Name = "lblQtdeServico";
            this.lblQtdeServico.Size = new System.Drawing.Size(69, 13);
            this.lblQtdeServico.TabIndex = 203;
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
            this.txtQtdeServico.Enabled = false;
            this.txtQtdeServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtQtdeServico.Location = new System.Drawing.Point(598, 175);
            this.txtQtdeServico.MaxLength = 32767;
            this.txtQtdeServico.Multiline = false;
            this.txtQtdeServico.Name = "txtQtdeServico";
            this.txtQtdeServico.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtQtdeServico.PasswordChar = false;
            this.txtQtdeServico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQtdeServico.PlaceholderText = "";
            this.txtQtdeServico.Size = new System.Drawing.Size(66, 28);
            this.txtQtdeServico.TabIndex = 9;
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
            this.btnConsultaServico.Enabled = false;
            this.btnConsultaServico.FlatAppearance.BorderSize = 0;
            this.btnConsultaServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaServico.ForeColor = System.Drawing.Color.White;
            this.btnConsultaServico.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaServico.Image")));
            this.btnConsultaServico.Location = new System.Drawing.Point(112, 175);
            this.btnConsultaServico.Name = "btnConsultaServico";
            this.btnConsultaServico.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaServico.TabIndex = 8;
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
            this.txtServico.Location = new System.Drawing.Point(157, 175);
            this.txtServico.MaxLength = 32767;
            this.txtServico.Multiline = false;
            this.txtServico.Name = "txtServico";
            this.txtServico.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtServico.PasswordChar = false;
            this.txtServico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtServico.PlaceholderText = "";
            this.txtServico.Size = new System.Drawing.Size(336, 28);
            this.txtServico.TabIndex = 202;
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
            this.txtCodServico.Enabled = false;
            this.txtCodServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodServico.Location = new System.Drawing.Point(12, 175);
            this.txtCodServico.MaxLength = 32767;
            this.txtCodServico.Multiline = false;
            this.txtCodServico.Name = "txtCodServico";
            this.txtCodServico.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodServico.PasswordChar = false;
            this.txtCodServico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodServico.PlaceholderText = "";
            this.txtCodServico.Size = new System.Drawing.Size(92, 28);
            this.txtCodServico.TabIndex = 7;
            this.txtCodServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodServico.Texts = "";
            this.txtCodServico.UnderlinedStyle = false;
            this.txtCodServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodServico_KeyPress);
            this.txtCodServico.Leave += new System.EventHandler(this.txtCodServico_Leave);
            // 
            // lblCodServico
            // 
            this.lblCodServico.AutoSize = true;
            this.lblCodServico.Location = new System.Drawing.Point(9, 159);
            this.lblCodServico.Name = "lblCodServico";
            this.lblCodServico.Size = new System.Drawing.Size(75, 13);
            this.lblCodServico.TabIndex = 201;
            this.lblCodServico.Text = "Cód. Serviço *";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(154, 159);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 200;
            this.lblServico.Text = "Serviço";
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
            this.btnAddServico.Location = new System.Drawing.Point(683, 175);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Size = new System.Drawing.Size(75, 28);
            this.btnAddServico.TabIndex = 10;
            this.btnAddServico.Text = "&Adicionar";
            this.btnAddServico.TextColor = System.Drawing.Color.White;
            this.btnAddServico.UseVisualStyleBackColor = false;
            this.btnAddServico.Click += new System.EventHandler(this.btnAddServico_Click);
            // 
            // lblDataCancelamento
            // 
            this.lblDataCancelamento.AutoSize = true;
            this.lblDataCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataCancelamento.Location = new System.Drawing.Point(615, 55);
            this.lblDataCancelamento.Name = "lblDataCancelamento";
            this.lblDataCancelamento.Size = new System.Drawing.Size(101, 13);
            this.lblDataCancelamento.TabIndex = 198;
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
            this.txtDataCancelamento.Location = new System.Drawing.Point(618, 71);
            this.txtDataCancelamento.Mask = "00/00/0000";
            this.txtDataCancelamento.MaxLength = 32767;
            this.txtDataCancelamento.Multiline = false;
            this.txtDataCancelamento.Name = "txtDataCancelamento";
            this.txtDataCancelamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCancelamento.PasswordChar = false;
            this.txtDataCancelamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCancelamento.PlaceholderText = "";
            this.txtDataCancelamento.Size = new System.Drawing.Size(98, 27);
            this.txtDataCancelamento.TabIndex = 196;
            this.txtDataCancelamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCancelamento.Texts = "  /  /";
            this.txtDataCancelamento.UnderlinedStyle = false;
            this.txtDataCancelamento.Visible = false;
            // 
            // lblCancelada
            // 
            this.lblCancelada.AutoSize = true;
            this.lblCancelada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCancelada.Location = new System.Drawing.Point(482, 80);
            this.lblCancelada.Name = "lblCancelada";
            this.lblCancelada.Size = new System.Drawing.Size(112, 13);
            this.lblCancelada.TabIndex = 197;
            this.lblCancelada.Text = "*NOTA CANCELADA*";
            this.lblCancelada.Visible = false;
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(9, 16);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(79, 13);
            this.lblDataEmissao.TabIndex = 195;
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
            this.txtDataEmissao.Location = new System.Drawing.Point(12, 32);
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
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(225, 16);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 13);
            this.lblModelo.TabIndex = 194;
            this.lblModelo.Text = "Modelo *";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(322, 16);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(38, 13);
            this.lblSerie.TabIndex = 193;
            this.lblSerie.Text = "Série *";
            // 
            // lblNroNota
            // 
            this.lblNroNota.AutoSize = true;
            this.lblNroNota.Location = new System.Drawing.Point(118, 16);
            this.lblNroNota.Name = "lblNroNota";
            this.lblNroNota.Size = new System.Drawing.Size(51, 13);
            this.lblNroNota.TabIndex = 192;
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
            this.txtModelo.Location = new System.Drawing.Point(228, 32);
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
            this.txtCliente.Location = new System.Drawing.Point(160, 101);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCliente.PasswordChar = false;
            this.txtCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCliente.PlaceholderText = "";
            this.txtCliente.Size = new System.Drawing.Size(248, 28);
            this.txtCliente.TabIndex = 191;
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
            this.txtCodCliente.Location = new System.Drawing.Point(12, 101);
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
            this.btnConsultaCliente.Location = new System.Drawing.Point(112, 100);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaCliente.TabIndex = 6;
            this.btnConsultaCliente.TextColor = System.Drawing.Color.White;
            this.btnConsultaCliente.UseVisualStyleBackColor = false;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(157, 85);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 190;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(9, 85);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(71, 13);
            this.lblCodCliente.TabIndex = 189;
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
            this.txtSerie.Location = new System.Drawing.Point(325, 32);
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
            this.txtNroNota.Location = new System.Drawing.Point(121, 32);
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
            this.btnCancelar.Location = new System.Drawing.Point(569, 773);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar Serviço";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroNotasServico
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
            this.Controls.Add(this.btnExcluirServico);
            this.Controls.Add(this.btnConsultaCondPag);
            this.Controls.Add(this.txtCondPag);
            this.Controls.Add(this.txtCodCondPag);
            this.Controls.Add(this.lblCondPag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalProdutos);
            this.Controls.Add(this.txtTotalServicos);
            this.Controls.Add(this.dataGridViewServicos);
            this.Controls.Add(this.lblPrecoServico);
            this.Controls.Add(this.txtPrecoServico);
            this.Controls.Add(this.lblQtdeServico);
            this.Controls.Add(this.txtQtdeServico);
            this.Controls.Add(this.btnConsultaServico);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.txtCodServico);
            this.Controls.Add(this.lblCodServico);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.btnAddServico);
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
            this.Name = "CadastroNotasServico";
            this.Text = "Cadastro Notas de Serviço";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroNotasServico_FormClosed);
            this.Load += new System.EventHandler(this.CadastroNotasServico_Load);
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
            this.Controls.SetChildIndex(this.btnAddServico, 0);
            this.Controls.SetChildIndex(this.lblServico, 0);
            this.Controls.SetChildIndex(this.lblCodServico, 0);
            this.Controls.SetChildIndex(this.txtCodServico, 0);
            this.Controls.SetChildIndex(this.txtServico, 0);
            this.Controls.SetChildIndex(this.btnConsultaServico, 0);
            this.Controls.SetChildIndex(this.txtQtdeServico, 0);
            this.Controls.SetChildIndex(this.lblQtdeServico, 0);
            this.Controls.SetChildIndex(this.txtPrecoServico, 0);
            this.Controls.SetChildIndex(this.lblPrecoServico, 0);
            this.Controls.SetChildIndex(this.dataGridViewServicos, 0);
            this.Controls.SetChildIndex(this.txtTotalServicos, 0);
            this.Controls.SetChildIndex(this.lblTotalProdutos, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblCondPag, 0);
            this.Controls.SetChildIndex(this.txtCodCondPag, 0);
            this.Controls.SetChildIndex(this.txtCondPag, 0);
            this.Controls.SetChildIndex(this.btnConsultaCondPag, 0);
            this.Controls.SetChildIndex(this.btnExcluirServico, 0);
            this.Controls.SetChildIndex(this.btnAddCondPag, 0);
            this.Controls.SetChildIndex(this.dataGridViewParcelas, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTotalPagar, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.txtTotalPagar, 0);
            this.Controls.SetChildIndex(this.txtPorcentagemDesconto, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GControls.GTextBox txtPorcentagemDesconto;
        private GControls.GTextBox txtTotalPagar;
        private GControls.GTextBox txtDesconto;
        protected System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesconto;
        protected System.Windows.Forms.Label lblObservacao;
        private GControls.GTextBox txtObservacao;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        protected GButtons btnAddCondPag;
        public GButtons btnExcluirServico;
        protected GButtons btnConsultaCondPag;
        protected GControls.GTextBox txtCondPag;
        protected GControls.GTextBox txtCodCondPag;
        protected System.Windows.Forms.Label lblCondPag;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label lblTotalProdutos;
        private GControls.GTextBox txtTotalServicos;
        private System.Windows.Forms.DataGridView dataGridViewServicos;
        protected System.Windows.Forms.Label lblPrecoServico;
        private GControls.GTextBox txtPrecoServico;
        protected System.Windows.Forms.Label lblQtdeServico;
        private GControls.GTextBox txtQtdeServico;
        private GButtons btnConsultaServico;
        private GControls.GTextBox txtServico;
        private GControls.GTextBox txtCodServico;
        protected System.Windows.Forms.Label lblCodServico;
        protected System.Windows.Forms.Label lblServico;
        protected GButtons btnAddServico;
        public System.Windows.Forms.Label lblDataCancelamento;
        public GControls.GMaskedTextBox txtDataCancelamento;
        public System.Windows.Forms.Label lblCancelada;
        private System.Windows.Forms.Label lblDataEmissao;
        private GControls.GMaskedTextBox txtDataEmissao;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        protected GButtons btnCancelar;
    }
}
