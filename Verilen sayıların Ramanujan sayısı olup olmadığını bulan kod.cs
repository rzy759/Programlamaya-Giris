using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 tane sayı giriniz");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
         
            if (a * a * a + b * b * b == c * c * c + d * d * d )            
                Console.WriteLine(  a+ "³ + " + b+"³ =" + c+"³ + "+d+"³ \n"+
                    "verilen sayılar Ramanujan sayısıdır");            
            else
                Console.WriteLine(a + "³ + " + b + "³ =! " + c + "³ + " + d + "³ \n" + 
                    "verilen sayılar Ramanujan sayısı değildir");
            Console.ReadLine();
        }
    }
}
