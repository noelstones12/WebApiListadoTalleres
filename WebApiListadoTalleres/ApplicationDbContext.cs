using Microsoft.EntityFrameworkCore;
using WebApiListadoTalleres.Entidades;

namespace WebApiListadoTalleres
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Taller> DbTalleres { get; set; }
        public DbSet<Agendamiento> DbAgendamientos { get; set; }
    }
}
