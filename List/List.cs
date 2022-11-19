using System.Collections.Generic;

namespace List
{
    class List
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(6);

            Console.WriteLine(numbers.Count);

            List<int> numbers2 = new List<int>() 
            { 
                1,9,10,11,12,13,
            
            };

            Console.WriteLine(numbers2.Count);

            numbers2.Add(55);
            numbers2.Add(46);

            Console.WriteLine(numbers2.Count);

            numbers2.Clear();
            Console.WriteLine(numbers2.Count);

            List<string> countries = new List<string>()
            {
                "Mexico", "Colombia", "EE.UU"
            };

            Console.WriteLine(countries.Count);
        }
    }
}