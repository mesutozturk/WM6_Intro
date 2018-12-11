using System;

namespace Methodlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir kenari 2 olan karenin alani: " + AlanHesapla(2, 3.14));
            Console.WriteLine();

            float r = 5;
            Console.WriteLine("Cemberin alani: "+ AlanHesapla(r,3));
        }
        /// <summary>
        /// Kare alan hesabi
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int AlanHesapla(int a)
        {
            return a * a;
        }
        /// <summary>
        /// dikdortgen alan hesabi
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int AlanHesapla(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// dikdortgen alan hesabi
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double AlanHesapla(double a, double b)
        {
            return a * b;
        }
        static double AlanHesapla(int a, double b)
        {
            return a * b;
        }

        static double AlanHesapla(float r, double pi = Math.PI)
        {
            double rr = Convert.ToDouble(r * r);
            return rr * pi;
        }

        //static float AlanHesapla(float a)
        //{
        //    return a * a;
        //}
    }
}
