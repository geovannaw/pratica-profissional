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
            this.txtCondPag = new System.Windows.Forms.TextBox();
            this.lblCondPag = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.lblPorcentagemTotal = new System.Windows.Forms.Label();
            this.txtPorcentagemTotal = new System.Windows.Forms.TextBox();
            this.btnAddParcela = new System.Windows.Forms.Button();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblMulta = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblCodFormaPag = new System.Windows.Forms.Label();
            this.txtCodFormaPag = new System.Windows.Forms.TextBox();
            this.lblFormaPag = new System.Windows.Forms.Label();
            this.txtFormaPag = new System.Windows.Forms.TextBox();
            this.btnConsultaFormaPag = new System.Windows.Forms.Button();
            this.dataGridViewParcelas = new System.Windows.Forms.DataGridView();
            this.numeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CódFormaPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirParcela = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(498, 438);
            this.btnSalvar.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(579, 438);
            this.btnSair.TabIndex = 14;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 441);
            this.txtDataCadastro.Text = "12062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(104, 441);
            this.txtDataUltAlt.Text = "12062024";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 425);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(101, 425);
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 17;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(505, 18);
            this.groupBox1.TabIndex = 15;
            // 
            // txtCondPag
            // 
            this.txtCondPag.Location = new System.Drawing.Point(16, 98);
            this.txtCondPag.MaxLength = 50;
            this.txtCondPag.Name = "txtCondPag";
            this.txtCondPag.Size = new System.Drawing.Size(296, 20);
            this.txtCondPag.TabIndex = 1;
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
            this.lblParcela.Location = new System.Drawing.Point(13, 139);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(65, 13);
            this.lblParcela.TabIndex = 15;
            this.lblParcela.Text = "Nº Parcela *";
            // 
            // txtParcela
            // 
            this.txtParcela.Location = new System.Drawing.Point(16, 155);
            this.txtParcela.MaxLength = 10;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(67, 20);
            this.txtParcela.TabIndex = 5;
            this.txtParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcela.Leave += new System.EventHandler(this.txtParcela_Leave);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(95, 139);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 13);
            this.lblDias.TabIndex = 17;
            this.lblDias.Text = "Dias *";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(98, 155);
            this.txtDias.MaxLength = 10;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(67, 20);
            this.txtDias.TabIndex = 6;
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDias.Leave += new System.EventHandler(this.txtDias_Leave);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(194, 139);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(22, 13);
            this.lblPorcentagem.TabIndex = 19;
            this.lblPorcentagem.Text = "% *";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(181, 155);
            this.txtPorcentagem.MaxLength = 10;
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(47, 20);
            this.txtPorcentagem.TabIndex = 7;
            this.txtPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentagem.Leave += new System.EventHandler(this.txtPorcentagem_Leave);
            // 
            // lblPorcentagemTotal
            // 
            this.lblPorcentagemTotal.AutoSize = true;
            this.lblPorcentagemTotal.Location = new System.Drawing.Point(242, 139);
            this.lblPorcentagemTotal.Name = "lblPorcentagemTotal";
            this.lblPorcentagemTotal.Size = new System.Drawing.Size(42, 13);
            this.lblPorcentagemTotal.TabIndex = 21;
            this.lblPorcentagemTotal.Text = "% Total";
            // 
            // txtPorcentagemTotal
            // 
            this.txtPorcentagemTotal.Enabled = false;
            this.txtPorcentagemTotal.Location = new System.Drawing.Point(245, 155);
            this.txtPorcentagemTotal.Name = "txtPorcentagemTotal";
            this.txtPorcentagemTotal.Size = new System.Drawing.Size(67, 20);
            this.txtPorcentagemTotal.TabIndex = 8;
            this.txtPorcentagemTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddParcela
            // 
            this.btnAddParcela.Location = new System.Drawing.Point(585, 153);
            this.btnAddParcela.Name = "btnAddParcela";
            this.btnAddParcela.Size = new System.Drawing.Size(69, 23);
            this.btnAddParcela.TabIndex = 12;
            this.btnAddParcela.Text = "Adicionar";
            this.btnAddParcela.UseVisualStyleBackColor = true;
            this.btnAddParcela.Click += new System.EventHandler(this.btnAddParcela_Click);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(498, 82);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(64, 13);
            this.lblDesconto.TabIndex = 28;
            this.lblDesconto.Text = "% Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(501, 98);
            this.txtDesconto.MaxLength = 10;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(70, 20);
            this.txtDesconto.TabIndex = 4;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(413, 82);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(44, 13);
            this.lblMulta.TabIndex = 26;
            this.lblMulta.Text = "% Multa";
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(416, 98);
            this.txtMulta.MaxLength = 10;
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(70, 20);
            this.txtMulta.TabIndex = 3;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMulta.Leave += new System.EventHandler(this.txtMulta_Leave);
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(328, 82);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(43, 13);
            this.lblJuros.TabIndex = 24;
            this.lblJuros.Text = "% Juros";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(331, 98);
            this.txtJuros.MaxLength = 10;
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(70, 20);
            this.txtJuros.TabIndex = 2;
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.Leave += new System.EventHandler(this.txtJuros_Leave);
            // 
            // lblCodFormaPag
            // 
            this.lblCodFormaPag.AutoSize = true;
            this.lblCodFormaPag.Location = new System.Drawing.Point(324, 139);
            this.lblCodFormaPag.Name = "lblCodFormaPag";
            this.lblCodFormaPag.Size = new System.Drawing.Size(47, 13);
            this.lblCodFormaPag.TabIndex = 30;
            this.lblCodFormaPag.Text = "Código *";
            // 
            // txtCodFormaPag
            // 
            this.txtCodFormaPag.Location = new System.Drawing.Point(327, 155);
            this.txtCodFormaPag.Name = "txtCodFormaPag";
            this.txtCodFormaPag.Size = new System.Drawing.Size(47, 20);
            this.txtCodFormaPag.TabIndex = 9;
            this.txtCodFormaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFormaPag.Leave += new System.EventHandler(this.txtCodFormaPag_Leave);
            // 
            // lblFormaPag
            // 
            this.lblFormaPag.AutoSize = true;
            this.lblFormaPag.Location = new System.Drawing.Point(419, 135);
            this.lblFormaPag.Name = "lblFormaPag";
            this.lblFormaPag.Size = new System.Drawing.Size(108, 13);
            this.lblFormaPag.TabIndex = 32;
            this.lblFormaPag.Text = "Forma de Pagamento";
            // 
            // txtFormaPag
            // 
            this.txtFormaPag.Enabled = false;
            this.txtFormaPag.Location = new System.Drawing.Point(422, 155);
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.Size = new System.Drawing.Size(152, 20);
            this.txtFormaPag.TabIndex = 11;
            // 
            // btnConsultaFormaPag
            // 
            this.btnConsultaFormaPag.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaFormaPag.Location = new System.Drawing.Point(380, 152);
            this.btnConsultaFormaPag.Name = "btnConsultaFormaPag";
            this.btnConsultaFormaPag.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaFormaPag.TabIndex = 10;
            this.btnConsultaFormaPag.UseVisualStyleBackColor = true;
            this.btnConsultaFormaPag.Click += new System.EventHandler(this.btnConsultaFormaPag_Click);
            // 
            // dataGridViewParcelas
            // 
            this.dataGridViewParcelas.AllowUserToAddRows = false;
            this.dataGridViewParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroParcela,
            this.dias,
            this.porcentagem,
            this.CódFormaPag,
            this.formaPagamento});
            this.dataGridViewParcelas.Location = new System.Drawing.Point(16, 195);
            this.dataGridViewParcelas.Name = "dataGridViewParcelas";
            this.dataGridViewParcelas.ReadOnly = true;
            this.dataGridViewParcelas.Size = new System.Drawing.Size(638, 189);
            this.dataGridViewParcelas.TabIndex = 33;
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
            // btnExcluirParcela
            // 
            this.btnExcluirParcela.Location = new System.Drawing.Point(555, 390);
            this.btnExcluirParcela.Name = "btnExcluirParcela";
            this.btnExcluirParcela.Size = new System.Drawing.Size(99, 23);
            this.btnExcluirParcela.TabIndex = 34;
            this.btnExcluirParcela.Text = "Excluir Parcela";
            this.btnExcluirParcela.UseVisualStyleBackColor = true;
            this.btnExcluirParcela.Click += new System.EventHandler(this.btnExcluirParcela_Click);
            // 
            // CadastroCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 474);
            this.Controls.Add(this.btnExcluirParcela);
            this.Controls.Add(this.dataGridViewParcelas);
            this.Controls.Add(this.btnConsultaFormaPag);
            this.Controls.Add(this.lblFormaPag);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.lblCodFormaPag);
            this.Controls.Add(this.txtCodFormaPag);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.btnAddParcela);
            this.Controls.Add(this.lblPorcentagemTotal);
            this.Controls.Add(this.txtPorcentagemTotal);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.lblCondPag);
            this.Controls.Add(this.txtCondPag);
            this.Name = "CadastroCondicaoPagamento";
            this.Text = "Cadastro de Condição de Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCondicaoPagamento_FormClosed);
            this.Load += new System.EventHandler(this.CadastroCondicaoPagamento_Load);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtCondPag, 0);
            this.Controls.SetChildIndex(this.lblCondPag, 0);
            this.Controls.SetChildIndex(this.txtParcela, 0);
            this.Controls.SetChildIndex(this.lblParcela, 0);
            this.Controls.SetChildIndex(this.txtDias, 0);
            this.Controls.SetChildIndex(this.lblDias, 0);
            this.Controls.SetChildIndex(this.txtPorcentagem, 0);
            this.Controls.SetChildIndex(this.lblPorcentagem, 0);
            this.Controls.SetChildIndex(this.txtPorcentagemTotal, 0);
            this.Controls.SetChildIndex(this.lblPorcentagemTotal, 0);
            this.Controls.SetChildIndex(this.btnAddParcela, 0);
            this.Controls.SetChildIndex(this.txtJuros, 0);
            this.Controls.SetChildIndex(this.lblJuros, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.lblMulta, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.lblDesconto, 0);
            this.Controls.SetChildIndex(this.txtCodFormaPag, 0);
            this.Controls.SetChildIndex(this.lblCodFormaPag, 0);
            this.Controls.SetChildIndex(this.txtFormaPag, 0);
            this.Controls.SetChildIndex(this.lblFormaPag, 0);
            this.Controls.SetChildIndex(this.btnConsultaFormaPag, 0);
            this.Controls.SetChildIndex(this.dataGridViewParcelas, 0);
            this.Controls.SetChildIndex(this.btnExcluirParcela, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCondPag;
        private System.Windows.Forms.Label lblCondPag;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Label lblPorcentagemTotal;
        private System.Windows.Forms.TextBox txtPorcentagemTotal;
        private System.Windows.Forms.Button btnAddParcela;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblCodFormaPag;
        private System.Windows.Forms.TextBox txtCodFormaPag;
        private System.Windows.Forms.Label lblFormaPag;
        private System.Windows.Forms.TextBox txtFormaPag;
        protected System.Windows.Forms.Button btnConsultaFormaPag;
        private System.Windows.Forms.DataGridView dataGridViewParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódFormaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
        private System.Windows.Forms.Button btnExcluirParcela;
    }
}
