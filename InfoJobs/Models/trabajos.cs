using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class trabajos
    {
        [Key]

        public int id_trabajo { get; set; }

        public string? nombre_empresa { get; set; }

        public string? nombre { get; set; }

        public string? descripcion { get; set; }

        public string? ubicacion { get; set; }

        public double? salario { get; set; }

        public string? sector { get; set; }

        public string? experiencia { get; set; }

        public string? contrato { get; set; }

        public string? imagen { get; set; }

    }
}
