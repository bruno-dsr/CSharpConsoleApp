using System;
using System.Globalization;

namespace EP2{
    public class Exercicio5{
        public void EX5(){
            double[] cachorro_quente = {1, 4.00}, x_salada = {2, 4.50}, x_bacon = {3, 5.00}, 
                     torrada = {4, 2.00}, refrigerante = {5, 1.50};

            Console.WriteLine("Entre com o código do produto e a quantidade: ");
            string[] pedido = Console.ReadLine().Split(' ');

            int codigo = int.Parse(pedido[0]);
            int quantidade = int.Parse(pedido[1]);
            double total;

            if (codigo == cachorro_quente[0]){
                total = quantidade * cachorro_quente[1];
            }
            else if (codigo == x_salada[0]){
                total = quantidade * x_salada[1];
            }

            else if (codigo == x_bacon[0]){
                total = quantidade * x_bacon[1];
            }

            else if (codigo == torrada[0]){
                total = quantidade * torrada[1];
            }

            else{
                total = quantidade * refrigerante[1];
            }

            Console.WriteLine("Valor total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}