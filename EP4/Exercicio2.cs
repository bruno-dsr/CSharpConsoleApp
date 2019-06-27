using System;

namespace EP4{
    public class Exercicio2{
        public void EX2(){
            System.Console.Write("Entre com a quantidade de repetições: ");
            int loop = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com os valores desejados: ");
            int _in = 0;
            int _out = 0;

            for(int i = 1; i <= loop; i++){
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20){
                    _in++;
                }
                else{
                    _out++;
                }
            }

            System.Console.WriteLine(_in + " in");
            System.Console.WriteLine(_out + " out");
        }
    }
}