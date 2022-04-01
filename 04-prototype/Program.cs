using System;

namespace _04_prototype
{
    class Program
    {
        /// <summary>
        /// 1.Creational Patterns 
        /// 2.Prototype Design Pattern sayesinde elimizdeki mevcut nesnelerin prototiplerini oluşturabilmekteyiz.
        /// 3.Bu nesnelerin kopyalarını elde edebilmekteyiz.
        /// 4.Prototip deseninin tasarlanmasının asıl sebebi, ilgili nesne üzerinden aynı tipte başka bir nesneyi hızlıca üretebilmektir.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Araba araba1 = new Araba("BMW");
            Araba araba2 = (Araba)araba1.Clone();

            if (araba1.Equals(araba2))
            {
                Console.WriteLine("Eşit");
            }
            else
            {
                Console.WriteLine("Değil");
            }

            Console.Read();
        }
    }
}
