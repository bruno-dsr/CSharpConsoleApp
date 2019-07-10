using System;
using System.Globalization;
using System.Collections.Generic;
using Inheritance_Polymorphism.Entities;

namespace Inheritance_Polymorphism
{
    class Program
    {
        // EXERCICIO REFERENTE A HERANÇA E POLIMORFISMO
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Console.Write("Entre a quantidade de produtos a serem registrados: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto #{i+1}");
                Console.Write("Produto [C]Comum / [U]Usado / [I]Importado: ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'C' || tipo == 'c')
                {
                    Produto p = new Produto(nome, preco);
                    produtos.Add(p);
                }

                else if(tipo == 'U' || tipo == 'u')
                {
                    Console.Write("Data de fabricação: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Produto p = new ProdutoUsado(nome, preco, data);
                    produtos.Add(p);
                }

                else
                {
                    Console.Write("Taxa alfandegária: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Produto p = new ProdutoImportado(nome, preco, taxa);
                    produtos.Add(p);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Etiquetas:");

            foreach(Produto produto in produtos)
            {
                Console.WriteLine(produto.Etiqueta());
            }
        }
    }
}
