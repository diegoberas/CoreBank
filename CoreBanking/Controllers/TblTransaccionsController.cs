using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreBanking.Models;

namespace CoreBanking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblTransaccionsController : ControllerBase
    {
        private readonly DBCoreContext _context;

        public TblTransaccionsController(DBCoreContext context)
        {
            _context = context;
        }

        // GET: api/TblTransaccions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblTransaccion>>> GetTblTransaccion()
        {
            try
            {
                return await _context.TblTransaccion.ToListAsync();
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }
           
        }

        // GET: api/TblTransaccions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblTransaccion>> GetTblTransaccion(int id)
        {
            try
            {
                var tblTransaccion = await _context.TblTransaccion.FindAsync(id);

                if (tblTransaccion == null)
                {
                    return NotFound();
                }

                return tblTransaccion;
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }

        }

        // PUT: api/TblTransaccions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblTransaccion(int id, TblTransaccion tblTransaccion)
        {
            try
            {
                if (id != tblTransaccion.Id)
                {
                    return BadRequest();
                }

                _context.Entry(tblTransaccion).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblTransaccionExists(id))
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

        // POST: api/TblTransaccions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        
        [HttpPost]
        public async Task<ActionResult<TblTransaccion>> PostTblTransaccion(TblTransaccion tblTransaccion)
        {
            try
            {
                if (!_context.TblCuentas.Any(x => x.Id == tblTransaccion.IdCuentaEmisora))
                    return NotFound("La cuenta del emisor no existe.");

                if (!_context.TblCuentas.Any(x => x.Id == tblTransaccion.IdCuentaReceptora))
                    return NotFound("La cuenta del receptor no existe.");

                if (tblTransaccion.PrecioProducto < 1)
                    return NotFound("Debe suministrar una cantidad de dinero mayor a 1.");

                var senderAccount = _context.TblCuentas.SingleOrDefault(x => x.Id == tblTransaccion.IdCuentaEmisora);
                var receiverAccount = _context.TblCuentas.SingleOrDefault(x => x.Id == tblTransaccion.IdCuentaReceptora);

                if (senderAccount.Balance - tblTransaccion.PrecioProducto < 0)
                    return BadRequest("La cuenta emisora no tiene dinero suficiente para la transacción.");

                senderAccount.Balance -= tblTransaccion.PrecioProducto;
                receiverAccount.Balance += tblTransaccion.PrecioProducto;

                _context.TblTransaccion.Add(tblTransaccion);

                await _context.SaveChangesAsync();

                return CreatedAtAction("GetTblTransaccion", new { id = tblTransaccion.Id }, tblTransaccion);
            }
            catch (Exception ex)
            {
                return StatusCode(5001, ex);
            }

        }

        // DELETE: api/TblTransaccions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblTransaccion>> DeleteTblTransaccion(int id)
        {
            try
            {
                var tblTransaccion = await _context.TblTransaccion.FindAsync(id);
                if (tblTransaccion == null)
                {
                    return NotFound();
                }

                _context.TblTransaccion.Remove(tblTransaccion);
                await _context.SaveChangesAsync();

                return tblTransaccion;
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }
            
        }

        private bool TblTransaccionExists(int id)
        {
            return _context.TblTransaccion.Any(e => e.Id == id);
        }
    }
}
