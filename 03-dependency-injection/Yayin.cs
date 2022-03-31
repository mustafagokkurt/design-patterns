using System;
using System.Collections.Generic;
using System.Text;

namespace _03_dependency_injection
{
    class Yayin
    {
        IMedya medya;

        // Constructor Based Dependecy Injection
        public Yayin(IMedya medya)
        {
            this.medya = medya;
        }

        // Setter Based Dependency Injection
        public IMedya medya2 { get; set; }

        // Method Based Dependency Injection
        public void setMedya(IMedya medya)
        {
            this.medya = medya;
        }

        public string YayinAkisi()
        {
            return this.medya.YayinAkisiniGetir();
        }

    }
}
