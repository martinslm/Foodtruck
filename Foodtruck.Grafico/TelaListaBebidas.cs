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
    public partial class TelaListaBebidas : Form
    {
        public TelaListaBebidas()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            ManterBebida tela = new ManterBebida();
            tela.MdiParent = this.MdiParent;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            carregarBebidas();
        }

        private void carregarBebidas()
        {
            dgBebidas.AutoGenerateColumns = false;
            List<Bebida> Bebidas = Program.Gerenciador.TodasAsBebidas();
            dgBebidas.DataSource = Bebidas;
        }

        private void TelaListaBebidas_Load(object sender, EventArgs e)
        {
            carregarBebidas();
        }
    }
}
