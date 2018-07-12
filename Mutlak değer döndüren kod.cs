using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            int topla = 0;
            int[] sayılar = new int[] { 7, 3, -2, 5, 0, 20 };

            for (int i = 0; i < 6; i++)
            {
             sayılar[i]= Math.Abs(sayılar[i]);
            }

            for (int i = 0; i < 6; i=i+2)
            {
               topla= topla+sayılar[i] + sayılar[i + 1];
            }

            Console.WriteLine(topla);
            Console.ReadLine();
        
        }
    }
}
