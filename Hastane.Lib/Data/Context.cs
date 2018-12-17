using Hastane.Lib.Models;
using System.Collections.Generic;

namespace Hastane.Lib.Data
{
    public static class Context
    {
        public static List<Hasta> Hastalar { get; set; }=new List<Hasta>();
        public static List<Doktor> Doktorlar { get; set; }=new List<Doktor>();
        public static List<Hemsire> Hemsireler { get; set; }=new List<Hemsire>();
        public  static  List<Randevu> Randevular { get; set; } = new List<Randevu>();
    }
}
