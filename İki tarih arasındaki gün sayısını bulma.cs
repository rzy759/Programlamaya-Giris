using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iki tane tarih giriniz: ");
            DateTime a = DateTime.Parse(Console.ReadLine());
            DateTime b = DateTime.Parse(Console.ReadLine());

            TimeSpan c = a - b;
            
            Console.WriteLine("gün sayısı: "+c.TotalDays);
            Console.ReadLine();             
                       
        }
    }
}
