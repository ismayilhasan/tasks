using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_casting
{
    class Word : IPrintible
    {
        void IPrintible.Print()
        {
            Console.WriteLine("Word has printed");
        }
    }
}
