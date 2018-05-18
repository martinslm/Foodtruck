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
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            carregarClientes();
        }

        private void carregarClientes()
        {
            dgClientes.AutoGenerateColumns = false;
            List<Cliente> Clientes = Program.Gerenciador.TodosOsClientes();
            dgClientes.DataSource = Clientes;
        }

        private void TelaListaClientes_Load(object sender, EventArgs e)
        {
            carregarClientes();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
