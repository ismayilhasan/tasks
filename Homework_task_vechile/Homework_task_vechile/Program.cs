using System;

namespace Homework_task_vechile
{
    class Program
    {
        static void Main(string[] args)
        {

            Vechile vechile = new Vechile();
            Vechile vechile1 = new Vechile("Chevrolet", " Cruze","Yellow",200);
            

            vechile1.getInfo();

            Console.WriteLine("***************************************");
            Bus bus = new Bus("Mercedes", "M50", "White", 200, 40);

            bus.getInfo();
        }
    }
}
