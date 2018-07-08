using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("bir sayı giriniz: ");
            string sayı = Console.ReadLine();
            int uzunluk=sayı.Length;
            int sayı1=int.Parse(sayı);
            double toplam = 0;

            int[] sayılar=new int[uzunluk];
            int i= 0;
            //sayıyı diziye aktardık
            while (sayı1 > 0)
            {                
                sayılar[i]=  sayı1 % 10;                                
                sayı1 = sayı1 / 10;
                i++;
            }

            for (i = 0; i < uzunluk; i++)
            {
               toplam=toplam+ (Math.Pow(2, i))*(sayılar[i]);
            }       
                              
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
