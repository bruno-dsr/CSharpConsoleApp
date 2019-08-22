using System.Globalization;
namespace LambdaExpressions_Delegates_Linq_03.Entities
{
    class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }

        public Produto(int iD, string nome, double preco, Categoria categoria)
        {
            ID = iD;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }

        public override string ToString()
        {
            return ($"ID: {ID}, {Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, Categoria: {Categoria.Nome}, Tier: {Categoria.Tier}");
        }
    }
}
