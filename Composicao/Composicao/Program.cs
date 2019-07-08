using System;
using Composicao.Entity;
using Composicao.Entity.Enums;
using System.Globalization;

namespace Composicao
{
    class Program
    {
        //EXERCICIO COMPOSIÇÃO
        static void Main(string[] args)
        {
            Console.Write("Enter the worker's department: ");
            string depName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level [Junior / MidLevel / Senior]: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(depName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int loop = int.Parse(Console.ReadLine());

            for(int i = 1; i <= loop; i++)
            {
                Console.WriteLine($"Enter data for contract #{i}: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, valuePerHour, hours));
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string[] monthYear = Console.ReadLine().Split('/');
            int month = int.Parse(monthYear[0]);
            int year = int.Parse(monthYear[1]);

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for {0}/{1}: R${2}", month, year, worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
