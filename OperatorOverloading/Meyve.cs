using System.Drawing;

namespace OperatorOverloading
{
    public abstract class Meyve
    {
        public int Agirlik { get; set; }
        public Color Renk { get; set; }
        public decimal Fiyat { get; set; }

        public static int operator +(Meyve a, Meyve b)
        {
            return a.Agirlik + b.Agirlik;
        }
        public static int operator -(Meyve a, Meyve b)
        {
            return a.Agirlik - b.Agirlik;
        }

        public static decimal operator *(Meyve a, Meyve b)
        {
            return a.Fiyat * b.Fiyat;
        }
        public static decimal operator /(Meyve a, Meyve b)
        {
            return a.Fiyat / b.Fiyat;
        }

        public static bool operator ==(Meyve a, Meyve b)
        {
            return a.Fiyat == b.Fiyat && a.Agirlik == b.Agirlik;
        }
        public static bool operator !=(Meyve a, Meyve b)
        {
            return a.Fiyat != b.Fiyat && a.Agirlik != b.Agirlik;
        }
    }
}
