﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz: ");
           int a=int.Parse  (Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = i+1; j < a; j++)
                {
                    
                    Console.Write(" * ");
                }
             Console.WriteLine(" * ");

            }
            Console.ReadLine();

        }
    }
}
