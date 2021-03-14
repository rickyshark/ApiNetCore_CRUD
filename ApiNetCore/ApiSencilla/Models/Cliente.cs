using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSencilla.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = ("varchar(100)"))]
        public string NombreCompleto { get; set; }

        [Required]
        [Column(TypeName = ("varchar(100)"))]
        public string Direccion { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "El formato del telefono no es valido!!")]
        public string Telefono { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}
