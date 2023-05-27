using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class sector
    {
        [Key]

        public int id_sector { get; set; }

        public string tipo_sector { get; set; }

    }
}
