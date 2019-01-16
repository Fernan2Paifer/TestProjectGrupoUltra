using ApiCajaAhorro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class EAhorroesController : ControllerBase
        {
        private readonly CajaAhorroDBContext _context;

        public EAhorroesController(CajaAhorroDBContext context)
            {
            _context = context;
            }

        // GET: api/EAhorroes
        [HttpGet]
        public IEnumerable<EAhorro> GetEAhorro()
            {
            return _context.EAhorro;
            }


        [HttpGet("[action]")]
        public IEnumerable<EAhorro> GetAhorrosByTrabajador([FromQuery(Name = "idTrab")]int idTrab)
            {
            return _context.EAhorro.Where(a => a.FkTrabajador == idTrab);
            }
        // GET: api/EAhorroes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEAhorro([FromRoute] int id)
            {
            if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }

            var eAhorro = await _context.EAhorro.FindAsync(id);

            if (eAhorro == null)
                {
                return NotFound();
                }

            return Ok(eAhorro);
            }
        [HttpGet("[action]")]
        public async Task<IActionResult> AddAhorro([FromQuery(Name = "IdTrabajador")]int IdTrabajador, [FromQuery(Name = "monto")]int monto)
            {
            if (monto <= 0)
                {
                return BadRequest("El monto del prestamo no puede ser igual o menor que 0");
                }


            EAhorro eAhorro = new EAhorro()
                {
                FkTrabajador = IdTrabajador,
                Fecha = DateTime.Now,
                Monto = monto
                };

            if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }

            if (!_context.EAhorro.Any(a => a.FkTrabajador == IdTrabajador))
                {

                var employee = await _context.ETrabajador.FindAsync(IdTrabajador);
                employee.MontoAinicial = monto;
                _context.Entry(employee).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                }


            _context.EAhorro.Add(eAhorro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAhorro", new { id = eAhorro.IdAhorro }, eAhorro);
            }
        // POST: api/EAhorroes
        [HttpPost("{idUser}/{monto}")]
        public async Task<IActionResult> PostEAhorro(string idUser, int monto)
            {
            if (string.IsNullOrEmpty(idUser))
                {
                return BadRequest("El id de usuario no pede ser vacio o nulo");
                }
            if (monto <= 0)
                {
                return BadRequest("El monto del ahorro no puede ser igual o menor que 0");
                }

            var employee = _context.ETrabajador.Where(a => a.FkUser == idUser);
            if (employee.Count() == 0)
                {
                return BadRequest("El id de usuario no existe");
                }
            EAhorro eAhorro = new EAhorro()
                {
                FkTrabajador = employee.FirstOrDefault().IdTrabajador,
                Fecha = DateTime.Now,
                Monto = monto
                };

            if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }

            _context.EAhorro.Add(eAhorro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEAhorro", new { id = eAhorro.IdAhorro }, eAhorro);
            }


        }
    }