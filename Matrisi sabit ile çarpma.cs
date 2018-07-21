using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("matrisin satır ve sutununu giriniz: ");
            
            int sa = int.Parse(Console.ReadLine());
            int su = int.Parse(Console.ReadLine());
            int[,] A = new int[sa, su];

            Console.WriteLine("matris elemanlarını giriniz: ");
            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < su; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("hangi sayı ile çarpılacak: ");
            int sayı = int.Parse(Console.ReadLine());

            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < su; j++)
                {
                    A[i, j] = A[i, j] * sayı;
                }

            }
            Console.WriteLine("sonuç: ");
            for (int i = 0; i < sa; i++)
            {
                for (int j = 0; j < su; j++)
                {
                    Console.Write(A[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
