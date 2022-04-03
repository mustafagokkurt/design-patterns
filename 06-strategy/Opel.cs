using System;
using System.Collections.Generic;
using System.Text;

namespace _06_strategy
{
    class Opel
    {
        public Opel(string UretimTipi)
        {
            Console.WriteLine($"Opel {UretimTipi} üretilmiştir.");
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KM { get; set; }
    }
}
