using System;

namespace Matriz
{
    class Program
    {
        //EXERCICIO MATRIZES
        static void Main(string[] args)
        {
            Console.Write("Informe as dimensões da matriz no formato 'X,Y': ");
            string[] dimensoes = Console.ReadLine().Split(',');
            int x = int.Parse(dimensoes[0]);
            int y = int.Parse(dimensoes[1]);

            int?[,] matriz = new int?[x, y];

            Console.WriteLine("\nPreencha os valores da matriz no formado 'x y z': ");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Entre com os valores da linha #{0}: ", i);
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < y; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("\nInforme o número que deseja identificar na matriz: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (matriz[i, j] == n)
                    {
                        Console.WriteLine("\nPosição: ({0},{1})", i, j);
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }

                        if (j < y - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }

                        if (i < x - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }

                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                    }
                }
            }
        }
    }
}
