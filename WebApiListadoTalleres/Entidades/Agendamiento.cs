namespace WebApiListadoTalleres.Entidades
{
    public class Agendamiento
    {
        public int Id { get; set; }
        public int TallerId { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public Taller Taller { get; set; }

    }
}
