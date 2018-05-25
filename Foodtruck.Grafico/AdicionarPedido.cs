using Foodtruck.Negocio;
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
        public Pedido PedidoSelecionado { get; set; }
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
            ValorTotal.Text = pedido.ValorTotal.ToString();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            pedido.Cliente = cbClientes.SelectedItem as Cliente;
            pedido.DataCompra = DateTime.Now;
            Validacao validacao;

            if (PedidoSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarPedido(pedido);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarPedido(pedido);
            }
            if (validacao.Valido)
            {
                MessageBox.Show("Pedido cadastrado com sucesso");
            }
            else
            {
                String msg = "";
                foreach (var mensagem in validacao.Mensagens)
                {
                    msg += mensagem + Environment.NewLine;
                }
                MessageBox.Show(msg);
            }
            this.Close();
        }

        private void AdicionarPedido_Shown(object sender, EventArgs e)
        {
            if(PedidoSelecionado != null)
            {
               this.cbClientes.SelectedItem = PedidoSelecionado.Cliente;
               this.dgBebidas.DataSource = PedidoSelecionado.Bebidas.ToList();
                this.dgLanches.DataSource = PedidoSelecionado.Lanches.ToList();
                pedido = PedidoSelecionado;
            }
        }
    }
}
