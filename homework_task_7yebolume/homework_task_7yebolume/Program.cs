using System;

namespace homework_task_7yebolume
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Seymur", "Kerim", "AZE", "Nihad", "Azerbaycan", "Respublikasi", "WWW" };


            int count = default;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > 5)
                {
                    Console.WriteLine(array[i]);

                }

            }
        }
    }
}


   