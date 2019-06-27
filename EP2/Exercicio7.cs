using System;
using System.Globalization;

namespace EP2{
    public class Exercicio7{
        public void EX7(){
            Console.WriteLine("Entre com as coordenadas: ");
            string[] input = Console.ReadLine().Split(' ');
            double x = double.Parse(input[0], CultureInfo.InvariantCulture);
            double y = double.Parse(input[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0){
                Console.WriteLine("Origem");
            }
            else if (x > 0 && y > 0){
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0){
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0){
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0){
                Console.WriteLine("Q4");
            }
        }
    }
}