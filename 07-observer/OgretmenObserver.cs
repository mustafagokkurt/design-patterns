using System;
using System.Collections.Generic;
using System.Text;

namespace _07_observer
{
    public class OgretmenObserver : Observer
{
    public override void Update()
    {
        Console.WriteLine("Öğrencinin kaçtığından öğretmenin haberi oldu.");
    }
}
}
