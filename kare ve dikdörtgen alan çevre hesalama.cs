using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pouıb
{
    class Program
    {
        static void Main(string[] args)
        {
            int kenar, karealan, karecevre;

            Console.WriteLine("**KARE ÇEVRE VE ALAN HESAPLAMA**");
          
            Console.Write("kenar giriniz= ");
            kenar = Convert.ToInt32(Console.ReadLine());

            karecevre = kenar * 4;
            karealan = kenar * kenar;

            Console.WriteLine("karecevre=" + karecevre);
            Console.WriteLine("karealan=" + karealan);

            Console.Read();

            int kenar1, kenar2, dikdortgenalan, dikdortgencevre;
           
            Console.WriteLine("**DİKDÖRTGEN ALAN VE ÇEVRE HESAPLAMA**");

            Console.Write("kenar1 giriniz= ");
            kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("kenar2 giriniz= ");
            kenar2 = Convert.ToInt32(Console.ReadLine());

            dikdortgenalan = kenar1 * kenar2;
            dikdortgencevre = (kenar1 + kenar2) * 2;

            Console.WriteLine("dikdortgencevre=" + dikdortgencevre);
            Console.WriteLine("dikdortgenalan=" + dikdortgenalan);

            Console.Read();


        }
    }
}