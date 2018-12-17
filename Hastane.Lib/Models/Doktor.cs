using System.Collections.Generic;

namespace Hastane.Lib.Models
{
    public class Doktor : Kisi, IMaasAlabilir
    {
        public decimal Maas { get; set; }
        public Servis Servis { get; set; }
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
    }
}
