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
    public partial class ManterLanche : Form
    {
        public ManterLanche()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Lanche novoLanche = new Lanche();
            novoLanche.id = Convert.ToInt64(tbId.Text);
            novoLanche.Nome = tbNome.Text;
            novoLanche.Valor = Convert.ToInt64(tbValor.Text);
            Validacao validacao = Program.Gerenciador.AdicionarLanche(novoLanche);

            if(!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach(var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }

                MessageBox.Show(mensagemValidacao);
            }
        }
    }
}
