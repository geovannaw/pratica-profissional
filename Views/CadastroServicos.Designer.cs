namespace Sistema_Vendas.Views
{
    partial class CadastroServicos
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
            this.lblServico = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Text = "12062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Text = "12062024";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(13, 78);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 12;
            this.lblServico.Text = "Serviço";
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(16, 94);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(364, 20);
            this.txtServico.TabIndex = 13;
            this.txtServico.Leave += new System.EventHandler(this.txtServico_Leave);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(16, 151);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 15;
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 135);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 14;
            this.lblPreco.Text = "Preço";
            // 
            // CadastroServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 454);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.lblServico);
            this.Name = "CadastroServicos";
            this.Text = "Cadastro de Serviços";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroServicos_FormClosed);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblServico, 0);
            this.Controls.SetChildIndex(this.txtServico, 0);
            this.Controls.SetChildIndex(this.lblPreco, 0);
            this.Controls.SetChildIndex(this.txtPreco, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
    }
}
