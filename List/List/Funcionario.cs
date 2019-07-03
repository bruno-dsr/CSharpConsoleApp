using System;
using System.Globalization;

namespace List
{
    public class Funcionario
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            return ID + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }
    }
}
