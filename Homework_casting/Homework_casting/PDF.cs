using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_casting
{
    class PDF : IPrintible
    {
        public void Print()
        {
            Console.WriteLine("PDF has printed");
        }
    }
}
