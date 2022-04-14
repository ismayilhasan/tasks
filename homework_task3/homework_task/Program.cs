using System;

namespace homework_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,i = 0;
         
            int num = Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                i = num % 10;
                sum += i;
                num /= 10;
            }

            Console.WriteLine(sum);





        }
    }
}
