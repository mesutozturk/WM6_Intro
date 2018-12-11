using System;

namespace InputIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1 Disaridan bir veri girisi oldugunda (Kullanici girisi)
             * 2 Dosya okuma islemi yapildiginda
             * 3 veritabani islemlerinde
             * 4 webisteklerde
             * TRY-CACTH KULLANMAK ZORUNDASINIZ!
             * ERROR HANDLING - HATA YONETIMI
             */
            Console.Write("Merhaba isminiz nedir? : ");
            string ad = Console.ReadLine();
            Console.WriteLine("Hosgeldin: " + ad);
            Console.Write("Yasinizi giriniz: ");
            //byte yas = Convert.ToByte(Console.ReadLine());
            try
            {
                byte yas = Convert.ToByte(Console.ReadLine());
                if (yas < 18)
                {
                    Console.WriteLine("Güle güle");
                }
                else
                {
                    Console.WriteLine("Sistemi kullanmaya devam edebilirsiniz");
                }
            }
            catch
            {
                Console.WriteLine("Yasiniz sayi olmali");
            }

            Console.Write("0-100 arasinda bir sayi giriniz: ");
            try
            {
                int girilen = int.Parse(Console.ReadLine());
                if (girilen < 0 || girilen > 100)
                {
                    throw new Exception("0-100 arasi bir sayi girmeliydin");
                }

                if (girilen % 2 == 1)
                    throw new ArgumentException();

                double sonuc = girilen / girilen;
                Console.WriteLine("Girilen sayi: " + girilen);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("girdigin sayi cift olmaliydi");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("sifir girmesen iyi olacak");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("ben her zaman calisirim :)");
            }
        }
    }
}