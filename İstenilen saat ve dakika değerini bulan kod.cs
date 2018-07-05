using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("saat = ");
            double saat= double.Parse(Console.ReadLine());
           
            Console.WriteLine("dakika = ");
            double dakika = double.Parse(Console.ReadLine());
           
            Console.WriteLine("fark = ");
            double fark = double.Parse(Console.ReadLine());

            double saatidakka= saat * 60;
            double toplam_dakika=dakika + saatidakka + fark;

            double b=((toplam_dakika / 60) % 24);
            double tam_kısım=b - (int)b;
            double dakika_kısmı= tam_kısım * 60;
            
            Console.WriteLine("sonuç: "+(int)b+","+ Math.Ceiling(dakika_kısmı));
            Console.ReadLine();

        }
    }
}
