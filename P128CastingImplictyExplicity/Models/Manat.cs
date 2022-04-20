using System;
using System.Collections.Generic;
using System.Text;

namespace P128CastingImplictyExplicity.Models
{
    class Manat
    {
        public double AZN { get; set; }

        public static implicit operator Dollar(Manat manat)
        {
            Dollar dollar = new Dollar();
            dollar.USD = manat.AZN / 1.7;
            return dollar;
        }

        public static implicit operator EURO(Manat manat)
        {
            EURO dollar = new EURO();
            dollar.EUR = manat.AZN / 1.99;
            return dollar;
        }
    }
}
