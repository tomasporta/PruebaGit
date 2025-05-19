using PruebaGit.Entidades;

namespace PruebaGit.Datos
{
    public class PersonaRepositorio
    {
        private List<Persona> personas = null!;
        public PersonaRepositorio()
        {
            personas = new List<Persona>();
            LeerDatos();
        }
        private void LeerDatos()
        {

            personas.Add(new Persona { Id = 1, Nombre = "Ana", Apellido = "García" });
            personas.Add(new Persona { Id = 2, Nombre = "Marcos", Apellido = "López" });
            personas.Add(new Persona { Id = 3, Nombre = "Sofía", Apellido = "Martínez" });
            personas.Add(new Persona { Id = 4, Nombre = "Pedro", Apellido = "González" });
            personas.Add(new Persona { Id = 5, Nombre = "Laura", Apellido = "Rodríguez" });
        }
       
        public void AgregarPersona(Persona nuevaPersona)
        {
            if (personas.Any(p => p.Id == nuevaPersona.Id))
            {
                Console.WriteLine(" Error: Ya existe una persona con este ID.");
                return;
            }

            personas.Add(nuevaPersona);
            Console.WriteLine(" Persona agregada correctamente!");
        }
        public void MostrarPersonas()
        {
            Console.WriteLine("\n Lista de Personas:");
            foreach (var persona in personas)
            {
                Console.WriteLine(persona);
            }
        }
        public void EliminarPersona(int id)
        {
            Persona persona = personas.FirstOrDefault(p => p.Id == id); ;
            if (persona != null) { personas.Remove(persona); }
            else throw new InvalidOperationException("Persona no encontrado");

        }


        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }

       
        }
    }

