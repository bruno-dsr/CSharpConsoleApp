using System;

namespace EP4{
    public class Exercicio5{
        public void EX5(){
            System.Console.Write("Informe o valor para calcular o fatorial: ");
            int input = int.Parse(Console.ReadLine());
            int output = 1;

            if(input != 0){
                for(int i = 1; i <= input; i++){
                    output *= i;
                }
                System.Console.WriteLine(output);
            }
            else{
                System.Console.WriteLine(1);
            }
        }
    }
}