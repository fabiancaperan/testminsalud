using System;
using System.ComponentModel.DataAnnotations;

namespace apitest.Models
{

    public class AutoConcesionario
    {
        [Key]
        public int AutoId { get; set; }
        [Key]
        public int ConcesionarioId { get; set; }
        public int Total { get; set; }
    }
    
}

