using PruebaGit.Datos;
using PruebaGit.Entidades;

namespace PruebaGit.Servicios
{
    public class PersonaServicio
    {
        private readonly PersonaRepositorio? personaRepositorio;
        public PersonaServicio()
        {
            personaRepositorio = new PersonaRepositorio();
        }

     

        public void AgregarPersona(int id, string nombre, string apellido)
        {
            Persona nuevaPersona = new Persona { Id = id, Nombre = nombre, Apellido = apellido };
            personaRepositorio.AgregarPersona(nuevaPersona);
        }

       

    }
}
