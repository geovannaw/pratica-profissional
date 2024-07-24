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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbInativo
            // 
            this.rbInativo.TabIndex = 29;
            // 
            // rbAtivo
            // 
            this.rbAtivo.TabIndex = 28;
            // 
            // rbFisica
            // 
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.TabIndex = 26;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.TabIndex = 25;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Texts = "0";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.TabIndex = 21;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Texts = "04/07/2024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Texts = "04/07/2024";
            // 
            // groupBox1
            // 
            this.groupBox3.TabIndex = 11;
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox1.TabIndex = 27;
            // 
            // groupBox4
            // 
            this.groupBox4.TabIndex = 22;
            // 
            // txtApelido_nome_fantasia
            // 
            this.txtApelido_nome_fantasia.TabIndex = 5;
            // 
            // txtCliente_razao_social
            // 
            this.txtCliente_razao_social.TabIndex = 4;
            this.txtCliente_razao_social.Leave += new System.EventHandler(this.txtCliente_razao_social_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.TabIndex = 7;
            // 
            // txtCelular
            // 
            this.txtCelular.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.TabIndex = 8;
            // 
            // txtContato
            // 
            this.txtContato.TabIndex = 10;
            // 
            // txtIE_RG
            // 
            this.txtIE_RG.TabIndex = 20;
            // 
            // txtCodCondPag
            // 
            this.txtCodCondPag.TabIndex = 23;
            this.txtCodCondPag.Leave += new System.EventHandler(this.txtCodCondPag_Leave);
            // 
            // btnConsultaCondPag
            // 
            this.btnConsultaCondPag.FlatAppearance.BorderSize = 0;
            this.btnConsultaCondPag.TabIndex = 24;
            this.btnConsultaCondPag.Click += new System.EventHandler(this.btnConsultaCondPag_Click);
            // 
            // btnConsultaCidades
            // 
            this.btnConsultaCidades.FlatAppearance.BorderSize = 0;
            this.btnConsultaCidades.Location = new System.Drawing.Point(279, 102);
            this.btnConsultaCidades.TabIndex = 18;
            this.btnConsultaCidades.Click += new System.EventHandler(this.btnConsultaCidades_Click);
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.TabIndex = 17;
            this.txtCodCidade.Leave += new System.EventHandler(this.txtCodCidade_Leave);
            // 
            // txtBairro
            // 
            this.txtBairro.TabIndex = 16;
            // 
            // txtComplemento
            // 
            this.txtComplemento.TabIndex = 15;
            // 
            // txtNumero
            // 
            this.txtNumero.TabIndex = 14;
            // 
            // txtEndereco
            // 
            this.txtEndereco.TabIndex = 13;
            // 
            // txtCEP
            // 
            this.txtCEP.TabIndex = 12;
            // 
            // txtSexo
            // 
            this.txtSexo.TabIndex = 6;
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(791, 544);
            this.Name = "CadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroClientes_FormClosed);
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
