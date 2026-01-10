using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
   

            Random milipiyango = new Random();
           
            long[] biletler = { 2123142345, 234561234, 3456712345, 45678, 56789 };
          string [] sahipler = { "ali", "veli", "ayse", "fatma", "ahmet" };

            int a;
            int b;
            a =milipiyango.Next(0,5);
            Console.WriteLine("kazanan: " + sahipler[a]);
            Console.WriteLine("bilet: " + biletler[a]);
            Console.WriteLine("sira: " + a);
            if (biletler[a] == 2123142345) 
            {
                Console.WriteLine("tebrikler kazandiniz");
               
            }
            else
            {
                Console.WriteLine("uzgunuz biletiniz cikmadi");
            }
        }
    }
}
