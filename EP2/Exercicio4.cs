using System;

namespace EP2{
    public class Exercicio4{
        public void EX4(){
            Console.WriteLine("Entre o horário de início e fim da partida:");
            string[] s = Console.ReadLine().Split(' ');

            int inicio = int.Parse(s[0]);
            int fim = int.Parse(s[1]);
            int duracao;

            if (inicio < fim){
                duracao = fim - inicio;
            }

            else{
                duracao = 24 - inicio + fim;
            }

            Console.WriteLine("A partida durou {0} horas.", duracao);

        }
    }
}