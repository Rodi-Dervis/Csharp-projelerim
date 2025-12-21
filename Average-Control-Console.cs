using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayi giriniz...");

            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                toplam += i;
            }
            double ortalama = toplam / sayi;

            if (ortalama > 4)
            {
                Console.WriteLine("ortalamaniz 50 den buyuktur...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ortalamaniz 50 den kucuktur...");
                Console.ReadLine();
            }

        }
    }
}
