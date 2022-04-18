using System;

namespace task_7yebolunen
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Number :: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count_1 = 1;
            int count_2 = 1;
            if (number % 7 == 0)
            {
                Console.WriteLine(number + "ededi 7 ye bolunur");
            }

            else
            {
                int new_number = number;

                while (count_1 <= 3)
                {

                    number++;
                    count_1 += 1;
                    if (number % 7 == 0)
                    {
                        Console.WriteLine(number);
                    }


                }
                while (count_2 <= 3)
                {
                    new_number--;
                    count_2 += 1;
                    if (new_number % 7 == 0)
                    {
                        Console.WriteLine(new_number);
                    }
                }


            }


        }
    }
}
