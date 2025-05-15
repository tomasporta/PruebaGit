using PruebaGit.Entidades;

namespace PruebaGit.Datos
{
    public class PersonaRepositorio
    {
        private List<Persona> personas = null!;
        public PersonaRepositorio()
        {
            personas=new List<Persona>();
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
    }
}
