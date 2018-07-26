using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    class Program
    {
        static void sayıyı_yazıya(int sayı)
        {
            int birler = sayı % 10;
            int onlar = (sayı / 10) % 10;
            int yüzler = (sayı / 100) % 10;
            int binler = (sayı / 1000) % 10;
            
            string[] birl = new string[10] { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onl = new string[10] { "", "on", "yirmi", "otuz", "kırk", "elli", "atmış", "yetmiş", "seksen", "doksan" };
            string[] yüzl = new string[10] { "", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz", "sekizyüz", "dokuzyüz" };
            string[] binl = new string[10] { "", "bin", "ikibin", "üçbin", "dörtbin", "beşbin", "altıbin", "yedibin", "sekizbin", "dokuzbin" };

            Console.Write(binl[binler] + yüzl[yüzler] + onl[onlar] + birl[birler] +" "); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("tarih giriniz: ");
            DateTime a = DateTime.Parse(Console.ReadLine());
            
            sayıyı_yazıya(a.Day);

            
            switch (a.Month)
            {
                case 1: Console.Write("ocak "); break;
                case 2: Console.Write("şubat "); break;
                case 3: Console.Write("mart "); break;
                case 4: Console.Write("nisan "); break;
                case 5: Console.Write("mayıs "); break;
                case 6: Console.Write("haziran "); break;
                case 7: Console.Write("temmuz "); break;
                case 8: Console.Write("ağustos "); break;
                case 9: Console.Write("eylül "); break;
                case 10: Console.Write("ekim "); break;
                case 11: Console.Write("kasım "); break;
                case 12: Console.Write("aralık  "); break;               
            }                                           
            
            sayıyı_yazıya(a.Year);

            Console.ReadLine();            
        }
        
    }
}
