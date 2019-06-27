using System;

namespace EP1{
    class Program{

        // EXERCICIOS PROPOSTOS PARTE 1
        // ABORDA: OPERADORES MATEMÁTICOS, ENTRADA E SAÍDA DE DADOS

        public static void Main(string[] args){
            System.Console.WriteLine("Selecione o exercício:");
            System.Console.WriteLine("[1] Soma entre dois números inteiros");
            System.Console.WriteLine("[2] Área de um círculo");
            System.Console.WriteLine("[3] Diferença entre produtos");
            System.Console.WriteLine("[4] Cálculo de salário de funcionário");
            System.Console.WriteLine("[5] Total de produtos");
            System.Console.WriteLine("[6] Área de formas geométricas");
            System.Console.WriteLine("[0] Encerrar programa");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                Exercicio1 e1 = new Exercicio1();
                e1.Ex1();
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

                case 0:
                break;

                default:
                break;
            }

            Console.ReadKey();
        }
    }
}