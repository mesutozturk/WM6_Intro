using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNesnesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random 

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(-10,0));
            }

            //disaridan bir 1-6 arasinda girilen sayi uzerinden bir zar oyunu oynanacak
            /* girilen sayi icin cift zar kac denemede gelecek bunu bulan program
             * 5
             * 16.denemede 5-5 bulundu
             */

            /*
             * program 0-100 arasinda bir sayi aklinda tutacak ve kullanicidan bunu bilmesini isteyecek
             * her tahminde kullaniciya yukari asagi seklinde ipucu verecek bildiginde ise kac denemede bildigini yazacak
             */

        }
    }
}
