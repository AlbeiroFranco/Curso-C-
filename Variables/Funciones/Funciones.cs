namespace Variables
{
    class Funciones
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;

            //int c = a + b;
            //int d = a + b;
            Suma(1, 2);
            Suma(a, b);
            int multi = Multiplicar(a, b);
            Console.WriteLine(multi);
            Show();
        }

        //funcion que no regresa nada pero si recibe parametros
        static void Suma(int num1, int num2)
        {
            //cw + dobleTab sniped
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }

        //Funcion que no regresa nada y no recibe parametros
        static void Show()
        {
            Console.WriteLine("Hola, Soy un texto que se imprime desde funcion");
        }

        //Funcion que recibe y regresa valores
        static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}