using Sistema_Vendas.Controller;
using Sistema_Vendas.Models;
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
        private Timer timerAtualizacao;
        private DadosEmpresaController<DadosEmpresaModel> dadosEmpresaController;
        public MenuPrincipal()
        {
            timerAtualizacao = new Timer();
            timerAtualizacao.Interval = 1000; //1 segundo
            timerAtualizacao.Tick += TimerAtualizacao_Tick;
            timerAtualizacao.Start();

            InitializeComponent();

        }

        private void TimerAtualizacao_Tick(object sender, EventArgs e)
        {
            lblDataMenu.Text = DateTime.Now.ToString();
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

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProdutos consultaProdutos = new ConsultaProdutos();
            consultaProdutos.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFuncionarios consultaFuncionarios = new ConsultaFuncionarios();
            consultaFuncionarios.ShowDialog();
        }

        private void condiçãoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCondicaoPagamento consultaCondicaoPagamento = new ConsultaCondicaoPagamento();
            consultaCondicaoPagamento.ShowDialog();
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFormasPagamento consultaFormasPagamento = new ConsultaFormasPagamento();
            consultaFormasPagamento.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaServicos consultaServicos = new ConsultaServicos();
            consultaServicos.ShowDialog();
        }
    }
}
