namespace Sistema_Vendas.Views
{
    partial class CadastroEstados
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnConsultaPais = new System.Windows.Forms.Button();
            this.txtCodPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 9;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Text = "11062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Text = "11062024";
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 7;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbInativo_CheckedChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 6;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 89);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado *";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(275, 88);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(28, 13);
            this.lblUF.TabIndex = 8;
            this.lblUF.Text = "UF *";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(128, 160);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(36, 13);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "País *";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(16, 104);
            this.txtEstado.MaxLength = 100;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(246, 20);
            this.txtEstado.TabIndex = 1;
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(278, 104);
            this.txtUF.MaxLength = 5;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(100, 20);
            this.txtUF.TabIndex = 2;
            this.txtUF.Leave += new System.EventHandler(this.txtUF_Leave);
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(128, 176);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(248, 20);
            this.txtPais.TabIndex = 5;
            // 
            // btnConsultaPais
            // 
            this.btnConsultaPais.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaPais.Location = new System.Drawing.Point(87, 174);
            this.btnConsultaPais.Name = "btnConsultaPais";
            this.btnConsultaPais.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaPais.TabIndex = 4;
            this.btnConsultaPais.UseVisualStyleBackColor = true;
            this.btnConsultaPais.Click += new System.EventHandler(this.btnConsultaPais_Click);
            // 
            // txtCodPais
            // 
            this.txtCodPais.Location = new System.Drawing.Point(16, 176);
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Size = new System.Drawing.Size(66, 20);
            this.txtCodPais.TabIndex = 3;
            this.txtCodPais.Leave += new System.EventHandler(this.txtCodPais_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código País *";
            // 
            // CadastroEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodPais);
            this.Controls.Add(this.btnConsultaPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstado);
            this.Name = "CadastroEstados";
            this.Text = "Cadastro de Estados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroEstados_FormClosed);
            this.Load += new System.EventHandler(this.CadastroEstados_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblUF, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.btnConsultaPais, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnConsultaPais;
        private System.Windows.Forms.TextBox txtCodPais;
        private System.Windows.Forms.Label label1;
    }
}
