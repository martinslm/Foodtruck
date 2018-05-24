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
        Pedido pedido = new Pedido();

        public AdicionarPedido()
        {
            InitializeComponent();
        }

        private void AdicionarPedido_Load(object sender, EventArgs e)
        {
            CarregaComboBoxes();
        }

        private void CarregaComboBoxes()
        {
            List<Cliente> Clientes = Program.Gerenciador.TodosOsClientes();
            cbClientes.DisplayMember = "Nome";
            cbClientes.ValueMember = "Id";
            cbClientes.DataSource = Clientes;

            cbLanche.DisplayMember = "Nome";
            cbLanche.ValueMember = "Id";
            cbLanche.DataSource = Program.Gerenciador.TodosOsLanches();

            cbBebida.DisplayMember = "Nome";
            cbBebida.ValueMember = "Id";
            cbBebida.DataSource = Program.Gerenciador.TodasAsBebidas();

        }

        private void carregaDataGrids()
        {
            dgBebidas.AutoGenerateColumns = false;
            dgBebidas.DataSource = pedido.Bebidas.ToList();
            dgLanches.AutoGenerateColumns = false;
            dgLanches.DataSource = pedido.Lanches.ToList();
        }

        private void btAddBebida_Click(object sender, EventArgs e)
        {
            Bebida BebidaSelecionada = (Bebida)cbBebida.SelectedItem;
            pedido.Bebidas.Add(BebidaSelecionada);
            carregaDataGrids();
            carregaTotal();
        }

        private void btAddLanche_Click(object sender, EventArgs e)
        {
            Lanche LancheSelecionado = (Lanche)cbLanche.SelectedItem;
            pedido.Lanches.Add(LancheSelecionado);
            carregaDataGrids();
            carregaTotal();
        }

        private void carregaTotal()
        {
            ValorTotal.Text = pedido.ValorTotal().ToString();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
