using System;
using System.Globalization;
using Enums_Composition.Entities;
using Enums_Composition.Entities.Enums;

namespace Enums_Composition
{
    class Program
    {
        //EXERCICIO ENUMS & COMPOSITION
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            DateTime nascCliente = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nomeCliente, emailCliente, nascCliente);

            Console.WriteLine("\nEntre com os dados do pedido: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            Console.Write("Quantos itens existem para esse pedido? ");
            int nItens = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nItens; i++)
            {
                Console.WriteLine($"Dados do item #{i}: ");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                order.AddItem(new OrderItem(quantidadeProduto, new Product(nomeProduto, precoProduto)));
            }

            Console.WriteLine();

            Console.WriteLine(order);
        }
    }
}
