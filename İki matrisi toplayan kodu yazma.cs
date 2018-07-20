using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("toplayacağınız matrisin boyutları: ");
            int sa = int.Parse(Console.ReadLine());
            int su = int.Parse(Console.ReadLine());

            int[,] A = new int[sa, su];
            int[,] B = new int[sa, su];
            int[,] C = new int[sa, su];

            Console.WriteLine("ilk matrisi giriniz: ");
            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < su; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("ikinci matrisi giriniz: ");
            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < su; j++)
                {
                    B[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("sonuc: ");
            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < su; j++)
                {
                    C[i, j] += A[i, j] + B[i, j];
                }
            }
            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < su; j++)
                {
                    Console.Write(C[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
