using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class TelaListaClientes : Form
    {
        public TelaListaClientes()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            ManterClientes tela = new ManterClientes();
            tela.MdiParent = this.MdiParent;
            tela.Show();
        }
    }
}
