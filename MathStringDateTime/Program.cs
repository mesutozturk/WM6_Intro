using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStringDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sistem uzerinde on tanimli methodlar vardir. en cok kullanilanlari

            //Matematik fonksiyonlari

            Console.WriteLine(Math.Sin(Math.PI / 2));
            Console.WriteLine(Math.Round(7.456, 2));
            Console.WriteLine(Math.Pow(3, 5));
            Console.WriteLine(Math.Sqrt(Math.Pow(3, 2) + Math.Pow(4, 2)));

            //Tarih fonksiyonlar
            DateTime tarih = DateTime.Now;
            DateTime sonraki = tarih.AddHours(3);
            sonraki = tarih.AddDays(3);
            sonraki = tarih.AddMinutes(new Random().Next());
            Console.WriteLine(tarih.AddDays(95));

            TimeSpan fark = sonraki - tarih;

            Console.WriteLine($"Toplam {fark.TotalMinutes} dakika");

            //Metinsel fonksiyonlar

            string a = "5";
            string b = "10";
            a = b;// string ifadeler icin immutable ifadesi kullanilir
            b = "20";
            Console.WriteLine(a);
            //kelime = null;

            string kelime = "Wissen Akademie";

            bool varMi = kelime.Contains("Akademi");
            //kelime.IndexOf('i');
            //kelime.LastIndexOf('i');
            Console.WriteLine(kelime.Remove(6));

            string baslik = "   Çin hükümeti otomotiv devlerinden anlık veri topluyor   ";

            baslik = baslik.ToLower();
            baslik = baslik.Trim();
            baslik = baslik.Replace(" ", "-");
            baslik = baslik.Replace("ç", "c");
            baslik = baslik.Replace("ü", "u");
            baslik = baslik.Replace("ı", "i");
            baslik = baslik.Replace("ı", "i");
            Console.WriteLine(baslik);

            string mailListesi = "asd@asc.com;asd@asc.com;sdf@asd.com;";
            string[] mailler = mailListesi.Split(';');

            Console.WriteLine(kelime.Substring(0,6));
            Console.WriteLine(kelime);
        }
    }
}
