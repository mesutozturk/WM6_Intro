namespace Hastane.Lib.Models
{
    public class Randevu
    {
        public Hasta Hasta { get; set; }
        public Doktor Doktor { get; set; }
        public Servis Servis { get; set; }
        public int Saat { get; set; }
    }
}
