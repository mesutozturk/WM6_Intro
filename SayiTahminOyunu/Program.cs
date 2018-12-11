using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(1, 100), tahmin = 0, sayac = 0;
                Console.WriteLine("1-100 arasinda bir sayi tahmin edin");
                do //bilene kadar donecek dongu
                {
                    try
                    {
                        sayac++;
                        tahmin = int.Parse(Console.ReadLine());
                        if (tahmin < 1 || tahmin > 99)
                            throw new ArgumentException("Lutfen 1-100 arasinda giris yapiniz");
                        if (rastgele < tahmin)
                            Console.WriteLine("Asagi");
                        else if (rastgele > tahmin)
                            Console.WriteLine("Yukari");
                        else
                        {
                            Console.WriteLine("Tebrikler "+sayac+". denemede bildiniz");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                } while (true);


                Console.WriteLine("Tekrar oynamak icin e yaziniz");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
