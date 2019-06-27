using System;
using System.Globalization;

namespace EP1{
    public class Exercicio5{
        public void EX5(){
          Console.WriteLine("Informe CODIGO QUANTIDADE VALOR:");
          string[] item1 = Console.ReadLine().Split(' ');
          Console.WriteLine("Informe CODIGO QUANTIDADE VALOR:");
          string[] item2 = Console.ReadLine().Split(' ');

          int cod1 = int.Parse(item1[0]);
          int qtd1 = int.Parse(item1[1]);
          double vlr1 = double.Parse(item1[2], CultureInfo.InvariantCulture);

          int cod2 = int.Parse(item2[0]);
          int qtd2 = int.Parse(item2[1]);
          double vlr2 = double.Parse(item2[2], CultureInfo.InvariantCulture);

          double total1 = vlr1 * qtd1;
          double total2 = vlr2 * qtd2;

          System.Console.WriteLine("TOTAL A PAGAR: R$ " + (total1 + total2).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}