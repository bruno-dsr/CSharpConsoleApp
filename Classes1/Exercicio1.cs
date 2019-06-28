using System;

namespace Classes1{
    public class Exercicio1{
        public void EX1(){
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            System.Console.WriteLine("Dados da pessoa #1:");
            System.Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da pessoa #2:");
            System.Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade){
                System.Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else{
                System.Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }
        }   
    }
}