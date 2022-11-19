namespace SentenciaIfElseIf
{
    class SentenciaIfElseIf
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;
            bool youHaveMoney = true;

            if (areYouHungry && youHaveMoney && IsOpenRestaurant("Crepes", 10) )
            {
                Console.WriteLine("eat");
            }
            else
            {
                Console.WriteLine("Not eat");  
            }

        }
        static bool IsOpenRestaurant(string name, int hour = 0)
        {
            if(name == "Crepes" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if(name == "Oxxo")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}