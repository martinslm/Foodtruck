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
    public partial class ManterClientes : Form
    {
        public ManterClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManterClientes_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.Id = Convert.ToInt64(tbId.Text);
            novoCliente.Nome = tbNome.Text;
            novoCliente.Email = tbEmail.Text;
            novoCliente.CPF = tbCPF.Text;
            Validacao validacao = Program.Gerenciador.AdicionarCliente(novoCliente);

            if(!validacao.Valido)
            {
                String mensagemValidacao = " ";
                foreach(var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
