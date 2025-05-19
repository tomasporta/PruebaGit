namespace PruebaGit.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; }=null!;
        public override string ToString()
        {
            return $"{Id}: {Nombre} {Apellido}";
        }
    }
}
