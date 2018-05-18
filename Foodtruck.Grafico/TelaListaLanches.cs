using Foodtruck.Negocio.Models;
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
    public partial class TelaListaLanches : Form
    {
        public TelaListaLanches()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            ManterLanche tela = new ManterLanche();
            tela.MdiParent = this.MdiParent;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            carregaLanches();
        }

        private void carregaLanches()
        {

            dgLanches.AutoGenerateColumns = false;
            List<Lanche> Lanches = Program.Gerenciador.TodosOsLanches();
            dgLanches.DataSource = Lanches;

        }

        private void TelaListaLanches_Load(object sender, EventArgs e)
        {
            carregaLanches();
        }
    }
}
