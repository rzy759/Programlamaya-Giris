using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi kaç elemanlı: ");
            int a = int.Parse(Console.ReadLine());

            int b = 0;
            Console.WriteLine("sayıları giriniz: ");
            List<int> sayılar = new List<int>();
           
            for (int i = 0; i < a; i++)
            {
                b=int.Parse(Console.ReadLine());
                if (b % 2 == 0)
                    sayılar.Add(b);
            }

            int ort = (sayılar.Max() + sayılar.Min()) / 2;
            Console.WriteLine("çift sayıların en büyüğü ile en küçüğün ortalaması: "+ort);          
            Console.ReadLine();
        }
    }
}
