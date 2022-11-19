using System.Collections.Generic;

namespace Foreach
{
    class Foreach
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                23,45,10,58,64
            };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            List<People> students = new List<People>()
            {
                new People() { Name = "Jose", Country = "Colombia" },
                new People() { Name = "Carlos", Country = "Tangamandapio"},
                new People() { Name = "Rocio", Country = "Mexico"}
            };

            static void Show(List<People> students)
            {
                Console.WriteLine(" -- Personas -- ");
                foreach(var student in students)
                {
                    Console.WriteLine($"Nombre: {student.Name}, País: { student.Country}");
                }
            }

            Show(students);

            //students.RemoveAt(0);
            students.Add(new People() { Name = "Ceci", Country = "Chile" });

            Show(students);

        }

        class People
        {
            public string Name { get; set; } 
            public string Country { get; set; }
        }

        
    }
}