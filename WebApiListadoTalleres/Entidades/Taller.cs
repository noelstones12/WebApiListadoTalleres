using System.Globalization;

namespace WebApiListadoTalleres.Entidades
{
    public class Taller
    {
        public int Id { get; set; }
        public string Nombre_Taller { get; set; }
        public string Comuna { get; set; }
        public List<Agendamiento> Agendamientos{ get; set; }
    }
}
