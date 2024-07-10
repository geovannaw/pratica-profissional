namespace Sistema_Vendas.Views
{
    partial class CadastroCidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCidades));
            this.lblCodEstado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new Sistema_Vendas.GControls.GTextBox();
            this.txtDDD = new Sistema_Vendas.GControls.GTextBox();
            this.txtCodEstado = new Sistema_Vendas.GControls.GTextBox();
            this.txtEstado = new Sistema_Vendas.GControls.GTextBox();
            this.btnConsultaEstado = new Sistema_Vendas.GButtons();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 9;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.rbInativo_CheckedChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 8;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Texts = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.TabIndex = 6;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Texts = "04/07/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Texts = "04/07/2024";
            // 
            // lblCodEstado
            // 
            this.lblCodEstado.AutoSize = true;
            this.lblCodEstado.Location = new System.Drawing.Point(14, 146);
            this.lblCodEstado.Name = "lblCodEstado";
            this.lblCodEstado.Size = new System.Drawing.Size(83, 13);
            this.lblCodEstado.TabIndex = 24;
            this.lblCodEstado.Text = "Código Estado *";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(140, 146);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(275, 84);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(38, 13);
            this.lblDDD.TabIndex = 17;
            this.lblDDD.Text = "DDD *";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(13, 85);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 13);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade *";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCidade.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCidade.BorderRadius = 5;
            this.txtCidade.BorderSize = 1;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.DisabledBackColor = System.Drawing.Color.White;
            this.txtCidade.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCidade.DisabledForeColor = System.Drawing.Color.White;
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCidade.Location = new System.Drawing.Point(16, 101);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Multiline = false;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCidade.PasswordChar = false;
            this.txtCidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCidade.PlaceholderText = "";
            this.txtCidade.Size = new System.Drawing.Size(246, 28);
            this.txtCidade.TabIndex = 1;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCidade.Texts = "";
            this.txtCidade.UnderlinedStyle = false;
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // txtDDD
            // 
            this.txtDDD.BackColor = System.Drawing.SystemColors.Window;
            this.txtDDD.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDDD.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtDDD.BorderRadius = 5;
            this.txtDDD.BorderSize = 1;
            this.txtDDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDD.DisabledBackColor = System.Drawing.Color.White;
            this.txtDDD.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtDDD.DisabledForeColor = System.Drawing.Color.White;
            this.txtDDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtDDD.Location = new System.Drawing.Point(278, 101);
            this.txtDDD.MaxLength = 5;
            this.txtDDD.Multiline = false;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtDDD.PasswordChar = false;
            this.txtDDD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDDD.PlaceholderText = "";
            this.txtDDD.Size = new System.Drawing.Size(100, 28);
            this.txtDDD.TabIndex = 2;
            this.txtDDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDDD.Texts = "";
            this.txtDDD.UnderlinedStyle = false;
            this.txtDDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDDD_KeyPress);
            // 
            // txtCodEstado
            // 
            this.txtCodEstado.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodEstado.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCodEstado.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtCodEstado.BorderRadius = 5;
            this.txtCodEstado.BorderSize = 1;
            this.txtCodEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodEstado.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodEstado.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtCodEstado.DisabledForeColor = System.Drawing.Color.White;
            this.txtCodEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCodEstado.Location = new System.Drawing.Point(16, 162);
            this.txtCodEstado.MaxLength = 10;
            this.txtCodEstado.Multiline = false;
            this.txtCodEstado.Name = "txtCodEstado";
            this.txtCodEstado.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtCodEstado.PasswordChar = false;
            this.txtCodEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodEstado.PlaceholderText = "";
            this.txtCodEstado.Size = new System.Drawing.Size(78, 28);
            this.txtCodEstado.TabIndex = 3;
            this.txtCodEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodEstado.Texts = "";
            this.txtCodEstado.UnderlinedStyle = false;
            this.txtCodEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodEstado_KeyPress);
            this.txtCodEstado.Leave += new System.EventHandler(this.txtCodEstado_Leave);
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
            this.txtEstado.Enabled = false;
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtEstado.Location = new System.Drawing.Point(143, 162);
            this.txtEstado.MaxLength = 32767;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtEstado.PasswordChar = false;
            this.txtEstado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEstado.PlaceholderText = "";
            this.txtEstado.Size = new System.Drawing.Size(235, 28);
            this.txtEstado.TabIndex = 37;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstado.Texts = "";
            this.txtEstado.UnderlinedStyle = false;
            // 
            // btnConsultaEstado
            // 
            this.btnConsultaEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaEstado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnConsultaEstado.BorderRadius = 5;
            this.btnConsultaEstado.BorderSize = 1;
            this.btnConsultaEstado.FlatAppearance.BorderSize = 0;
            this.btnConsultaEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEstado.ForeColor = System.Drawing.Color.White;
            this.btnConsultaEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaEstado.Image")));
            this.btnConsultaEstado.Location = new System.Drawing.Point(101, 162);
            this.btnConsultaEstado.Name = "btnConsultaEstado";
            this.btnConsultaEstado.Size = new System.Drawing.Size(36, 28);
            this.btnConsultaEstado.TabIndex = 4;
            this.btnConsultaEstado.TextColor = System.Drawing.Color.White;
            this.btnConsultaEstado.UseVisualStyleBackColor = false;
            this.btnConsultaEstado.Click += new System.EventHandler(this.btnConsultaEstado_Click);
            // 
            // CadastroCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 454);
            this.Controls.Add(this.btnConsultaEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodEstado);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCodEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblCidade);
            this.Name = "CadastroCidades";
            this.Text = "Cadastro de Cidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCidades_FormClosed);
            this.Load += new System.EventHandler(this.CadastroCidades_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.lblDDD, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblCodEstado, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtDDD, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.txtCodEstado, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.btnConsultaEstado, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblCidade;
        private GControls.GTextBox txtCidade;
        private GControls.GTextBox txtDDD;
        private GControls.GTextBox txtCodEstado;
        private GControls.GTextBox txtEstado;
        private GButtons btnConsultaEstado;
    }
}
