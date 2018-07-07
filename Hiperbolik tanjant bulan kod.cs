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
            
            double a=Math.Exp(u);
            double b = Math.Exp(-u);

            double tanh = (a - b) / (a + b);

            Console.WriteLine("hiperbolik tanjant: "+tanh);
            Console.ReadLine();
        }
    }
}
