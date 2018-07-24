using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\must\Desktop\bina.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Console.WriteLine("Binary Number - Decimal Number");
            string yazı = sr.ReadLine();
            while (yazı != null)
            {
                Console.Write(yazı+ "\t- ");
                int c = 0;

                for (int i = 0; i < yazı.Length; i++)
                {
                    if (yazı[yazı.Length - i - 1] == '0') continue;

                    c += (int)Math.Pow(2, i);

                }
                Console.WriteLine(c);

                yazı = sr.ReadLine();

            }         
            
            
            Console.ReadLine();

        }
    }
}
