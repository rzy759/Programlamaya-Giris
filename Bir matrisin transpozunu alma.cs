using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };

            Console.WriteLine("Transpose Matris: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(A[j, i]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
