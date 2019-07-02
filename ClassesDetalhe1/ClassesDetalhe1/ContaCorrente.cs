using System;
using System.Globalization;

namespace ClassesDetalhe1
{
    public class ContaCorrente
    {
        public int Numero { get; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        private double Taxa = 5.00;

        public ContaCorrente(int numero, string nome)
        {
            Numero = numero;
            Titular = nome;
        }

        public ContaCorrente(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + Taxa);
        }

        public void Operacoes()
        {
            Console.WriteLine("[1] Deposito");
            Console.WriteLine("[2] Saque");
            Console.WriteLine("[3] Saldo");
            Console.WriteLine("[4] Dados da conta");
            Console.WriteLine("[0] Encerrar");
        }
    }
}
