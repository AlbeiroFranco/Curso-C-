using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Linq
    {
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer()
                {
                    Name = "Stella",
                    Brand = "Germany Beers"
                },
                new Beer()
                {
                    Name = "Corona",
                    Brand = "Lagger"
                },
                new Beer()
                {
                    Name = "Budweiser",
                    Brand = "USA Beers"
                },
                new Beer()
                {
                    Name = "Poker",
                    Brand = "Bavaria"
                },
                new Beer()
                {
                    Name = "Club Colombia",
                    Brand = "Bavaria"
                }
            };

            foreach (var beer in beers)
            {
                Console.WriteLine(beer);
            }

            Console.WriteLine("-------------------------------");

            //Select

            var beerName = from beer in beers
                           select new
                           {
                               Name = beer.Name,
                               Letters = beer.Name.Length,
                               Fixed = 1
                           };

            foreach (var beer in beerName)
                Console.WriteLine($"{beer.Name} {beer.Letters} {beer.Fixed}");
            
            Console.WriteLine("-------------------------------");

            var beerNameReal = from beer in beers
                               select beer.Name;

            foreach (var beer in beerNameReal)
                Console.WriteLine(beer);
            

            Console.WriteLine("-------------------------------");

            var beerBrand = from beer in beers
                            where beer.Brand == "Lagger" || beer.Name == "Poker"
                            select beer;

            foreach (var beer in beerBrand)
                Console.WriteLine(beer);

            Console.WriteLine("-------------------------------");

            var orderBeers = from beer in beers
                             orderby beer.Brand
                             select beer;
            foreach (var beer in orderBeers)
                Console.WriteLine(beer);


        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public override string ToString()
        {
            return $"Nombre: {Name} Marca: {Brand}";
        }
    }
}

