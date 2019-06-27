using System;

namespace EP2{
    public class Exercicio2{
        public void EX2(){
            Console.Write("Entre com um valor inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0){
                Console.WriteLine("PAR");
            }

            else{
                Console.WriteLine("IMPAR");
            }
        }
    }
}