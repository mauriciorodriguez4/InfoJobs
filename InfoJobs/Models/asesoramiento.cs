using System.ComponentModel.DataAnnotations;
namespace InfoJobs.Models
{
    public class asesoramiento
    {
        [Key]
        public int id { get; set; }
        public string? correo { get; set; }
        public string? tipo_trabajo { get; set; }
        public string? telefono { get; set; }
    }
}
