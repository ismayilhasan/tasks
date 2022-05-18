using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Find_Population
{
    class Country
    {
        public string Name;
        public int TotalPopulation;
         public static  List<City> Cities;

        static Country()
        {
            Cities = new List<City>(); ;
        }
        public Country(string name, int totalPopulation)
        {
            Name = name;
            TotalPopulation = totalPopulation;
           
        }
        public static void FindAllByPopulation(int min, int max)
        {
            foreach (City items in Cities)
            {
                if (items.Population > min && items.Population < max)
                {
                    Console.WriteLine(items);
                }


            }
        }
    }
}
