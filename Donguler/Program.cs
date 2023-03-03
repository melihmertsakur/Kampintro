using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);


            }
            Console.WriteLine("---------------------");
            Console.WriteLine("for bitti");
            Console.WriteLine("---------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Sayfa Sonu");
            Console.ReadKey();
        }
    }
}










