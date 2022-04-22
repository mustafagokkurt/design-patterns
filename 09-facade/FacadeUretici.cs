using System;
using System.Collections.Generic;
using System.Text;

namespace _09_facade
{
    class FacadeUretici
    {
        SasiOlusturucu sasi;
        MotorOlusturucu motor;
        ArabaOlusturucu olustur;

        public FacadeUretici()
        {
            sasi = new SasiOlusturucu() { x = 3, y = 5, z = true };
            motor = new MotorOlusturucu() { x = 2, y = 4, z = false };
            olustur = new ArabaOlusturucu(sasi, motor);
        }

        public void ArabaUret()
        {
            Araba uretilenAraba = olustur.Olustur(Renkler.Kırmızı);
        }
    }
}
