using System;
using System.Collections.Generic;
using System.Text;

namespace P128CastingImplictyExplicity.Models
{
    class Dollar
    {
        public double USD { get; set; }

        public static explicit operator Manat(Dollar manat)
        {
            Manat dollar = new Manat();
            dollar.AZN = manat.USD * 1.69;
            return dollar;
        }
    }
}
