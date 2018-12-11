namespace Cs.Lib.Abstracts
{
    public abstract class Tabanca : Silah, IAtesEdebilen, ISarjorlu
    {
        protected int _sarjorKapasitesi, _kalanFisek;
        public abstract int AtesEt();

        public int SarjorKapasitesi
        {
            get => _sarjorKapasitesi;
        }
        public int KalanFisek
        {
            get => _kalanFisek;
        }
        public abstract int YenidenDoldur();
    }
}
