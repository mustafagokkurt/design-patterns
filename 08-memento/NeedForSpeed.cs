using System;
using System.Collections.Generic;
using System.Text;

namespace _08_memento
{
    //originator
    class NeedForSpeed
    {
        public int Level { get; set; }
        public string BolumAdi { get; set; }

        public override string ToString()
        {
            return $"{Level}. level {BolumAdi} bölüm.";
        }

        //T anında nesneyi tutacak olan metod.
        public NfsMemento Kaydet()
        {
            return new NfsMemento
            {
                BolumAdi = this.BolumAdi,
                Level = this.Level
            };
        }

        //T anındaki nesneye bizi ulaşturacak olan metod.
        public void OncekiniYukle(NfsMemento Memento)
        {
            this.BolumAdi = Memento.BolumAdi;
            this.Level = Memento.Level;
        }
    }
}
