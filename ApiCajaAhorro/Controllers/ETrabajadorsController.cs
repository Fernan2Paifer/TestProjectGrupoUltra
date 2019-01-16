using ApiCajaAhorro.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCajaAhorro.Controllers
    {
    [EnableCors("MyPolicy")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ETrabajadorsController : ControllerBase
        {
        private readonly CajaAhorroDBContext _context;

        public ETrabajadorsController(CajaAhorroDBContext context)
            {
            _context = context;
            }

        // GET: api/ETrabajadors
        [HttpGet]
        public IEnumerable<ETrabajador> GetETrabajador()
            {

            return _context.ETrabajador;
            }

        // GET: api/ETrabajadors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetETrabajador([FromRoute] int id)
            {


            if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }

            var eTrabajador = await _context.ETrabajador.FindAsync(id);

            if (eTrabajador == null)
                {
                return NotFound();
                }
            return Ok(eTrabajador);
            }

        [HttpGet("[action]")]
        public IActionResult ReporteTrabajadores()
            {
            var ListResult = new List<object>();
            var allworkers = _context.ETrabajador.ToList();

            foreach (var item in allworkers)
                {

                var result = new
                    {
                    employee = item,
                    antiguedad = (DateTime.Now - item.FechaInicioRl.Value).Days / 365,
                    montoAhorrado = _context.EAhorro.Where(a => a.FkTrabajador == item.IdTrabajador).Sum(a => a.Monto)
                    };
                ListResult.Add(result);
                }
         
            return Ok(ListResult);
            }

        [HttpGet("[action]")]
        public IActionResult Trabajadores([FromQuery(Name = "from")] int from = 0, [FromQuery(Name = "to")] int to = 4)
            {
            var quantity = to - from;

            if (quantity <= 0)
                {
                return BadRequest("El parámetro 'to' no puede ser mayor que el parámetro 'from'.");
                }

            if (from < 0)
                {
                return BadRequest("El paramtro 'from' no puede ser negativo");
                }

            var allworkers = _context.ETrabajador.ToList();
            var result = new
                {
                Total = allworkers.Count,
                Workers = allworkers.Skip(from).Take(quantity).ToArray()
                };

            return Ok(result);
            }


        [HttpGet("InscribirTrabajador/{id}")]
        public async Task<IActionResult> InscribirTrabajador([FromRoute] int id)
            {

            if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }

            var employee = await _context.ETrabajador.FindAsync(id);
            employee.Inscrito = true;
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            if (employee == null)
                {
                return NotFound();
                }
            return Ok(employee);
            }

        [HttpGet("SolicitarPrestamo/{IdTrabajador}/{monto}")]
        public IActionResult SolicitarPrestamo([FromRoute] int IdTrabajador, int monto)
            {
            var sqlConection = (SqlConnection)_context.Database.GetDbConnection();
            var command = new SqlCommand("Solicitarprestamo", sqlConection)
                {
                CommandType = System.Data.CommandType.StoredProcedure
                };
            command.Parameters.AddWithValue("IdTrabajador", IdTrabajador);
            command.Parameters.AddWithValue("Monto", monto);
            sqlConection.Open();

            var montoAprobado = command.ExecuteScalar();//aqui se devuelve el resultado del procedimiento d almacenado Solicitarprestamo
            sqlConection.Close();

            return Ok(montoAprobado);//se envia al cliente 0 si no es aprobada dado que tiene menos de un año de antiguedad, su monto si esta en alguna de las categorias y 
            }//*********************//cummple con la antiguedad y el maximo de la categoria cuando su monto excede a la categoria que le corresponde por su antiguedad


        }
    }