using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSencilla.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public string NumeroTarjeta { get; set; }

        public DateTime Fecha  { get; set; }

        public int  Mora { get; set; }
    }
}
