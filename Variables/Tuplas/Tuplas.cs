namespace Tuplas
{
    class Tuplas
    {
        static void Main(string[] args)
        {
            (int id, string name) product = (1, "Cerveza Corona");

            Console.WriteLine($"{product.id} {product.name}");

            product.name = "Cerveza Reds";

            Console.WriteLine($"{product.id} {product.name}");

            var person = (1, "Jose");


            Console.WriteLine($"Persona {person.Item1} {person.Item2}");

            var people = new[]
            {
                (1, "Jose"),
                (2, "Juan"),
                (3, "Maria")
            };

            foreach (var p in people)
            {
                Console.WriteLine($" People {p.Item1} {p.Item2}");
            }

            //Arreglo de tuplas
            (int id, string name)[] people2 = new[]
            {
                (1, "Jose"),
                (2, "Juan"),
                (3, "Maria")
            };

            foreach (var p in people2)
            {
                Console.WriteLine($"Id: {p.id} Name: {p.name}");
            }

            var cityInfo = getLocationCOL();
            //crea tupla sin necesidad de crear una clase
            Console.WriteLine($"Lat: {cityInfo.lat} Long: {cityInfo.lng} City: {cityInfo.city}");

            var(_ , lng, _) = getLocationCOL();
            Console.WriteLine(lng);

        }

        public static (float lat, float lng, string city) getLocationCOL()
        {
            float lat = 19.12121f;
            float lng = -99.13212f;
            string city = "COL";

            return (lat, lng, city);
        }
    }
}