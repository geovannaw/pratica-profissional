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
        private string permissaoUsuario;
        public MenuPrincipal(string permissao)
        {
            timerAtualizacao = new Timer();
            timerAtualizacao.Interval = 1000; //1 segundo
            timerAtualizacao.Tick += TimerAtualizacao_Tick;
            timerAtualizacao.Start();

            InitializeComponent();

            permissaoUsuario = permissao;

            //configurar permissões de acordo com o usuário
            configurarPermissoes();

            lblUsuarioLogado.Text = Program.usuarioLogado;
        }

        private void configurarPermissoes()
        {
            if (permissaoUsuario == "ADMIN")
            {
                usuáriosToolStripMenuItem.Enabled = true; //se for admin ou gerente, pode cadastrar usuarios
            }
            else if(permissaoUsuario == "GERENTE")
            {
                usuáriosToolStripMenuItem.Enabled = true; //se for admin ou gerente, pode cadastrar usuarios
            }
            else if (permissaoUsuario == "ATENDENTE") //se for atendente, nao tem permissao para ver os fornecedores
            {
                fornecedoresToolStripMenuItem.Enabled = false; 
            }
             //o funcionário normal só nao terá permissao para cadastrar usuários
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

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaOS consultaOS = new ConsultaOS();
            consultaOS.ShowDialog();
        }

        private void notaDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaNotaCompra consultaNotaCompra = new ConsultaNotaCompra();
            consultaNotaCompra.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaContasPagar consultaContasPagar = new ConsultaContasPagar();
            consultaContasPagar.ShowDialog();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaContasReceber consultaContasReceber = new ConsultaContasReceber();
            consultaContasReceber.ShowDialog();
        }

        private void notaDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaNotasVenda consultaNotasVenda = new ConsultaNotasVenda();
            consultaNotasVenda.ShowDialog();
        }

        private void notasDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaNotasServico consultaNotasServico = new ConsultaNotasServico();
            consultaNotasServico.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios consultaUsuarios = new ConsultaUsuarios();
            consultaUsuarios.ShowDialog();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Você realmente deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread(); //encerra todas as threads e fecha o sistema
            }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
