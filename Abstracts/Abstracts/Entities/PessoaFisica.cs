namespace Abstracts.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastoMedico { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double rendaAnual, double gastoMedico) : base(nome, rendaAnual)
        {
            GastoMedico = gastoMedico;
        }

        public override double ImpostoAPagar()
        {
            double imposto = 0;
            if (RendaAnual < 20000.00)
            {
                imposto = RendaAnual * (15.0 / 100);
            }
            else
            {
                imposto = RendaAnual * (25.0 / 100);
            }

            if (GastoMedico > 0)
            {
                imposto -= GastoMedico * (50.0 / 100);
            }

            return imposto;
        }
    }
}
