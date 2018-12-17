namespace Hastane.Lib.Models
{
    public class Personel : Kisi,IMaasAlabilir
    {
        public PersonelBrans Brans { get; set; }
        public decimal Maas { get; set; }
    }

    public enum PersonelBrans
    {
        Temizlik,
        Muhasebe,
        IdariIsler
    }
}
