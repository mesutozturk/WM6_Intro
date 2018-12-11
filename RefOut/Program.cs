using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            a = b;
            b = 20;
            Console.WriteLine(a);

            int[] dizi1 = new int[5];
            dizi1[0] = 5;
            int[] dizi2 = new int[3];
            dizi2[0] = 10;

            dizi1 = dizi2;
            dizi2[0] = 20;

            Console.WriteLine(dizi1[0]);

            int sayi = 5;
            RefTest(ref sayi);
            Console.WriteLine(sayi);

            Array.Resize(ref dizi1, 5);

            int girilen = 0;

            if (SayiMi(out girilen))
            {
                Console.WriteLine(girilen * girilen);
            }
            if(int.TryParse(Console.ReadLine(), out girilen))
            {
                Console.WriteLine(girilen * girilen);
            }

        }

        static bool SayiMi(out int sayi)
        {
            try
            {
                sayi = int.Parse(Console.ReadLine());
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            sayi = 0;
            return false;
        }
        static void RefTest(ref int a)
        {
            a *= a;
        }
    }
}
