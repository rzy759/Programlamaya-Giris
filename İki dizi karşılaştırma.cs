using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = new int[] { 1, 2 };
            int[] dizi2 = new int[] { 0, 1, 2, 3 };

            for (int i = 0; i < dizi1.Length; i++)
            {
                for (int j = 0; j < dizi2.Length; j++)
                {
                    if (dizi1[i]==dizi2[j])
                    {
                        Console.WriteLine("aynı olan elemanlar: "+j);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
