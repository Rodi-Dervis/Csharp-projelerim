using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boy_endeks_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lutfen kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lutfen boyuuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if(bke<18)
            {
                Console.WriteLine("zayifsiniz");
                Console.ReadLine();
            }
            else if(bke>=18 && bke<25)
            {
                Console.WriteLine("normal");
                Console.ReadLine();

            }
            else if (bke>=25 && bke<30)
            {
                Console.WriteLine("kilolusunuz");
                Console.ReadLine();
            }
            else if (bke>=30)
            {
                Console.WriteLine("obezsiniz");
                Console.ReadLine();
            }
        }
    }
}
