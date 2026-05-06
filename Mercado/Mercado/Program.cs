using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Mercado_SENAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"
████████████████████████████████████████████
█▄─▀█▀─▄█▄─▄▄─█▄─▄▄▀█─▄▄▄─██▀▄─██▄─▄▄▀█─▄▄─█
██─█▄█─███─▄█▀██─▄─▄█─███▀██─▀─███─██─█─██─█
▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀");
                Console.ResetColor();
                Console.WriteLine("\nBem-Vindo ao nosso Mercado");
                Console.WriteLine("Escolha o que você irá cadastrar\n");

                Console.WriteLine("1 - Produtos");
                Console.WriteLine("2 - Clientes");
                Console.WriteLine("3 - Funcionários");
                Console.WriteLine("4 - Fornecedor");
                Console.WriteLine("5 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cadastroProduto();
                        break;
                    case 2:
                        cadastroCliente();
                        break;
                    case 3:
                        cadastroFuncionario();
                        break;
                    case 4:
                        cadastroFornecedor();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(@"
██████████████████████████████
█─▄─▄─█─▄▄▄─█─█─██▀▄─██▄─██─▄█
███─███─███▀█─▄─██─▀─███─██─██
▀▀▄▄▄▀▀▄▄▄▄▄▀▄▀▄▀▄▄▀▄▄▀▀▄▄▄▄▀▀");
                        Console.ResetColor();
                        Console.WriteLine("\nAté mais, Volte Sempre");
                        Thread.Sleep(500);
                        Console.WriteLine("Pressione qualquer tecla para sair...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um valor válido!");
                        Thread.Sleep(500);
                        break;
                }
            }
        }
        static void cadastroProduto()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
██████████████████████████████████████████
█▄─▄▄─█▄─▄▄▀█─▄▄─█▄─▄▄▀█▄─██─▄█─▄─▄─█─▄▄─█
██─▄▄▄██─▄─▄█─██─██─██─██─██─████─███─██─█
▀▄▄▄▀▀▀▄▄▀▄▄▀▄▄▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▀▄▄▄▀▀▄▄▄▄▀");
            Console.ResetColor();

            Console.WriteLine("\nQual é o nome do produto cadastrado");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("\nQual a quantidade que você vai cadastrar?");
            int qtdProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual é a marca desse produto?");
            string marcaProduto = Console.ReadLine();

            Console.WriteLine("\nQual é o preço desse produto");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o CNPJ do Fornecedor:");
            int fornecedorProduto = int.Parse(Console.ReadLine());


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
██████████████████████████████████████████
█▄─▄▄─█▄─▄▄▀█─▄▄─█▄─▄▄▀█▄─██─▄█─▄─▄─█─▄▄─█
██─▄▄▄██─▄─▄█─██─██─██─██─██─████─███─██─█
▀▄▄▄▀▀▀▄▄▀▄▄▀▄▄▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▀▄▄▄▀▀▄▄▄▄▀");
            Console.ResetColor();
            Console.WriteLine("\nEste será seu novo produto:");
            Console.WriteLine($"{qtdProduto}x {nomeProduto} - {marcaProduto} (R${precoProduto})");
            Console.WriteLine("\nPressione qualquer tecla para cadastrar...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Produto Cadastrado!");
            Console.ResetColor();

        }
        static void cadastroCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
███████████████████████████████████████████
█─▄▄▄─█▄─▄███▄─▄█▄─▄▄─█▄─▀█▄─▄█─▄─▄─█▄─▄▄─█
█─███▀██─██▀██─███─▄█▀██─█▄▀─████─████─▄█▀█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀");
            Console.ResetColor();
            Console.WriteLine("\nNome do cliente");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("\nCPF");
            int cnpjCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEmail");
            string enderecoCliente = Console.ReadLine();

            Console.WriteLine("\nTelefone");
            int telCliente = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cliente Cadastrado com sucesso!");
            Console.ResetColor();
        }
        static void cadastroFuncionario()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
██████████████████████████████████████████████████████████████████
█▄─▄▄─█▄─██─▄█▄─▀█▄─▄█─▄▄▄─█▄─▄█─▄▄─█▄─▀█▄─▄██▀▄─██▄─▄▄▀█▄─▄█─▄▄─█
██─▄████─██─███─█▄▀─██─███▀██─██─██─██─█▄▀─███─▀─███─▄─▄██─██─██─█
▀▄▄▄▀▀▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▀▄▄▄▄▀");
            Console.ResetColor();
            Console.WriteLine("\nNome do funcionário");
            string nomeFuncionario = Console.ReadLine();

            Console.WriteLine("\nCPF");
            int cnpjFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("\nRG");
            int rgFuncionarioe = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTelefone");
            int telFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEndereço Residencial");
            string enderecoFuncionario = Console.ReadLine();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Funcionário Cadastrado com sucesso!");
            Console.ResetColor();
        }
        static void cadastroFornecedor()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
█████████████████████████████████████████████████████████████
█▄─▄▄─█─▄▄─█▄─▄▄▀█▄─▀█▄─▄█▄─▄▄─█─▄▄▄─█▄─▄▄─█▄─▄▄▀█─▄▄─█▄─▄▄▀█
██─▄███─██─██─▄─▄██─█▄▀─███─▄█▀█─███▀██─▄█▀██─██─█─██─██─▄─▄█
▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▄▄▀▄▄▀");
            Console.ResetColor();
            Console.WriteLine("\nNome do Fornecedor");
            string nomeFornecedor = Console.ReadLine();

            Console.WriteLine("\nCNPJ");
            int cnpjFornecedor = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEmail");
            string emailFornecedor = Console.ReadLine();

            Console.WriteLine("\nTelefone");
            int telFornecedor = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fornecedor Cadastrado com sucesso!");
            Console.ResetColor();
        }
    }
}