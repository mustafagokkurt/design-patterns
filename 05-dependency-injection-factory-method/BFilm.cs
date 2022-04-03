using System;
using System.Collections.Generic;
using System.Text;

namespace _05_dependency_injection_factory_method
{
    class BFilm : FilmAbs
    {
        public override int Stok
        {
            get
            {
                return 44;
            }
        }

        public override string FilmAdi()
        {
            Console.WriteLine("B Film");
            return "B Film";
        }

        public override bool Oynat()
        {
            Console.WriteLine("B Film Oynatılıyor...");
            return true;
        }

        public override bool Sat()
        {
            Console.WriteLine("B Film Satılmıştır...");
            return true;
        }

        public override bool VarMi()
        {
            Console.WriteLine($"B Film'den {Stok} kadar var...");
            return true;
        }
    }
}
