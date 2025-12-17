using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 500;
            Console.WriteLine("-------hos geldiniz-------");
            Console.WriteLine("yapmak istediginiz islemi seciniz");
            Console.WriteLine("1 bakiye sorgulama  : ");
            Console.WriteLine("2 bakiye cekme : ");
            Console.WriteLine("3 bakiye yukleme : ");
            Console.WriteLine("4 cikis yap ");

            string secim = Console.ReadLine();

            if(secim =="1")
            {
                Console.WriteLine("bakiyeniz  : "+bakiye);
            }
            if (secim =="2")

            {
                Console.WriteLine("cekmek istediginiz bakiyeyi giriniz ");
                int cekmek_istedig_inbakiye= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kalan bakiye : "+(bakiye-cekmek_istedig_inbakiye));
            }
            if (secim =="3")

            {
                Console.WriteLine("yuklemek istediginiz bakiyeyi giriniz ");
                int yuklenecek_bakiye= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("guncel bakiye  : "+(bakiye+yuklenecek_bakiye));
            }
            if (secim =="4")
            {
                Console.WriteLine("cikis yapmak icin q basiniz ");
                string cikis_islemi= Console.ReadLine();
                Console.WriteLine("cikis yapildi bizi tercih etiginiz icin tessekur ederiz ");

            }

        }
    }
}
