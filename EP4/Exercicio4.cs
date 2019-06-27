using System;
using System.Globalization;

namespace EP4{
    public class Exercicio4{
        public void EX4(){
            System.Console.Write("Informe o número de repetições: ");
            int loop = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe em sequência dois valores para divisão: ");
            for(int i = 1; i <= loop; i++){
                string[] input = Console.ReadLine().Split(' ');
                double a = double.Parse(input[0], CultureInfo.InvariantCulture);
                double b = double.Parse(input[1], CultureInfo.InvariantCulture);

                if(b == 0){
                    System.Console.WriteLine("Impossível dividir por 0!");
                }
                else
                {
                    System.Console.WriteLine((a / b).ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}