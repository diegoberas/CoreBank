using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreBanking.Models;
using CoreBanking.Dto;

namespace CoreBanking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPrestamosController : ControllerBase
    {
        private readonly DBCoreContext _context;

        public TblPrestamosController(DBCoreContext context)
        {
            _context = context;
        }

        // GET: api/TblPrestamos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblPrestamos>>> GetTblPrestamos()
        {
            try
            {
                return await _context.TblPrestamos.ToListAsync();
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex); 
            }
        
        }

        // GET: api/TblPrestamos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPrestamos>> GetTblPrestamos(int id)
        {
            try
            {
                var tblPrestamos = await _context.TblPrestamos.FindAsync(id);

                if (tblPrestamos == null)
                {
                    return NotFound();
                }

                return tblPrestamos;
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }

        }

        // PUT: api/TblPrestamos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPrestamos(int id, TblPrestamos tblPrestamos)
        {
            try
            {
                if (id != tblPrestamos.Id)
                {
                    return BadRequest();
                }

                _context.Entry(tblPrestamos).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblPrestamosExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }
          
        }

        // POST: api/TblPrestamos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
            [HttpPost]
            public async Task<ActionResult<TblPrestamos>> PostTblPrestamos(TblPrestamos tblPrestamos)
            {
                try
                {
                    tblPrestamos.CantidadFaltante = tblPrestamos.CantidadSolicitada;

                    _context.TblPrestamos.Add(tblPrestamos);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction("GetTblPrestamos", new { id = tblPrestamos.Id }, tblPrestamos);
                }
                catch (Exception ex)
                {

                    return StatusCode(5001, ex);
                }

            }

        

        // DELETE: api/TblPrestamos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblPrestamos>> DeleteTblPrestamos(int id)
        {
            try
            {
                var tblPrestamos = await _context.TblPrestamos.FindAsync(id);
                if (tblPrestamos == null)
                {
                    return NotFound();
                }

                _context.TblPrestamos.Remove(tblPrestamos);
                await _context.SaveChangesAsync();

                return tblPrestamos;
            }
            catch (Exception ex)
            {
                return StatusCode(5001, ex);
            }
           
        }

        [HttpGet("{cedula}")]
        public async Task<ActionResult<List<TblPrestamos>>> GetTblPrestamos(string cedula)
        {
            try
            {
                var tblPrestamos = await _context.TblPrestamos.Where(e => e.Cedula == cedula).ToListAsync();

                if (tblPrestamos == null)
                {
                    return NotFound();
                }

                return tblPrestamos;
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }

        }
        private bool TblPrestamosExists(int id)
        {
            return _context.TblPrestamos.Any(e => e.Id == id);
        }

        [HttpPost("PayPrestamo")]
        public async Task<IActionResult> PayPrestamo([FromBody] PagarPrestamoDto input)
        {
            try
            {
                var loan = _context.TblPrestamos.SingleOrDefault(p => p.Id == input.PrestamoId);

                if (loan == null)
                    return BadRequest("Préstamo no existente.");

                if (input.Cantidad < 1)
                    return BadRequest("Debe indicar una cantidad a pagar positiva.");

                if (loan.CantidadFaltante == 0)
                    return BadRequest("El prestamo indicado ya está pagado");

                if (loan.CantidadFaltante - input.Cantidad < 0)
                    return BadRequest("La cantidad a pagar sobre pasa la cantidad faltante, debe pagar menos");

                loan.CantidadFaltante -= input.Cantidad;

                await _context.SaveChangesAsync();

                return Ok(loan);
            }
            catch (Exception ex)
            {
                return StatusCode(5001, ex);
            }
        }


    }
}
