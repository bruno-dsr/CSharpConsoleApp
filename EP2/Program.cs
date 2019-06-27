using System;

namespace EP2
{
    class Program
    {
        //EXERCICIOS PROPOSTOS PARTE 2
        //ABORDA: ESTRUTURA CONDICIONAL IF/ELSE
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios estruturas condicionais.\n\n");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("[1] Verificar número negativo");
            Console.WriteLine("[2] Verificar par ou ímpar");
            Console.WriteLine("[3] Verificar números múltiplos");
            Console.WriteLine("[4] Duração da partida");
            Console.WriteLine("[5] Valor do produto");
            Console.WriteLine("[6] Verificar Intervalo");
            Console.WriteLine("[7] Verificar coordenadas");
            Console.WriteLine("[8] Cálculo de imposto");
            Console.WriteLine("[0] Encerrar programa");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
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

                case 4:
                Exercicio4 e4 = new Exercicio4();
                e4.EX4();
                break;

                case 5:
                Exercicio5 e5 = new Exercicio5();
                e5.EX5();
                break;

                case 6:
                Exercicio6 e6 = new Exercicio6();
                e6.EX6();
                break;

                case 7:
                Exercicio7 e7 = new Exercicio7();
                e7.EX7();
                break;

                case 8:
                Exercicio8 e8 = new Exercicio8();
                e8.EX8();
                break;

                case 0:
                break;

                default:
                break;
            }
            Console.ReadKey();
        }
    }
}
