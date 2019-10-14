using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam, fark, carpım, bolum;
          
            Console.WriteLine("HESAP MAKİNESİ");

            Console.Write("1. sayıyı giriniz=");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz=");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam =" + toplam);
            
            fark = sayi1 - sayi2;
            Console.WriteLine("fark =" + fark);
           
            carpım = sayi1 * sayi2;
            Console.WriteLine("carpım =" + carpım);
           
            bolum = sayi1 / sayi2;
            Console.WriteLine("bolum =" + bolum);
            
            Console.Read();
        }
    }
}
