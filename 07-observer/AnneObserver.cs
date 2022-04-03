using System;
using System.Collections.Generic;
using System.Text;

namespace _07_observer
{
    public class AnneObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Öğrencinin kaçtığından anasının haberi oldu.");
        }
    }
}
