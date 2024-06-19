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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnConsultaModelos = new System.Windows.Forms.Button();
            this.lblUN = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodFornecedor = new System.Windows.Forms.Label();
            this.btnConsultaFornecedor = new System.Windows.Forms.Button();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lblCodModelol = new System.Windows.Forms.Label();
            this.txtCodModelo = new System.Windows.Forms.TextBox();
            this.txtCustoMedio = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblCustoMedio = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoUltCompra = new System.Windows.Forms.TextBox();
            this.lblPrecoUltCompra = new System.Windows.Forms.Label();
            this.txtDataUltCompra = new System.Windows.Forms.MaskedTextBox();
            this.lblDataUltCompra = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(437, 415);
            this.btnSalvar.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(518, 415);
            this.btnSair.TabIndex = 14;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(15, 418);
            this.txtDataCadastro.Text = "11062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(103, 418);
            this.txtDataUltAlt.Text = "11062024";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(12, 402);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(100, 402);
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
            this.groupBox1.Location = new System.Drawing.Point(444, 14);
            this.groupBox1.TabIndex = 15;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(16, 95);
            this.txtProduto.MaxLength = 200;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(493, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(526, 95);
            this.txtUN.MaxLength = 5;
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(64, 20);
            this.txtUN.TabIndex = 2;
            this.txtUN.Leave += new System.EventHandler(this.txtUN_Leave);
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(147, 155);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(175, 20);
            this.txtModelo.TabIndex = 14;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(334, 155);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(175, 20);
            this.txtMarca.TabIndex = 15;
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
            // btnConsultaModelos
            // 
            this.btnConsultaModelos.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaModelos.Location = new System.Drawing.Point(105, 152);
            this.btnConsultaModelos.Name = "btnConsultaModelos";
            this.btnConsultaModelos.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaModelos.TabIndex = 4;
            this.btnConsultaModelos.UseVisualStyleBackColor = true;
            this.btnConsultaModelos.Click += new System.EventHandler(this.btnConsultaModelos_Click);
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
            // btnConsultaFornecedor
            // 
            this.btnConsultaFornecedor.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaFornecedor.Location = new System.Drawing.Point(105, 214);
            this.btnConsultaFornecedor.Name = "btnConsultaFornecedor";
            this.btnConsultaFornecedor.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaFornecedor.TabIndex = 6;
            this.btnConsultaFornecedor.UseVisualStyleBackColor = true;
            this.btnConsultaFornecedor.Click += new System.EventHandler(this.btnConsultaFornecedor_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(147, 216);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(360, 20);
            this.txtFornecedor.TabIndex = 28;
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(16, 216);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(83, 20);
            this.txtCodFornecedor.TabIndex = 5;
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
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
            // txtCodModelo
            // 
            this.txtCodModelo.Location = new System.Drawing.Point(16, 155);
            this.txtCodModelo.Name = "txtCodModelo";
            this.txtCodModelo.Size = new System.Drawing.Size(83, 20);
            this.txtCodModelo.TabIndex = 3;
            this.txtCodModelo.Leave += new System.EventHandler(this.txtCodModelo_Leave);
            // 
            // txtCustoMedio
            // 
            this.txtCustoMedio.Enabled = false;
            this.txtCustoMedio.Location = new System.Drawing.Point(139, 272);
            this.txtCustoMedio.Name = "txtCustoMedio";
            this.txtCustoMedio.Size = new System.Drawing.Size(100, 20);
            this.txtCustoMedio.TabIndex = 8;
            this.txtCustoMedio.Text = "0";
            this.txtCustoMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustoMedio.Leave += new System.EventHandler(this.txtCustoMedio_Leave);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(260, 272);
            this.txtPrecoVenda.MaxLength = 10;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoVenda.TabIndex = 9;
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoVenda.Leave += new System.EventHandler(this.txtPrecoVenda_Leave);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(13, 256);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 37;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblCustoMedio
            // 
            this.lblCustoMedio.AutoSize = true;
            this.lblCustoMedio.Location = new System.Drawing.Point(136, 256);
            this.lblCustoMedio.Name = "lblCustoMedio";
            this.lblCustoMedio.Size = new System.Drawing.Size(66, 13);
            this.lblCustoMedio.TabIndex = 38;
            this.lblCustoMedio.Text = "Custo Médio";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(257, 256);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(76, 13);
            this.lblPrecoVenda.TabIndex = 39;
            this.lblPrecoVenda.Text = "Preço Venda *";
            // 
            // txtPrecoUltCompra
            // 
            this.txtPrecoUltCompra.Enabled = false;
            this.txtPrecoUltCompra.Location = new System.Drawing.Point(380, 272);
            this.txtPrecoUltCompra.Name = "txtPrecoUltCompra";
            this.txtPrecoUltCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoUltCompra.TabIndex = 10;
            this.txtPrecoUltCompra.Text = "0";
            this.txtPrecoUltCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoUltCompra.Leave += new System.EventHandler(this.txtPrecoUltCompra_Leave);
            // 
            // lblPrecoUltCompra
            // 
            this.lblPrecoUltCompra.AutoSize = true;
            this.lblPrecoUltCompra.Location = new System.Drawing.Point(377, 256);
            this.lblPrecoUltCompra.Name = "lblPrecoUltCompra";
            this.lblPrecoUltCompra.Size = new System.Drawing.Size(93, 13);
            this.lblPrecoUltCompra.TabIndex = 41;
            this.lblPrecoUltCompra.Text = "Preço Últ. Compra";
            // 
            // txtDataUltCompra
            // 
            this.txtDataUltCompra.Enabled = false;
            this.txtDataUltCompra.Location = new System.Drawing.Point(500, 272);
            this.txtDataUltCompra.Mask = "00/00/0000";
            this.txtDataUltCompra.Name = "txtDataUltCompra";
            this.txtDataUltCompra.Size = new System.Drawing.Size(90, 20);
            this.txtDataUltCompra.TabIndex = 11;
            this.txtDataUltCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataUltCompra.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataUltCompra
            // 
            this.lblDataUltCompra.AutoSize = true;
            this.lblDataUltCompra.Location = new System.Drawing.Point(497, 256);
            this.lblDataUltCompra.Name = "lblDataUltCompra";
            this.lblDataUltCompra.Size = new System.Drawing.Size(88, 13);
            this.lblDataUltCompra.TabIndex = 43;
            this.lblDataUltCompra.Text = "Data Últ. Compra";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(16, 332);
            this.txtObservacao.MaxLength = 200;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(574, 20);
            this.txtObservacao.TabIndex = 12;
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
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(16, 272);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 7;
            this.txtSaldo.Text = "0";
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(608, 454);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblDataUltCompra);
            this.Controls.Add(this.txtDataUltCompra);
            this.Controls.Add(this.lblPrecoUltCompra);
            this.Controls.Add(this.txtPrecoUltCompra);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.lblCustoMedio);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtCustoMedio);
            this.Controls.Add(this.lblCodModelol);
            this.Controls.Add(this.txtCodModelo);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCodFornecedor);
            this.Controls.Add(this.btnConsultaFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblUN);
            this.Controls.Add(this.btnConsultaModelos);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.txtProduto);
            this.Name = "CadastroProdutos";
            this.Text = "Cadastro de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroProdutos_FormClosed);
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtProduto, 0);
            this.Controls.SetChildIndex(this.txtUN, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.lblProduto, 0);
            this.Controls.SetChildIndex(this.btnConsultaModelos, 0);
            this.Controls.SetChildIndex(this.lblUN, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.txtCodFornecedor, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.Controls.SetChildIndex(this.btnConsultaFornecedor, 0);
            this.Controls.SetChildIndex(this.lblCodFornecedor, 0);
            this.Controls.SetChildIndex(this.lblFornecedor, 0);
            this.Controls.SetChildIndex(this.txtCodModelo, 0);
            this.Controls.SetChildIndex(this.lblCodModelol, 0);
            this.Controls.SetChildIndex(this.txtCustoMedio, 0);
            this.Controls.SetChildIndex(this.txtPrecoVenda, 0);
            this.Controls.SetChildIndex(this.lblSaldo, 0);
            this.Controls.SetChildIndex(this.lblCustoMedio, 0);
            this.Controls.SetChildIndex(this.lblPrecoVenda, 0);
            this.Controls.SetChildIndex(this.txtPrecoUltCompra, 0);
            this.Controls.SetChildIndex(this.lblPrecoUltCompra, 0);
            this.Controls.SetChildIndex(this.txtDataUltCompra, 0);
            this.Controls.SetChildIndex(this.lblDataUltCompra, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.Controls.SetChildIndex(this.txtSaldo, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblProduto;
        protected System.Windows.Forms.Button btnConsultaModelos;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblCodFornecedor;
        protected System.Windows.Forms.Button btnConsultaFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label lblCodModelol;
        private System.Windows.Forms.TextBox txtCodModelo;
        private System.Windows.Forms.TextBox txtCustoMedio;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblCustoMedio;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoUltCompra;
        private System.Windows.Forms.Label lblPrecoUltCompra;
        private System.Windows.Forms.MaskedTextBox txtDataUltCompra;
        private System.Windows.Forms.Label lblDataUltCompra;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        protected System.Windows.Forms.TextBox txtSaldo;
    }
}
