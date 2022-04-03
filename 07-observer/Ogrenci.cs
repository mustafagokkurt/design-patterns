using System;
using System.Collections.Generic;
using System.Text;

namespace _07_observer
{
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Memleket { get; set; }
        public int Sinif { get; set; }

        bool dersiAstiMi;
        
        public bool DersiAstiMi
        {
            get { return dersiAstiMi; }
            set
            {
                if (value == true)
                {
                    Notify();
                    dersiAstiMi = value;
                }
                else
                    dersiAstiMi = value;
            }
        }
        
        List<Observer> Gozlemciler;
        public Ogrenci()
        {
            this.Gozlemciler = new List<Observer>();
        }
        
        public void AboneEkle(Observer observer)
        {
            Gozlemciler.Add(observer);
        }
        
        public void AboneCikar(Observer observer)
        {
            Gozlemciler.Remove(observer);
        }
        
        public void Notify()
        {
            Gozlemciler.ForEach(g =>
            {
                g.Update();
            });
        }
    }
}
