using System;
using System.Collections.Generic;
using System.Text;

namespace _06_strategy
{
    class Uretici
    {
        //public Uretici()
        //{
        //    SeriUret sUret = new SeriUret();
        //    sUret.Uret();
        //}

        public Uretici(Strategy strategy)
        {
            strategy.Uret();
        }
    }
}
