using System;

namespace homework_custom_contain
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string fullname = "ismayil Hasanov";
            fullname.CustomContain("ismayil");
            fullname.CustomContain("aNov");
            fullname.CustomContain("HAsanov");
            fullname.CustomContain(" Hasanov");
            fullname.CustomContain("ISMAYIL hasanov");





        }
    }
}
