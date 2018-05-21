using Foodtruck.Negocio.Models;
using Foodtruck.Negocio.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco(); 
        public Gerenciador()
        {

        }
        public Validacao RemoverCliente(Cliente cliente)
        {
            Validacao validacao = new Validacao();
            banco.Clientes.Remove(cliente);
            banco.SaveChanges();
            return validacao;
        }

        public Validacao AdicionarCliente(Cliente ClienteAdicionado)
        {
            Validacao validacao = new Validacao();
            if(this.banco.Clientes.Where(c =>c.Id == ClienteAdicionado.Id).Any())
            {
                validacao.Mensagens.Add("Id", "Já existe um cliente com este ID");
            }
            if (String.IsNullOrEmpty(ClienteAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome", "O nome não pode ser nulo ou vazio.");
            }
            if (String.IsNullOrEmpty(ClienteAdicionado.Email))
            {
                validacao.Mensagens.Add("Email", "O e-mail não pode ser vazio ou nulo.");
            }
            if(!ClienteAdicionado.Email.Contains("@"))
            {
                validacao.Mensagens.Add("Email", "Email no formato inválido");
            }

            if (validacao.Valido)
            {
                this.banco.Clientes.Add(ClienteAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }
        public Validacao AlterarCliente(Cliente clienteAlterado)
        {
            Validacao validacao = new Validacao();
            Cliente clienteBanco = BuscaClientePorID(clienteAlterado.Id);
            clienteBanco.Nome = clienteAlterado.Nome;
            clienteBanco.CPF = clienteAlterado.CPF;
            clienteBanco.Email = clienteAlterado.Email;
            this.banco.SaveChanges();
            return validacao;
        }
        public Validacao AdicionarLanche(Lanche LancheAdicionado)
        {
            Validacao validacao = new Validacao();
            //validacao nome
            if(String.IsNullOrEmpty(LancheAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome", "O nome do lanche não pode ser nulo ou vazio.");
            }
            //validacao valor
            if(LancheAdicionado.Valor <=0)
            {
                validacao.Mensagens.Add("Valor","O valor do lanche não pode ser zerado ou negativo");
            }
            if (this.banco.Lanches.Where(c => c.id == LancheAdicionado.id).Any())
            {
                validacao.Mensagens.Add("Id", "Já existe um lanche com este ID");
            }

            if (validacao.Valido)
            {
                this.banco.Lanches.Add(LancheAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Validacao AdicionarBebida(Bebida BebidaAdicionada)
        {
            Validacao validacao = new Validacao();
            if (this.banco.Bebidas.Where(c => c.id == BebidaAdicionada.id).Any())
            {
                validacao.Mensagens.Add("Id", "Já existe uma Bebida com este ID");
            }
            //nome
            if (String.IsNullOrEmpty(BebidaAdicionada.Nome))
            {
                validacao.Mensagens.Add("Nome","O nome da bebida não pode ser nulo ou vazio");
            }
            //valor
            if(BebidaAdicionada.Valor <=0)
            {
                validacao.Mensagens.Add("Valor","Certifique-se de que o valor da bebida é positivo e maior que 0.");
            }

            ///tamanho
            if(BebidaAdicionada.Tamanho <=10)
            {
                validacao.Mensagens.Add("Tamanho","Certifique-se que o tamanho da bebida foi informado em ML");
            }

            if (validacao.Valido)
            {
                this.banco.Bebidas.Add(BebidaAdicionada);
                this.banco.SaveChanges();
            }
                return validacao;
        }

        public void AdicionarPedido (Pedido PedidoAdicionado)
        {
            this.banco.Pedidos.Add(PedidoAdicionado);
        }

        public Cliente BuscaClientePorID(long id)
        {
            return this.banco.Clientes.Where(c => c.Id == id).FirstOrDefault();
        }
        public List<Cliente> TodosOsClientes()
        {
            return this.banco.Clientes.ToList();
        }

        public List<Lanche> TodosOsLanches()
        {
            return this.banco.Lanches.ToList();
        }

        public List<Bebida> TodasAsBebidas()
        {
            return this.banco.Bebidas.ToList();
        }
    }
}
