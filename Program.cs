using Sistema_Vendas.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas
{
    internal static class Program
    {
        public static string usuarioLogado { get; set; }
        public static string permissaoLogado { get; set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TelaLogin telaLogin = new TelaLogin();
            Application.Run(telaLogin);
        }
    }
}
