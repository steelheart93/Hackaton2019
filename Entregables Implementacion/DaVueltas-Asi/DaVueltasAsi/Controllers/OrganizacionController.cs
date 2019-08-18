using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaVueltasAsi.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DaVueltasAsi.Controllers
{
    [Route("api/controladora")]
    [ApiController]
    public class OrganizacionController : ControllerBase
    {
        private readonly OrganizacionContext _context;

        public OrganizacionController(OrganizacionContext context)
        {
            _context = context;

            if (_context.Organizaciones.Count() == 0)
            {
                _context.Organizaciones.Add(new Organizacion("12345", "Asicol", "Cra 24 # 43-87", "asicol@gmail.com",
                    "Discapacitados", "176242742625", "Bancolombia", "Débito", "Maria Perez"));
                _context.SaveChanges();

            }
        }

        // GET: api/Organizaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organizacion>>> consultarOrganizaciones()
        {
            return await _context.Organizaciones.ToListAsync();
        }

        // GET: api/Organizacion/1
        [HttpGet("{Nit}")]
        public async Task<ActionResult<Organizacion>> consultarOrganizacion(string Nit)
        {
            var organizacion = await _context.Organizaciones.FindAsync(Nit);

            if (organizacion == null)
            {
                return NotFound();
            }

            return organizacion;
        }

        // POST: api/ingresar
        [HttpPost]
        public async Task<ActionResult<Organizacion>> ingresarOrganizacion(Organizacion organizacion)
        {
            _context.Organizaciones.Add(organizacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(consultarOrganizacion), new { Nit = organizacion.Nit }, organizacion);
        }


    }
}
