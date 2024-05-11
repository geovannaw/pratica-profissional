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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbJuridica
            // 
            this.rbJuridica.TabIndex = 4;
            // 
            // rbFisica
            // 
            this.rbFisica.TabIndex = 3;
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 27;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 26;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 29;
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 28;
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 12;
            // 
            // txtCelular
            // 
            this.txtCelular.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.TabIndex = 8;
            // 
            // txtCliente_razao_social
            // 
            this.txtCliente_razao_social.TabIndex = 5;
            // 
            // txtApelido_nome_fantasia
            // 
            this.txtApelido_nome_fantasia.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.TabIndex = 25;
            // 
            // txtPais
            // 
            this.txtPais.TabIndex = 22;
            // 
            // txtUF
            // 
            this.txtUF.TabIndex = 21;
            // 
            // btnConsultaCidades
            // 
            this.btnConsultaCidades.TabIndex = 19;
            this.btnConsultaCidades.Click += new System.EventHandler(this.btnConsultaCidades_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.TabIndex = 20;
            // 
            // txtNumero
            // 
            this.txtNumero.TabIndex = 15;
            // 
            // txtComplemento
            // 
            this.txtComplemento.TabIndex = 16;
            // 
            // txtEndereco
            // 
            this.txtEndereco.TabIndex = 14;
            // 
            // txtCEP
            // 
            this.txtCEP.TabIndex = 13;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.TabIndex = 11;
            // 
            // txtSexo
            // 
            this.txtSexo.TabIndex = 7;
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.TabIndex = 18;
            this.txtCodCidade.Leave += new System.EventHandler(this.txtCodCidade_Leave);
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.TabIndex = 23;
            // 
            // txtIE_RG
            // 
            this.txtIE_RG.TabIndex = 24;
            // 
            // CadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Name = "CadastroFornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFornecedor_FormClosed);
            this.Load += new System.EventHandler(this.CadastroFornecedores_Load);
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
