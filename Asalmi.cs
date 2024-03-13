using System;

namespace AsalSayiKontrolu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.Write("Sayıyı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }

            if (sayac == 0)
            {
                Console.WriteLine("Girilen sayı ASAL bir sayıdır.");
            }
            else
            {
                Console.WriteLine("Girilen sayı ASAL bir sayı DEĞİLDİR.");
            }
        }
    }
}
