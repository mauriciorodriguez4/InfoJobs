using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class aplicante
    {
        [Key]
        public int id_aplicante { get; set; }
        public int? id_usuario { get; set; }
        public string? cv {get; set; }
        public int? id_trabajos { get; set; }
        public char? Estado {get; set; }
    }
}
