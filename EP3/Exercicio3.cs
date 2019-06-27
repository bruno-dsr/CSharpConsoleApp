using System;

namespace EP3{
    public class Exercicio3{
        public void EX3(){
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int codigo = 0;

            Console.WriteLine("Entre com os códigos. Digite [4] para encerrar. ");
            codigo = int.Parse(Console.ReadLine());
            while (codigo != 4){
                if (codigo < 1 && codigo > 4){
                    Console.WriteLine("Informe um código válido");
                }
                else if (codigo == 1){
                    alcool++;
                }
                else if (codigo == 2){
                    gasolina++;
                }
                else if (codigo == 3){
                    diesel++;
                }
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Obrigado!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}