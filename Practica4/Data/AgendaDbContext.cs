using Microsoft.EntityFrameworkCore;

namespace Practica4.Data
{
    public class AgendaDbContext : DbContext
    {
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Evento> Eventos { get; set; }
        public DbSet<Models.Estado> Estados { get; set; }


    }
}
