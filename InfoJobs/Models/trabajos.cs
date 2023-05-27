using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class trabajos
    {
        [Key]

        public int id_trabajo { get; set; }

        public string nombre_empresa { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public int id_ubicacion { get; set; }

        public double salario { get; set; }

        public DateTime fecha_publicacion { get; set; }

        public int id_categoria { get; set; }

        public string sector { get; set; }

        public string experiencia { get; set; }

        public string contrato { get; set; }
    }
}
