using System;
using Exception_Project.Entities.Exceptions;

namespace Exception_Project.Entities
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo, double limiteSaque)
        {
            if (numero < 1000 || numero > 9999)
            {
                throw new ContaException("O número da conta não pode conter mais nem menos de 4 dígitos");
            }

            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new ContaException("Impossível depositar um valor negativo.");
            }
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > LimiteSaque)
            {
                throw new ContaException("Valor solicitado é maior que o limite de saque.");
            }

            if (Saldo - valor < 0)
            {
                throw new ContaException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }

        public override string ToString()
        {
            return ($"Conta: {Numero}, Titular: {Titular}");
        }

        public static void ExibirOperacoes()
        {
            Console.WriteLine("[1] Abertura de Conta");
            Console.WriteLine("[2] Listar Contas");
            Console.WriteLine("[3] Depósito");
            Console.WriteLine("[4] Saque");
            Console.WriteLine("[5] Saldo");
            Console.WriteLine("[0] Encerrar");
        }

        public static int SelecionarOperacao()
        {
            Console.WriteLine("\nSelecione uma operação: ");
            ExibirOperacoes();
            Console.Write("Operação: ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
    }
}
