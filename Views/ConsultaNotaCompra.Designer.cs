namespace Sistema_Vendas.Views
{
    partial class ConsultaNotaCompra
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
            this.btnVisualizar = new Sistema_Vendas.GButtons();
            this.dataGridViewNFCompra = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNFCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Location = new System.Drawing.Point(381, 412);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(11, 412);
            this.btnAlterar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(92, 412);
            this.btnExcluir.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnVisualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnVisualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnVisualizar.BorderRadius = 5;
            this.btnVisualizar.BorderSize = 1;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Location = new System.Drawing.Point(462, 412);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 28);
            this.btnVisualizar.TabIndex = 16;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.TextColor = System.Drawing.Color.White;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dataGridViewNFCompra
            // 
            this.dataGridViewNFCompra.AllowUserToResizeColumns = false;
            this.dataGridViewNFCompra.AllowUserToResizeRows = false;
            this.dataGridViewNFCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewNFCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNFCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.País,
            this.Sigla,
            this.DDI});
            this.dataGridViewNFCompra.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewNFCompra.Location = new System.Drawing.Point(17, 58);
            this.dataGridViewNFCompra.Name = "dataGridViewNFCompra";
            this.dataGridViewNFCompra.ReadOnly = true;
            this.dataGridViewNFCompra.Size = new System.Drawing.Size(598, 339);
            this.dataGridViewNFCompra.TabIndex = 17;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // País
            // 
            this.País.HeaderText = "País";
            this.País.Name = "País";
            this.País.ReadOnly = true;
            this.País.Width = 255;
            // 
            // Sigla
            // 
            this.Sigla.HeaderText = "Sigla";
            this.Sigla.Name = "Sigla";
            this.Sigla.ReadOnly = true;
            // 
            // DDI
            // 
            this.DDI.HeaderText = "DDI";
            this.DDI.Name = "DDI";
            this.DDI.ReadOnly = true;
            // 
            // ConsultaNotaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(633, 454);
            this.Controls.Add(this.dataGridViewNFCompra);
            this.Controls.Add(this.btnVisualizar);
            this.Name = "ConsultaNotaCompra";
            this.Text = "Consulta Notas de Compra";
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnVisualizar, 0);
            this.Controls.SetChildIndex(this.dataGridViewNFCompra, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNFCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected GButtons btnVisualizar;
        private System.Windows.Forms.DataGridView dataGridViewNFCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDI;
    }
}
