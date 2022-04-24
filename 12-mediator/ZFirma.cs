using System;
using System.Collections.Generic;
using System.Text;

namespace _12_mediator
{
    /// <summary>
    /// Concrete Colleague
    /// </summary>
    public class ZFirma : Firma
    {
        public ZFirma(INakliye nakliye) : base(nakliye)
        {
        }
        public override void NakliyeyeBasla()
        {
            Console.WriteLine("Ankara'dan eşyalar yüklendi.");
            _nakliye.MaliDevret(this);
        }
    }
}
