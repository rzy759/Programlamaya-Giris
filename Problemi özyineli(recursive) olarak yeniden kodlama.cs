using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static int Carpma(int a,int b)
        {
            int toplam = 0;
            for (int i = 0; i < b; i++)
            {
                toplam += a;
            }            
            return toplam;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("iki sayı giriniz: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sonuc = Carpma(a, b);            
           
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
