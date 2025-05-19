

using PruebaGit.Datos;
using PruebaGit.Entidades;

namespace PruebaGit.Consola
{
    internal class Program
    {

        private static bool continuar;

        static void Main(string[] args)
        {
            var servicio = new PersonaRepositorio();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n Manejo de Personas ");
                Console.WriteLine("1 - Agregar");
                Console.WriteLine("2 - Eliminar");
                Console.WriteLine("3 - Listar");
                Console.WriteLine("4 - Salir");
                Console.WriteLine("5 - Editar");
                Console.Write("Ingrese opción: ");

                string? opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarPersona(servicio);
                        break;
                    //case "2":
                    //    EliminarPersona(servicio);
                    //    break;
                    //case "3":
                    //    servicio.MostrarPersonas();
                    //    break;
                    //case "5":
                    //    EditarPersona(servicio);
                    //    break;
                    //case "4":
                        continuar = false;
                        Console.WriteLine(" Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine(" Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadLine();
            }
        }

       

        private static void AgregarPersona(PersonaRepositorio servicio)
        {
            Console.Write("ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine(" Error: ID inválido.");
                return;
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine() ?? "";

            servicio.AgregarPersona(new Persona { Id = id, Nombre = nombre, Apellido = apellido });
        }

       
    }
}

