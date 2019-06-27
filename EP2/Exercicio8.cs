using System;
using System.Globalization;

namespace EP2{
    public class Exercicio8{
        public void EX8(){
            Console.WriteLine("Informe o salário: ");
            double salario  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000){
                Console.WriteLine("Isento");
            }

            else if (salario >= 2000.01 && salario <= 3000){
                imposto = (salario - 2000.0) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (salario >= 3000.01 && salario <= 4500){
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if (salario > 4500){
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}