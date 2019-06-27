using System;

namespace EP3{
    public class Exercicio1{
        public void EX1(){
            int senha = 0;

            while (senha != 2002){
                Console.WriteLine("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());

                if (senha != 2002){
                    Console.WriteLine("Acesso negado");
                }
            }
            
            Console.WriteLine("Acesso permitido");
        }
    }
}