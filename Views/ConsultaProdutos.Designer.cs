namespace Sistema_Vendas.Views
{
    partial class ConsultaProdutos
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
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBuscaInativos
            // 
            this.cbBuscaInativos.CheckedChanged += new System.EventHandler(this.cbBuscaInativos_CheckedChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(18, 14);
            this.txtPesquisa.Size = new System.Drawing.Size(183, 28);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToResizeColumns = false;
            this.dataGridViewProdutos.AllowUserToResizeRows = false;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Produto,
            this.Unidade,
            this.Preco_venda});
            this.dataGridViewProdutos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(18, 58);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(600, 342);
            this.dataGridViewProdutos.TabIndex = 8;
            this.dataGridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick);
            this.dataGridViewProdutos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewProdutos_RowPrePaint);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 255;
            // 
            // Unidade
            // 
            this.Unidade.HeaderText = "Unidade";
            this.Unidade.Name = "Unidade";
            this.Unidade.ReadOnly = true;
            // 
            // Preco_venda
            // 
            this.Preco_venda.HeaderText = "Preço Venda";
            this.Preco_venda.Name = "Preco_venda";
            this.Preco_venda.ReadOnly = true;
            // 
            // ConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(633, 454);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Name = "ConsultaProdutos";
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.ConsultaProdutos_Load);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewProdutos, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_venda;
    }
}
