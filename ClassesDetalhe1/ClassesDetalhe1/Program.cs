using System;
using System.Globalization;

namespace ClassesDetalhe1
{
    class Program
    {
        //EXERCICIO CLASSES DETALHADO 1
        //ABORDA: MEMBROS ESTÁTICOS, CONSTRUTOR, SOBRECARGA, ENCAPSULAMENTO, THIS, PROPERTIES, AUTO PROPERTIES E MODIFICADORES DE ACESSO
        static void Main(string[] args)
        {
            ContaCorrente conta;
            Console.WriteLine("Abertura de Conta");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string nome = Console.ReadLine();
            Console.Write("Deseja abrir a conta com um depósito inicial? [S/N]  ");
            char opt = char.Parse(Console.ReadLine());

            if (opt == 'S' || opt == 's')
            {
                Console.Write("Informe o saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaCorrente(numero, nome, saldo);
            }

            else
            {
                conta = new ContaCorrente(numero, nome);
            }

            Console.WriteLine("\nConta criada com sucesso!");
            Console.WriteLine("\nSelecione uma opção:");
            conta.Operacoes();
            int escolha = int.Parse(Console.ReadLine());

            while (escolha != 0)
            {
                switch (escolha)
                {
                    case 1:
                        Console.Write("\nInforme o valor a depositar: ");
                        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Deposito(deposito);
                        Console.WriteLine("Depósito realizado com sucesso.");
                        break;

                    case 2:
                        Console.Write("\nInforme o valor a sacar (Taxa de saque: R$ 5.00): ");
                        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Saque(saque);
                        Console.WriteLine("Saque realizado com sucesso.");
                        break;

                    case 3:
                        Console.WriteLine("\nO saldo atual é de: R$ " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case 4:
                        Console.WriteLine(conta.ToString());
                        break;

                    case 0:
                        break;
                }

                if (escolha != 0)
                {
                    Console.WriteLine("\nSelecione uma opção:");
                    conta.Operacoes();
                    escolha = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
