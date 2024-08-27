namespace Sistema_Vendas.Views
{
    partial class ConsultaContasPagar
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
            this.dataGridViewContasPagar = new System.Windows.Forms.DataGridView();
            this.numeroNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCancelamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBuscaInativos
            // 
            this.cbBuscaInativos.Location = new System.Drawing.Point(684, 25);
            this.cbBuscaInativos.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(304, 8);
            this.groupBox2.Size = new System.Drawing.Size(113, 40);
            // 
            // rbCodigo
            // 
            this.rbCodigo.Location = new System.Drawing.Point(120, 14);
            this.rbCodigo.Visible = false;
            // 
            // rbNome
            // 
            this.rbNome.Size = new System.Drawing.Size(88, 17);
            this.rbNome.Text = "Número Nota";
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Location = new System.Drawing.Point(546, 422);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(627, 422);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(12, 422);
            this.btnExcluir.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.Location = new System.Drawing.Point(209, 16);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(708, 422);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 16);
            // 
            // dataGridViewContasPagar
            // 
            this.dataGridViewContasPagar.AllowUserToAddRows = false;
            this.dataGridViewContasPagar.AllowUserToDeleteRows = false;
            this.dataGridViewContasPagar.AllowUserToResizeColumns = false;
            this.dataGridViewContasPagar.AllowUserToResizeRows = false;
            this.dataGridViewContasPagar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContasPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroNota,
            this.modelo,
            this.serie,
            this.idFornecedor,
            this.fornecedor,
            this.parcela,
            this.valorParcela,
            this.dataVencimento,
            this.dataPagamento,
            this.dataCancelamento});
            this.dataGridViewContasPagar.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewContasPagar.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewContasPagar.Name = "dataGridViewContasPagar";
            this.dataGridViewContasPagar.ReadOnly = true;
            this.dataGridViewContasPagar.Size = new System.Drawing.Size(771, 346);
            this.dataGridViewContasPagar.TabIndex = 17;
            this.dataGridViewContasPagar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContasPagar_CellContentClick);
            this.dataGridViewContasPagar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContasPagar_CellDoubleClick);
            this.dataGridViewContasPagar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewContasPagar_CellFormatting);
            // 
            // numeroNota
            // 
            this.numeroNota.HeaderText = "Número Nota";
            this.numeroNota.Name = "numeroNota";
            this.numeroNota.ReadOnly = true;
            this.numeroNota.Width = 80;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 60;
            // 
            // serie
            // 
            this.serie.HeaderText = "Série";
            this.serie.Name = "serie";
            this.serie.ReadOnly = true;
            this.serie.Width = 60;
            // 
            // idFornecedor
            // 
            this.idFornecedor.HeaderText = "Cód. Fornecedor";
            this.idFornecedor.Name = "idFornecedor";
            this.idFornecedor.ReadOnly = true;
            this.idFornecedor.Width = 70;
            // 
            // fornecedor
            // 
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 160;
            // 
            // parcela
            // 
            this.parcela.HeaderText = "Parcela";
            this.parcela.Name = "parcela";
            this.parcela.ReadOnly = true;
            this.parcela.Width = 60;
            // 
            // valorParcela
            // 
            this.valorParcela.HeaderText = "Valor";
            this.valorParcela.Name = "valorParcela";
            this.valorParcela.ReadOnly = true;
            this.valorParcela.Width = 80;
            // 
            // dataVencimento
            // 
            this.dataVencimento.HeaderText = "Data Vencimento";
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.ReadOnly = true;
            this.dataVencimento.Width = 80;
            // 
            // dataPagamento
            // 
            this.dataPagamento.HeaderText = "Data Pagamento";
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.ReadOnly = true;
            this.dataPagamento.Width = 80;
            // 
            // dataCancelamento
            // 
            this.dataCancelamento.HeaderText = "Data Cancelamento";
            this.dataCancelamento.Name = "dataCancelamento";
            this.dataCancelamento.ReadOnly = true;
            this.dataCancelamento.Width = 80;
            // 
            // ConsultaContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.dataGridViewContasPagar);
            this.Name = "ConsultaContasPagar";
            this.Text = "Consulta Contas a Pagar";
            this.Load += new System.EventHandler(this.ConsultaContasPagar_Load);
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.dataGridViewContasPagar, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContasPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCancelamento;
    }
}
