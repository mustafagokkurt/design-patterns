using System;
using System.Collections.Generic;
using System.Text;

namespace _02_factory_method
{
    class Creator
    {
        public Araba FactoryMethod(Arabalar arabaMarkasi)
        {
            Araba araba = null;

            switch (arabaMarkasi)
            {
                case Arabalar.BMW:
                    araba = new Bmw();
                    break;
                case Arabalar.Mercedes:
                    araba = new Mercedes();
                    break;
                default:
                    break;
            }

            return araba;
        }
    }
}
