using System;
using System.Collections.Generic;
using System.Text;

namespace homework_custom_contain
{
    static class Methods
    {

        
        
        public static void CustomContain(this string str, string searching)
        {
            string STR = str.ToLower();
            string Searching = searching.ToLower();
            bool result = false ;
            string neew = "";

            for (int i = 0; i <= STR.Length - Searching.Length; i++) //ismayil may
            {
                for (int j = 0; j < Searching.Length; j++)
                {
                    neew += STR[i + j];
                    //Console.WriteLine(neew);
                }
                if (neew == Searching)
                {
                    result = true;

                }


                neew = "";
            }

            if(result)
            {
                Console.WriteLine(true);
                
            }
            else
            {
                Console.WriteLine(false);
            }

        }



    }


}

