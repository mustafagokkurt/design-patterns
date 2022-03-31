using System;
using System.Collections.Generic;
using System.Text;

namespace _03_dependency_injection
{
    class Radyo : IMedya
    {
        public string YayinAkisiniGetir()
        {
            return "Radyo Yayın Akışı";
        }
    }
}
