using System;
using System.Globalization;

namespace Arrays
{
    class Quarto
    {
        public int Numero { get; set; }
        public string Ocupante { get; set; }
        public string Email { get; set; }

        public Quarto(int numero, string ocupante, string email)
        {
            Numero = numero;
            Ocupante = ocupante;
            Email = email;
        }

        public override string ToString()
        {
            return Numero + ": " + Ocupante + ", " + Email;
        }
    }
}
