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
        private void AbreTelaInclusaoAlteracao(Lanche lancheSelecionado)
        {
            ManterLanche tela = new ManterLanche();
            tela.MdiParent = this.MdiParent;
            tela.LancheSelecionado = lancheSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregaLanches();
        }

        private void CarregaLanches()
        {
            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.MultiSelect = false;
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLanches.AutoGenerateColumns = false;
            List<Lanche> Lanches = Program.Gerenciador.TodosOsLanches();
            dgLanches.DataSource = Lanches;

        }

        private void TelaListaLanches_Load(object sender, EventArgs e)
        {
            CarregaLanches();
        }

        private bool VerificarSelecao()
        {
            if (dgLanches.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;

        }

        private void dgLanches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btRemover_Click_1(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                    if (Program.Gerenciador.TodosOsPedidos().SelectMany(p => p.Lanches).Any(t => t.Id == lancheSelecionado.Id))
                        MessageBox.Show("Não é possível excluir um lanche já cadastrado em um pedido.");
                    else
                    {
                        var validacao = Program.Gerenciador.RemoverLanche(lancheSelecionado);
                        if (validacao.Valido)
                        {
                            MessageBox.Show("Lanche removido com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um problema ao remover o lanche");
                        }
                    }
                    CarregaLanches();
                }

            }
        }

        private void btAlterar_Click_1(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(lancheSelecionado);

            }

        }

        private void dgLanches_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
