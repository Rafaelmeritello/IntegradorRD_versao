using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FerramentasUC4X
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Utils.CarregarConfiguracoes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "configuracoes.yml"));
            if (Utils.ConfiguracoesAtuais == null)
            {
                MessageBox.Show("Erro ao carregar o arquivo de configuração: configuração.yml");
            }
            Application.Run(new Inicial());
        }
    }
}
