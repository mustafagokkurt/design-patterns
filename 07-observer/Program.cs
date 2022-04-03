using System;

namespace _07_observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.AboneEkle(new BabaObserver());
            o.AboneEkle(new AnneObserver());
            o.AboneEkle(new OgretmenObserver());

            o.Adi = "Gençay";
            o.SoyAdi = "Yıldız";
            o.Memleket = "Artvin";
            o.Sinif = 24;
            o.DersiAstiMi = true;

            Console.ReadKey(true);
        }
    }
}
