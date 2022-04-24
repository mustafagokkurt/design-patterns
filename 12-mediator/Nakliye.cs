using System;
using System.Collections.Generic;
using System.Text;

namespace _12_mediator
{
    /// <summary>
    /// Concrete Mediator
    /// </summary>
    public class Nakliye : INakliye
    {
        XFirma _xfirma;
        YFirma _yfirma;
        ZFirma _zfirma;
        public XFirma XFirma { set => _xfirma = value; }
        public YFirma YFirma { set => _yfirma = value; }
        public ZFirma ZFirma { set => _zfirma = value; }
        public void MaliDevret(Firma firma)
        {
            if (firma is XFirma)
            {
                Console.WriteLine("Eşyalar Sivas'ta tekrar nakledilmek üzere indirildi.\n");
                _yfirma.NakliyeyeBasla();
            }
            else if (firma is YFirma)
            {
                Console.WriteLine("Eşyalar Ankara'da tekrar nakledilmek üzere indirildi.\n");
                _zfirma.NakliyeyeBasla();
            }
            else
                Console.WriteLine("Eşyalar Edirne'ye vardı çok şükür...");
        }
    }
}
