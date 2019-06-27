using System;
using System.Globalization;
namespace EP2{
    public class Exercicio6{
        public void EX6(){
          Console.WriteLine("Informe o valor dentro do intervalo: ");
          double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          if (x >= 0 && x <= 25){
              Console.WriteLine("Intervalo [0, 25]");
          }
          else if (x >= 25.01 && x <= 50){
              Console.WriteLine("Intervalo [25, 50]");
          }
          else if (x >= 50.01 && x <= 75){
              Console.WriteLine("Intervalo [50, 75]");
          }
          else if (x >= 75.01 && x <= 100){
              Console.WriteLine("Intervalo [75, 100]");
          }
          else{
              Console.WriteLine("Fora do inervalo");
          }
        }
    }
}