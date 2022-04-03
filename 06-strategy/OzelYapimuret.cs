using System;
using System.Collections.Generic;
using System.Text;

namespace _06_strategy
{
    class OzelYapimUret: Strategy
    {
        public override Opel Uret()
        {
            return new Opel("özel yapım");
        }
    }
}
