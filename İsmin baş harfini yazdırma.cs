using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] isim = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("ismi girin: ");
                isim[i] = Console.ReadLine();
            }
              
            for (int i = 0; i < 3; i++)
            {
                Console.Write(isim[i][0]);
            }
            Console.ReadLine();

        }
    }
}
