using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions_Delegates_Linq_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### LEITURA DE DADOS DE FUNCIONÁRIO ###\n\n");
            Console.Write("Entre com o caminho do arquivo .csv: ");
            string path = Console.ReadLine();
            Console.WriteLine();

            try
            {
                List<Funcionario> funcionarios = new List<Funcionario>();
                FileStream fs = new FileStream(@path, FileMode.Open);
                StreamReader file = new StreamReader(fs);

                while (!file.EndOfStream)
                {
                    string[] f = file.ReadLine().Split(';');
                    Funcionario funcionario = new Funcionario(f[0], f[1], double.Parse(f[2], CultureInfo.InvariantCulture));
                    funcionarios.Add(funcionario);
                }

                Console.Write("Inform o valor de salário a ser utilizado como parâmetro: ");
                double parametro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Console.WriteLine("### E-Mail dos funcionários cujo salário é superior a R$ " + parametro.ToString("F2", CultureInfo.InvariantCulture) + "\n");
                var emails = funcionarios.Where(f => f.Salario > parametro).OrderBy(f => f.Email).Select(f => f.Email);
                foreach (string s in emails)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();

                Console.WriteLine("### Soma do salário de funcionários com a inicial M ###\n");
                var soma = funcionarios.Where(f => f.Nome[0] == 'M').Sum(f => f.Salario);
                Console.WriteLine("R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
                Console.WriteLine("Encerrando o programa...");
            }
        }
    }
}
