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
    public partial class AdicionarPedido : Form
    {
        public AdicionarPedido()
        {
            InitializeComponent();
        }

        private void AdicionarPedido_Load(object sender, EventArgs e)
        {
            List<Cliente> Clientes = Program.Gerenciador.TodosOsClientes();
            cbClientes.DisplayMember = "Nome";
            cbClientes.ValueMember = "Id";
            cbClientes.DataSource = Clientes;

        }
    }
}
