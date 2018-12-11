using System;

namespace Geometri.Lib
{
    public class Dikdortgen : Sekil
    {
        public double Y { get; set; }
        public override double AlanHesapla()
        {
            return X * Y;
        }

        public override double CevreHesapla()
        {
            return 2 * (X + Y);
        }

        public override double KosegenHesapla()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}
