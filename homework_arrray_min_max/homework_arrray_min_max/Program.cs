using System;

namespace homework_arrray_min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Massivin Uzunlugu  ::");
            int size =  Convert.ToInt32( Console.ReadLine());  
            int[] array = new int[size];
            int number = default;

            int largest = 0;
            for(int i = 0;i<size;i++)
            {
                Console.WriteLine(i + 1 + "ci eded ::");

                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            

            foreach (int item in array)
            {
                if (largest < item)
                {
                    largest = item;
                }
            }
       

            Console.WriteLine(largest + "is max in array");

            

        }
    }
}
