using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSencilla.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        public string NumeroTarjeta { get; set; }

        [Required]
        public DateTime Fecha  { get; set; }

        [Required]
        public int  Mora { get; set; }
    }
}
