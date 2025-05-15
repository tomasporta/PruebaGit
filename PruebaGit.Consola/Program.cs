using PruebaGit.Servicios;

namespace PruebaGit.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var servicio = new PersonaServicio();
            Console.WriteLine("Manejo de Personas");
            Console.WriteLine("1 - Agregar");
            Console.WriteLine("2 - Borrar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Listar");
            Console.WriteLine("Ingrese opción:");
            string? opcion=Console.ReadLine();
        }
    }
}
