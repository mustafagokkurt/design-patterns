using System;

namespace _09_facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeUretici uretici = new FacadeUretici();
            uretici.ArabaUret();

            Console.Read();
        }
    }
}
