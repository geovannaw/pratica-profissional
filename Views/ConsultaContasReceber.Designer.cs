namespace Sistema_Vendas.Views
{
    partial class ConsultaContasReceber
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
            this.dataGridViewContasReceber = new System.Windows.Forms.DataGridView();
            this.numeroNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCancelamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBuscaInativos
            // 
            this.cbBuscaInativos.Location = new System.Drawing.Point(675, 25);
            this.cbBuscaInativos.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(107, 40);
            // 
            // rbCodigo
            // 
            this.rbCodigo.Location = new System.Drawing.Point(110, 17);
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
            this.btnIncluir.Location = new System.Drawing.Point(549, 422);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(630, 422);
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
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(711, 422);
            // 
            // dataGridViewContasReceber
            // 
            this.dataGridViewContasReceber.AllowUserToAddRows = false;
            this.dataGridViewContasReceber.AllowUserToDeleteRows = false;
            this.dataGridViewContasReceber.AllowUserToResizeColumns = false;
            this.dataGridViewContasReceber.AllowUserToResizeRows = false;
            this.dataGridViewContasReceber.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroNota,
            this.modelo,
            this.serie,
            this.idCliente,
            this.cliente,
            this.parcela,
            this.valorParcela,
            this.dataVencimento,
            this.dataRecebimento,
            this.dataCancelamento});
            this.dataGridViewContasReceber.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewContasReceber.Location = new System.Drawing.Point(15, 58);
            this.dataGridViewContasReceber.Name = "dataGridViewContasReceber";
            this.dataGridViewContasReceber.ReadOnly = true;
            this.dataGridViewContasReceber.Size = new System.Drawing.Size(771, 346);
            this.dataGridViewContasReceber.TabIndex = 18;
            this.dataGridViewContasReceber.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContasReceber_CellDoubleClick);
            this.dataGridViewContasReceber.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewContasReceber_CellFormatting);
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
            // idCliente
            // 
            this.idCliente.HeaderText = "Cód. Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 70;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 160;
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
            // dataRecebimento
            // 
            this.dataRecebimento.HeaderText = "Data Recebimento";
            this.dataRecebimento.Name = "dataRecebimento";
            this.dataRecebimento.ReadOnly = true;
            this.dataRecebimento.Width = 80;
            // 
            // dataCancelamento
            // 
            this.dataCancelamento.HeaderText = "Data Cancelamento";
            this.dataCancelamento.Name = "dataCancelamento";
            this.dataCancelamento.ReadOnly = true;
            this.dataCancelamento.Width = 80;
            // 
            // ConsultaContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.dataGridViewContasReceber);
            this.Name = "ConsultaContasReceber";
            this.Text = "Consulta Contas Receber";
            this.Load += new System.EventHandler(this.ConsultaContasReceber_Load);
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.dataGridViewContasReceber, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContasReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCancelamento;
    }
}
