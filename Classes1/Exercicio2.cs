using System;
using System.Globalization;

namespace Classes1{
    public class Exercicio2{
        public void EX2(){
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            System.Console.WriteLine("Entre com os dados do Funcionario #1: ");
            System.Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            System.Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com os dados do Funcionario #2: ");
            System.Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            System.Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;
            System.Console.WriteLine("Salario médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}