namespace Sistema_Vendas.Views
{
    partial class TelaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new Sistema_Vendas.GControls.GTextBox();
            this.btnLogin = new Sistema_Vendas.GButtons();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new Sistema_Vendas.GControls.GTextBox();
            this.btnCancelar = new Sistema_Vendas.GButtons();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtUsuario.BorderRadius = 5;
            this.txtUsuario.BorderSize = 1;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.DisabledBackColor = System.Drawing.Color.White;
            this.txtUsuario.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtUsuario.DisabledForeColor = System.Drawing.Color.White;
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtUsuario.Location = new System.Drawing.Point(22, 52);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.Size = new System.Drawing.Size(250, 28);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.BorderSize = 1;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(22, 171);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 28);
            this.btnLogin.TabIndex = 98;
            this.btnLogin.Text = "&Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(22, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 99;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(19, 101);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 100;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtSenha.BorderRadius = 5;
            this.txtSenha.BorderSize = 1;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.DisabledBackColor = System.Drawing.Color.White;
            this.txtSenha.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtSenha.DisabledForeColor = System.Drawing.Color.White;
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtSenha.Location = new System.Drawing.Point(22, 117);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSenha.PasswordChar = false;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.Size = new System.Drawing.Size(250, 28);
            this.txtSenha.TabIndex = 101;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.Texts = "";
            this.txtSenha.UnderlinedStyle = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.White;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnCancelar.Location = new System.Drawing.Point(22, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(250, 28);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(295, 265);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GControls.GTextBox txtUsuario;
        protected GButtons btnLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private GControls.GTextBox txtSenha;
        public GButtons btnCancelar;
    }
}