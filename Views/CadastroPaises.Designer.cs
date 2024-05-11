namespace Sistema_Vendas.Views
{
    partial class CadastroPaises
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
            this.lblPais = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblDDI = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtDDI = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 7;
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 5;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 4;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(13, 88);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 7;
            this.lblPais.Text = "País";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(13, 160);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 8;
            this.lblSigla.Text = "Sigla";
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(143, 160);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(26, 13);
            this.lblDDI.TabIndex = 9;
            this.lblDDI.Text = "DDI";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(16, 104);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(368, 20);
            this.txtPais.TabIndex = 1;
            this.txtPais.Leave += new System.EventHandler(this.txtPais_Leave);
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(16, 176);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(112, 20);
            this.txtSigla.TabIndex = 2;
            this.txtSigla.Leave += new System.EventHandler(this.txtSigla_Leave);
            // 
            // txtDDI
            // 
            this.txtDDI.Location = new System.Drawing.Point(146, 176);
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Size = new System.Drawing.Size(110, 20);
            this.txtDDI.TabIndex = 3;
            this.txtDDI.Leave += new System.EventHandler(this.txtDDI_Leave);
            // 
            // CadastroPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 454);
            this.Controls.Add(this.txtDDI);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblDDI);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblPais);
            this.Name = "CadastroPaises";
            this.Text = "Cadastro de Países";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroPaises_FormClosed);
            this.Load += new System.EventHandler(this.CadastroPaises_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.lblDDI, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.txtDDI, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblDDI;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtDDI;
    }
}
