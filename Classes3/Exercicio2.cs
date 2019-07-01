using System;
using System.Globalization;

namespace Classes3{
    public class Exercicio2{
        public void EX2(){
            Funcionario f = new Funcionario();

            System.Console.WriteLine("Entre com os dados do funcionário:");
            System.Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            System.Console.Write("Salário: ");
            f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Impostos: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("");

            System.Console.WriteLine("Funcionario: " + f.ToString());
            System.Console.WriteLine("");

            System.Console.Write("Digite a porcentagem para o aumento de salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.AumentarSalario(porcentagem);
            System.Console.WriteLine("Dados atualizados: " + f.ToString());

        }
    }
}