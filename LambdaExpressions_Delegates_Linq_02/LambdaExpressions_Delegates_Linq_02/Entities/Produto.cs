using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions_Delegates_Linq_02.Entities
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
    }
}
