using System;
using System.Globalization;

namespace Classes2{
    public class Produto{
        public string Nome;
        public double Preco;
        public int Quantidade;

        public void ValorTotalEmEstoque(){
            System.Console.WriteLine("{0}, $ {1}, {2} unidades, Total: $ {3}", Nome, Preco.ToString("F2", CultureInfo.InvariantCulture), 
            Quantidade, (Preco * Quantidade).ToString("F2", CultureInfo.InvariantCulture));
        }

        public void AdicionarProdutos(int quantity){
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity){
            Quantidade -= quantity;
        }
    }
}