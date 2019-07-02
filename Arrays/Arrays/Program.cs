using System;
using System.Globalization;

namespace Arrays
{
    class Program
    {
        // EXERCICIOS ARRAYS
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];

            Console.Write("Informe a quantidade de quartos a serem alugados: ");
            int loop = int.Parse(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Ocupante: ");
                string ocupante = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto escolhido: ");
                int numero = int.Parse(Console.ReadLine());

                while (quartos[numero] != null)
                {
                    Console.Write("Quarto ocupado. Escolha outro quarto: ");
                    numero = int.Parse(Console.ReadLine());
                }

                quartos[numero] = new Quarto(numero, ocupante, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");
            for (int j = 0; j < 10; j++)
            {
                if (quartos[j] != null)
                {
                    Console.WriteLine(quartos[j]);
                }
            }
        }
    }
}
