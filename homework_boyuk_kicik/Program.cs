using System;

namespace homework_boyuk_kicik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("A = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B = ");
            b = Convert.ToInt32(Console.ReadLine());


            if (a > b)
            {
                Console.WriteLine("A ededi B den boyukdur (A > B)");
            }
            else if (b>a)
            {
                Console.WriteLine("B ededi a dan boyukdur (B > A)");
            }
            else
            {
                Console.WriteLine("ededler berabedir");
            }

        }
    }
}
