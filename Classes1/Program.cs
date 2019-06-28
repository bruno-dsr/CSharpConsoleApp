using System;

namespace Classes1
{
    class Program
    {
        // EXERCICIOS CLASSES PARTE 1
        // ABORDA: CLASSES E ATRIBUTOS
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escolha um exercício:");
            ExibirExercicios();
            int escolha = int.Parse(Console.ReadLine());

            while (escolha != 0){
                switch(escolha){
                    case 1:
                    Exercicio1 e1 = new Exercicio1();
                    e1.EX1();
                    break;

                    case 2:
                    Exercicio2 e2 = new Exercicio2();
                    e2.EX2();
                    break;

                    case 0:
                    break;
                }

                if (escolha != 0){
                    System.Console.WriteLine("Escolha um novo exercicio:");
                    ExibirExercicios();
                    escolha = int.Parse(Console.ReadLine());
                }

            }
        }

        static void ExibirExercicios(){
            System.Console.WriteLine("[1] Checar idade");
            System.Console.WriteLine("[2] Média de salários");
            System.Console.WriteLine("[0] Encerrar programa");
        }
    }
}
