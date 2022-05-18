using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Find_Population
{
    class City
    {
        public string Name;
        public int Population;

        public City(string name,int population)
        {
            Name = name;
            Population = population;
        }

        public override string ToString()
        {
            return $"Name : {Name} Population {Population} ";
        }

    }
}
