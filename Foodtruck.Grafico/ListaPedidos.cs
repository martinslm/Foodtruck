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
    public partial class ListaPedidos : Form
    {
        public Pedido PedidoSelecionado { get; set; }
        public ListaPedidos()
        {
            InitializeComponent();
        }

        private void ListaPedidos_Load(object sender, EventArgs e)
        {
            CarregaDG();
        }

        private void CarregaDG()
        {
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.AutoGenerateColumns = false;
            List<Pedido> Pedidos = Program.Gerenciador.TodosOsPedidos();
            dgPedidos.DataSource = Pedidos;
        }

        private void btVisualizaPedido_Click(object sender, EventArgs e)
        {

            AdicionarPedido tela = new AdicionarPedido();
            tela.Show();

        }

        private void btRemoverPedido_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Tem certeza que deseja remover este pedido?", "Remover pedido", MessageBoxButtons.OKCancel);
            if (Resultado == DialogResult.OK)
            {
                if (dgPedidos.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Selecione uma linha");
                    return;
                }
                else
                {
                    Pedido PedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverPedido(PedidoSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Pedido removido com sucesso!");
                    }
                }
            }

            CarregaDG();
        }

        private void btEditaPedido_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Pedido PedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(PedidoSelecionado);

            }

        }


        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {

         }

        private bool VerificarSelecao()
        {
            if (dgPedidos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;

        }

       /* private void AdicionarPedido_Shown(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao();
            this.cbClientes
        }*/

        private void AbreTelaInclusaoAlteracao (Pedido PedidoSelecionado)
        {
            AdicionarPedido tela = new AdicionarPedido();
            tela.MdiParent = this.MdiParent;
            tela.PedidoSelecionado = PedidoSelecionado;
            tela.FormClosed += Tela_FormClosed;

            tela.Show();
        }
    }
}
