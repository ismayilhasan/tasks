using System;

namespace homework_task_array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number :: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[default];
            for(int i = 0; i<=number; i++)
            {
                 
                if(number < 50)
                {
                    
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }



                else if (number < 100 && number > 50)
                {

                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }

                else if (number > 100)
                {
                    if(i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}
