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
            Console.WriteLine(banco.Database.Connection.ConnectionString);
        }
        //Cliente
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
        public Validacao RemoverCliente(Cliente cliente)
        {
            Validacao validacao = new Validacao();
            banco.Clientes.Remove(cliente);
            banco.SaveChanges();
            return validacao;
        }
        //Cliente
        /*-------------*/
        //Lanche
       
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
            if (this.banco.Lanches.Where(c => c.Id == LancheAdicionado.Id).Count()>0)
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
        public Validacao AlterarLanche(Lanche lancheAlterado)
        {
            Validacao validacao = new Validacao();
            Lanche lancheBanco = BuscaLanchePorID(lancheAlterado.Id);
            lancheBanco.Nome = lancheAlterado.Nome;
            lancheBanco.Valor = lancheAlterado.Valor;
            this.banco.SaveChanges();
            return validacao;
        }
        public Validacao RemoverLanche(Lanche lanche)
        {
            Validacao validacao = new Validacao();
            banco.Lanches.Remove(lanche);
            banco.SaveChanges();
            return validacao;
        }
        //Lanche
        /*--------------*/
        //Bebida
        
        public Validacao AdicionarBebida(Bebida BebidaAdicionada)
        {
            Validacao validacao = new Validacao();

  
            if (this.banco.Bebidas.Where(c => c.Id == BebidaAdicionada.Id).Count()>0)
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
        public Validacao AlterarBebida(Bebida bebidaAlterada)
        {
            Validacao validacao = new Validacao();
            Bebida bebidaBanco = BuscaBebidaPorID(bebidaAlterada.Id);
            bebidaBanco.Nome = bebidaAlterada.Nome;
            bebidaBanco.Valor = bebidaAlterada.Valor;
            bebidaBanco.Tamanho = bebidaAlterada.Tamanho;
            this.banco.SaveChanges();
            return validacao;
        }
        public Validacao RemoverBebida(Bebida bebida)
        {
            Validacao validacao = new Validacao();
            banco.Bebidas.Remove(bebida);
            banco.SaveChanges();
            return validacao;
        }
        //Bebida
        /*-----------------*/
        //Pedido
        public Validacao AdicionarPedido (Pedido PedidoAdicionado)
        {
            Validacao validacao = new Validacao();

            if (string.IsNullOrEmpty(Convert.ToString(PedidoAdicionado.DataCompra)))
            {
                validacao.Mensagens.Add("datacompra", "O campo data não pode ser nulo ou vazío");
            }

            if (!(this.banco.Clientes.Where(x => x.Id == PedidoAdicionado.Cliente.Id).Any()))
            {
                validacao.Mensagens.Add("cliente", "Não existe nenhum cliente cadastrado com esse código idenfiticador");
            }

            foreach (Lanche lanche in PedidoAdicionado.Lanches)
            {
                if (!(this.banco.Lanches.Where(x => x.Id == lanche.Id).Any()))
                {
                    validacao.Mensagens.Add("lanche", "$Não existe nenhum lanche cadastrado em um dos códigos informados");
                }
            }

            foreach (Bebida bebida in PedidoAdicionado.Bebidas)
            {
                if (!(this.banco.Bebidas.Where(x => x.Id == bebida.Id).Any()))
                {
                    validacao.Mensagens.Add("bebida", "$Não existe nenhuma bebida cadastrada em um dos códigos informados");
                }
            }

            this.banco.Pedidos.Add(PedidoAdicionado);
            this.banco.SaveChanges();

            return validacao;
        }
        public Validacao RemoverPedido (Pedido Pedido)
        {
            Validacao validacao = new Validacao();
            banco.Pedidos.Remove(Pedido);
            banco.SaveChanges();
            return validacao;
        }

        public Cliente BuscaClientePorID(long id)
        {
            return this.banco.Clientes.Where(c => c.Id == id).FirstOrDefault();
        }
        public Lanche BuscaLanchePorID(long id)
        {
            return this.banco.Lanches.Where(c => c.Id == id).FirstOrDefault();
        }
        public Bebida BuscaBebidaPorID(long id)
        {
            return this.banco.Bebidas.Where(c => c.Id == id).FirstOrDefault();
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

        public List<Pedido> TodosOsPedidos()
        {
            return this.banco.Pedidos.ToList();
        }
    }
}
