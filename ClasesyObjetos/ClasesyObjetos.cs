namespace ClasesyObjetos
{
    class ClasesyObjetos
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100,DateTime.Now);
            Sale sale2 = new Sale(200,DateTime.Now);
            Console.WriteLine(sale1.GetInfo());
            Console.WriteLine(sale2.GetInfo());
        }
    }

    class Sale
    {
        int total;
        DateTime date;
        
        //Constructor se distingue porque se llama igual que la clase
        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }
        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }
        public void Show()
        {
            Console.WriteLine("Ventas");
        }
    }
}