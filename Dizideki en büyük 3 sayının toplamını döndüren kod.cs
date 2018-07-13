using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi kaç elemanlı: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("sayıları giriniz: ");
            int[] sayılar = new int[a];

            for (int i = 0; i < a; i++)
            {
                sayılar[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sayılar);
            Array.Reverse(sayılar);

            Console.WriteLine("\nbüyükten küçüğe sıralanmış hali:");
            foreach (int i in sayılar)
            {
                Console.WriteLine(i);
            }

            int toplam = sayılar[0] + sayılar[1] + sayılar[2];
            Console.WriteLine("\ntoplam: "+toplam);
            Console.ReadLine();
        }
    }
}
