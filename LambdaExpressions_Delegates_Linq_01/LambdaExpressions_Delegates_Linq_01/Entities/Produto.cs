using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions_Delegates_Linq_01.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return ($"{Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        //Função estática delegate para comparar produtos por nome
        public static int CompararPorNome(Produto p1, Produto p2)
        {
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }

        //Função estática delegate para comparar produtos por nome
        public static int CompararPorPreco(Produto p1, Produto p2)
        {
            return p1.Preco.CompareTo(p2.Preco);
        }
    }
}
