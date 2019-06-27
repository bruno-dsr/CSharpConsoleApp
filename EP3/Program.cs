using System;

namespace EP3
{
    class Program
    {
        // EXERCICIOS PROPOSTOS PARTE 3
        // ABORDA: ESTRUTURA DE REPETIÇÃO WHILE
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um exercício");
            Console.WriteLine("[1] Testar senha");
            Console.WriteLine("[2] Leitor de coordenadas");
            Console.WriteLine("[3] Produtos em posto de gasolina");
            Console.WriteLine("[0] Encerrar programa");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha){
                case 1:
                Exercicio1 e1 = new Exercicio1();
                e1.EX1();
                break;

                case 2:
                Exercicio2 e2 = new Exercicio2();
                e2.EX2();
                break;

                case 3:
                Exercicio3 e3 = new Exercicio3();
                e3.EX3();
                break;

                case 0:
                break;

                default:
                break;
            }
        }
    }
}
