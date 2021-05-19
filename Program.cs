using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnurAkyıldız_Ödev9.txt
{
    public class Base
    {
        public virtual void Test()
        {
            Console.WriteLine("Bu, sanal metotun temel sürümüdür");
        }
    }
    public class Derived : Base
    {
        public override void Test()
        {
            Console.WriteLine("Bu, sanal metotun türetilmiş sürümüdür");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Base base1 = new Base();
            base1.Test();
            Base base2 = new Derived();
            base2.Test();


            Console.ReadKey();
        }
    }
}
