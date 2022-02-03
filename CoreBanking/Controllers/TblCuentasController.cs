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
    public class TblCuentasController : ControllerBase
    {
        private readonly DBCoreContext _context;

        public TblCuentasController(DBCoreContext context)
        {
            _context = context;
        }

        // GET: api/TblCuentas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblCuentas>>> GetTblCuentas()
        {
            try
            {
                return await _context.TblCuentas.ToListAsync();
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }
         
        }

        // GET: api/TblCuentas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCuentas>> GetTblCuentas(int id)
        {
            try
            {
                var tblCuentas = await _context.TblCuentas.FindAsync(id);

                if (tblCuentas == null)
                {
                    return NotFound();
                }

                return tblCuentas;
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }

        }

        // PUT: api/TblCuentas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCuentas(int id, TblCuentas tblCuentas)
        {
            try
            {
                if (id != tblCuentas.Id)
                {
                    return BadRequest();
                }

                _context.Entry(tblCuentas).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblCuentasExists(id))
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

        // POST: api/TblCuentas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCuentas>> PostTblCuentas(TblCuentas tblCuentas)
        {
            try
            {
                _context.TblCuentas.Add(tblCuentas);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetTblCuentas", new { id = tblCuentas.Id }, tblCuentas);
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }

        }

        // DELETE: api/TblCuentas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCuentas>> DeleteTblCuentas(int id)
        {
            try
            {
                var tblCuentas = await _context.TblCuentas.FindAsync(id);
                if (tblCuentas == null)
                {
                    return NotFound();
                }

                _context.TblCuentas.Remove(tblCuentas);
                await _context.SaveChangesAsync();

                return tblCuentas;
            }
            catch (Exception ex)
            {
                return StatusCode(5001, ex);
            }

        }

        private bool TblCuentasExists(int id)
        {
            return _context.TblCuentas.Any(e => e.Id == id);
        }
    }
}
