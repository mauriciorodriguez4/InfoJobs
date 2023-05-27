using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class categoria
    {
        [Key]

        public int id_categoria { get; set; }

        public string nombre_categoria { get; set; }


    }
}
