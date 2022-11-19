using System.Collections.Generic;

namespace ListCommonMethods
{
    class ListCommonMethods
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1, 10, 8, 59, 35, 56,
            };

            Show(numbers);

            numbers.Insert(2, 74);

            Show(numbers);

            if (numbers.Contains(74))
                Console.WriteLine("Existe");
            else
                Console.WriteLine("No Existe");

            //indexOf
            int pos = numbers.IndexOf(3);
            Console.WriteLine(pos);
            //indexOf si no existe el numero nos devuelve un -1
            pos = numbers.IndexOf(100);
            Console.WriteLine(pos);
            //sort
            numbers.Sort();
            Show(numbers);

            //string es inmutable
            string name = "Carlos";
            name = name.ToUpper();
            Console.WriteLine(name);

            numbers.AddRange(new List<int>()
            {
                200,300,100
            });

            Show(numbers);


        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine(" -- Numeros --");
            foreach( var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        
    }
}
