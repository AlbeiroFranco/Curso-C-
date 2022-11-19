using System.Collections.Generic;

namespace Linkq
{
    class Linkq
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
                }
            };

            foreach (var beer in beers)
            {
                Console.WriteLine(beer);
            }

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

