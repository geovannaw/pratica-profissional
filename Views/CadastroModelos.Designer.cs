namespace Sistema_Vendas.Views
{
    partial class CadastroModelos
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
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(274, 413);
            this.btnSalvar.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(355, 413);
            this.btnSair.TabIndex = 8;
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 6;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(276, 15);
            this.groupBox1.TabIndex = 4;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(16, 99);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(248, 20);
            this.txtModelo.TabIndex = 1;
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(285, 99);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(145, 20);
            this.txtMarca.TabIndex = 2;
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(13, 83);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 13);
            this.lblModelo.TabIndex = 14;
            this.lblModelo.Text = "Modelo *";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(282, 83);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(44, 13);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca *";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(16, 164);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(414, 20);
            this.txtObservacao.TabIndex = 3;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(13, 148);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 17;
            this.lblObservacao.Text = "Observação";
            // 
            // CadastroModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(446, 454);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Name = "CadastroModelos";
            this.Text = "Cadastro de Modelos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroModelos_FormClosed);
            this.Load += new System.EventHandler(this.CadastroModelos_Load);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.txtObservacao, 0);
            this.Controls.SetChildIndex(this.lblObservacao, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
    }
}
