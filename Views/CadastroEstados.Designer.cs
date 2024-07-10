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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEstados));
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new Sistema_Vendas.GControls.GTextBox();
            this.txtUF = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodPais = new Sistema_Vendas.GControls.GTextBox();
            this.txtPais = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaPais = new Sistema_Vendas.GButtons();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 10;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbInativo_CheckedChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 9;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Texts = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.TabIndex = 7;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Texts = "04/07/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Texts = "04/07/2024";
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
            this.lblPais.Size = new System.Drawing.Size(29, 13);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "País";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código País *";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstado.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtEstado.BorderRadius = 5;
            this.txtEstado.BorderSize = 1;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.DisabledBackColor = System.Drawing.Color.White;
            this.txtEstado.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtEstado.DisabledForeColor = System.Drawing.Color.White;
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtEstado.Location = new System.Drawing.Point(19, 104);
            this.txtEstado.MaxLength = 100;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtEstado.PasswordChar = false;
            this.txtEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.Size = new System.Drawing.Size(246, 28);
            this.txtEstado.TabIndex = 2;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstado.Texts = "";
            this.txtEstado.UnderlinedStyle = false;
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
            // 
            // txtUF
            // 
            this.txtUF.BackColor = System.Drawing.SystemColors.Window;
            this.txtUF.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUF.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtUF.BorderRadius = 5;
            this.txtUF.BorderSize = 1;
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.DisabledBackColor = System.Drawing.Color.White;
            this.txtUF.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtUF.DisabledForeColor = System.Drawing.Color.White;
            this.txtUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtUF.Location = new System.Drawing.Point(278, 104);
            this.txtUF.MaxLength = 5;
            this.txtUF.Multiline = false;
            this.txtUF.Name = "txtUF";
            this.txtUF.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUF.PasswordChar = false;
            this.txtUF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUF.PlaceholderText = "";
            this.txtUF.Size = new System.Drawing.Size(100, 28);
            this.txtUF.TabIndex = 3;
            this.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUF.Texts = "";
            this.txtUF.UnderlinedStyle = false;
            this.txtUF.Leave += new System.EventHandler(this.txtUF_Leave);
            // 
            // txtCodPais
            // 
            this.txtCodPais.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodPais.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodPais.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodPais.BorderRadius = 5;
            this.txtCodPais.BorderSize = 1;
            this.txtCodPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodPais.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodPais.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodPais.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodPais.Location = new System.Drawing.Point(19, 174);
            this.txtCodPais.MaxLength = 10;
            this.txtCodPais.Multiline = false;
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodPais.PasswordChar = false;
            this.txtCodPais.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodPais.PlaceholderText = "";
            this.txtCodPais.Size = new System.Drawing.Size(65, 28);
            this.txtCodPais.TabIndex = 4;
            this.txtCodPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodPais.Texts = "";
            this.txtCodPais.UnderlinedStyle = false;
            this.txtCodPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPais_KeyPress);
            this.txtCodPais.Leave += new System.EventHandler(this.txtCodPais_Leave);
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
            this.txtPais.Enabled = false;
            this.txtPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtPais.Location = new System.Drawing.Point(131, 174);
            this.txtPais.MaxLength = 32767;
            this.txtPais.Multiline = false;
            this.txtPais.Name = "txtPais";
            this.txtPais.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtPais.PasswordChar = false;
            this.txtPais.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPais.PlaceholderText = "";
            this.txtPais.Size = new System.Drawing.Size(247, 28);
            this.txtPais.TabIndex = 37;
            this.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPais.Texts = "";
            this.txtPais.UnderlinedStyle = false;
            // 
            // btnConsultaPais
            // 
            this.btnConsultaPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaPais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaPais.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaPais.BorderRadius = 5;
            this.btnConsultaPais.BorderSize = 1;
            this.btnConsultaPais.FlatAppearance.BorderSize = 0;
            this.btnConsultaPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPais.ForeColor = System.Drawing.Color.White;
            this.btnConsultaPais.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaPais.Image")));
            this.btnConsultaPais.Location = new System.Drawing.Point(89, 174);
            this.btnConsultaPais.Name = "btnConsultaPais";
            this.btnConsultaPais.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaPais.TabIndex = 5;
            this.btnConsultaPais.TextColor = System.Drawing.Color.White;
            this.btnConsultaPais.UseVisualStyleBackColor = false;
            this.btnConsultaPais.Click += new System.EventHandler(this.btnConsultaPais_Click);
            // 
            // CadastroEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(399, 454);
            this.Controls.Add(this.btnConsultaPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCodPais);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstado);
            this.Name = "CadastroEstados";
            this.Text = "Cadastro de Estados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroEstados_FormClosed);
            this.Load += new System.EventHandler(this.CadastroEstados_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
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
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.btnConsultaPais, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label label1;
        private GControls.GTextBox txtEstado;
        private GControls.GTextBox txtUF;
        private GControls.GTextBox txtCodPais;
        private GControls.GTextBox txtPais;
        private GButtons btnConsultaPais;
    }
}
