namespace TiposAnonimos
{
    class TiposAnonimos
    {
        static void Main(string[] args)
        {
            var jose = new
            {
                Name = "Jose",
                Country = "Colombia"
            };

            Console.WriteLine($"{jose.Name} {jose.Country}");

            var beers = new[]
            {
                new {Name = "Reds", Brand = "Bavaria"},
                new {Name = "Azteka", Brand = "Fullers"},
            };

            foreach (var beer in beers)
            {
                Console.WriteLine($"Cerveza: {beer.Name}, Marca: {beer.Brand}");
            }

        }
    }
}