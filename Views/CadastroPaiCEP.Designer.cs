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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtDataUltAlt = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblDataUltAlt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
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
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(16, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(222, 413);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(303, 413);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 416);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(67, 20);
            this.txtDataCadastro.TabIndex = 7;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Enabled = false;
            this.txtDataUltAlt.Location = new System.Drawing.Point(104, 416);
            this.txtDataUltAlt.Mask = "00/00/0000";
            this.txtDataUltAlt.Name = "txtDataUltAlt";
            this.txtDataUltAlt.Size = new System.Drawing.Size(67, 20);
            this.txtDataUltAlt.TabIndex = 8;
            this.txtDataUltAlt.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 400);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDataCadastro.TabIndex = 9;
            this.lblDataCadastro.Text = "Data Cadastro";
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.AutoSize = true;
            this.lblDataUltAlt.Location = new System.Drawing.Point(101, 400);
            this.lblDataUltAlt.Name = "lblDataUltAlt";
            this.lblDataUltAlt.Size = new System.Drawing.Size(67, 13);
            this.lblDataUltAlt.TabIndex = 10;
            this.lblDataUltAlt.Text = "Data Últ. Alt.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInativo);
            this.groupBox1.Controls.Add(this.rbAtivo);
            this.groupBox1.Location = new System.Drawing.Point(16, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(80, 24);
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
            this.rbAtivo.Location = new System.Drawing.Point(16, 24);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.rbAtivo_CheckedChanged);
            // 
            // CadastroPaiCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDataUltAlt);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.txtDataUltAlt);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroPaiCEP";
            this.Text = "CadastroPaiCEP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        protected System.Windows.Forms.TextBox txtCodigo;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.MaskedTextBox txtDataCadastro;
        protected System.Windows.Forms.MaskedTextBox txtDataUltAlt;
        protected System.Windows.Forms.Label lblDataCadastro;
        protected System.Windows.Forms.Label lblDataUltAlt;
        protected System.Windows.Forms.RadioButton rbInativo;
        protected System.Windows.Forms.RadioButton rbAtivo;
        protected System.Windows.Forms.GroupBox groupBox1;
    }
}