using System;

namespace KararYapilariVeDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operatorler 
            //Matematiksel operatorler

            int sayi1 = 6, sayi2 = 10;
            double sayi3 = 0;
            //=
            // + - * / 
            sayi3 = sayi2 / (double)sayi1;
            Console.WriteLine(sayi3);

            //sayi1 = sayi1 + sayi2;
            sayi1 += sayi2;
            sayi1++;
            Console.WriteLine(sayi1++);
            Console.WriteLine(++sayi1);

            sayi1 = 5;
            sayi2 = 10;

            sayi1 = sayi1 + sayi2;
            sayi2 = sayi1 - sayi2;
            sayi1 = sayi1 - sayi2;

            //% mod(kalanli bolme)

            sayi1 = sayi2 % 3;

            //+ 

            string sonuc = "Toplam: " + sayi3;
            Console.WriteLine(sonuc);
            Console.WriteLine("Sonuc: " + (3 + 6 + 9));

            //Karsilastirma operatorleri
            // < > <= >= == != !  ---- true/false 
            bool dogruMu = sayi1 > sayi2;

            dogruMu = sayi1 == sayi2;
            dogruMu = !dogruMu;

            //mantiksal operatorler 
            // & | && ||

            dogruMu = sayi1 < sayi2 || sayi2 % 2 == 0;
            dogruMu = (sayi1 < 0 || sayi1 > 100) && sayi1 % 2 == 0;

            // if eger anlaminda. eger icine yazilan ifade true ise if blogu degilse else blogu calisir. 
            dogruMu = sayi1 % 2 == 0;
            if (dogruMu)
            {
                Console.WriteLine("Sayı1 çifttir");
            }
            else
            {
                Console.WriteLine("Sayı1 tektir");
            }

            Console.WriteLine("Sayi1 " + (dogruMu ? "çifttir" : "tektir")); //ternary if
            Console.WriteLine(sayi1 % 2 == 0 ? "Sayi1 çifttir" : "Sayi1 tektir");

            double notOrtalama = 55;
            if (notOrtalama < 50)
                Console.WriteLine("Kaldiniz");
            else if (notOrtalama < 90)
            {
                Console.WriteLine("Geçtiniz");
            }
            else
                Console.WriteLine("Üstün Başarı");


            DayOfWeek bugun = DateTime.Now.DayOfWeek;
            if (bugun == DayOfWeek.Monday)
            {
                Console.WriteLine("Bugün Pazartesi");
            }

            switch (bugun)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Pazar");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Pazartesi");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Salı");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Çarşamba");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Perşembe");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Cuma");
                    break;
                default:
                    Console.WriteLine("Cumartesi");
                    break;
            }

            //donguler
            while (true)
            {
                Console.WriteLine(DateTime.Now);
                if (DateTime.Now.Second < 30 || DateTime.Now.Second > 50)
                    break;
            }

            do
            {
                Console.WriteLine(DateTime.Now);
                if (DateTime.Now.Second < 30 || DateTime.Now.Second > 50)
                    break;
            } while (true);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //program calistiginda ekrana bir doktorun muayene saatlerini yazan program. 15er dakika ara ile yazacak. mesai 09.00 ile 16.30 arası olacak 12.00 13.00 ogle tatili
            /*
             * 09.00
             * 09.15
             * 09.30
             * 09.45
             * 10.00
             *
             * 11.45
             * 13.00
             *
             * 16.30
             */

            for (int saat = 9; saat <= 16; saat++)
            {
                if (saat == 12)
                {
                    Console.WriteLine("*** Öğle Tatili ***");
                    continue;
                }
                for (int dakika = 0; dakika <= 45; dakika += 15)
                {
                    if (saat == 16 && dakika == 45) break;
                    Console.WriteLine(saat.ToString("00") + "." + dakika.ToString("00"));
                }
            }
            DateTime baslangic = new DateTime(2000, 1, 1, 9, 0, 0);
            do
            {
                if (baslangic.Hour == 12)
                {
                    Console.WriteLine("*** Öğle Tatili ***");
                    baslangic = baslangic.AddHours(1);
                    continue;
                }
                Console.WriteLine(baslangic.ToShortTimeString());
                baslangic = baslangic.AddMinutes(15);
            } while (!(baslangic.Hour == 16 && baslangic.Minute == 45));

            baslangic = new DateTime(2000, 1, 1, 9, 0, 0);
            while (!(baslangic.Hour == 16 && baslangic.Minute == 45))
            {
                if (baslangic.Hour == 12)
                {
                    Console.WriteLine("*** Öğle Tatili ***");
                    baslangic = baslangic.AddHours(1);
                    continue;
                }
                Console.WriteLine(baslangic.ToShortTimeString());
                baslangic = baslangic.AddMinutes(15);
            } 
            Console.WriteLine("test");
        }
    }
}