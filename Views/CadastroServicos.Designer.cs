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
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(295, 247);
            this.btnSalvar.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(376, 247);
            this.btnSair.TabIndex = 5;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(12, 249);
            this.txtDataCadastro.Text = "12062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(100, 249);
            this.txtDataUltAlt.Text = "12062024";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(9, 233);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(97, 233);
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 8;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 6;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(13, 88);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(50, 13);
            this.lblServico.TabIndex = 12;
            this.lblServico.Text = "Serviço *";
            // 
            // txtServico
            // 
            this.txtServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServico.Location = new System.Drawing.Point(16, 104);
            this.txtServico.MaxLength = 100;
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(435, 20);
            this.txtServico.TabIndex = 2;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 145);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(42, 13);
            this.lblPreco.TabIndex = 14;
            this.lblPreco.Text = "Preço *";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(16, 161);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // CadastroServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(463, 282);
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
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        public System.Windows.Forms.TextBox txtServico;
    }
}
