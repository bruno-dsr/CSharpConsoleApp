using System;
using System.Globalization;

namespace EP1{
    public class Exercicio2{
        public void EX2(){
           Console.WriteLine("Informe o valor do raio para calcular a área do círculo: ");
           double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           double pi = 3.14159;
           double area = pi * Math.Pow(raio, 2.0);
           System.Console.WriteLine("A área do círculo é: {0}", area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}