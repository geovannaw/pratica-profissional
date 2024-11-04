namespace Sistema_Vendas.Views
{
    partial class CadastroUsuarios
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
            this.txtUsuario = new Sistema_Vendas.GControls.GTextBox();
            this.txtSenha = new Sistema_Vendas.GControls.GTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.cbPermissao = new Sistema_Vendas.GControls.GComboBox();
            this.lblPermissao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 341);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(101, 341);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(308, 19);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(296, 357);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(382, 357);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 357);
            this.txtDataCadastro.Texts = "13/09/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(104, 357);
            this.txtDataUltAlt.Texts = "13/09/2024";
            // 
            // txtUsuarioUltAlt
            // 
            this.txtUsuarioUltAlt.Location = new System.Drawing.Point(192, 357);
            // 
            // lblUsuarioUltAlt
            // 
            this.lblUsuarioUltAlt.Location = new System.Drawing.Point(189, 341);
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
            this.txtUsuario.Location = new System.Drawing.Point(16, 115);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.Size = new System.Drawing.Size(441, 28);
            this.txtUsuario.TabIndex = 34;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = false;
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
            this.txtSenha.Location = new System.Drawing.Point(16, 192);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.Size = new System.Drawing.Size(441, 28);
            this.txtSenha.TabIndex = 35;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.Texts = "";
            this.txtSenha.UnderlinedStyle = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(13, 99);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(13, 176);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 37;
            this.lblSenha.Text = "Senha";
            // 
            // cbPermissao
            // 
            this.cbPermissao.BackColor = System.Drawing.Color.White;
            this.cbPermissao.BorderColor = System.Drawing.Color.DarkGray;
            this.cbPermissao.BorderRadius = 5;
            this.cbPermissao.BorderSize = 1;
            this.cbPermissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbPermissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbPermissao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.cbPermissao.Items.AddRange(new object[] {
            "ADMIN",
            "ATENDENTE",
            "GERENTE",
            "FUNCIONÁRIO"});
            this.cbPermissao.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cbPermissao.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbPermissao.Location = new System.Drawing.Point(16, 274);
            this.cbPermissao.MinimumSize = new System.Drawing.Size(100, 28);
            this.cbPermissao.Name = "cbPermissao";
            this.cbPermissao.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.cbPermissao.Size = new System.Drawing.Size(171, 28);
            this.cbPermissao.TabIndex = 38;
            this.cbPermissao.Texts = "";
            // 
            // lblPermissao
            // 
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Location = new System.Drawing.Point(13, 258);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(55, 13);
            this.lblPermissao.TabIndex = 39;
            this.lblPermissao.Text = "Permissão";
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(470, 400);
            this.Controls.Add(this.lblPermissao);
            this.Controls.Add(this.cbPermissao);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Name = "CadastroUsuarios";
            this.Text = "Cadastro de Usuários";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.CadastroUsuarios_Load);
            this.Controls.SetChildIndex(this.txtUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.lblUsuarioUltAlt, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.txtSenha, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.lblSenha, 0);
            this.Controls.SetChildIndex(this.cbPermissao, 0);
            this.Controls.SetChildIndex(this.lblPermissao, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GControls.GTextBox txtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        protected GControls.GComboBox cbPermissao;
        private System.Windows.Forms.Label lblPermissao;
        public GControls.GTextBox txtUsuario;
    }
}
