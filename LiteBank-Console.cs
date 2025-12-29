using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 500;
            Console.WriteLine("====== atm ye hos geldiniz ===============");
            Console.WriteLine("para cekemk icin 1 e basiniz ");
            Console.WriteLine("para yatirmak icin 2 ye basiniz");
            Console.WriteLine("bakiye goruntulemek icin 3 e basiniz");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("cekmek isetginiz tuttari giriniz: ");
                    int cekilecek_miktar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("kalan bakiye : "+(bakiye- cekilecek_miktar));
                    break;

                    case "2":
                    Console.WriteLine("yatirmak istediginiz mikatri giriniz: ");
                    int yatirilack_miktar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("guncel bakiye"+(bakiye+ yatirilack_miktar));
                    break;
                    case "3":
                    Console.WriteLine( "bakiyeniz :"+bakiye);
                    break;
            }

        }
    }
}

