using System;

namespace Kalitim
{
    public class SefOgretmen : Ogretmen
    {
        public double Katsayi { get; set; }

        public SefOgretmen()
        {
            instanceDate = DateTime.Now;
        }
    }
}
