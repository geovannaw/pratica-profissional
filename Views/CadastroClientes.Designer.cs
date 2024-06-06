namespace Sistema_Vendas.Views
{
    partial class CadastroClientes
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
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente_razao_social
            // 
            this.txtCliente_razao_social.Leave += new System.EventHandler(this.txtCliente_razao_social_Leave);
            // 
            // btnConsultaCidades
            // 
            this.btnConsultaCidades.Location = new System.Drawing.Point(278, 92);
            this.btnConsultaCidades.Click += new System.EventHandler(this.btnConsultaCidades_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.ItemHeight = 13;
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.Leave += new System.EventHandler(this.txtCodCidade_Leave);
            // 
            // rbFisica
            // 
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // rbJuridica
            // 
//            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Name = "CadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroClientes_FormClosed);
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
