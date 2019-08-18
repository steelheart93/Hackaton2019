using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DaVueltasFin.Models
{
    public class Donacion
    {
        [Key]
        public string codigo { get; set; }
        public float valor { get; set; }
        public string numeroTarjetaBenefactor { get; set; }
        public string numeroCuentaBeneficiario { get; set; }

        public Donacion(string codigo, float valor, string numeroTarjetaBenefactor, string numeroCuentaBeneficiario)
        {
            this.codigo = codigo;
            this.valor = valor;
            this.numeroTarjetaBenefactor = numeroTarjetaBenefactor;
            this.numeroCuentaBeneficiario = numeroCuentaBeneficiario;
        }
        
    }
}
