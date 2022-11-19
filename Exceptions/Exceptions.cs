namespace Exceptions
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\\Users\\jose.franco\\Downloads\\path.txt");

                Console.WriteLine(content);

                throw new Exception("Ocurrio algo inesperado");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
            }
            catch(Exception ex2) 
            {
                Console.WriteLine(ex2.Message);
            }
            finally
            {
                Console.WriteLine("Aqui ejecuta pase lo que pase");
            }

            Console.WriteLine("sigue ejecutandose");

        }
    }
}
