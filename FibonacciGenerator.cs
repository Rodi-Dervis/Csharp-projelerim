using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lutfen bir sayi giriniz ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int  a = 0, b = 1, c = 10;

            for (int i = 0; i < sayi; i++)
            {
                Console.Write(a + " ");
                int g = a;
                a = b;
                b = g + b;
            }
        }
    }
}
