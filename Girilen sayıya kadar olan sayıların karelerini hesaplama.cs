using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 den büyük bir sayı giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int b = 0;

            for (int i = 1; i <= a; i++)
            {
                b +=  (i * i);               

            }
            Console.WriteLine("Kareler toplamı ="+b);
            Console.ReadLine();
            
        }
    }
}
