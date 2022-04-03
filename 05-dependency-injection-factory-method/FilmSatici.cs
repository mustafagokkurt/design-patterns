using System;
using System.Collections.Generic;
using System.Text;

namespace _05_dependency_injection_factory_method
{
    class FilmSatici
    {
        FilmAbs film;
        public FilmSatici(FilmAbs film)
        {
            this.film = film;
        }

        public void Sat()
        {
            if (film.VarMi())
                film.Sat();
        }
    }
}
