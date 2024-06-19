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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubTotalServicos = new System.Windows.Forms.TextBox();
            this.lblSubTotalServicos = new System.Windows.Forms.Label();
            this.txtSubTotalProdutos = new System.Windows.Forms.TextBox();
            this.lblSubTotalProdutos = new System.Windows.Forms.Label();
            this.tabServicos = new System.Windows.Forms.TabPage();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnConsultaProduto = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.tabDadosPrincipais = new System.Windows.Forms.TabPage();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txxtFuncionario = new System.Windows.Forms.TextBox();
            this.btnConsultaFuncionarios = new System.Windows.Forms.Button();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnConsultaClientes = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gpTotal.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            this.tabDadosPrincipais.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "% Desconto";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 10;
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
            this.tabProdutos.Controls.Add(this.dataGridView1);
            this.tabProdutos.Controls.Add(this.lblMarca);
            this.tabProdutos.Controls.Add(this.lblModelo);
            this.tabProdutos.Controls.Add(this.txtMarca);
            this.tabProdutos.Controls.Add(this.txtModelo);
            this.tabProdutos.Controls.Add(this.lblCodProduto);
            this.tabProdutos.Controls.Add(this.txtCodProduto);
            this.tabProdutos.Controls.Add(this.txtProduto);
            this.tabProdutos.Controls.Add(this.btnConsultaProduto);
            this.tabProdutos.Controls.Add(this.lblProduto);
            this.tabProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdutos.Size = new System.Drawing.Size(591, 317);
            this.tabProdutos.TabIndex = 1;
            this.tabProdutos.Text = "Produtos";
            this.tabProdutos.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(469, 37);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(101, 20);
            this.txtMarca.TabIndex = 69;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(335, 37);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(120, 20);
            this.txtModelo.TabIndex = 68;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(18, 21);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(69, 13);
            this.lblCodProduto.TabIndex = 67;
            this.lblCodProduto.Text = "Cód. Produto";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(21, 37);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(66, 20);
            this.txtCodProduto.TabIndex = 63;
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(142, 37);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(180, 20);
            this.txtProduto.TabIndex = 65;
            // 
            // btnConsultaProduto
            // 
            this.btnConsultaProduto.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaProduto.Location = new System.Drawing.Point(96, 35);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaProduto.TabIndex = 64;
            this.btnConsultaProduto.UseVisualStyleBackColor = true;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(139, 21);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 66;
            this.lblProduto.Text = "Produto";
            // 
            // tabDadosPrincipais
            // 
            this.tabDadosPrincipais.Controls.Add(this.txtObservacao);
            this.tabDadosPrincipais.Controls.Add(this.lblObservacao);
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
            this.txtFuncionario.Size = new System.Drawing.Size(91, 20);
            this.txtFuncionario.TabIndex = 63;
            // 
            // txxtFuncionario
            // 
            this.txxtFuncionario.Enabled = false;
            this.txxtFuncionario.Location = new System.Drawing.Point(176, 102);
            this.txxtFuncionario.Name = "txxtFuncionario";
            this.txxtFuncionario.Size = new System.Drawing.Size(180, 20);
            this.txxtFuncionario.TabIndex = 65;
            // 
            // btnConsultaFuncionarios
            // 
            this.btnConsultaFuncionarios.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaFuncionarios.Location = new System.Drawing.Point(129, 100);
            this.btnConsultaFuncionarios.Name = "btnConsultaFuncionarios";
            this.btnConsultaFuncionarios.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaFuncionarios.TabIndex = 64;
            this.btnConsultaFuncionarios.UseVisualStyleBackColor = true;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(173, 86);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 66;
            this.lblFuncionario.Text = "Funcionário";
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
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(27, 40);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(91, 20);
            this.txtCodCliente.TabIndex = 58;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(176, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(180, 20);
            this.txtCliente.TabIndex = 60;
            // 
            // btnConsultaClientes
            // 
            this.btnConsultaClientes.Image = global::Sistema_Vendas.Properties.Resources.imagem_lupa;
            this.btnConsultaClientes.Location = new System.Drawing.Point(129, 38);
            this.btnConsultaClientes.Name = "btnConsultaClientes";
            this.btnConsultaClientes.Size = new System.Drawing.Size(36, 24);
            this.btnConsultaClientes.TabIndex = 59;
            this.btnConsultaClientes.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(173, 24);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 61;
            this.lblCliente.Text = "Cliente";
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
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(332, 21);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 70;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(466, 21);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 71;
            this.lblMarca.Text = "Marca";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 200);
            this.dataGridView1.TabIndex = 72;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(24, 198);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 68;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(27, 214);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(534, 72);
            this.txtObservacao.TabIndex = 69;
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(440, 40);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(171, 21);
            this.cbSituacao.TabIndex = 14;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(437, 24);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 15;
            this.lblSituacao.Text = "Situação";
            // 
            // CadastroOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.cbSituacao);
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
            this.Controls.SetChildIndex(this.cbSituacao, 0);
            this.Controls.SetChildIndex(this.lblSituacao, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpTotal.ResumeLayout(false);
            this.gpTotal.PerformLayout();
            this.tabProdutos.ResumeLayout(false);
            this.tabProdutos.PerformLayout();
            this.tabDadosPrincipais.ResumeLayout(false);
            this.tabDadosPrincipais.PerformLayout();
            this.tabPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        protected System.Windows.Forms.TextBox txtMarca;
        protected System.Windows.Forms.TextBox txtModelo;
        protected System.Windows.Forms.Label lblCodProduto;
        protected System.Windows.Forms.TextBox txtCodProduto;
        protected System.Windows.Forms.TextBox txtProduto;
        protected System.Windows.Forms.Button btnConsultaProduto;
        protected System.Windows.Forms.Label lblProduto;
        protected System.Windows.Forms.Label lblMarca;
        protected System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.TextBox txtObservacao;
        protected System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label lblSituacao;
    }
}
