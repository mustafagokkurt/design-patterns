using System;
using System.Collections.Generic;
using System.Text;

namespace _05_dependency_injection_factory_method
{
    class CFilm : FilmAbs
    {
        public override int Stok
        {
            get
            {
                return 414;
            }
        }

        public override string FilmAdi()
        {
            Console.WriteLine("C Film");
            return "C Film";
        }

        public override bool Oynat()
        {
            Console.WriteLine("C Film Oynatılıyor...");
            return true;
        }

        public override bool Sat()
        {
            Console.WriteLine("C Film Satılmıştır...");
            return true;
        }

        public override bool VarMi()
        {
            Console.WriteLine($"C Film'den {Stok} kadar var...");
            return true;
        }
    }
}
