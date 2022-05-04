using System;
using System.Collections.Generic;
using System.Text;

namespace homework_task_selling
{
    class Milk : Product
    {
        public byte Volume;
        public byte FatRate;
        public Milk(string name, byte price, byte count, byte volume,byte fatRate) : base(name,price,count)
        {
            Volume = volume;
            FatRate = fatRate;
            Income = Price * Volume;
        }
        static Milk()
        {
            TotalinCome = 0;
        }
        public override void Sell()
        {

           
            
            TotalinCome += Income;
            Count--;
            Console.WriteLine("volume of Product : " + Volume);
            Console.WriteLine("Total Income : " + TotalinCome);
            Volume--;
        }
    }
}
