namespace LambdaExpressions_Delegates_Linq_03.Entities
{
    class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Tier { get; set; }

        public Categoria(int iD, string nome, int tier)
        {
            ID = iD;
            Nome = nome;
            Tier = tier;
        }
    }
}
