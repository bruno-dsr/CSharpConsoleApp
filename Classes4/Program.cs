using System;
using System.Globalization;

namespace Classes4
{
    class Program
    {
        // EXERCICIOS CLASSES PARTE 4
        // ABORDA: MEMBROS ESTÁTICOS
        static void Main(string[] args)
        {
            System.Console.Write("Informe o valor da cotação atual:");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Informe o valor em dólares a ser comprado: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Valor em reais a ser pago: " + ConversorDeMoeda.CalcularValorTotal(cotacao, valor).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
