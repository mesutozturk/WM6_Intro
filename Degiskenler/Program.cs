using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //PascalCase
            //camelCase

            //İsimlendirme kurallari
            //isimler rakam ile baslayamaz ama rakam bulundurabilirler
            //isimler ozel karakter barindiramaz. _ haric
            //tanimli komutlarin ismi kullanilamaz.
            //ayni namespace uzerinde daha once tanimlanmis bir degisken ismi bir daha kullanilamaz.

            // TAD - Tip Ad = Deger;

            //Tamsayi tipler


            byte degiskenByte = 255; //isaretsiz 8bit
            sbyte degiskenSbyte = 127; //isaretli 8bit
            short degiskenShort = 3200; //isaretli 16bit
            ushort degiskenUshort = 65535; //isaretsiz 16bit
            int degiskenInt = int.MaxValue; //isaretli 32bit
            uint degiskenUint = uint.MaxValue; //isaretsiz 32bit
            long degiskenLong = 5000;
            ulong degiskenUlong = 232348324234; //64bit


            degiskenInt = degiskenShort;
            degiskenShort = Convert.ToInt16(degiskenLong);
            Console.WriteLine(degiskenShort);

            //Ondalikli tipler

            float degiskenFloat = 3.14f;
            double degiskenDouble = 3.14d;
            decimal degiskenDecimal = 3.14m;

            degiskenInt = 0b1011; //binary
            degiskenInt = 0x2e; //hex
            degiskenDouble = 3.01e10;

            Console.WriteLine(degiskenInt * 3);

            //metinsel ifadeler
            char degiskenChar = '6';
            string degiskenString = "Hello World";

            //mantiksal ifade
            bool dogruMu = false;//true;

            DateTime suan = DateTime.Now;
            suan = new DateTime(2018, 11, 26);

            object degiskenObject = suan;
            degiskenObject = degiskenInt;
            degiskenObject = degiskenDouble;

            var a = 1;
            var b = 2d;
            var c = 3m;
            var d = "merhaba";
        }
    }
}
