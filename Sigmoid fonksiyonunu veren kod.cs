using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz: ");
            double u = double.Parse(Console.ReadLine());            
            
            double a = Math.Exp(-u);
            double sigmoid = 1 / (1 + a);

            Console.WriteLine("sigmoid= "+sigmoid);
            Console.ReadLine();
        }
    }
}
