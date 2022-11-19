using System.Text.Json;

namespace Json
{
    class Json
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Stella",
                Brand = "Aortis"
            };

            //Json Normal
            //string json = "{\"Name\": \"Stella\", \"Brand\": \"Aortis\"}";

            string json = JsonSerializer.Serialize(myBeer);
            Beer beer = JsonSerializer.Deserialize<Beer>(json);

            //Arreglo de Json
            Beer[] beers = new Beer[]{
                new Beer()
                {
                    Name = "Club",
                    Brand = "Colombia"
                },
                new Beer()
                {
                    Name = "Budweiser",
                    Brand = "Bavaria"
                }
            };

            //Coleccion de objetos
            //string json2 = "[" +
            //    "{\"Name\": \"Club\", \"Brand\": \"Colombia\"}," +
            //    "{\"Name\": \"Corona\", \"Brand\": \"Extra\"}," +
            //    "]";

            string json2 = JsonSerializer.Serialize(beers);
            //Convertir a objeto
            Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);

        }

        
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
    }
}
