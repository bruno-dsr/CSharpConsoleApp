using System;
using System.Globalization;

namespace EP1{
    public class Exercicio6{
        public void EX6(){
            Console.WriteLine("Informe três valores decimais:");
            string[] valores = Console.ReadLine().Split(' ');
            double triangulo, circulo, trapezio, quadrado, retangulo;
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            triangulo = (a * c) / 2;
            circulo = pi * Math.Pow(c, 2);
            trapezio = ((a + b) * c) / 2;
            quadrado = Math.Pow(b, 2);
            retangulo = a * b;

            Console.WriteLine("Triângulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}