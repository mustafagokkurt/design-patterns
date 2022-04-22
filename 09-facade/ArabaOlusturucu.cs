using System;
using System.Collections.Generic;
using System.Text;

namespace _09_facade
{
    class ArabaOlusturucu
{
    public SasiOlusturucu Sasi { get; set; }
    public MotorOlusturucu Motor { get; set; }
    public ArabaOlusturucu(SasiOlusturucu sasi, MotorOlusturucu Motor)
    {
        this.Sasi = sasi;
        this.Motor = Motor;
    }

    public Araba Olustur(Renkler renk)
    {
        return new Araba(Sasi, Motor, renk);
    }
}
}
