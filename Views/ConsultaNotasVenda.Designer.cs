namespace Sistema_Vendas.Views
{
    partial class ConsultaNotasVenda
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
            this.btnVisualizar = new Sistema_Vendas.GButtons();
            this.dataGridViewNFVenda = new System.Windows.Forms.DataGridView();
            this.numeroNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCancelamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNFVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBuscaInativos
            // 
            this.cbBuscaInativos.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(296, 8);
            this.groupBox2.Size = new System.Drawing.Size(107, 40);
            // 
            // rbCodigo
            // 
            this.rbCodigo.Location = new System.Drawing.Point(110, 15);
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
            this.btnIncluir.Location = new System.Drawing.Point(416, 414);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(12, 414);
            this.btnAlterar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(93, 414);
            this.btnExcluir.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(578, 414);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnVisualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnVisualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(23)))), ((int)(((byte)(159)))));
            this.btnVisualizar.BorderRadius = 5;
            this.btnVisualizar.BorderSize = 1;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Location = new System.Drawing.Point(497, 414);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 28);
            this.btnVisualizar.TabIndex = 19;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.TextColor = System.Drawing.Color.White;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dataGridViewNFVenda
            // 
            this.dataGridViewNFVenda.AllowUserToAddRows = false;
            this.dataGridViewNFVenda.AllowUserToDeleteRows = false;
            this.dataGridViewNFVenda.AllowUserToResizeColumns = false;
            this.dataGridViewNFVenda.AllowUserToResizeRows = false;
            this.dataGridViewNFVenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewNFVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNFVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroNota,
            this.modelo,
            this.serie,
            this.idCliente,
            this.cliente,
            this.dataEmissao,
            this.DataCancelamento});
            this.dataGridViewNFVenda.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewNFVenda.Location = new System.Drawing.Point(13, 58);
            this.dataGridViewNFVenda.Name = "dataGridViewNFVenda";
            this.dataGridViewNFVenda.ReadOnly = true;
            this.dataGridViewNFVenda.Size = new System.Drawing.Size(641, 339);
            this.dataGridViewNFVenda.TabIndex = 20;
            this.dataGridViewNFVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNFVenda_CellDoubleClick);
            this.dataGridViewNFVenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewNFVenda_CellFormatting);
            // 
            // numeroNota
            // 
            this.numeroNota.HeaderText = "Número";
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
            this.idCliente.HeaderText = "Código Cliente";
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
            // dataEmissao
            // 
            this.dataEmissao.HeaderText = "Data Emissão";
            this.dataEmissao.Name = "dataEmissao";
            this.dataEmissao.ReadOnly = true;
            this.dataEmissao.Width = 85;
            // 
            // DataCancelamento
            // 
            this.DataCancelamento.HeaderText = "Data Cancelamento";
            this.DataCancelamento.Name = "DataCancelamento";
            this.DataCancelamento.ReadOnly = true;
            this.DataCancelamento.Width = 83;
            // 
            // ConsultaNotasVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(667, 454);
            this.Controls.Add(this.dataGridViewNFVenda);
            this.Controls.Add(this.btnVisualizar);
            this.Name = "ConsultaNotasVenda";
            this.Text = "Consulta de Notas Venda";
            this.Load += new System.EventHandler(this.ConsultaNotasVenda_Load);
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnVisualizar, 0);
            this.Controls.SetChildIndex(this.dataGridViewNFVenda, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNFVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected GButtons btnVisualizar;
        private System.Windows.Forms.DataGridView dataGridViewNFVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCancelamento;
    }
}
