using System;

namespace _08_memento
{
    class Program
    {
        static void Main(string[] args)
        {
            NeedForSpeed oyun = new NeedForSpeed();
            oyun.Level = 1;
            oyun.BolumAdi = "Drag Yarışı";
            Console.WriteLine(oyun.ToString());

            NfsCareTaker taker = new NfsCareTaker();
            taker.Memento = oyun.Kaydet();

            oyun.Level = 2;
            oyun.BolumAdi = "Drag Yarışı";
            Console.WriteLine(oyun.ToString());

            oyun.OncekiniYukle(taker.Memento);

            Console.WriteLine(oyun.ToString());
            Console.Read();
        }
    }
}
