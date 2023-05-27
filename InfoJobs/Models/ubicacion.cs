using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class ubicacion
    {
        [Key]
        public int id_ubicacion { get; set; }

        public string departamento { get; set; }

    }
}
