using System;

namespace AdamAsmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Onceden tanimli kelimelerin bulundugu bir adam asmaca oyunu programlayiniz.
             * 6 hak uzerinden oynayacak
             * puanlandirma  sorudakiharfsayisi*100=maksimum puan
             * her yanlis cevapta puan %15i azalacak
             * 2 cesit kullanici girisi olacak
             * 1.si harf harf tahmin
             * 2.si kelime tahmini
             *
             * 2 cesit oyun bitirme olacak
             * 1.si harfleri tek tek bilerek
             * 2.si kelime tahmini yaparak
             * _ _ _ _ _ _ _ _
             * i
             * i _ _ _ _ _ _ _
             * l
             * i _ _ _ _ _ _ l
             * istanbul
             * tebrikler bildiniz tekrar oynamak ister misiniz
             *              
             */

            do
            {
                int hak = 6, bilinen = 0;
                string[] sorular = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayrabolu" };
                Random rnd = new Random();
                string seciliSoru = sorular[rnd.Next(sorular.Length)];
                double puan = seciliSoru.Length * 100;
                char[] ekran = new char[seciliSoru.Length];
                for (int i = 0; i < seciliSoru.Length; i++)
                    ekran[i] = '_';
                do
                {
                    foreach (char ee in ekran)
                        Console.Write(ee + " ");
                    //string a = string.Format("\n {0} harf. puan: {1} . kalan hak: {2}", seciliSoru.Length, puan, hak);
                    string ozet = $"\n--> {seciliSoru.Length} harf. puan: {puan} . kalan hak: {hak}";
                    Console.WriteLine(ozet);
                    Console.WriteLine("Tahmininizi giriniz");
                    string tahmin = Console.ReadLine().ToLower();

                    if (tahmin.Length == 1)
                    {
                        bool bildiMi = false, girildiMi = false;
                        for (int k = 0; k < ekran.Length; k++)
                        {
                            if (ekran[k] == tahmin[0])
                            {
                                girildiMi = true;
                                break;
                            }
                        }
                        if (!girildiMi)
                            for (int i = 0; i < seciliSoru.Length; i++)
                            {
                                if (seciliSoru[i] == tahmin[0])
                                {
                                    bildiMi = true;
                                    ekran[i] = tahmin[0];
                                    bilinen++;
                                }
                            }

                        if (!bildiMi)
                        {
                            hak--;
                            puan *= 0.85;
                        }
                    }
                    else
                    {
                        if (tahmin == seciliSoru)
                            break;

                        hak--;
                        puan *= 0.85;
                    }


                } while (hak > 0 && bilinen != seciliSoru.Length);

                Console.WriteLine(hak > 0 ? "Tebriker bildiniz" : "Bilemediniz");

                Console.WriteLine("Tekrar oynamak icin e ye basiniz");
                if (Console.ReadLine().ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
