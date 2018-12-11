using System;

namespace Geometri.Lib
{
    public abstract class Sekil
    {
        public double X { get; set; }
        /*
         * virtual keywordu. override edebilmemizi saglamakta. eger override edilmezse base classda yazildigi gibi calisir. override edildikten sonra, override edilmis classdan kalitim alinirsa, kalitim alan class override edilmis halini kalitim alir. isterse kendisi tekrar override eder.
         */
        public virtual double CevreHesapla()
        {
            return 4 * X;
        }

        public virtual double AlanHesapla()
        {
            return Math.Pow(X, 2);
        }
        public virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
