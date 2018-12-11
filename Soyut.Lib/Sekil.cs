using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut.Lib
{
    public abstract class Sekil 
        // abstract neslenerin ornegi(instance) alinamaz.
        //icerisindeki abstract olmayan nesneler aynen aktarilir.
    {
        public double X { get; set; }
        public abstract double CevreHesapla();

        public abstract double AlanHesapla();

        public abstract double KosegenHesapla();
    }
}
