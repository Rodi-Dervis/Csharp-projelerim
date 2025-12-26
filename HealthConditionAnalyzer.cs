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
            Console.WriteLine("lutfen kiolonuzu giriniz : ");
            int kilo =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lutfen boyunu cm olarak gir : ");
            double boy = Convert.ToDouble(Console.ReadLine());

            if(kilo>100 && boy<160)
            {
                Console.WriteLine("saglik konturulune gitmelisin");
            }
            else
            {
                Console.WriteLine("formunuz yerinde ");
            }
        }
    }
}
