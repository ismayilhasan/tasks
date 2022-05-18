using System;

namespace Homework_Find_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            Country Spain = new Country("Spain", 47450795);
            Country Azerbaijan = new Country("Azerbaijan", 60296023);
            Country Italy = new Country("Italy", 47450795);
            Country Turkey = new Country("Turkey", 84339067);

            City Madrid = new City("Madrid", 3345894);
            City Roma = new City("Roma", 2860009);
            City Istanbul = new City("Istanbul", 15636000);
            City Ganja = new City("Ganja", 335600);

            Country.Cities.Add(Madrid);
            Country.Cities.Add(Roma);
            Country.Cities.Add(Istanbul);
            Country.Cities.Add(Ganja);

            Country.FindAllByPopulation(30000, 4000000); // istanbul 15 milyon oldugu ucun gelmiyecek



        }
    }
}
