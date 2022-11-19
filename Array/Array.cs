namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]
            {
                "Jose",
                "Albeiro",
                "Milton",
                "Alfredo",
                "Luisa",
                "Ceci",
                null
            };

            //friends[0] = "Jose";


            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);
            Console.WriteLine(friends[6]);

            friends[6] = "Lukas";

            Console.WriteLine(friends[6]);

             
        }
    }
}