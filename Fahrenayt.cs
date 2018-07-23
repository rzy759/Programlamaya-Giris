using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("celcius değerini giriniz: ");
            int a = int.Parse(Console.ReadLine());

            double fahr=(a*1.8)+32;

            Console.WriteLine("Fahrenayt: "+fahr+ "°F");
            Console.ReadLine();
        }
    }
}
