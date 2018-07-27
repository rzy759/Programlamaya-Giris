using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ismi girin: ");
            string isim = Console.ReadLine();
            string[] ayrı=isim.Split(' ');
            foreach (var item in ayrı)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ayrı)
            {
                Console.Write(item[0]);
            }

            Console.ReadLine();
        }
    }
}
