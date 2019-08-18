using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaVueltasFin.Models
{
    public class Tarjeta
    {   
        [Key]
        public string numero { get; set; }
        public bool activo { get; set; }

        public Tarjeta(string numero, bool activo)
        {
            this.numero = numero;
            this.activo = activo;
        }


    }
}
