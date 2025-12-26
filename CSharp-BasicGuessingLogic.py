using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            Console.WriteLine("sayi bir giriniz");
            string not5=Console.ReadLine();
            int rakam = Convert.ToInt32(not5);
            if (rakam > sayi1)
            {
                Console.WriteLine("daha kucuk hbir sayi giriniz  : ");

            }

            else if (rakam < sayi1)
            {
                Console.WriteLine("daha buyuk sayi giriniz  : ");
            }
            else
            {
                Console.WriteLine("tebrikler dogru sayi girdiniz  : ");
            }
        }
    }
}
