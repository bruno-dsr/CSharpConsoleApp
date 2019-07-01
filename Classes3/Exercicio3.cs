using System;
using System.Globalization;

namespace Classes3{
    public class Exercicio3{
        public void EX3(){
            Aluno a = new Aluno();
            System.Console.WriteLine("Informe o nome do aluno:");
            a.Nome = Console.ReadLine();
            System.Console.Write("Nota trimestre 1: ");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Nota trimestre 2: ");
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Nota trimestre 3: ");
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(a.Media() >= 60.00){
                System.Console.WriteLine("Nota final: " + a.Media().ToString("F2", CultureInfo.InvariantCulture));
                System.Console.WriteLine("Aluno aprovado.");
            }

            else{
                System.Console.WriteLine("Nota final: " + a.Media().ToString("F2", CultureInfo.InvariantCulture));
                System.Console.WriteLine("Aluno reprovado.");
                System.Console.WriteLine("Faltam " + (60.00 - a.Media()).ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            }

        }
    }
}