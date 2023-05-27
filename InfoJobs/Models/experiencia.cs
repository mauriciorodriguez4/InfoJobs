using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class experiencia
    {
        [Key]

        public int id_experiencia { get; set; }

        public string? cantidad { get; set; }

    }
}
