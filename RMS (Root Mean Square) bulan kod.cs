using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dizi kaç elemalı: ");
            int a = int.Parse(Console.ReadLine());
            int[] sayılar=new int[a];
            int[] sayılarKare = new int[a];

            Console.WriteLine("Sayıları giriniz:");
            
            for (int i = 0; i < sayılar.Length; i++)
            {
                sayılar[i] = int.Parse(Console.ReadLine());                                
            }

            Console.Write("Sayilar: ");
            for (int i = 0; i < sayılar.Length; i++)
            {
            Console.Write(sayılar[i] +", ");
            }
            Console.WriteLine();
            //---
            Console.Write("Kareleri: ");
            for (int i = 0; i < sayılar.Length; i++)
            {
                sayılarKare[i]= sayılar[i] * sayılar[i];
                Console.Write( sayılarKare[i]+", ");
            }
            Console.WriteLine();

            int ort=sayılarKare.Sum()/a;
            Console.WriteLine("Ortalamaları : "+ort);
            
            double karekök= Math.Sqrt(ort);
            Console.WriteLine("Karekökü : "+karekök );
            
            Console.ReadLine();
        }
    }
}
