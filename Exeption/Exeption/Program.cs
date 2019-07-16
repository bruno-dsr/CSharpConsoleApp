using System;
using System.Collections.Generic;
using Exception_Project.Entities;
using Exception_Project.Entities.Exceptions;
using System.Globalization;

namespace Exception_Project
{
    class Program
    {
        //EXERCICIO REFERENTE A EXCESSÕES
        static void Main(string[] args)
        {
            int opt = 0;
            List<Conta> contas = new List<Conta>();
            try
            {
                opt = Conta.SelecionarOperacao();
            }

            catch (FormatException)
            {
                Console.WriteLine("Ocorreu um erro! Não foi possível reconhecer a operação escolhida.");
            }

            while (opt != 0)
            {
                switch (opt)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("\n--|| Abertura de Conta ||--");
                            Console.Write("Número: ");
                            int numero = int.Parse(Console.ReadLine());
                            Console.Write("Titular: ");
                            string titular = Console.ReadLine();
                            Console.Write("Saldo Inicial: ");
                            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Limite para saque: ");
                            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            contas.Add(new Conta(numero, titular, saldo, limite));
                            Console.WriteLine($"Conta {numero} aberta com sucesso!");

                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                        catch (ContaException e)
                        {
                            Console.WriteLine("Ocorreu um erro durante a abertura de conta: " + e.Message);
                            opt = Conta.SelecionarOperacao();
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ocorreu um erro durante a abertura de conta: " + e.Message);
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                    case 2:
                        Console.WriteLine("\n--|| Lista de Contas Ativas ||--");
                        foreach (Conta conta in contas)
                        {
                            Console.WriteLine(conta);
                        }
                        opt = Conta.SelecionarOperacao();
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("\n--|| Depósito ||--");
                            Console.Write("Informe o número da conta: ");
                            int nAcc1 = int.Parse(Console.ReadLine());
                            Conta c1 = contas.Find(x => x.Numero == nAcc1);

                            if (c1 == null)
                            {
                                Console.WriteLine("Número de conta inexistente.");
                            }
                            else
                            {
                                Console.Write("Informe o valor de depósito: ");
                                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                c1.Depositar(valor);
                                Console.WriteLine("Depósito realizado com sucesso.");
                            }
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                        catch(ContaException e)
                        {
                            Console.WriteLine("Ocorreu um erro: " + e.Message);
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Ocorreu um erro: " + e.Message);
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                    case 4:
                        try
                        {
                            Console.WriteLine("\n--|| Saque ||--");
                            Console.Write("Informe o número da conta: ");
                            int nAcc2 = int.Parse(Console.ReadLine());
                            Conta c2 = contas.Find(x => x.Numero == nAcc2);
                            if (c2 == null)
                            {
                                Console.WriteLine("Número de conta inexistente.");
                            }
                            else
                            {
                                Console.Write("Informe o valor de saque: ");
                                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                c2.Sacar(valor);
                                Console.WriteLine("Saque realizado com sucesso.");
                            }
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                        catch (ContaException e)
                        {
                            Console.WriteLine("Ocorreu um erro: " + e.Message);
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Ocorreu um erro: " + e.Message);
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                    case 5:
                        try
                        {
                            Console.WriteLine("\n--|| Saldo ||--");
                            Console.Write("Informe o número da conta: ");
                            int nAcc3 = int.Parse(Console.ReadLine());
                            Conta c3 = contas.Find(x => x.Numero == nAcc3);
                            if (c3 == null)
                            {
                                Console.WriteLine("Número de conta inexistente.");
                            }
                            else
                            {
                                Console.WriteLine(c3 + ", Saldo: " + c3.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                            }
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                        catch (ContaException e)
                        {
                            Console.WriteLine("Ocorreu um erro: " + e.Message);
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Ocorreu um erro: " + e.Message);
                            opt = Conta.SelecionarOperacao();
                            break;
                        }

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        opt = Conta.SelecionarOperacao();
                        break;
                }
            }
        }
    }
}
