using System;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do//1 oyunluk dongu
            {
                Random rnd = new Random();
                int giris = 0, zar1 = 0, zar2 = 0, sayac = 0;
                bool dogruMu = false;
                Console.WriteLine("1-6 arasinda bir giris yapiniz");
                try
                {
                    giris = int.Parse(Console.ReadLine());
                    if (giris < 1 || giris > 6)
                        throw new ArgumentException("Lutfen 1-6 arasinda giris yapiniz");
                    dogruMu = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                while (dogruMu) // girilen sayi cifti bulunana kadar zar atilacak
                {
                    sayac++;
                    zar1 = rnd.Next(1, 7);
                    zar2 = rnd.Next(1, 7);
                    Console.WriteLine(sayac + ". deneme: " + zar1 + " - " + zar2);
                    if (zar1 == zar2 && zar1 == giris)
                        break;
                }
                if (dogruMu) Console.WriteLine(sayac + ". denemede bulundu");
                Console.WriteLine("Tekrar oynamak icin e yaziniz");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
