using System;

namespace EP2{
    public class Exercicio3{
        public void EX3(){
            Console.WriteLine("Entre com os valores de A e B: ");
            string[] s = Console.ReadLine().Split(' ');

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            
            if(a % b == 0 || b % a == 0){
                Console.WriteLine("São múltiplos");
            }
            else{
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}