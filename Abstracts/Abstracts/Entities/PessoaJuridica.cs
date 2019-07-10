namespace Abstracts.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int funcionarios) : base(nome, rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double ImpostoAPagar()
        {
            if (Funcionarios > 10)
            {
                return RendaAnual * (14.0 / 100);
            }

            else
            {
                return RendaAnual * (16.0 / 100);
            }
        }
    }
}
