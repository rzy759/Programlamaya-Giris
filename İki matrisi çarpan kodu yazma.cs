using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("çarpacağınız matrisin boyutları: ");
            int sa = int.Parse(Console.ReadLine());
            int su = int.Parse(Console.ReadLine());


            int[,] A = new int[sa, su];
            int[,] B = new int[su, sa]; 
            int[,] C = new int[sa, sa];

            Console.WriteLine("İlk matrisi giriniz: ");
            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < su; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("İkinci matrisi giriniz: ");
            for (int i = 0; i < su; i++)
            {
                for (int j = 0; j < sa; j++)
                {
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < sa; i++)
            {
                for (int j = i; j < sa; j++)
                {
                    for (int k= 0; k < su; k++)
                    {
                       C[i, j] += A[i, k] * B[k, j];
                    }                                       
                }
            }
            Console.WriteLine("sonuç: ");
            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < sa; j++)
                {
                    Console.WriteLine(C[i, j]);

                }
            }

            

            Console.ReadLine();
        }
    }
}
