using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSinif
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////Random Sınıfı Uygulama 

            //Random r = new Random();
            //int sayi1, sayi2;
            //sayi1 = r.Next(0,51);
            //sayi2 = r.Next(0,51);
            //Console.Write(sayi1 + " " + sayi2);
            //Console.Read();

            Random rn = new Random();
            int sehir;
            string[] sehirler = { "Adana", " Bursa", " Ankara", "İstanbul" };
            sehir = rn.Next(0,sehirler.Length);
            Console.Write(sehirler[sehir]);
            Console.Read();

        }
    }
}
