using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Selamlama();
            Selamlama();
            Selamlama();
            Selamlama();
            int toplam = Topla(3, 6);
            Console.WriteLine("toplam: " + toplam);
            Console.WriteLine("Denklem: " + Disc(1, 4, 9));
            string[] kisiler = { "Kamil", "Ayşe", "Fatma", "Kerem" };
            Selamlama(kisiler);
            toplam = Topla(2, 2, 1, 2, 3, 4, 2, 1, 2, 3, 43, 4, 2, 2, 9, 7, 6, 7, 8);
            Console.WriteLine("toplam: " + toplam);
        }
        /// <summary>
        /// Program her calistiginda kulliciya selam vermeye yarar.
        /// </summary>
        static void Selamlama()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                return;
            Console.WriteLine("Merhaba Method");
        }
        /// <summary>
        /// verilen 2 tamsayiyi toplayan metod
        /// </summary>
        /// <param name="sayi1">toplama yapilacak birinci sayi</param>
        /// <param name="sayi2">toplama yapilacak ikinci sayi</param>
        /// <returns>iki sayinin toplam degeri</returns>
        static int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static int Topla(int carpim, params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 1; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam * carpim;
        }
        static string Disc(int a, int b, int c)
        {
            int sonuc = b * b - 4 * a * c;
            if (sonuc < 0)
                return "Denklemin reel koku yoktur";
            else if (sonuc == 0)
                return "Denklemin 1 reel koku vardir";

            return "Denklemin 2 reel koku vardir";
        }

        static void Selamlama(string[] kisiler)
        {
            foreach (string kisi in kisiler)
            {
                Console.WriteLine("Hosgeldin " + kisi);
            }
        }
    }
}
