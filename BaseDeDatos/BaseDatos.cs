using BaseDeDatos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BaseDatos
{
    class BaseDatos
    {
        static void Main(string[] args)
        {
            try
            {
                BeerDB beerDB = new BeerDB(@"SG-718\SQLEXPRESS", "CsharpBD", "sa", "Sinco123");
                bool again = true; 
                int op = 0;

                do
                {
                    ShowMenu();
                    Console.WriteLine("Elige una opción");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Show(beerDB);
                            break;
                        case 2:
                            Add(beerDB);
                            break;
                        case 3:
                            Update(beerDB);
                            break;
                        case 4:
                            Delete(beerDB);
                            break;
                        case 5:
                            again = false;
                            break;
                    }

                } while (again);
                
                

            }
            catch(SqlException ex)
            {
                Console.WriteLine("No pudimos conectarte a tu base de datos");
            }
            

            
        }

        public static void ShowMenu() 
        {
            Console.WriteLine("\n----------- MENU -----------");
            Console.WriteLine("1 -- Mostrar");
            Console.WriteLine("2 -- Agregar");
            Console.WriteLine("3 -- Editar");
            Console.WriteLine("4 -- Eliminar");
            Console.WriteLine("5 -- Salir");
        }

        static public void Show(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Cervezas de la base de datos");
            List<Beer> beers = beerDB.GetAll();

            foreach (var beer in beers)
            {
                Console.WriteLine($"Id: {beer.Id}, Name: {beer.Name}");
            }
        }

        public static void Add(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Agregar Nueva Cerveza");
            Console.WriteLine("Escribe el nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el ID de la marca");
            int brandId = int.Parse(Console.ReadLine());
            Beer beer = new Beer(name, brandId);
            beerDB.Add(beer);
        }

        public static void Update(BeerDB beerDB)
        {
            Console.Clear() ;
            Console.WriteLine("Editar una cerveza");
            Show(beerDB);
            Console.WriteLine("Excribe el ID de la cerveza");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDB.Get(id);

            if( beer != null)
            {
                Console.WriteLine("Escribe el nombre de la cerveza: ");
                string name = Console.ReadLine() ;
                Console.WriteLine("Escribe el ID de la marca: ");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId = brandId;

                beerDB.Update(beer);
            }else
            {
                Console.WriteLine("La cervezar no existe");
            }
        }

        public static void Delete(BeerDB beerDB)
        {
            Console.Clear();
            Show(beerDB);
            Console.WriteLine("Eliminar una cerveza");
            Console.WriteLine("Excribe el ID de la cerveza a eliminar");
            int id = int.Parse(Console.ReadLine());

            Beer beer = beerDB.Get(id);
            if (beer != null)
            {
                Console.Clear();
                beerDB.Delete(id);
            }
            else
            {
                Console.WriteLine("La cervezar no existe");
            }
        }
    }
}
