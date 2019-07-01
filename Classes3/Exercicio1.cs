using System;
using System.Globalization;

namespace Classes3{
    public class Exercicio1{
        public void EX1(){
            Retangulo r = new Retangulo();

            System.Console.WriteLine("Entre com os dados do retângulo: ");
            System.Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("");

            System.Console.WriteLine("Área: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Perímetro: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}