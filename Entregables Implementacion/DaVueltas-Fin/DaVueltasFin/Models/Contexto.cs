using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DaVueltasFin.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Donacion> donaciones { get; set; }
        public DbSet<CuentaBancaria> cuentasBancarias { get; set; }
        public DbSet<Tarjeta>  tarjetas{ get; set; }
    }
}
