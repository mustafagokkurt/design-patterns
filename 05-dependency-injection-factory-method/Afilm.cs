using System;
using System.Collections.Generic;
using System.Text;

namespace _05_dependency_injection_factory_method
{
    class AFilm : FilmAbs
    {
        public override int Stok
        {
            get
            {
                return 23;
            }
        }

        public override string FilmAdi()
        {
            Console.WriteLine("A Film");
            return "A Film";
        }

        public override bool Oynat()
        {
            Console.WriteLine("A Film Oynatılıyor...");
            return true;
        }

        public override bool Sat()
        {
            Console.WriteLine("A Film Satılmıştır...");
            return true;
        }

        public override bool VarMi()
        {
            Console.WriteLine($"A Film'den {Stok} kadar var...");
            return true;
        }
    }    
}
