using System;

namespace _05_dependency_injection_factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory Method Design Pattern
            Creater Uretici = new Creater();
            //Dependency Injection
            FilmSatici Satici = new FilmSatici(Uretici.FactoryMethod(FilmTipleri.CFilm));
            Satici.Sat();

            Console.Read();
        }
    }
}
