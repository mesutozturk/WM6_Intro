using System;

namespace Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //disaridan girilen sayi kadar * karakteri kullanilarak kare sekli cizme
            /*
             * 5
             * *****
             * *****
             * *****
             * *****
             * *****
             * a) eger yanlis bir giris olduysa program tekrar bir sayi girmesi icin istekte bulunmali
             * b) cizim islemi bittikten sonra tekrar calistirmak istiyormusunuz? e/h diye bir soru sormali cevap e ise tekrar bastan baslamali
             * c) sekli ici bos cizsin
             *  4
             *  ****
             *  *  *
             *  *  *
             *  ****
             * d) girilen sayi yuksekliginde eskenar ucgen cizsin
             *  3 icin
             *    *
             *   ***
             *  *****
             * 4 icin
             *     *
             *    ***
             *   *****
             *  *******
             * f) giriste bana 3 farkli secenek sunsun. 1) kare 2) iciboskare 3)ucgen
             * bu secenekleri sectigimde ona gore cizim yapsin
             */

            do // bir oyunluk dongu
            {
                Console.Clear();
                string secim = string.Empty;
                do
                {
                    Console.WriteLine("***SECENEKLER***");
                    Console.WriteLine("1) KARE CIZIMI");
                    Console.WriteLine("2) ICI BOS KARE CIZIMI\n3) UCGEN CIZIMI");
                    secim = Console.ReadLine();
                    if (secim == "1" || secim == "2" || secim == "3")
                        break;
                    Console.WriteLine("Lutfen 1-2-3 seceneklerinden birini seciniz");
                } while (true);

                int x = 0;
                do
                {
                    Console.WriteLine("Uzunlugu giriniz");
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                        if (x <= 0)
                            throw new Exception("Lutfen pozitif bir sayi giriniz");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);

                switch (secim)
                {
                    case "1":
                        //kare cizimi
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                Console.Write("x");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                if (i == 0 || i == x - 1 || j == 0 || j == x - 1)
                                    Console.Write("x");
                                else
                                    Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        for (int i = 1; i <= x; i++)
                        {
                            for (int j = 1; j <= i + x - 1; j++)
                            {
                                Console.Write(x - i >= j ? " " : "x");
                            }
                            Console.WriteLine();
                        }
                        break;
                }
                Console.WriteLine("Tekrar etmek icin e tusuna basiniz");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);

            //diziler arrays
            //methodlar 
            //windows forms application
            //OOP
        }
    }
}
