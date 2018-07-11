using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iki sayı giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sonuc = 0;

            if (b < 0)
            {
                for (int i = b; i < 0; i++)           
                sonuc -= a;   
            }
            else if (a<0)
            {
                for (int i = a; i < 0; i++)
                sonuc -= b;
                
            }
            else if (a < 0 && b < 0)
            {
                for (int i = 0; i < b; i++)
                sonuc += a;
            }
            else
            {
                for (int i = 0; i < b; i++)            
                sonuc += a;
            }
           
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
