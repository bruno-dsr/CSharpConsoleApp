using System;
using System.Globalization;
using System.Collections.Generic;
using Abstracts.Entities;

namespace Abstracts
{
    class Program
    {
        //EXERCICIO CLASSES E MÉTODOS ABSTRATOS
        static void Main(string[] args)
        {
            List<Pessoa> contribuintes = new List<Pessoa>();

            System.Console.Write("Informe o número de contribuíntes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Contribuinte #{i+1}:");
                Console.Write("Pessoa [F]Fisica ou [J]Jurídica: ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'F' || tipo == 'f')
                {
                    Console.Write("Gasto médico: ");
                    double gastoMedico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contribuintes.Add(new PessoaFisica(nome, rendaAnual, gastoMedico));
                }
                else
                {
                    Console.Write("Quantidade de funcionário: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaJuridica(nome, rendaAnual, funcionarios));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Valores de impostos a pagar:");

            foreach (Pessoa contribuinte in contribuintes)
            {
                Console.WriteLine(contribuinte.Nome + ": R$ " + contribuinte.ImpostoAPagar().ToString("F2", CultureInfo.InvariantCulture));
            }

            double impostoTotal = 0;

            foreach (Pessoa contribuinte in contribuintes)
            {
                impostoTotal += contribuinte.ImpostoAPagar();
            }

            Console.WriteLine();
            Console.WriteLine("Total em impostos: R$ " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
