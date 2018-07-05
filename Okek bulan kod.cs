using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static int Ekok(int a,int b)
        {
            return (a * b) / Ebob(a, b);


        }
        static int Ebob(int a,int b)
        {
            if (b == 0)
                return a;
            else
                return Ebob(b,a % b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayı: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayı: ");
            int b = int.Parse(Console.ReadLine());
            int sonuc=Ekok(a, b);
            Console.WriteLine("Okek: "+ sonuc);
            Console.ReadLine();
        }
    }
}
