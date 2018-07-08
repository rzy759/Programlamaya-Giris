using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            bool durum;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < 62; i++)
            {
                durum = true;
                for (int j = 2; j < i; j++)
                {                  
                    if (i % j == 0)
                    {
                        durum = false;
                        break;
                    }              
                }

                if (durum == true)
                {
                    Console.WriteLine( i);                                        
                }          
                            
            }
            Console.ReadLine();   
        }
    }
}
