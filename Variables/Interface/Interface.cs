namespace Interface
{
    class Interface
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Tiburonsin", 56),
                new Shark("Jaws", 65)
            };

            IFish[] fishs = new IFish[]
            {
                new Siren(200),
                new Shark("Tiburonsin", 56)
            };

            IFish f = new Shark("Tiburon", 40);

            ShowFish(sharks);
            ShowAnimal(sharks);
            ShowFish(fishs);

        }
        public static void ShowFish(IFish[] fishs)
        {
            Console.WriteLine(" - Mostramos los peces --");
            int i = 0;
            while (i < fishs.Length)
            {         
                Console.WriteLine(fishs[i].Swim());
                i++;
            }
        }
        public static void ShowAnimal(IAnimal[] animals)
        {
            Console.WriteLine(" - Mostramos los Animales --");
            int i = 0;
            while (i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }
    }
    public class Siren : IFish
    {
        public int Speed { get; set; }
        public Siren(int Speed)
        {
            this.Speed = Speed;
        }
        public string Swim()
        {
            return $"La Sirena Nada a {Speed} KM/H";
        }
    }

    public class Shark: IAnimal, IFish
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Shark(string Name, int Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
        }
        public string Swim() 
        { 
            return $"{Name} Nada {Speed} KM/H";
        }
    }

    public interface IAnimal
    {
        public string Name { get; set; }   

    }
    public interface IFish
    {
        public int Speed { get; set; }
        public string Swim();

    }
}

