namespace Sistema_Vendas.Views
{
    partial class CadastroOS
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
            this.gpTotal = new System.Windows.Forms.GroupBox();
            this.txtSubTotalProdutos = new System.Windows.Forms.TextBox();
            this.lblSubTotalProdutos = new System.Windows.Forms.Label();
            this.txtSubTotalServicos = new System.Windows.Forms.TextBox();
            this.lblSubTotalServicos = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabServicos = new System.Windows.Forms.TabPage();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.tabDadosPrincipais = new System.Windows.Forms.TabPage();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnConsultaClientes = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txxtFuncionario = new System.Windows.Forms.TextBox();
            this.btnConsultaFuncionarios = new System.Windows.Forms.Button();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gpTotal.SuspendLayout();
            this.tabDadosPrincipais.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Text = "0";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(621, 447);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(702, 447);
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(16, 450);
            this.txtDataCadastro.Text = "14062024";
            // 
            // txtDataUltAlt
            // 
            this.txtDataUltAlt.Location = new System.Drawing.Point(104, 450);
            this.txtDataUltAlt.Text = "14062024";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Location = new System.Drawing.Point(13, 434);
            // 
            // lblDataUltAlt
            // 
            this.lblDataUltAlt.Location = new System.Drawing.Point(101, 434);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(628, 18);
            // 
            // gpTotal
            // 
            this.gpTotal.Controls.Add(this.label1);
            this.gpTotal.Controls.Add(this.textBox2);
            this.gpTotal.Controls.Add(this.txtDesconto);
            this.gpTotal.Controls.Add(this.lblDesconto);
            this.gpTotal.Controls.Add(this.txtTotal);
            this.gpTotal.Controls.Add(this.lblTotal);
            this.gpTotal.Controls.Add(this.txtSubTotalServicos);
            this.gpTotal.Controls.Add(this.lblSubTotalServicos);
            this.gpTotal.Controls.Add(this.txtSubTotalProdutos);
            this.gpTotal.Controls.Add(this.lblSubTotalProdutos);
            this.gpTotal.Location = new System.Drawing.Point(628, 90);
            this.gpTotal.Name = "gpTotal";
            this.gpTotal.Size = new System.Drawing.Size(149, 326);
            this.gpTotal.TabIndex = 13;
            this.gpTotal.TabStop = false;
            this.gpTotal.Text = "Total Ordem de Serviço";
            // 
            // txtSubTotalProdutos
            // 
            this.txtSubTotalProdutos.Location = new System.Drawing.Point(13, 73);
            this.txtSubTotalProdutos.Name = "txtSubTotalProdutos";
            this.txtSubTotalProdutos.Size = new System.Drawing.Size(124, 20);
            this.txtSubTotalProdutos.TabIndex = 3;
            // 
            // lblSubTotalProdutos
            // 
            this.lblSubTotalProdutos.AutoSize = true;
            this.lblSubTotalProdutos.Location = new System.Drawing.Point(10, 57);
            this.lblSubTotalProdutos.Name = "lblSubTotalProdutos";
            this.lblSubTotalProdutos.Size = new System.Drawing.Size(91, 13);
            this.lblSubTotalProdutos.TabIndex = 2;
            this.lblSubTotalProdutos.Text = "Subtotal Produtos";
            // 
            // txtSubTotalServicos
            // 
            this.txtSubTotalServicos.Location = new System.Drawing.Point(13, 130);
            this.txtSubTotalServicos.Name = "txtSubTotalServicos";
            this.txtSubTotalServicos.Size = new System.Drawing.Size(124, 20);
            this.txtSubTotalServicos.TabIndex = 5;
            // 
            // lblSubTotalServicos
            // 
            this.lblSubTotalServicos.AutoSize = true;
            this.lblSubTotalServicos.Location = new System.Drawing.Point(10, 114);
            this.lblSubTotalServicos.Name = "lblSubTotalServicos";
            this.lblSubTotalServicos.Size = new System.Drawing.Size(90, 13);
            this.lblSubTotalServicos.TabIndex = 4;
            this.lblSubTotalServicos.Text = "Subtotal Serviços";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(13, 250);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(124, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(10, 234);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(16, 187);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(56, 20);
            this.txtDesconto.TabIndex = 9;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(13, 171);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(53, 13);
            this.lblDesconto.TabIndex = 8;
            this.lblDesconto.Text = "Desconto";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "% Desconto";
            // 
            // tabServicos
            // 
            this.tabServicos.Location = new System.Drawing.Point(4, 22);
            this.tabServicos.Name = "tabServicos";
            this.tabServicos.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicos.Size = new System.Drawing.Size(591, 317);
            this.tabServicos.TabIndex = 2;
            this.tabServicos.Text = "Serviços";
            this.tabServicos.UseVisualStyleBackColor = true;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdutos.Size = new System.Drawing.Size(591, 317);
            this.tabProdutos.TabIndex = 1;
            this.tabProdutos.Text = "Produtos";
            this.tabProdutos.UseVisualStyleBackColor = true;
            // 
            // tabDadosPrincipais
            // 
            this.tabDadosPrincipais.Controls.Add(this.lblCodFuncionario);
            this.tabDadosPrincipais.Controls.Add(this.txtFuncionario);
            this.tabDadosPrincipais.Controls.Add(this.txxtFuncionario);
            this.tabDadosPrincipais.Controls.Add(this.btnConsultaFuncionarios);
            this.tabDadosPrincipais.Controls.Add(this.lblFuncionario);
            this.tabDadosPrincipais.Controls.Add(this.lblCodCliente);
            this.tabDadosPrincipais.Controls.Add(this.txtCodCliente);
            this.tabDadosPrincipais.Controls.Add(this.txtCliente);
            this.tabDadosPrincipais.Controls.Add(this.btnConsultaClientes);
            this.tabDadosPrincipais.Controls.Add(this.lblCliente);
            this.tabDadosPrincipais.Location = new System.Drawing.Point(4, 22);
            this.tabDadosPrincipais.Name = "tabDadosPrincipais";
            this.tabDadosPrincipais.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosPrincipais.Size = new System.Drawing.Size(591, 317);
            this.tabDadosPrincipais.TabIndex = 0;
            this.tabDadosPrincipais.Text = "Dados Principais";
            this.tabDadosPrincipais.UseVisualStyleBackColor = true;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabDadosPrincipais);
            this.tabPrincipal.Controls.Add(this.tabProdutos);
            this.tabPrincipal.Controls.Add(this.tabServicos);
            this.tabPrincipal.Location = new System.Drawing.Point(16, 73);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(599, 343);
            this.tabPrincipal.TabIndex = 12;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(143, 24);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 61;
            this.lblCliente.Text = "Cliente";
            // 
            // btnConsultaClientes
            // 
            this.btnConsultaClientes.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaClientes.Location = new System.Drawing.Point(99, 38);
            this.btnConsultaClientes.Name = "btnConsultaClientes";
            this.btnConsultaClientes.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaClientes.TabIndex = 59;
            this.btnConsultaClientes.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(146, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(180, 20);
            this.txtCliente.TabIndex = 60;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(27, 40);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(62, 20);
            this.txtCodCliente.TabIndex = 58;
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(24, 24);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(71, 13);
            this.lblCodCliente.TabIndex = 62;
            this.lblCodCliente.Text = "Cód. Cliente *";
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Location = new System.Drawing.Point(24, 86);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(94, 13);
            this.lblCodFuncionario.TabIndex = 67;
            this.lblCodFuncionario.Text = "Cód. Funcionário *";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(27, 102);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(62, 20);
            this.txtFuncionario.TabIndex = 63;
            // 
            // txxtFuncionario
            // 
            this.txxtFuncionario.Enabled = false;
            this.txxtFuncionario.Location = new System.Drawing.Point(146, 102);
            this.txxtFuncionario.Name = "txxtFuncionario";
            this.txxtFuncionario.Size = new System.Drawing.Size(180, 20);
            this.txxtFuncionario.TabIndex = 65;
            // 
            // btnConsultaFuncionarios
            // 
            this.btnConsultaFuncionarios.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaFuncionarios.Location = new System.Drawing.Point(99, 100);
            this.btnConsultaFuncionarios.Name = "btnConsultaFuncionarios";
            this.btnConsultaFuncionarios.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaFuncionarios.TabIndex = 64;
            this.btnConsultaFuncionarios.UseVisualStyleBackColor = true;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(143, 86);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 66;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // CadastroOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.gpTotal);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "CadastroOS";
            this.Text = "Cadastro Ordem de Serviço ";
            this.Controls.SetChildIndex(this.tabPrincipal, 0);
            this.Controls.SetChildIndex(this.gpTotal, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtDataCadastro, 0);
            this.Controls.SetChildIndex(this.txtDataUltAlt, 0);
            this.Controls.SetChildIndex(this.lblDataCadastro, 0);
            this.Controls.SetChildIndex(this.lblDataUltAlt, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpTotal.ResumeLayout(false);
            this.gpTotal.PerformLayout();
            this.tabDadosPrincipais.ResumeLayout(false);
            this.tabDadosPrincipais.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubTotalServicos;
        private System.Windows.Forms.Label lblSubTotalServicos;
        private System.Windows.Forms.TextBox txtSubTotalProdutos;
        private System.Windows.Forms.Label lblSubTotalProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabServicos;
        private System.Windows.Forms.TabPage tabProdutos;
        private System.Windows.Forms.TabPage tabDadosPrincipais;
        protected System.Windows.Forms.Label lblCodCliente;
        protected System.Windows.Forms.TextBox txtCodCliente;
        protected System.Windows.Forms.TextBox txtCliente;
        protected System.Windows.Forms.Button btnConsultaClientes;
        protected System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TabControl tabPrincipal;
        protected System.Windows.Forms.Label lblCodFuncionario;
        protected System.Windows.Forms.TextBox txtFuncionario;
        protected System.Windows.Forms.TextBox txxtFuncionario;
        protected System.Windows.Forms.Button btnConsultaFuncionarios;
        protected System.Windows.Forms.Label lblFuncionario;
    }
}
