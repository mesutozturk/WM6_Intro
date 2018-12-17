using Hastane.Lib.Models;
using System.Collections.Generic;

namespace Hastane.Lib.Data
{
    public class Context
    {
        public List<Hasta> Hastalar { get; set; } = new List<Hasta>();
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public List<Randevu> Randevular { get; set; } = new List<Randevu>();
    }
}
