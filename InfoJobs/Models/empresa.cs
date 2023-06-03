using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InfoJobs.Models
{
    public class empresa
    {
        [Key]
        public int id_empresa { get; set; }
        public string? nombre { get; set; }
        public string? objetivos { get; set; }
        public string? mision { get; set; }
        public int? clasificacion { get; set; }
        public string? logo { get; set; }
    }
}
