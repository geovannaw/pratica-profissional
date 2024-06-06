namespace Sistema_Vendas.Views
{
    partial class ConsultaFuncionarios
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
            this.dataGridViewFuncionarios = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBuscaInativos
            // 
            this.cbBuscaInativos.CheckedChanged += new System.EventHandler(this.cbBuscaInativos_CheckedChanged);
            // 
            // dataGridViewFuncionarios
            // 
            this.dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Funcionário,
            this.Cargo,
            this.Celular});
            this.dataGridViewFuncionarios.Location = new System.Drawing.Point(18, 55);
            this.dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            this.dataGridViewFuncionarios.Size = new System.Drawing.Size(600, 346);
            this.dataGridViewFuncionarios.TabIndex = 8;
            this.dataGridViewFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuncionarios_CellDoubleClick);
            this.dataGridViewFuncionarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewFuncionarios_CellFormatting);
//            this.dataGridViewFuncionarios.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewFuncionarios_RowPrePaint);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Funcionário
            // 
            this.Funcionário.HeaderText = "Funcionário";
            this.Funcionário.Name = "Funcionário";
            this.Funcionário.Width = 255;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // ConsultaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(633, 454);
            this.Controls.Add(this.dataGridViewFuncionarios);
            this.Name = "ConsultaFuncionarios";
            this.Text = "Consulta de Funcionários";
            this.Load += new System.EventHandler(this.ConsultaFuncionarios_Load);
            this.Controls.SetChildIndex(this.txtPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewFuncionarios, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    }
}
