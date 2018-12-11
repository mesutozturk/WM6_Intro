using System;

namespace Geometri.Lib
{
    public class Dikucgen : Dikdortgen
    {
        public override double AlanHesapla()
        {
            return base.AlanHesapla() / 2;
        }

        public override double CevreHesapla()
        {
            return this.X + this.Y + this.KosegenHesapla();
        }
    }
}
