namespace While
{
    class While
    {
        static void Main(string[] args)
        {
            int i = 0;   

            while (i < 100)
            {
                Console.WriteLine("iteracion de i " + i++);
                
            }

            int j = 0;

            while (j < 100)
            {
                if(j > 50)
                    break;
                Console.WriteLine("iteracion de j " + j++);

            }

            string[] friends = new string[7]
            {
                "Jose",
                "Albeiro",
                "Milton",
                "Alfredo",
                "Luisa",
                "Ceci",
                "Lukas"
            };

            int index = 0;

            while (index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }

            bool run = false;

            do
            {
                Show();
            } while (run);

            static void Show()
            {
                Console.WriteLine("Entro una vez y ya");
            }

        }
    }
}
