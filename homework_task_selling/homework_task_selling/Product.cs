using System;
using System.Collections.Generic;
using System.Text;

namespace homework_task_selling
{
    class Product
    {
        public string Name;
        public int Price;
        public  int Count;
        public static int Income;
        public static int TotalinCome;
        int selledCount;
        
        public Product(string name,byte price,byte count)
        {
            Name = name;
            Price = price;
            Count = count;
          
        }

        static Product()
        {
            Income = 0;
            TotalinCome = 0;
        }

        public virtual void  Sell()
        {
            selledCount = 1;
            Income = Price * selledCount;
            TotalinCome += Income;
            Count --;
            Console.WriteLine("Count of Product : " + Count) ;
            Console.WriteLine("Total Income : " + TotalinCome);

           
        }
    }
}
