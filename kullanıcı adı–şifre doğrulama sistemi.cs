using System;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deneme_sayisi = 2; // Döngü dışında tanımlanmalı

            while (true)
            {
                Console.WriteLine("Kullanici adinizi giriniz: ");
                string kullaniciadi = Console.ReadLine();

                Console.WriteLine("Sifrenizi giriniz: ");
                string sifre = Console.ReadLine();

                if (kullaniciadi == "rodi" && sifre == "00000")
                {
                    Console.WriteLine("Giris yapildi");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanici adi veya sifre hatali");

                    deneme_sayisi -= 1;

                    if (deneme_sayisi == 0)
                    {
                        Console.WriteLine("Üst üste hatali deneme yapildi, lutfen daha sonra tekrar deneyiniz.");
                        break;
                    }
                }
            }
        }
    }
}
