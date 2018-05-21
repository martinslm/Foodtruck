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

        private void AbreTelaInclusaoAlteracao(Cliente clienteSelecionado)
        {
            ManterClientes tela = new ManterClientes();
            tela.MdiParent = this.MdiParent;
            tela.ClienteSelecionado = clienteSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgClientes.MultiSelect = false;
            dgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgClientes.AutoGenerateColumns = false;
            List<Cliente> Clientes = Program.Gerenciador.TodosOsClientes();
            dgClientes.DataSource = Clientes;
        }

        private void TelaListaClientes_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private bool VerificarSelecao()
        {
            if (dgClientes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;

        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if(VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Cliente clienteselecionado = (Cliente)dgClientes.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverCliente(clienteselecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Cliente removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o cliente");
                    }
                    CarregarClientes();

                }
                
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Cliente clienteselecionado = (Cliente)dgClientes.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(clienteselecionado);
                
            }
            
        }
    }
}
