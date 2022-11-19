namespace Sobrecarga
{
    class Sobrecarga
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Sum(5,6));
            Console.WriteLine(math.Sum("7","2"));

            int[] numbers = new int[] { 1, 2, 6};
            Console.WriteLine(math.Sum(numbers));

        }

        class Math
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }

            public int Sum(string a, string b)
            {
                return int.Parse(a) + int.Parse(b);
            }
            //recibe una coleccion de objetos
            public int Sum(int[] numbers)
            {
                int result = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i];
                }

                return result;
            }
        }

    }
}