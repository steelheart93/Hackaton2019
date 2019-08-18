using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaVueltasFin.Models
{
    public class CuentaBancaria
    {
        [Key]
        public string numero { get; set; }

        public CuentaBancaria(string numero)
        {
            this.numero = numero;
        }

    }
}
