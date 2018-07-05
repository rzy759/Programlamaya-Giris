using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saat sayısını giriniz: ");
            int saat = int.Parse(Console.ReadLine());

            int ücret = 0;
            if (saat <= 10)
                ücret = saat * 1;
            else if (saat <= 20)
                ücret = saat * 2;
            else if (saat <= 40)
                ücret = saat * 3;
            else if (saat <= 100)
                ücret = saat * 4;
            else if(saat>100)
                ücret = saat * 5;

            
            Console.WriteLine("Mesai Ücreti: "+ücret +"tl");
            Console.ReadLine();
        }
    }
}
