using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi kaç elemanlı: ");
            int a = int.Parse(Console.ReadLine());
            double çarpım = 1;
            int[] sayılar = new int[a];
            
            Console.WriteLine("sayıları giriniz: ");
            for (int i = 0; i < a; i++)
            {
                sayılar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                çarpım = çarpım * sayılar[i];                   
            }
            double üs = 1 / (double)a;
            
            Console.WriteLine("geometrik ortalaması: "+Math.Pow(çarpım, üs));
            Console.ReadLine();
        }
    }
}
