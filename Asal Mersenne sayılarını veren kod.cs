using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            double mers=0;
            bool durum;

            for (int i = 2; i < 50; i++)
            {
                durum = true;
                for (int j =2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        durum = false;
                        break;
                    }

                }
                
                if (durum==true)
                {
                    mers = Math.Pow(2, i) - 1;
                    Console.WriteLine(mers);                   
                }
            }
            Console.ReadLine();

        }
    }
}
