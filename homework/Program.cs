using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded =");
            int numb = Convert.ToInt32(Console.ReadLine());    

            if(numb % 2 == 0)
            {
                Console.WriteLine(numb + " " + "cut ededdir");
            }
            else
            {
                Console.WriteLine(numb + " " + " tek ededdir");

            }


        }
    }
}
