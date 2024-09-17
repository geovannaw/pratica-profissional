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
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtServico = new Sistema_Vendas.GControls.GTextBox();
            this.txtPreco = new Sistema_Vendas.GControls.GTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 227);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(101, 227);
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 7;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(302, 12);
            this.groupBox1.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(16, 33);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Texts = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(295, 242);
            this.btnSalvar.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(376, 242);
            this.btnSair.TabIndex = 4;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 243);
            this.txtDataCadastro.Texts = "04/07/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(104, 243);
            this.txtDataUltAlt.Texts = "04/07/2024";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(13, 17);
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(192, 243);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(189, 227);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(13, 81);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(50, 13);
            this.lblServico.TabIndex = 12;
            this.lblServico.Text = "Serviço *";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(13, 152);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(42, 13);
            this.lblPreco.TabIndex = 14;
            this.lblPreco.Text = "Preço *";
            // 
            // txtServico
            // 
            this.txtServico.BackColor = System.Drawing.SystemColors.Window;
            this.txtServico.BorderColor = System.Drawing.Color.DarkGray;
            this.txtServico.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtServico.BorderRadius = 5;
            this.txtServico.BorderSize = 1;
            this.txtServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServico.DisabledBackColor = System.Drawing.Color.White;
            this.txtServico.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtServico.DisabledForeColor = System.Drawing.Color.White;
            this.txtServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtServico.Location = new System.Drawing.Point(16, 97);
            this.txtServico.MaxLength = 100;
            this.txtServico.Multiline = false;
            this.txtServico.Name = "txtServico";
            this.txtServico.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtServico.PasswordChar = false;
            this.txtServico.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtServico.PlaceholderText = "";
            this.txtServico.Size = new System.Drawing.Size(435, 28);
            this.txtServico.TabIndex = 1;
            this.txtServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServico.Texts = "";
            this.txtServico.UnderlinedStyle = false;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Window;
            this.txtPreco.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPreco.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtPreco.BorderRadius = 5;
            this.txtPreco.BorderSize = 1;
            this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreco.DisabledBackColor = System.Drawing.Color.White;
            this.txtPreco.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPreco.DisabledForeColor = System.Drawing.Color.White;
            this.txtPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPreco.Location = new System.Drawing.Point(16, 168);
            this.txtPreco.MaxLength = 32767;
            this.txtPreco.Multiline = false;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPreco.PasswordChar = false;
            this.txtPreco.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPreco.PlaceholderText = "";
            this.txtPreco.Size = new System.Drawing.Size(100, 28);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.Texts = "";
            this.txtPreco.UnderlinedStyle = false;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // CadastroServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(463, 282);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblServico);
            this.Name = "CadastroServicos";
            this.Text = "Cadastro de Serviços";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroServicos_FormClosed);
            this.Load += new System.EventHandler(this.CadastroServicos_Load);
            this.Controls.SetChildIndex(this.txtUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.lblUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblServico, 0);
            this.Controls.SetChildIndex(this.lblPreco, 0);
            this.Controls.SetChildIndex(this.txtServico, 0);
            this.Controls.SetChildIndex(this.txtPreco, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblPreco;
        private GControls.GTextBox txtPreco;
        public GControls.GTextBox txtServico;
    }
}
