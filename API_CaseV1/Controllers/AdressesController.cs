using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_CaseV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {
        private readonly DBInteractor _context;

        public AdressesController(DBInteractor context)
        {
            _context = context;
        }

        // GET: api/Adresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adressen>>> GetAdressen()
        {
          if (_context.Adressen == null)
          {
              return NotFound();
          }
            return await _context.Adressen.ToListAsync();
        }

        // GET: api/Adresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Adressen>> GetAdressen(long id)
        {
          if (_context.Adressen == null)
          {
              return NotFound();
          }
            var adressen = await _context.Adressen.FindAsync(id);

            if (adressen == null)
            {
                return NotFound();
            }

            return adressen;
        }

        // PUT: api/Adresses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdressen(long id, Adressen adressen)
        {
            if (id != adressen.Id)
            {
                return BadRequest();
            }

            _context.Entry(adressen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdressenExists(id))
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

        // POST: api/Adresses
        [HttpPost]
        public async Task<ActionResult<Adressen>> PostAdressen(Adressen adressen)
        {
          if (_context.Adressen == null)
          {
              return Problem("Entity set 'DBInteractor.Adressen'  is null.");
          }
            _context.Adressen.Add(adressen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdressen", new { id = adressen.Id }, adressen);
        }

        // DELETE: api/Adresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdressen(long id)
        {
            if (_context.Adressen == null)
            {
                return NotFound();
            }
            var adressen = await _context.Adressen.FindAsync(id);
            if (adressen == null)
            {
                return NotFound();
            }

            _context.Adressen.Remove(adressen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdressenExists(long id)
        {
            return (_context.Adressen?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
