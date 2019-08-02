using System;
using System.Globalization;
using Interface.Entities;
using Interface.Services;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados do contrato: ");
                Console.Write("Numero: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Data: ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Valor: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Número de parcelas: ");
                int months = int.Parse(Console.ReadLine());

                Contract contrato = new Contract(number, date, amount, months);

                ContractProcessingService contractProcessing = new ContractProcessingService(new PaypalService());
                Console.WriteLine("\nPARCELAS:");
                contractProcessing.ProcessContract(contrato);
                Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                Console.ReadLine();
            }

        }
    }
}
