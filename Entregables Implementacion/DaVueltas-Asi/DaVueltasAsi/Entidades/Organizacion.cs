using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaVueltasAsi.Entidades
{
    public class Organizacion
    {
        [Key]
        public string Nit { get;  set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get;  set; }
        public string TipoBeneficiario { get;  set; }
        public string NumeroCuenta { get; set; }
        public string Banco { get; set; }
        public string TipoCuenta { get; set; }
        public string Titular { get;  set; }

        public Organizacion(string Nit, string Nombre, string Direccion, string CorreoElectronico, string TipoBeneficiario,
            string NumeroCuenta, string Banco, string TipoCuenta, string Titular)
        {
            this.Nit = Nit;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.CorreoElectronico = CorreoElectronico;
            this.TipoBeneficiario = TipoBeneficiario;
            this.NumeroCuenta = NumeroCuenta;
            this.Banco = Banco;
            this.TipoCuenta = TipoCuenta;
            this.Titular = Titular;
        }


    }


}
