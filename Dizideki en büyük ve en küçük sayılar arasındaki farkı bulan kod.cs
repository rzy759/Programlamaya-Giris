using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi kaç elemanlı: ");
            int a = int.Parse(Console.ReadLine());
            int[] sayılar = new int[a];

            Console.WriteLine("sayıları giriniz: ");
            for (int i = 0; i < a; i++)
            {
                sayılar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nküçükten büyüğe sıralanmış hali: ");
            Array.Sort(sayılar);
            foreach (int i in sayılar)
            {
                Console.WriteLine(i);
            }
        
            
            int fark = sayılar[a-1] - sayılar[0];
            Console.WriteLine("fark: "+fark);
            Console.ReadLine();
        }
    }
}
