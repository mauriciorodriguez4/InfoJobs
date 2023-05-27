using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class contrato
    {
        [Key]

        public int id_contrato { get; set; }

        public string tipo_contrato { get; set; }

    }
}
