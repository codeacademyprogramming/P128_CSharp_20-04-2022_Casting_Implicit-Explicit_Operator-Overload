using P128CastingImplictyExplicity.Models;
using System;


namespace P128CastingImplictyExplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            Manat manat = new Manat();
            manat.AZN = 17000;

            Dollar dollar = manat;
            Console.WriteLine(dollar.USD);

            Manat yeniManat = (Manat)dollar;
            Console.WriteLine(yeniManat.AZN);

            //int b = 79879879;
            //double a = b;
            //Console.WriteLine(a);
        }

        void test()
        {
            Manat manat = new Manat();
            manat.AZN = 34000;

            Dollar dollar = manat;

        }
    }
}
