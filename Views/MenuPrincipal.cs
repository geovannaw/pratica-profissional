﻿using Sistema_Vendas.Models;
using Sistema_Vendas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaModelos consultaModelos = new ConsultaModelos();
            consultaModelos.ShowDialog();
        }

        private void paísesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPaises consultaPaises = new ConsultaPaises();
            consultaPaises.ShowDialog();
        }

        private void dadosDaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosEmpresa dadosEmpresa = new DadosEmpresa();
            dadosEmpresa.ShowDialog();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEstados consultaEstados = new ConsultaEstados();
            consultaEstados.ShowDialog();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCidades consultaCidades = new ConsultaCidades();
            consultaCidades.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes consultaClientes = new ConsultaClientes();
            consultaClientes.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFornecedores consultaFornecedores = new ConsultaFornecedores();
            consultaFornecedores.ShowDialog();
        }
    }
}
