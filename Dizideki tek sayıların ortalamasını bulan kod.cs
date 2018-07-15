using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi kaç elemanlı: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("sayıları giriniz: ");
            int[] sayılar = new int[a];
            int toplam = 0;
            int sayaç=0;
            for (int i = 0; i < a; i++)
            {
                sayılar[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a; i++)
            {
                if(sayılar[i] % 2 != 0)
                {
                    toplam += sayılar[i];
                    sayaç++;
                }
            }
            double ort = toplam / (double)sayaç;
            Console.WriteLine("ortalaması: "+ort);
            Console.ReadLine();        

        
        }
    }
}
