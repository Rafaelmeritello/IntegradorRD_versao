using FerramentasUC4X.modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerramentasUC4X
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void atualizadorFluxoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizadorControle atualizador1 = new AtualizadorControle();
            atualizador1.Show();
        }

        private void atualizadorPlanilhaUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizadorUpload atualizador = new AtualizadorUpload();
            atualizador.Show();
        }
    }
}
