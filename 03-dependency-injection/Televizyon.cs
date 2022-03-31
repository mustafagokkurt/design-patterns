using System;
using System.Collections.Generic;
using System.Text;

namespace _03_dependency_injection
{
    class Televizyon : IMedya
    {
        public string YayinAkisiniGetir()
        {
            return "TV Yayın Akışı";
        }
    }
}
