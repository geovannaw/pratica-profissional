namespace Sistema_Vendas.Views
{
    partial class ConsultaFormasPagamento
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
            this.dataGridViewFormaPag = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormaPag)).BeginInit();
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
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(18, 14);
            this.txtPesquisa.Size = new System.Drawing.Size(183, 28);
            // 
            // dataGridViewFormaPag
            // 
            this.dataGridViewFormaPag.AllowUserToResizeColumns = false;
            this.dataGridViewFormaPag.AllowUserToResizeRows = false;
            this.dataGridViewFormaPag.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewFormaPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormaPag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.formaPagamento});
            this.dataGridViewFormaPag.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewFormaPag.Location = new System.Drawing.Point(18, 58);
            this.dataGridViewFormaPag.Name = "dataGridViewFormaPag";
            this.dataGridViewFormaPag.ReadOnly = true;
            this.dataGridViewFormaPag.Size = new System.Drawing.Size(600, 339);
            this.dataGridViewFormaPag.TabIndex = 8;
            this.dataGridViewFormaPag.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFormaPag_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // formaPagamento
            // 
            this.formaPagamento.HeaderText = "Forma de Pagamento";
            this.formaPagamento.Name = "formaPagamento";
            this.formaPagamento.ReadOnly = true;
            this.formaPagamento.Width = 455;
            // 
            // ConsultaFormasPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(633, 454);
            this.Controls.Add(this.dataGridViewFormaPag);
            this.Name = "ConsultaFormasPagamento";
            this.Text = "Consulta Formas de Pagamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultaFormasPagamento_FormClosing);
            this.Load += new System.EventHandler(this.ConsultaFormasPagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultaFormasPagamento_KeyDown);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewFormaPag, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormaPag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFormaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
    }
}
