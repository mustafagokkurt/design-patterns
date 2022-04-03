using System;
using System.Collections.Generic;
using System.Text;

namespace _06_strategy
{
    class SiparisUzerineUret: Strategy
    {
        public override Opel Uret()
        {
            return new Opel("sipariş üzerine");
        }
    }
}
