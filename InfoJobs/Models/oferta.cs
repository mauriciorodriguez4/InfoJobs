using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class oferta
    {
            [Key]
            public int id_oferta { get; set; }
            public string? titulo { get; set; }
            public string? ubicacion { get; set; }
            public string? descripcion { get; set; }
            public string? requisitos { get; set; }
            public string? contacto { get; set; }
            public int? id_empresa { get; set; }
            public int? id_categoria { get; set; }
    }
}
