using System;
using System.Collections.Generic;
using System.Text;

namespace _06_strategy
{
    class SeriUret: Strategy
    {
        public override Opel Uret()
        {
            return new Opel("seri");
        }
    }
}
