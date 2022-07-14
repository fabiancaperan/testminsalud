
using System.ComponentModel.DataAnnotations;

namespace apitest.Models
{
    public class Concesionarios
    {
        [Key]
        public int ConcesionarioId { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
    }
}

