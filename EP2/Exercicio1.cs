using System;

namespace EP2{
    public class Exercicio1{
        public void EX1(){
            Console.Write("Entre com um valor numérico inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if(x < 0){
                Console.WriteLine("NEGATIVO");
            }

            else{
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}