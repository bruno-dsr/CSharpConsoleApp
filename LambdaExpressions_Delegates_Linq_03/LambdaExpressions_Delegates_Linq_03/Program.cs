using System;
using System.Collections.Generic;
using System.Linq;
using LambdaExpressions_Delegates_Linq_03.Entities;
using System.Globalization;

namespace LambdaExpressions_Delegates_Linq_03
{
    class Program
    {
        static void PrintList<T>(string mensagem, IEnumerable<T> lista)
        {
            Console.WriteLine(mensagem);
            foreach (T item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Categoria c1 = new Categoria(1, "Ferramentas", 3);
            Categoria c2 = new Categoria(2, "Computadores", 2);
            Categoria c3 = new Categoria(3, "Eletronicos", 1);

            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto(1, "Celular", 870.00, c3));
            produtos.Add(new Produto(2, "Chave de Fenda", 28.70, c1));
            produtos.Add(new Produto(3, "Macbook", 2600.00, c2));
            produtos.Add(new Produto(4, "Headphone", 270.25, c3));
            produtos.Add(new Produto(5, "Martelo", 17.90, c1));
            produtos.Add(new Produto(6, "Desktop PC", 1800.00, c2));
            produtos.Add(new Produto(7, "Videogame", 1700.00, c3));
            produtos.Add(new Produto(8, "Videogame Portatil", 1250.00, c3));
            produtos.Add(new Produto(9, "Furadeira", 120.50, c1));
            produtos.Add(new Produto(10, "Notebook", 1500.00, c2));
            produtos.Add(new Produto(11, "Televisao", 930.00, c3));
            produtos.Add(new Produto(12, "Serrote", 86.70, c1));


            // Trabalhando com LINQ

            //Usando a função WHERE do LINQ com uma expressão lambda como predicate
            var L1 = produtos.Where(p => p.Categoria.Tier == 1 && p.Preco <= 1500.00).ToList();
            //Ordenando a lista por ordem crescente de preço
            L1.Sort((p1, p2) => p1.Preco.CompareTo(p2.Preco));
            PrintList("Produtos Tier 1 de valor menor ou igual a R$ 1500.00:", L1);

            var L2 = produtos.Where(p => p.Categoria.Nome == "Ferramentas").Select(p => p.Nome).ToList();
            PrintList("Nome dos produtos da categoria Ferramentas: ", L2);

            var L3 = produtos.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Preco, Categoria = p.Categoria.Nome });
            PrintList("Nome do produto, preço e nome de categoria de produtos com inicial C", L3);

            //Ordenando a lista por ID utilizando ORDERBY
            var L4 = produtos.Where(p => p.Categoria.Tier == 3).OrderBy(p => p.ID);
            PrintList("Produtos TIER 3 ordenados por ID: ", L4);

            //Do resultado L4, pula 1 item e exibe os próximos 2
            var L5 = L4.Skip(1).Take(2);
            PrintList("Produtos TIER 3 ordenados por ID pulando 1 e exibindo 2", L5);

            //Primeiro item da lista com FIRST
            var L6 = produtos.First();
            Console.WriteLine("Primeiro produto da lista: " + L6);
            Console.WriteLine();

            //Primeiro item da lista com FIRSTORDEFAULT onde não há resultado
            var L7 = produtos.FirstOrDefault(p => p.Preco > 5000.00);
            Console.WriteLine("Primeiro produto (ou padrão) com valor maior a R$ 5000.00: " + L7);
            Console.WriteLine();

            //Retornando um único item com SINGLEORDEFAULT
            var L8 = produtos.SingleOrDefault(p => p.ID == 3);
            Console.WriteLine("Produto ID 3: " + L8);
            Console.WriteLine();

            var L9 = produtos.SingleOrDefault(p => p.ID == 19);
            Console.WriteLine("Produto ID 19: " + L9);
            Console.WriteLine();

            //Retornando o maior preco
            var L10 = produtos.Max(p => p.Preco);
            Console.WriteLine("Maior preço: " + L10.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            var L11 = produtos.Min(p => p.Preco);
            Console.WriteLine("Menor preço: " + L11.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            //Soma dos preços da categoria 2
            var L12 = produtos.Where(p => p.Categoria.ID == 2).Sum(p => p.Preco);
            Console.WriteLine("Soma dos preços da Categoria 2: " + L12.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            //Média de preços da categoria 3
            var L13 = produtos.Where(p => p.Categoria.ID == 3).Average(p => p.Preco);
            Console.WriteLine("Média de preços da Categoria 3: " + L13.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            //Valor padrão caso resultado nulo
            var L14 = produtos.Where(p => p.Categoria.ID == 8).Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Média de preços da Categoria 8: " + L14.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            //Soma com AGREGATE
            var L15 = produtos.Where(p => p.Categoria.ID == 1).Select(p => p.Preco).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma da categoria 1 com Agregate: " + L15.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            //Agrupamento
            Console.WriteLine("Produtos por categoria: ");
            var L16 = produtos.GroupBy(p => p.Categoria);
            foreach (IGrouping<Categoria, Produto> grupo in L16)
            {
                Console.WriteLine("Categoria: " + grupo.Key.Nome);
                foreach (Produto p in grupo)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
