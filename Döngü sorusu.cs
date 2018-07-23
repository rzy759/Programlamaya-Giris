using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iki farklı sayı giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int toplam = 0;
            int sayac = 0;
            Console.WriteLine("tek sayılar: ");
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;                
            }
            for (int i = a; i < b; i++)
                {
                    if (i%2!=0)
                    {
                        Console.WriteLine(i);
                        toplam += i;
                        sayac++;
                    }
                    else                
                        sayac = 1;
                
                }

            int ort = toplam / sayac;
            Console.WriteLine("ortalama: "+ort);
            Console.ReadLine();
        }
    }
}
