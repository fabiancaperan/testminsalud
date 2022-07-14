using System;
using System.ComponentModel.DataAnnotations;

namespace apitest.Models
{
    public class Autos
    {
        [Key]
        public int AutoId { get; set; }
        public string Descripcion { get; set; }
        public string Combustible { get; set; }
        public string Marca { get; set; }
    }
}

