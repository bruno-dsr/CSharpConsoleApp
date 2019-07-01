using System;

namespace Classes3
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIOS CLASSE PARTE 3
            //ABORDA CLASSES, MÉTODOS, ATRIBUTOS, TOSTRING E OVERRIDE

            System.Console.WriteLine("Selecione um exercício:");
            ExibirExercicios();
            int escolha = int.Parse(Console.ReadLine());

            while (escolha != 0){
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
                }

                if (escolha != 0){
                    System.Console.WriteLine("Escolha um novo exercicio: ");
                    ExibirExercicios();
                    escolha = int.Parse(Console.ReadLine());
                }
            }
        }

        static void ExibirExercicios(){
            System.Console.WriteLine("[1] Área, perímetro e diagonal de retângulo");
            System.Console.WriteLine("[2] Cálculo de aumento");
            System.Console.WriteLine("[3] Cálculo de média do aluno");
            System.Console.WriteLine("[0] Encerrar Programa");
        }
    }
}
