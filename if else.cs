using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            Console.WriteLine("isminizi giriniz= ");
            isim = Console.ReadLine();

            if (isim=="onur akyıldız")
                {
                Console.WriteLine("doğru isim");
                }
                else
                {
                Console.WriteLine("yanlış isim");
                }
                 Console.Read();
        }       
    }
}
