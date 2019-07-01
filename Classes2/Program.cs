using System;
using System.Globalization;

namespace Classes2
{
    class Program
    {
        //EXERCICIO CLASSES PARTE 2
        //ABORDA: MÉTODOS
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            System.Console.WriteLine("Entre com os dados do produto:");
            System.Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            System.Console.Write("Valor unitário: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            System.Console.Write("\n");
            System.Console.WriteLine(produto.ToString());
            System.Console.Write("\n");

            System.Console.Write("Digite a quantidade de itens a ser adicionado ao estoque: ");
            int entrada = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(entrada);
            System.Console.Write("Dados atualizados: " + produto.ToString());
            System.Console.Write("\n");

            System.Console.Write("Digite a quantidade de itens a ser removida ao estoque: ");
            int saida = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(saida);
            System.Console.Write("Dados atualizados: " + produto.ToString());
            System.Console.WriteLine("\n");
        }
    }
}
