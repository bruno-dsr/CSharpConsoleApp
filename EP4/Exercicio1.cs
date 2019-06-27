using System;

namespace EP4{
    public class Exercicio1{
        public void EX1(){
            System.Console.Write("Informe um valor inteiro: ");
            int input = int.Parse(Console.ReadLine());

            for(int i = 1; i <= input; i++){
                if(i % 2 != 0){
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}