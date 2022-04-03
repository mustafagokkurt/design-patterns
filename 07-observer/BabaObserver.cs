using System;
using System.Collections.Generic;
using System.Text;

namespace _07_observer
{
    public class BabaObserver : Observer
{
    public override void Update()
    {
        Console.WriteLine("Öğrencinin kaçtığından babasının haberi oldu.");
    }
}
}
