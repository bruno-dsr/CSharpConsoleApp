using System.Globalization;

namespace Inheritance_Polymorphism.Entities
{
    sealed class ProdutoImportado : Produto
    {
        public double TaxaAlfandegaria { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandegaria) : base(nome, preco)
        {
            TaxaAlfandegaria = taxaAlfandegaria;
        }

        public double ValorTotal()
        {
            return Preco + TaxaAlfandegaria;
        }

        public override string Etiqueta()
        {
            return Nome + " R$ " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture) 
                   + " (Taxa alfandegária: R$ " + TaxaAlfandegaria.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
