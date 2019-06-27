using System;

namespace EP4{
    public class Exercicio7{
        public void EX7(){
            System.Console.Write("Informe um número inteiro: ");
            int input = int.Parse(Console.ReadLine());

            for(int i = 1; i <= input; i++){
                System.Console.WriteLine("{0} {1} {2}", i, Math.Pow(i, 2), Math.Pow(i, 3));
            }
        }
    }
}