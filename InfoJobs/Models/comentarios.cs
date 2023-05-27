using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class comentarios
    {
        [Key]

        public int id_comentario { get; set; }
        public string comentario { get; set; }
        public int valoracion { get; set; }


    }
}
