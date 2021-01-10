using MfpcProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MfpcProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalibratorsController : ControllerBase
    {
        private readonly FarmaContext _context;

        public CalibratorsController(FarmaContext context)
        {
            _context = context;
        }

        // GET: api/Calibrators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Calibrator>>> GetCalibrators()
        {
            return await _context.Calibrators.ToListAsync();
        }

        // GET: api/Calibrators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Calibrator>> GetCalibrator(int id)
        {
            var calibrator = await _context.Calibrators.FindAsync(id);

            if (calibrator == null)
            {
                return NotFound();
            }

            return calibrator;
        }

        // PUT: api/Calibrators/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalibrator(int id, Calibrator calibrator)
        {
            if (id != calibrator.Id)
            {
                return BadRequest();
            }

            _context.Entry(calibrator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalibratorExists(id))
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

        // POST: api/Calibrators
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Calibrator>> PostCalibrator(Calibrator calibrator)
        {
            _context.Calibrators.Add(calibrator);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCalibrator), new { id = calibrator.Id }, calibrator);
        }

        // DELETE: api/Calibrators/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCalibrator(int id)
        {
            var calibrator = await _context.Calibrators.FindAsync(id);
            if (calibrator == null)
            {
                return NotFound();
            }

            _context.Calibrators.Remove(calibrator);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CalibratorExists(int id)
        {
            return _context.Calibrators.Any(e => e.Id == id);
        }
    }
}
