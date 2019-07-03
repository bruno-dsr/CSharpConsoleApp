using System;
using System.Collections.Generic;

namespace Conjunto
{
    class Program
    {
        //EXERCICIO CONJUNTO
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            Console.Write("Quantidade de alunos no curso A: ");
            int loop = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código dos alunos do curso A:");
            for (int i = 1; i <= loop; i++)
            {
                Console.Write("Aluno #{0}: ", i);
                a.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\nQuantidade de alunos no curso B: ");
            loop = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código dos alunos do curso B:");
            for (int i = 1; i <= loop; i++)
            {
                Console.Write("Aluno #{0}: ", i);
                b.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\nQuantidade de alunos no curso C: ");
            loop = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o código dos alunos do curso C:");
            for (int i = 1; i <= loop; i++)
            {
                Console.Write("Aluno #{0}: ", i);
                c.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> result = new HashSet<int>();
            result.UnionWith(a);
            result.UnionWith(b);
            result.UnionWith(c);

            Console.WriteLine("\nTotal de alunos: " + result.Count);
        }
    }
}
