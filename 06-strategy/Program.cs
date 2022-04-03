using System;

namespace _06_strategy
{

    /// <summary>
    /// 1.Bir işlem için birden fazla farklı yöntemlerin uygulanabileceği durumlar mevcuttur.
    /// 2.İşte bu tarz durumlarda hangi yöntemin uygulanacağını, 
    /// 3.Hangisinin devreye sokulacağını Strategy Design Pattern ile gerçekleştirebiliyoruz.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Uretici uret = new Uretici();
            //Console.Read();

            OzelYapimUret oyUret = new OzelYapimUret();
            SeriUret sUret = new SeriUret();
            SiparisUzerineUret suUret = new SiparisUzerineUret();
            Uretici uret1 = new Uretici(oyUret);
            Uretici uret2 = new Uretici(sUret);
            Uretici uret3 = new Uretici(suUret);
            Console.Read();




        }
    }
}
