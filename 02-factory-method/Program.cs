using System;

namespace _02_factory_method
{
    /// <summary>
    /// Creational Patterns    
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Creator creator = new Creator();

            Araba bmw = creator.FactoryMethod(Arabalar.BMW);
            Araba mercedes = creator.FactoryMethod(Arabalar.Mercedes);



            Console.WriteLine(bmw.DetayBilgileriGetir());
            Console.WriteLine(mercedes.DetayBilgileriGetir());
        }
    }
}
