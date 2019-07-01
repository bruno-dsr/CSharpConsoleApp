using System;
using System.Globalization;

namespace Classes3{
    public class Funcionario{
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido(){
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem){
            double aumento = (Salario * (porcentagem / 100));
            Salario += aumento;
        }

        public override string ToString(){
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}