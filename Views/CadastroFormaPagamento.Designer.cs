namespace Sistema_Vendas.Views
{
    partial class CadastroFormaPagamento
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
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new Sistema_Vendas.GControls.GTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(15, 191);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(103, 191);
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 6;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Texts = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(224, 204);
            this.btnSalvar.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(305, 204);
            this.btnSair.TabIndex = 3;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(18, 207);
            this.txtDataCadastro.Texts = "04/07/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(106, 207);
            this.txtDataUltAlt.Texts = "04/07/2024";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(13, 106);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(115, 13);
            this.lblFormaPagamento.TabIndex = 13;
            this.lblFormaPagamento.Text = "Forma de Pagamento *";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtFormaPagamento.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPagamento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.txtFormaPagamento.BorderRadius = 5;
            this.txtFormaPagamento.BorderSize = 1;
            this.txtFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamento.DisabledBackColor = System.Drawing.Color.White;
            this.txtFormaPagamento.DisabledBorderColor = System.Drawing.Color.Gainsboro;
            this.txtFormaPagamento.DisabledForeColor = System.Drawing.Color.White;
            this.txtFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtFormaPagamento.Location = new System.Drawing.Point(16, 122);
            this.txtFormaPagamento.MaxLength = 50;
            this.txtFormaPagamento.Multiline = false;
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtFormaPagamento.PasswordChar = false;
            this.txtFormaPagamento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFormaPagamento.PlaceholderText = "";
            this.txtFormaPagamento.Size = new System.Drawing.Size(364, 28);
            this.txtFormaPagamento.TabIndex = 1;
            this.txtFormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFormaPagamento.Texts = "";
            this.txtFormaPagamento.UnderlinedStyle = false;
            this.txtFormaPagamento.Leave += new System.EventHandler(this.txtFormaPagamento_Leave);
            // 
            // CadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(396, 249);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.lblFormaPagamento);
            this.Name = "CadastroFormaPagamento";
            this.Text = "Cadastro Forma de Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFormaPagamento_FormClosed);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblFormaPagamento, 0);
            this.Controls.SetChildIndex(this.txtFormaPagamento, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFormaPagamento;
        private GControls.GTextBox txtFormaPagamento;
    }
}
