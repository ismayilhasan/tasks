using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_casting
{
    class MainPrintFile 
    {
        public MainPrintFile(IPrintible print)
        {
            print.Print();
        }
    }
}
