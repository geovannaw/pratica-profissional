namespace Sistema_Vendas.Views
{
    partial class CadastroPaiCEP
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblDataUltAlt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new Sistema_Vendas.GControls.GTextBox();
            this.btnSalvar = new Sistema_Vendas.GButtons();
            this.btnSair = new Sistema_Vendas.GButtons();
            this.txtDataCadastro = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.txtDataUltAlt = new Sistema_Vendas.GControls.GMaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(9, 392);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDataCadastro.TabIndex = 9;
            this.lblDataCadastro.Text = "Data Cadastro";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.AutoSize = true;
            this.lblDataUltAlt.Location = new System.Drawing.Point(106, 392);
            this.lblDataUltAlt.Name = "lblDataUltAlt";
            this.lblDataUltAlt.Size = new System.Drawing.Size(67, 13);
            this.lblDataUltAlt.TabIndex = 10;
            this.lblDataUltAlt.Text = "Data Últ. Alt.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInativo);
            this.groupBox1.Controls.Add(this.rbAtivo);
            this.groupBox1.Location = new System.Drawing.Point(231, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 49);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(80, 20);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbInativo_CheckedChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(16, 20);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodigo.BorderRadius = 5;
            this.txtCodigo.BorderSize = 1;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodigo.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.Location = new System.Drawing.Point(16, 40);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.Size = new System.Drawing.Size(100, 28);
            this.txtCodigo.TabIndex = 16;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.Texts = "";
            this.txtCodigo.UnderlinedStyle = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnSalvar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnSalvar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnSalvar.BorderRadius = 5;
            this.btnSalvar.BorderSize = 1;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(226, 408);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundColor = System.Drawing.Color.White;
            this.btnSair.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnSair.BorderRadius = 5;
            this.btnSair.BorderSize = 1;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnSair.Location = new System.Drawing.Point(312, 408);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 28);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sai&r";
            this.btnSair.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataCadastro.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataCadastro.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataCadastro.BorderRadius = 5;
            this.txtDataCadastro.BorderSize = 1;
            this.txtDataCadastro.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataCadastro.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataCadastro.Location = new System.Drawing.Point(12, 408);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.MaxLength = 32767;
            this.txtDataCadastro.Multiline = false;
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataCadastro.PasswordChar = false;
            this.txtDataCadastro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataCadastro.PlaceholderText = "";
            this.txtDataCadastro.Size = new System.Drawing.Size(82, 27);
            this.txtDataCadastro.TabIndex = 32;
            this.txtDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataCadastro.Texts = "  /  /";
            this.txtDataCadastro.UnderlinedStyle = false;
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataUltAlt.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDataUltAlt.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDataUltAlt.BorderRadius = 5;
            this.txtDataUltAlt.BorderSize = 1;
            this.txtDataUltAlt.DisabledBackColor = System.Drawing.Color.White;
            this.txtDataUltAlt.DisabledForeColor = System.Drawing.Color.White;
            this.txtDataUltAlt.Enabled = false;
            this.txtDataUltAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataUltAlt.Location = new System.Drawing.Point(109, 408);
            this.txtDataUltAlt.Mask = "00/00/0000";
            this.txtDataUltAlt.MaxLength = 32767;
            this.txtDataUltAlt.Multiline = false;
            this.txtDataUltAlt.Name = "txtDataUltAlt";
            this.txtDataUltAlt.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDataUltAlt.PasswordChar = false;
            this.txtDataUltAlt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDataUltAlt.PlaceholderText = "";
            this.txtDataUltAlt.Size = new System.Drawing.Size(82, 27);
            this.txtDataUltAlt.TabIndex = 33;
            this.txtDataUltAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataUltAlt.Texts = "  /  /";
            this.txtDataUltAlt.UnderlinedStyle = false;
            // 
            // CadastroPaiCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(399, 454);
            this.Controls.Add(this.txtDataUltAlt);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDataUltAlt);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroPaiCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroPaiCEP";
            this.Load += new System.EventHandler(this.CadastroPaiCEP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblDataCadastro;
        protected System.Windows.Forms.Label lblDataUltAlt;
        protected System.Windows.Forms.RadioButton rbInativo;
        protected System.Windows.Forms.RadioButton rbAtivo;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected GControls.GTextBox txtCodigo;
        protected GButtons btnSalvar;
        public GButtons btnSair;
        protected GControls.GMaskedTextBox txtDataCadastro;
        protected GControls.GMaskedTextBox txtDataUltAlt;
        protected System.Windows.Forms.Label lblCodigo;
    }
}