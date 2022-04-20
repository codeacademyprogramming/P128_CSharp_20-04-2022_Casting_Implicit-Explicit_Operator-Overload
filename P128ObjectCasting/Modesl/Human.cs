using System;
using System.Collections.Generic;
using System.Text;

namespace P128ObjectCasting.Modesl
{
    class Human
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public override string ToString()
        {
            return $"Ad: {Name} SoyAd: {SurName}";
        }
    }
}
