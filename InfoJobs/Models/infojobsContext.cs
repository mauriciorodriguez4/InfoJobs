using Microsoft.EntityFrameworkCore;

namespace InfoJobs.Models
{
    public class infojobsContext : DbContext
    {
        public infojobsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<aplicante> aplicante {get; set;}
        public DbSet<trabajos> trabajos { get; set; }

        public DbSet<categoria> categoria { get; set; }

        public DbSet<ubicacion> ubicacion { get; set; }

        public DbSet<sector> sector { get; set; }

        public DbSet<contrato> contrato { get; set; }

        public DbSet<recursos> recursos { get; set; }

        public DbSet<experiencia> experiencia { get; set; }

        public DbSet<oferta> oferta { get; set; }

        public DbSet<empresa> empresa { get; set; }

        public DbSet<asesoramiento> asesoramiento { get; set; }
        public DbSet<comentarios> comentarios { get; set; }
    }
}
