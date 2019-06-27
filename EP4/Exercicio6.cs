using System;

namespace EP4{
    public class Exercicio6{
        public void EX6(){
            System.Console.Write("Informe um número para conhecer seus divisores: ");
            int input = int.Parse(Console.ReadLine());

            for(int i = 1; i <= input; i++){
                if(input % i == 0){
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}