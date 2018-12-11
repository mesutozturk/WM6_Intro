using System;

namespace Soyut.Lib
{
    public class Kare : Sekil
    {
        public override double CevreHesapla()
        {
            return X * 4;
        }

        public override double AlanHesapla()
        {
            return X * X;
        }

        public override double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
