
using System;

namespace homework_task_3elave_etme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write( "NUMBER :: ");
            int number = Convert.ToInt32(Console.ReadLine());
;                add(number);

        }




        public static void add(int num)
        {
            Console.Write("Number : ");
            

            int count = num; int i = 3;

            while (count > 0)
            {
                i *= 10;
                count /= 10;

            }

            Console.WriteLine("new number :: " + (num + i));

            
        }









    }
}
