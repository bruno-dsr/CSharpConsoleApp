using System;
using System.Collections.Generic;
using LambdaExpressions_Delegates_Linq_01.Entities;

namespace LambdaExpressions_Delegates_Linq_01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto("TV", 1200.00));
            produtos.Add(new Produto("Notebook", 2500.00));
            produtos.Add(new Produto("Videogame", 1650.00));

            //Usando a função estática definida na classe Produto
            //produtos.Sort(Produto.CompararPorPreco);

            //Usando uma expressão lambda para comparação, substituindo o uso da função estática da classe
            //A declaração de tipos é inferida
            //(p1, p2) => p1.Preco.CompareTo(p2.Preco)
            produtos.Sort((p1, p2) => p1.Preco.CompareTo(p2.Preco));

            foreach (Produto p in produtos)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
