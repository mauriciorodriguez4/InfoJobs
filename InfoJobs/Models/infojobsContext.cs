using Microsoft.EntityFrameworkCore;

namespace InfoJobs.Models
{
    public class infojobsContext : DbContext
    {
        public infojobsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<trabajos> trabajos { get; set; }

        public DbSet<categoria> categoria { get; set; }

        public DbSet<ubicacion> ubicacion { get; set; }

        public DbSet<sector> sector { get; set; }

        public DbSet<contrato> contrato { get; set; }

        public DbSet<experiencia> experiencia { get; set; }

        public DbSet<oferta> oferta { get; set; }
    }
}
