using System;
using System.Text.RegularExpressions;

namespace Kalitim
{
    public class Ogretmen : Kisi, IMaasAlabilir
    {
        private int falan = 0;
        public Branslar Brans { get; set; }
        public decimal Maas { get; set; }

        public Ogretmen()
        {

        }
        public Ogretmen(string ad) : base(ad)
        {
            instanceDate = DateTime.Now;
        }

        private decimal _saatlikUcret;

        public decimal SaatlikUcret
        {
            set => _saatlikUcret = value;
        }
        public decimal Tutar
        {
            get => _saatlikUcret * 20 * 8;
        }
        public decimal AvansVer()
        {
            throw new NotImplementedException();
        }

        public decimal OdemeYap()
        {
            throw new NotImplementedException();
        }
    }
}
