using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DaVueltasFin.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DaVueltasFin.Controllers
{
    [Route("api/controladora")]
    [ApiController]
    public class Controladora : ControllerBase
    {
        private readonly Contexto _context;

        public Controladora(Contexto context)
        {
            _context = context;


            if (_context.tarjetas.Count() == 0)
            {
                _context.tarjetas.Add(new Tarjeta( "123456789", true));
                _context.SaveChanges();
            }

            if (_context.cuentasBancarias.Count() == 0)
            {
                _context.cuentasBancarias.Add(new CuentaBancaria("987654321"));
                _context.SaveChanges();
            }

            if (_context.donaciones.Count() == 0)
            {
                _context.donaciones.Add(new Donacion("1",130, "123456789","987654321" ));
                _context.SaveChanges();
            }
        }

        // GET: api/Tarjeta
        [HttpGet]
        [Route("Tarjeta")]
        public async Task<ActionResult<IEnumerable<Tarjeta>>> GetTarjeta()
        {
            return await _context.tarjetas.ToListAsync();
        }

        // GET: api/Tarjeta/123456789
        [HttpGet]
        [Route("Tarjeta/{numero}")]
        public async Task<ActionResult<Tarjeta>> GetTarjeta(string numero)
        {
            
            var tarjeta = await _context.tarjetas.FindAsync(numero);

            if (tarjeta == null)
            {
                return NotFound();
            }

            return tarjeta;
        }

        // GET: api/CuentaBancaria
        [HttpGet]
        [Route("Cuenta")]
        public async Task<ActionResult<IEnumerable<CuentaBancaria>>> GetCuentaBancaria()
        {
            return await _context.cuentasBancarias.ToListAsync();
        }

        // GET: api/CuentaBancaria/987654321
        [HttpGet]
        [Route("Cuenta/{numero}")]
        public async Task<ActionResult<CuentaBancaria>> GetCuentaBancaria(string numero)
        {
            var cuentasBancaria = await _context.cuentasBancarias.FindAsync(numero);

            if (cuentasBancaria == null)
            {
                return NotFound();
            }

            return cuentasBancaria;
        }


        // GET: api/Donacion
        [HttpGet]
        [Route("Donacion")]
        public async Task<ActionResult<IEnumerable<Donacion>>> GetDonacion()
        {
            return await _context.donaciones.ToListAsync();
        }

        // GET: api/Donacion/1
        [HttpGet]
        [Route("Donacion/{codigo}")]
        public async Task<ActionResult<Donacion>> GetDonacion(string codigo)
        {
            var donacion = await _context.donaciones.FindAsync(codigo);

            if (donacion == null)
            {
                return NotFound();
            }

            return donacion;
        }

        // POST: api/Donacion
        [HttpPost]
        public async Task<ActionResult<Donacion>> PostDonacion(Donacion donacion)
        {
            _context.donaciones.Add(donacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDonacion), new { valor = donacion.valor, numeroTarjetaBenefactor = donacion.numeroTarjetaBenefactor, numeroCuentaBeneficiario = donacion.numeroCuentaBeneficiario }, donacion);
        }

        public static 


    }
}
