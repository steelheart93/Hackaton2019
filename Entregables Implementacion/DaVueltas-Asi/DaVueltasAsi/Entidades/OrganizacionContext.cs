using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DaVueltasAsi.Entidades
{
    public class OrganizacionContext : DbContext
    {
        public OrganizacionContext(DbContextOptions<OrganizacionContext> options) : base(options)
        {

        }

        public DbSet<Organizacion> Organizaciones { get; set; }
    }

}
