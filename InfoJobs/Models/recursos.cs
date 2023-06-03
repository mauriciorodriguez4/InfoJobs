using System.ComponentModel.DataAnnotations;
namespace InfoJobs.Models
{
    public class recursos
    {
        [Key]
        public int id_recurso { get; set; }
        public string? fuente { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public string? imagen { get; set; }
        public string? tipo { get; set; }
    }
}
