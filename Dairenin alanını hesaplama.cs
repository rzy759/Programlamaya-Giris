using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dairenin yarıçapını giriniz: ");
            int r = int.Parse(Console.ReadLine());

            double alan = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("dairenin alanı: "+alan);
            Console.ReadLine();
        }
    }
}
