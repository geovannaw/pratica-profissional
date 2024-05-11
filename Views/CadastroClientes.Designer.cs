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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 23;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 22;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 25;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.TabIndex = 8;
            // 
            // txtCelular
            // 
            this.txtCelular.TabIndex = 7;
            // 
            // txtCliente_razao_social
            // 
            this.txtCliente_razao_social.TabIndex = 3;
            // 
            // txtApelido_nome_fantasia
            // 
            this.txtApelido_nome_fantasia.TabIndex = 4;
            // 
            // txtPais
            // 
            this.txtPais.TabIndex = 19;
            // 
            // txtUF
            // 
            this.txtUF.TabIndex = 18;
            // 
            // btnConsultaCidades
            // 
            this.btnConsultaCidades.Location = new System.Drawing.Point(278, 92);
            this.btnConsultaCidades.TabIndex = 17;
            this.btnConsultaCidades.Click += new System.EventHandler(this.btnConsultaCidades_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.TabIndex = 16;
            // 
            // txtBairro
            // 
            this.txtBairro.TabIndex = 14;
            // 
            // txtNumero
            // 
            this.txtNumero.TabIndex = 12;
            // 
            // txtComplemento
            // 
            this.txtComplemento.TabIndex = 13;
            // 
            // txtEndereco
            // 
            this.txtEndereco.TabIndex = 11;
            // 
            // txtCEP
            // 
            this.txtCEP.TabIndex = 10;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.TabIndex = 9;
            // 
            // txtSexo
            // 
            this.txtSexo.ItemHeight = 13;
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.TabIndex = 15;
            this.txtCodCidade.Leave += new System.EventHandler(this.txtCodCidade_Leave);
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.TabIndex = 20;
//            this.txtCPF_CNPJ.Leave += new System.EventHandler(this.txtCPF_CNPJ_Leave);
            // 
            // txtIE_RG
            // 
            this.txtIE_RG.TabIndex = 21;
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Name = "CadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroClientes_FormClosed);
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
