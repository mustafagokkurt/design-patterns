using System;
using System.Collections.Generic;
using System.Text;

namespace _05_dependency_injection_factory_method
{
    enum FilmTipleri
    {
        AFilm,
        BFilm,
        CFilm
    }

    class Creater
    {
        public FilmAbs FactoryMethod(FilmTipleri FilmTipi)
        {
            FilmAbs film = null;

            switch (FilmTipi)
            {
                case FilmTipleri.AFilm:
                    film = new AFilm();
                    break;
                case FilmTipleri.BFilm:
                    film = new BFilm();
                    break;
                case FilmTipleri.CFilm:
                    film = new CFilm();
                    break;
            }

            return film;
        }
    }
}
