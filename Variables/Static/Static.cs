namespace Static
{
    class Static
    {
        static void Main(string[] args)
        {
            People jose = new People()
            {
                Name = "Jose",
                Age = 30,
            };

            People juan = new People()
            {
                Name = "Juan",
                Age = 27,
            };

            Console.WriteLine(People.GetCount());



        }

        public class People
        {
            public static int Count = 0; 
            public string Name { get; set; }
            public int Age { get; set; }
            public People()
            {
                Count++;
            }
            public static string GetCount()
            {
                return $"Esta clase se ha utilizado {Count} veces";
            }

        }
    }
}

