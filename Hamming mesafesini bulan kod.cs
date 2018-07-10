using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("iki dizgi giriniz: ");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int sayaç = 0;
            char[] akarakterler = a.ToCharArray();
            char[] bkarakterler = b.ToCharArray();
            if (a.Length==b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j <=i ; j++)
                    {
                        if (a[i] != b[i])
                    {
                        sayaç++;
                        break;
                    }                   
                    }              
                }
            Console.WriteLine(sayaç);
            }
            else
                Console.WriteLine("dizgi uzunlukları birbirine eşit değil ");           
            
            Console.ReadLine();
        }
    }
}
