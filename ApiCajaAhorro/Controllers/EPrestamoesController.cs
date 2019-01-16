using ApiCajaAhorro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCajaAhorro.Controllers
    {
    [EnableCors("MyPolicy")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EPrestamoesController : ControllerBase
        {
        private readonly CajaAhorroDBContext _context;

        public EPrestamoesController(CajaAhorroDBContext context)
            {
            _context = context;
            }

        // GET: api/EPrestamoes
        [HttpGet]
        public IEnumerable<EPrestamo> GetEPrestamo()
            {
            return _context.EPrestamo;
            }
        [HttpGet("[action]")]
        public IEnumerable<EPrestamo> GetPrestamosByTrabajador([FromQuery(Name = "idTrab")]int idTrab)
            {
            return _context.EPrestamo.Where(a=>a.FkTrabajador==idTrab);
            }


        // GET: api/EPrestamoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEPrestamo([FromRoute] int id)
            {
            if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }

            var ePrestamo = await _context.EPrestamo.FindAsync(id);

            if (ePrestamo == null)
                {
                return NotFound();
                }

            return Ok(ePrestamo);
            }



        // POST: api/EPrestamoes
        [HttpGet("[action]")]
        public async Task<IActionResult> AceptarPrestamo([FromQuery(Name = "IdTrabajador")]int IdTrabajador, [FromQuery(Name = "monto")]int monto)
            {
               if (monto <= 0)
                {
                return BadRequest("El monto del prestamo no puede ser igual o menor que 0");
                }

       
            EPrestamo ePrestamo = new EPrestamo()
                {
                FkTrabajador = IdTrabajador,
                Fecha = DateTime.Now,
                Monto = monto
                };

            if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }
            _context.EPrestamo.Add(ePrestamo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEPrestamo", new { id = ePrestamo.IdPrestamo }, ePrestamo);
            }


        }
    }