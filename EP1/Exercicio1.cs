// Exercicios estrutura sequencial

using System;

namespace EP1{
    public class Exercicio1{
        public void Ex1(){
            System.Console.WriteLine("Entre com o valor A: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com o valor B: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.WriteLine("A soma entre {0} e {1} é igual a {2}.", a, b, a+b);
        }
    }
}