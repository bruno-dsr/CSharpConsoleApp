using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace ManipulacaoDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o caminho do arquivo .csv: ");
            string path = @"" + Console.ReadLine();

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        List<Produto> produtos = new List<Produto>();

                        while (!sr.EndOfStream)
                        {
                            string[] s = sr.ReadLine().Split(',');
                            Produto produto = new Produto
                            {
                                Nome = s[0],
                                Preco = double.Parse(s[1], CultureInfo.InvariantCulture),
                                Quantidade = int.Parse(s[2])
                            };

                            produtos.Add(produto);
                        }
                        string pathOut = Path.GetDirectoryName(path) + @"\out\summary.csv";
                        Directory.CreateDirectory(Path.GetDirectoryName(pathOut));

                        using (StreamWriter sw = new StreamWriter(File.OpenWrite(pathOut)))
                        {
                            foreach (Produto produto in produtos)
                            {
                                sw.WriteLine(produto.Nome + "," + (produto.Preco * produto.Quantidade).ToString("F2", CultureInfo.InvariantCulture));
                            }
                            Console.WriteLine("Arquivo de destino criado em: " + pathOut);
                        }
                    }
                }
                Console.ReadKey();
            }

            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}
