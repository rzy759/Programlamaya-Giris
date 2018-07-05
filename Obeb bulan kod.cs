using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static int Ebob(int a,int b)
        {
            if (b == 0)
                return a;
            else
                return Ebob(b,a % b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("sayi1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("sayi2: ");
            int b = int.Parse(Console.ReadLine());
            int sonuc=Ebob(a, b);
            Console.WriteLine("Obeb: "+ sonuc);
            Console.ReadLine();
        }
    }
}
