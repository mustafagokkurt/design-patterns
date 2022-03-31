using System;
using System.Collections.Generic;
using System.Text;

namespace _02_factory_method
{
    class Mercedes : Araba
    {
        public override string DetayBilgileriGetir()
        {
            return "Mercedes";
        }
    }
}
