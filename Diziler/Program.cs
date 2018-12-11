using System;
using System.Collections;
using System.Collections.Generic;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array ayni tip verilerin tek bir degiskende saklanmasi icin kullanilir.

            int degisken = 5;

            int[] sayilar = new int[5];
            //index 0 dan baslar
            sayilar[0] = 5;
            sayilar[1] = 55;
            sayilar[2] = 45;
            sayilar[3] = 15;
            sayilar[4] = 52;
            for (int i = 0; i < sayilar.Length; i++)
            {
                int gelen = sayilar[i];
                Console.WriteLine(gelen);
            }

            foreach (int gelen in sayilar)
            {
                Console.WriteLine(gelen);
            }

            string[] kisiler = { "Kamil", "Ahmet", "Falan", "Filan" };

            double[,] matris = new double[2, 2];
            matris[0, 0] = 3.14;
            matris[0, 1] = 5;
            matris[1, 0] = 2;
            matris[1, 1] = 1;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }

            string isim = "Kamil";
            char aa = isim[0];

            Random rnd = new Random();

            matris = new double[10, 4];
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.NextDouble();
                }
            }

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " - ");
                }
                Console.WriteLine();
            }

            ArrayList liste = new ArrayList();
            liste.Add(5);
            liste.Add("Kamil");
            liste.Add(true);
            liste.Add(3.14);

            //int a = liste[0];

            List<double> listem = new List<double>()
            {
                3,4,2,1,2
            };
            listem.Add(5);
            listem.Add(6);
            listem.Add(9);
            listem.Add(14);

            listem.Remove(0);

            
        }
    }
}
