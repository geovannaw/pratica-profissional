﻿namespace Sistema_Vendas.Views
{
    partial class ConsultaNotaCompra
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
            this.dataGridViewNFCompra = new System.Windows.Forms.DataGridView();
            this.numeroNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCancelamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNFCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBuscaInativos
            // 
            this.cbBuscaInativos.Location = new System.Drawing.Point(556, 19);
            this.cbBuscaInativos.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(296, 7);
            this.groupBox2.Size = new System.Drawing.Size(107, 40);
            // 
            // rbCodigo
            // 
            this.rbCodigo.Location = new System.Drawing.Point(110, 14);
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
            this.btnIncluir.Location = new System.Drawing.Point(421, 412);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(17, 412);
            this.btnAlterar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(98, 412);
            this.btnExcluir.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(583, 412);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(17, 14);
            this.txtPesquisa.Size = new System.Drawing.Size(184, 28);
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
            this.btnVisualizar.Location = new System.Drawing.Point(502, 412);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 28);
            this.btnVisualizar.TabIndex = 16;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.TextColor = System.Drawing.Color.White;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dataGridViewNFCompra
            // 
            this.dataGridViewNFCompra.AllowUserToAddRows = false;
            this.dataGridViewNFCompra.AllowUserToDeleteRows = false;
            this.dataGridViewNFCompra.AllowUserToResizeColumns = false;
            this.dataGridViewNFCompra.AllowUserToResizeRows = false;
            this.dataGridViewNFCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dataGridViewNFCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNFCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroNota,
            this.modelo,
            this.serie,
            this.idFornecedor,
            this.fornecedor,
            this.dataChegada,
            this.dataCancelamento});
            this.dataGridViewNFCompra.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewNFCompra.Location = new System.Drawing.Point(17, 58);
            this.dataGridViewNFCompra.Name = "dataGridViewNFCompra";
            this.dataGridViewNFCompra.ReadOnly = true;
            this.dataGridViewNFCompra.Size = new System.Drawing.Size(641, 339);
            this.dataGridViewNFCompra.TabIndex = 19;
            this.dataGridViewNFCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNFCompra_CellDoubleClick);
            this.dataGridViewNFCompra.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewNFCompra_CellFormatting);
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
            // idFornecedor
            // 
            this.idFornecedor.HeaderText = "Código Fornecedor";
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
            // dataChegada
            // 
            this.dataChegada.HeaderText = "Data Chegada";
            this.dataChegada.Name = "dataChegada";
            this.dataChegada.ReadOnly = true;
            this.dataChegada.Width = 85;
            // 
            // dataCancelamento
            // 
            this.dataCancelamento.HeaderText = "Data Cancelamento";
            this.dataCancelamento.Name = "dataCancelamento";
            this.dataCancelamento.ReadOnly = true;
            this.dataCancelamento.Width = 83;
            // 
            // ConsultaNotaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(674, 454);
            this.Controls.Add(this.dataGridViewNFCompra);
            this.Controls.Add(this.btnVisualizar);
            this.Name = "ConsultaNotaCompra";
            this.Text = "Consulta Notas de Compra";
            this.Load += new System.EventHandler(this.ConsultaNotaCompra_Load);
            this.Controls.SetChildIndex(this.cbBuscaInativos, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnVisualizar, 0);
            this.Controls.SetChildIndex(this.dataGridViewNFCompra, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNFCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected GButtons btnVisualizar;
        private System.Windows.Forms.DataGridView dataGridViewNFCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCancelamento;
    }
}
