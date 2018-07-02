using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci kenar: ");
            double a=double.Parse(Console.ReadLine());
            Console.WriteLine("ikinci kenar: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("üçüncü kenar: ");
            double c = double.Parse(Console.ReadLine());

            

            if (Math.Pow(a,2)+Math.Pow(b,2)==Math.Pow(c,2)||
                Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)||
                Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
            {
                Console.WriteLine("bu bir dik üçgendir");
            }
            else
            {
                Console.WriteLine("bu dik üçgen değildir");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
