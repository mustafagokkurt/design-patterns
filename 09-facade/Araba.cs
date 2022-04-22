using System;
using System.Collections.Generic;
using System.Text;

namespace _09_facade
{
    class Araba
    {
        public Araba(SasiOlusturucu sasi, MotorOlusturucu Motor, Renkler Renk)
        {
            Console.WriteLine($"Iskelet x = {sasi.x}");
            Console.WriteLine($"Iskelet y = {sasi.y}");
            Console.WriteLine($"Iskelet z = {sasi.z}");
            Console.WriteLine($"Motor x = {Motor.x}");
            Console.WriteLine($"Motor y = {Motor.y}");
            Console.WriteLine($"Motor z = {Motor.z}");
            Console.WriteLine($"Renk = {Renk}");
        }
    }
}
