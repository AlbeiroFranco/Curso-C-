namespace Propiedades
{
    class Propiedades
    {
        static void Main(string[] args)
        {
            //Nombre de clase + Nombre de variable + new + nombre de la clase del constructor
            Sale mySale = new Sale(100, DateTime.Now);
            mySale.Total = -1478878787;
            Console.WriteLine(mySale.Date);
            Console.WriteLine(mySale.Total);
        }

        class Sale
        {
            private int total;
            private DateTime date;

            public string Date
            {
                get
                {
                    return date.ToLongDateString();
                }
            }

            public int Total
            {
                get
                {
                    return total;
                }
                set
                {
                    if(value < 0)
                        value = 0;
                    total = value;
                }

            }

            //Accesor
            //public string Total
            //{
            //    get 
            //    {
            //        return total.ToString("#.00");
            //    }
             
            //}

            //Constructor se distingue porque se llama igual que la clase
            public Sale(int total, DateTime date)
            {
                this.total = total;
                this.date = date;
            }
        }
    }
}