using System;

namespace EP1{
    public class Exercicio3{
        public void EX3(){
            Console.Write("Informe o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de C: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de D: ");
            int d = int.Parse(Console.ReadLine());
            
            int dif = (a * b) - (c * d);

            Console.WriteLine("A diferença entre {0}x{1} - {2}x{3} = {4}", a, b, c, d, dif);
        }
    }
}