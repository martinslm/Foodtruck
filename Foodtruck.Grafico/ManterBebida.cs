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
    public partial class ManterBebida : Form
    {
        public Bebida BebidaSelecionada { get; set; }
        public ManterBebida()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ManterBebida_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            Bebida novaBebida = new Bebida();
            if (Int64.TryParse(tbId.Text, out long value))
            {
                novaBebida.Id = value;
            }
            else
           {
               novaBebida.Id = -1;
            }
            novaBebida.Id = Convert.ToInt64(tbId.Text);
            novaBebida.Nome = tbNome.Text;
            novaBebida.Tamanho = Convert.ToInt64(tbTamanho.Text);
            novaBebida.Valor = Convert.ToInt64(tbValor.Text);
            Validacao validacao;
            if (BebidaSelecionada == null)
            {
                validacao = Program.Gerenciador.AdicionarBebida(novaBebida);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarBebida(novaBebida);
            }
            if (!validacao.Valido)
            {
                String mensagemValidacao = " ";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }

                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Cadastro de bebida realizado com sucesso");
            }

            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterBebidas_Shown(object sender, EventArgs e)
        {
            if (BebidaSelecionada != null)
            {
                this.tbId.Text = BebidaSelecionada.Id.ToString();
                this.tbNome.Text = BebidaSelecionada.Nome;
                this.tbTamanho.Text = BebidaSelecionada.Tamanho.ToString();
                this.tbValor.Text = BebidaSelecionada.Valor.ToString();


            }
        }
    }
}
