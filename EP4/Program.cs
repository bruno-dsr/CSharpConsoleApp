using System;

namespace EP4
{
    class Program
    {
        //EXERCICIOS PROPOSTOS PARTE 4
        //ABORDA: ESTRUTURA DE REPETIÇÃO 'FOR'
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escolha um exercicio");
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

                    case 0:
                    break;

                    default:
                    break;
                }

                if(escolha != 0){
                    System.Console.WriteLine("Escolha um novo exercício: ");
                    ExibirExercicios();
                    escolha = int.Parse(Console.ReadLine());
                }
            }
        }

        static void ExibirExercicios(){
                System.Console.WriteLine("[1] Exibir números ímpares");
                System.Console.WriteLine("[2] Verificar Intervalo [10,20]");
                System.Console.WriteLine("[3] Cálculo de média ponderada");
                System.Console.WriteLine("[4] Divisão entre dois números");
                System.Console.WriteLine("[5] Cálculo de fatorial");
                System.Console.WriteLine("[6] Calcular divisores");
                System.Console.WriteLine("[7] Potência contínua");
                System.Console.WriteLine("[0] Encerrar programa");
        }
    }
}
