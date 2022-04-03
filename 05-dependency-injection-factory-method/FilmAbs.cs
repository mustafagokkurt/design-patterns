using System;
using System.Collections.Generic;
using System.Text;

namespace _05_dependency_injection_factory_method
{
    abstract class FilmAbs
    {
        public abstract string FilmAdi();
        public abstract bool Oynat();
        public abstract bool Sat();
        public abstract bool VarMi();
        public abstract int Stok { get; }
    }
}
