using System;
using System.Globalization;

namespace Inheritance_Polymorphism.Entities
{
    sealed class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string Etiqueta()
        {
            return Nome + " (Usado) R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " (Fabricado em: " + DataFabricacao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
