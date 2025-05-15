using PruebaGit.Datos;

namespace PruebaGit.Servicios
{
    public class PersonaServicio
    {
        private readonly PersonaRepositorio? personaRepositorio;
        public PersonaServicio()
        {
            personaRepositorio = new PersonaRepositorio();
        }

    }
}
