using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemeGirisYapmiMi = true;
            if (sistemeGirisYapmiMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.ReadKey();

        }
    }
}
 