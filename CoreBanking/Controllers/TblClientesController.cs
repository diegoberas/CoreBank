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
    public class TblClientesController : ControllerBase
    {
        private readonly DBCoreContext _context;

        public TblClientesController(DBCoreContext context)
        {
            _context = context;
        }

        // GET: api/TblClientes
        [HttpGet("GetTblClientes")]
        public async Task<ActionResult<IEnumerable<TblClientes>>> GetTblClientes()
        {
            try
            {
                return await _context.TblClientes.ToListAsync();
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }
            
        }

        // GET: api/TblClientes/5
        [HttpGet("GetTblClientesId")]
        public async Task<ActionResult<TblClientes>> GetTblClientesId(int id)
        {
            try
            {
                var tblClientes = await _context.TblClientes.FindAsync(id);

                if (tblClientes == null)
                {
                    return NotFound();
                }

                return tblClientes;
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }

        }


        [HttpPut("PutTblClientes")]
        public async Task<IActionResult> PutTblClientes(string cedula, TblClientes tblClientes)
        {
            try
            {
                if (cedula != tblClientes.Cedula)
                {
                    return BadRequest();
                }

                _context.Entry(tblClientes).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblClientesExists(cedula))
                    {
                        return NotFound();
                    }
                    else
                    {
                       
                    }
                }

                return NoContent();
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }
          
        }

     
        [HttpPost("PostTblClientes")]
        public async Task<ActionResult<TblClientes>> PostTblClientes(TblClientes tblClientes)
        {
            try
            {
                _context.TblClientes.Add(tblClientes);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetTblClientes", new { id = tblClientes.Id }, tblClientes);
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }

        }


        [HttpDelete("DeleteTblClientes")]
        public async Task<ActionResult<TblClientes>> DeleteTblClientes(int id)
        {
            try
            {
                var tblClientes = await _context.TblClientes.FindAsync(id);
                if (tblClientes == null)
                {
                    return NotFound();
                }

                _context.TblClientes.Remove(tblClientes);
                await _context.SaveChangesAsync();

                return tblClientes;
            }
            catch (Exception ex)
            {

                return StatusCode(5001, ex);
            }
          
        }

        private bool TblClientesExists(string cedula)
        {
            return _context.TblClientes.Any(e => e.Cedula == cedula);
        }
    }
}
