namespace Sistema_Vendas.Views
{
    partial class ConsultaPaises
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
            this.dataGridViewPaises = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(18, 14);
            this.txtPesquisa.Size = new System.Drawing.Size(183, 28);
            // 
            // cbBuscaInativos
            // 
            this.cbBuscaInativos.CheckedChanged += new System.EventHandler(this.cbBuscaInativos_CheckedChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Location = new System.Drawing.Point(298, 416);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(379, 416);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(460, 416);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(541, 416);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // dataGridViewPaises
            // 
            this.dataGridViewPaises.AllowUserToResizeColumns = false;
            this.dataGridViewPaises.AllowUserToResizeRows = false;
            this.dataGridViewPaises.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.País,
            this.Sigla,
            this.DDI});
            this.dataGridViewPaises.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPaises.Location = new System.Drawing.Point(18, 58);
            this.dataGridViewPaises.Name = "dataGridViewPaises";
            this.dataGridViewPaises.ReadOnly = true;
            this.dataGridViewPaises.Size = new System.Drawing.Size(598, 339);
            this.dataGridViewPaises.TabIndex = 7;
            this.dataGridViewPaises.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaises_CellDoubleClick);
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
            // ConsultaPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(633, 454);
            this.Controls.Add(this.dataGridViewPaises);
            this.Name = "ConsultaPaises";
            this.Text = "Consulta de Países";
            this.Load += new System.EventHandler(this.ConsultaPaises_Load);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.dataGridViewPaises, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPaises;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDI;
    }
}
