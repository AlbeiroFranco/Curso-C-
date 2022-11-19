namespace For
{
    class For
    {
        static void Main(string[] args)
        {
            string[] friends = new string[]
            {
                "Jose",
                "Albeiro",
                "Milton",
                "Alfredo",
                "Luisa",
                "Ceci",
            };

            bool run = true;

            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }


        }
    }
}
