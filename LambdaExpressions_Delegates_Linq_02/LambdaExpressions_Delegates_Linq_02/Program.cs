using System;
using LambdaExpressions_Delegates_Linq_02.Entities;
using System.Collections.Generic;

namespace LambdaExpressions_Delegates_Linq_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto("TV", 1500.00));
            produtos.Add(new Produto("Notebook", 1800.00));
            produtos.Add(new Produto("IPod", 460.00));
            produtos.Add(new Produto("Celular", 980.00));
            produtos.Add(new Produto("Videogame", 1700.00));

            //Trabalho com PREDICATE e DELEGATES
            //Possível utilizar como Predicate o resultado de uma função lambda.
            produtos.RemoveAll(p => p.Preco >= 1000.00);

            //Outra forma possível seria utilizando uma função como parâmetro
            //produtos.RemoveAll(VerificaValor);

            //Opção utilizando delegates
            //Deleg deleg = VerificaValor;
            //produtos.RemoveAll(deleg.Invoke);

            foreach (Produto p in produtos)
            {
                Console.WriteLine(p);
            }
        }

        //Função estática usada como predicate
        public static bool VerificaValor(Produto p)
        {
            return p.Preco >= 1000.00;
        }

        //Delegate usado como predicate
        delegate bool Deleg(Produto p);
    }
}
