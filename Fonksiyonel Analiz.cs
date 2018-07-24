using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("harfi giriniz: ");
            string harf = Console.ReadLine();

            switch (harf)
            {
                case "A": case "B": case "C":
                    Console.WriteLine(harf + " harfi telefonda 2 rakamına karşılık gelir");
                    break;
                case "D": case "E": case "F":
                    Console.WriteLine(harf + " harfi telefonda 3 rakamına karşılık gelir");
                    break;
                case "G": case "H": case "I":
                    Console.WriteLine(harf + " harfi telefonda 4 rakamına karşılık gelir");
                    break;
                case "J": case "K": case "L":
                    Console.WriteLine(harf + " harfi telefonda 5 rakamına karşılık gelir");
                    break;
                case "M": case "N": case "O":
                    Console.WriteLine(harf + " harfi telefonda 6 rakamına karşılık gelir");
                    break;
                case "P": case "R": case "S":
                    Console.WriteLine(harf + " harfi telefonda 7 rakamına karşılık gelir");
                    break;
                case "T": case "U": case "V":
                    Console.WriteLine(harf + " harfi telefonda 8 rakamına karşılık gelir");
                    break;
                case "W": case "X": case "Y":
                    Console.WriteLine(harf + " harfi telefonda 9 rakamına karşılık gelir");
                    break;
            }
            Console.ReadLine();
        }
    }
}
