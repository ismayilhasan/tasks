using System;

namespace homework_task_selling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bread products");
            Product bread = new Product("bread", 2, 10);
            bread.Sell();
            bread.Sell();
            bread.Sell();
            
            Console.WriteLine("************************");
            Console.WriteLine("milk products");
            Milk milk = new Milk("milk", 3, 5, 2, 50);
            milk.Sell();

            //(string name, byte price, byte count, byte volume, byte fatRate)
        }
    }
}
