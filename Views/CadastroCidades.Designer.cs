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
            this.lblCodEstado = new System.Windows.Forms.Label();
            this.txtCodEstado = new System.Windows.Forms.TextBox();
            this.btnConsultaEstado = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 9;
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
            // lblCodEstado
            // 
            this.lblCodEstado.AutoSize = true;
            this.lblCodEstado.Location = new System.Drawing.Point(14, 148);
            this.lblCodEstado.Name = "lblCodEstado";
            this.lblCodEstado.Size = new System.Drawing.Size(76, 13);
            this.lblCodEstado.TabIndex = 24;
            this.lblCodEstado.Text = "Código Estado";
            // 
            // txtCodEstado
            // 
            this.txtCodEstado.Location = new System.Drawing.Point(16, 168);
            this.txtCodEstado.Name = "txtCodEstado";
            this.txtCodEstado.Size = new System.Drawing.Size(66, 20);
            this.txtCodEstado.TabIndex = 4;
            this.txtCodEstado.Leave += new System.EventHandler(this.txtCodEstado_Leave);
            // 
            // btnConsultaEstado
            // 
            this.btnConsultaEstado.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaEstado.Location = new System.Drawing.Point(87, 166);
            this.btnConsultaEstado.Name = "btnConsultaEstado";
            this.btnConsultaEstado.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaEstado.TabIndex = 5;
            this.btnConsultaEstado.UseVisualStyleBackColor = true;
            this.btnConsultaEstado.Click += new System.EventHandler(this.btnConsultaEstado_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(128, 168);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(248, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(278, 96);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(100, 20);
            this.txtDDD.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(16, 96);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(246, 20);
            this.txtCidade.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(128, 152);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(275, 80);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 17;
            this.lblDDD.Text = "DDD";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(16, 81);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade";
            // 
            // CadastroCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(399, 454);
            this.Controls.Add(this.lblCodEstado);
            this.Controls.Add(this.txtCodEstado);
            this.Controls.Add(this.btnConsultaEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDDD);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDDD);
            this.Controls.Add(this.lblCidade);
            this.Name = "CadastroCidades";
            this.Text = "Cadastro de Cidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroCidades_FormClosed);
            this.Load += new System.EventHandler(this.CadastroCidades_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCidade, 0);
            this.Controls.SetChildIndex(this.lblDDD, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtDDD, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.btnConsultaEstado, 0);
            this.Controls.SetChildIndex(this.txtCodEstado, 0);
            this.Controls.SetChildIndex(this.lblCodEstado, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodEstado;
        private System.Windows.Forms.TextBox txtCodEstado;
        private System.Windows.Forms.Button btnConsultaEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblCidade;
    }
}
