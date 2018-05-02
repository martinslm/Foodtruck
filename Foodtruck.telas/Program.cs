using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.telas
{
    class Program
    {
        static Gerenciador gerenciador = new Gerenciador();
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("========== FOODTRUCK MANAGER ==========");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Lanche");
                Console.WriteLine("4 - Listar Lanches");
                Console.WriteLine("5 - Cadastrar Bebida");
                Console.WriteLine("6 - Listar Bebida");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        AdicionarCliente();
                        break;

                    case 2:
                        ListarClientes();
                        break;

                    case 3:
                        AdicionarLanche();
                        break;

                    case 4:
                        ListarLanche();
                        break;

                    case 5:
                        AdicionarBebida();
                        break;

                    case 6:
                        ListarBebida();
                        break;


                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
            } while (opcao != 0);
        }

        public static void ListarBebida()
        {
            List<Bebida> BebidasCadastradas = gerenciador.TodasAsBebidas();
            foreach(Bebida bebida in BebidasCadastradas)
            {
                Console.WriteLine(bebida.Descrever());
            }
            Console.ReadLine();
        }

        public static void ListarLanche()
        {
            List<Lanche> LanchesCadastrados = gerenciador.TodosOsLanches();
            foreach(Lanche lanche in LanchesCadastrados)
            {
                Console.WriteLine(lanche.Descrever());
            }
            Console.ReadLine();
        }

        public static void ListarClientes()
        {
            List<Cliente> ClientesCadastrados = gerenciador.TodosOsClientes();
            foreach(Cliente cliente in ClientesCadastrados)
            {
                Console.WriteLine(cliente.Descrever());
            }
            Console.ReadLine();
        }
        public static void AdicionarCliente()
        {
            Console.Clear();
            Cliente novoCliente = new Cliente();
            Console.WriteLine("Informe o código:");
            //programa aborta ao inserir um valor diferente de inteiro. Seria Necessario inserir um bool para validação.
            novoCliente.Id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Informe o nome:");
            novoCliente.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF");
            novoCliente.CPF = Console.ReadLine();
            Console.WriteLine("Informe o Email:");
            novoCliente.Email = Console.ReadLine();

            Validacao validacao = gerenciador.AdicionarCliente(novoCliente);
            if (validacao.Valido)
            {
                Console.WriteLine("Cliente Cadastrado com sucesso!");
                Console.ReadLine();
            }
            else
            {
                foreach(var key in validacao.Mensagens.Keys)
                {
                    String mensagem = validacao.Mensagens[key];
                    Console.WriteLine($"{key}: {mensagem}");
                }
            }

           }

        public static void AdicionarLanche()
        {
            Console.Clear();
            Lanche novoLanche = new Lanche();
            Console.WriteLine("Informe o código (ID):");
            novoLanche.id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Informe o nome:");
            novoLanche.Nome = Console.ReadLine();
            Console.WriteLine("Informe o valor:");
            novoLanche.Valor = Convert.ToDecimal(Console.ReadLine());

            Validacao validacao = gerenciador.AdicionarLanche(novoLanche);
            if(validacao.Valido)
            {
                Console.WriteLine("Lanche Cadastrado com sucesso!");
                Console.ReadLine();
            }
            else
            {
                foreach (var key in validacao.Mensagens.Keys)
                {
                    String mensagem = validacao.Mensagens[key];
                    Console.WriteLine($"{key}: {mensagem}");
                }
            }
        }

        public static void AdicionarBebida()
        {
            Console.Clear();
            Bebida novaBebida = new Bebida();
            Console.WriteLine("Informe o código (ID):");
            novaBebida.id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Informe o nome:");
            novaBebida.Nome = Console.ReadLine();
            Console.WriteLine("Informe o valor");
            novaBebida.Valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o tamanho da Bebida em ML:");
            novaBebida.Tamanho = Convert.ToSingle(Console.ReadLine());

            Validacao validacao = gerenciador.AdicionarBebida(novaBebida);
            if(validacao.Valido)
            {
                Console.WriteLine("Bebida adicionada com sucesso!");
                Console.ReadLine();
            }
            else
            {
                foreach(var key in validacao.Mensagens.Keys)
                {
                    String mensagem = validacao.Mensagens[key];
                    Console.WriteLine($"{key}: {mensagem}");
                }
            }
        }
    }
}
