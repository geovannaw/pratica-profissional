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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).BeginInit();
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
            // dataGridViewFuncionarios
            // 
            this.dataGridViewFuncionarios.AllowUserToResizeColumns = false;
            this.dataGridViewFuncionarios.AllowUserToResizeRows = false;
            this.dataGridViewFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Funcionário,
            this.Cargo,
            this.Celular});
            this.dataGridViewFuncionarios.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewFuncionarios.Location = new System.Drawing.Point(18, 55);
            this.dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            this.dataGridViewFuncionarios.ReadOnly = true;
            this.dataGridViewFuncionarios.Size = new System.Drawing.Size(600, 346);
            this.dataGridViewFuncionarios.TabIndex = 8;
            this.dataGridViewFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuncionarios_CellDoubleClick);
            this.dataGridViewFuncionarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewFuncionarios_CellFormatting);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 72;
            // 
            // Funcionário
            // 
            this.Funcionário.HeaderText = "Funcionário";
            this.Funcionário.Name = "Funcionário";
            this.Funcionário.ReadOnly = true;
            this.Funcionário.Width = 240;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 145;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // ConsultaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(633, 454);
            this.Controls.Add(this.dataGridViewFuncionarios);
            this.Name = "ConsultaFuncionarios";
            this.Text = "Consulta de Funcionários";
            this.Load += new System.EventHandler(this.ConsultaFuncionarios_Load);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.dataGridViewFuncionarios, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
