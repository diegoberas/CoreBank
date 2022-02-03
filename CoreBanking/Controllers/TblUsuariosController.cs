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
    public class TblUsuariosController : ControllerBase
    {
        private readonly DBCoreContext _context;

        public TblUsuariosController(DBCoreContext context)
        {
            _context = context;
        }

        // GET: api/TblUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblUsuarios>>> GetTblUsuarios()
        {
            try
            {
                return await _context.TblUsuarios.ToListAsync();
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }
          
        }

        // GET: api/TblUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblUsuarios>> GetTblUsuarios(int id)
        {
            try
            {
                var tblUsuarios = await _context.TblUsuarios.FindAsync(id);

                if (tblUsuarios == null)
                {
                    return NotFound();
                }

                return tblUsuarios;
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }

        }

        // PUT: api/TblUsuarios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblUsuarios(int id, TblUsuarios tblUsuarios)
        {
            try
            {
                if (id != tblUsuarios.Id)
                {
                    return BadRequest();
                }

                _context.Entry(tblUsuarios).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblUsuariosExists(id))
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

        // POST: api/TblUsuarios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblUsuarios>> PostTblUsuarios(TblUsuarios tblUsuarios)
        {
            try
            {
                _context.TblUsuarios.Add(tblUsuarios);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetTblUsuarios", new { id = tblUsuarios.Id }, tblUsuarios);
            }
            catch (Exception ex)
            {
                return StatusCode(5001, ex);
            }

        }

        // DELETE: api/TblUsuarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblUsuarios>> DeleteTblUsuarios(int id)
        {
            try
            {
                var tblUsuarios = await _context.TblUsuarios.FindAsync(id);
                if (tblUsuarios == null)
                {
                    return NotFound();
                }

                _context.TblUsuarios.Remove(tblUsuarios);
                await _context.SaveChangesAsync();

                return tblUsuarios;
            }
            catch (Exception ex)
            {
                return StatusCode(5001, ex);
            }
            
        }

        private bool TblUsuariosExists(int id)
        {
            return _context.TblUsuarios.Any(e => e.Id == id);
        }
    }
}
