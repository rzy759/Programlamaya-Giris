using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir metin giriniz: ");
            string a = Console.ReadLine();
            string[] D = a.Split(' ');
            int sayac = 0;
            foreach (var i in D)
            {
                sayac++;
            }
            Console.WriteLine(sayac);
            Console.ReadLine();
        }
    }
}
