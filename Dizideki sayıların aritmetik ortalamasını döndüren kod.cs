using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi kaç elemanlı: ");
            int a = int.Parse(Console.ReadLine());
            double[] sayılar = new double[a];
            Console.WriteLine("sayıları giriniz: ");
            for (int i = 0; i < a; i++)
            {
                sayılar[i] = double.Parse(Console.ReadLine());
            }

            double ort = sayılar.Sum() / a;
            Console.WriteLine("ortalaması: "+ort);
            Console.ReadLine();           
        }
    }
}
