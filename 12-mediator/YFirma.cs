using System;
using System.Collections.Generic;
using System.Text;

namespace _12_mediator
{
    /// <summary>
    /// Concrete Colleague
    /// </summary>
    public class YFirma : Firma
    {
        public YFirma(INakliye nakliye) : base(nakliye)
        {
        }
        public override void NakliyeyeBasla()
        {
            Console.WriteLine("Sivas'tan eşyalar yüklendi.");
            _nakliye.MaliDevret(this);
        }
    }
}
