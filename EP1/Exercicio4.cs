using System;
using System.Globalization;

namespace EP1{
    public class Exercicio4{
        public void EX4(){
            Console.Write("Informe o número do funcionário: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Informe o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor da hora: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valor * horas;

            System.Console.WriteLine("NUMBER = " + number);
            System.Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}