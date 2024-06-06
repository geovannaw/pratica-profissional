namespace Sistema_Vendas.Views
{
    partial class CadastroFornecedores
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
            // rbFisica
            // 
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // rbJuridica
            // 
//            this.rbJuridica.CheckedChanged += new System.EventHandler(this.rbJuridica_CheckedChanged);
            // 
            // CadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Name = "CadastroFornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFornecedores_FormClosed);
            this.Load += new System.EventHandler(this.CadastroFornecedores_Load);
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

        private System.Windows.Forms.Label label1;
    }
}
