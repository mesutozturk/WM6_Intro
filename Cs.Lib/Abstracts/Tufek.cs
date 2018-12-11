using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib.Abstracts
{
    public abstract class Tufek : Silah, IAtesEdebilen, ISarjorlu, ISeriAtabilir
    {
        protected int _sarjorKapasitesi, _kalanFisek, _atisKatsayisi;
        public int AtisKatsayisi
        {
            get => this._atisKatsayisi;
        }
        public int SarjorKapasitesi
        {
            get => this._sarjorKapasitesi;
        }

        public int KalanFisek
        {
            get => this._kalanFisek;
        }

        public abstract int YenidenDoldur();

        public abstract int AtesEt();

    }
}
