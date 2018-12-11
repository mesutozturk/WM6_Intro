namespace XmlJsonServislerineBaglanma
{
    public class Doviz
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public int Birim { get; set; }
        public decimal Alis { get; set; }
        public decimal Satis { get; set; }

        public string Gorunum
        {
            get => $"{Birim} {Ad}";
        }

        public override string ToString()
        {
            return $"{Birim} {Ad}";
        }
    }
}
