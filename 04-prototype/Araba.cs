using System;
using System.Collections.Generic;
using System.Text;

namespace _04_prototype
{
    class Araba : PrototypeAraba
    {
        public string Marka { get; set; }

        public Araba(string marka)
        {
            this.Marka = marka;
        }

        public override PrototypeAraba Clone()
        {
            return this.MemberwiseClone() as PrototypeAraba;
        }
    }
}
