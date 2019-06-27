using System;
using System.Globalization;

namespace EP4{
    public class Exercicio3{
        public void EX3(){
            System.Console.Write("Informe o número de repetições: ");
            int loop = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe em sequência três números para cálculo de média para cada repetição: ");

            for(int i = 1; i <= loop; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                double a = double.Parse(input[0], CultureInfo.InvariantCulture);
                double b = double.Parse(input[1], CultureInfo.InvariantCulture);
                double c = double.Parse(input[2], CultureInfo.InvariantCulture);

                a = a * 2.0;
                b = b * 3.0;
                c = c * 5.0;

                double media = (a + b + c) / 10;

                System.Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}