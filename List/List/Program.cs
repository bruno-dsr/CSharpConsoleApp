using System;
using System.Globalization;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        //EXERCICIO LISTAS
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.Write("Quantos funcionários serão registrados? ");
            int loop = int.Parse(Console.ReadLine());

            for (int i = 1; i <= loop; i++)
            {
                Console.WriteLine("\nFuncionário #" + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Funcionario f = funcionarios.Find(x => x.ID == id);
                while (f != null)
                {
                    Console.WriteLine("ID já existe. Por favor, informe um novo ID.");
                    Console.Write("ID: ");
                    id = int.Parse(Console.ReadLine());
                    f = funcionarios.Find(x => x.ID == id);
                }

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("\nInforme o ID do funcionário que receberá o aumento: ");
            int idf = int.Parse(Console.ReadLine());
            Console.Write("Informe a porcentagem de aumento: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario ff = funcionarios.Find(x => x.ID == idf);
            ff.AumentarSalario(percent);

            Console.WriteLine("\nLista atualizada de funcionários:");

            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}
