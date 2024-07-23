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
            this.txtPais = new Sistema_Vendas.GControls.GTextBox();
            this.txtSigla = new Sistema_Vendas.GControls.GTextBox();
            this.txtDDI = new Sistema_Vendas.GControls.GTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Texts = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.TabIndex = 5;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Texts = "04/07/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Texts = "04/07/2024";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(13, 92);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(36, 13);
            this.lblPais.TabIndex = 7;
            this.lblPais.Text = "País *";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(13, 160);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(37, 13);
            this.lblSigla.TabIndex = 8;
            this.lblSigla.Text = "Sigla *";
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(143, 160);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(33, 13);
            this.lblDDI.TabIndex = 9;
            this.lblDDI.Text = "DDI *";
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.SystemColors.Window;
            this.txtPais.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPais.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtPais.BorderRadius = 5;
            this.txtPais.BorderSize = 1;
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.DisabledBackColor = System.Drawing.Color.White;
            this.txtPais.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtPais.DisabledForeColor = System.Drawing.Color.White;
            this.txtPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPais.Location = new System.Drawing.Point(16, 108);
            this.txtPais.MaxLength = 100;
            this.txtPais.Multiline = false;
            this.txtPais.Name = "txtPais";
            this.txtPais.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPais.PasswordChar = false;
            this.txtPais.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPais.PlaceholderText = "";
            this.txtPais.Size = new System.Drawing.Size(368, 28);
            this.txtPais.TabIndex = 1;
            this.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPais.Texts = "";
            this.txtPais.UnderlinedStyle = false;
            this.txtPais.Leave += new System.EventHandler(this.txtPais_Leave);
            // 
            // txtSigla
            // 
            this.txtSigla.BackColor = System.Drawing.SystemColors.Window;
            this.txtSigla.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSigla.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtSigla.BorderRadius = 5;
            this.txtSigla.BorderSize = 1;
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.DisabledBackColor = System.Drawing.Color.White;
            this.txtSigla.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtSigla.DisabledForeColor = System.Drawing.Color.White;
            this.txtSigla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSigla.Location = new System.Drawing.Point(16, 176);
            this.txtSigla.MaxLength = 5;
            this.txtSigla.Multiline = false;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSigla.PasswordChar = false;
            this.txtSigla.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSigla.PlaceholderText = "";
            this.txtSigla.Size = new System.Drawing.Size(113, 28);
            this.txtSigla.TabIndex = 2;
            this.txtSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSigla.Texts = "";
            this.txtSigla.UnderlinedStyle = false;
            this.txtSigla.Leave += new System.EventHandler(this.txtSigla_Leave);
            // 
            // txtDDI
            // 
            this.txtDDI.BackColor = System.Drawing.SystemColors.Window;
            this.txtDDI.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDDI.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDDI.BorderRadius = 5;
            this.txtDDI.BorderSize = 1;
            this.txtDDI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDI.DisabledBackColor = System.Drawing.Color.White;
            this.txtDDI.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDDI.DisabledForeColor = System.Drawing.Color.White;
            this.txtDDI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDDI.Location = new System.Drawing.Point(146, 176);
            this.txtDDI.MaxLength = 5;
            this.txtDDI.Multiline = false;
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDDI.PasswordChar = false;
            this.txtDDI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDDI.PlaceholderText = "";
            this.txtDDI.Size = new System.Drawing.Size(114, 28);
            this.txtDDI.TabIndex = 3;
            this.txtDDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDDI.Texts = "";
            this.txtDDI.UnderlinedStyle = false;
            this.txtDDI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDDI_KeyPress);
            // 
            // CadastroPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
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
            this.Controls.SetChildIndex(this.lblCodigo, 0);
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

        protected System.Windows.Forms.Label lblPais;
        protected System.Windows.Forms.Label lblSigla;
        protected System.Windows.Forms.Label lblDDI;
        private GControls.GTextBox txtSigla;
        private GControls.GTextBox txtDDI;
        public GControls.GTextBox txtPais;
    }
}
