using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Ogrenci : Kisi
    {
        public string Sinif { get; set; }
        public byte Not { get; set; }
        public string OkulNo { get; set; }
    }
}
