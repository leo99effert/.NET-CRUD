using Library_Leo_Effert.Data;
using Library_Leo_Effert.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Leo_Effert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookCustomersController : ControllerBase
    {
        private readonly Context _context;

        public BookCustomersController(Context context)
        {
            _context = context;
        }

        // GET: api/BookCustomers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookCustomer>>> GetBookCustomers()
        {
            return await _context.BookCustomers.ToListAsync();
        }

        // GET: api/BookCustomers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookCustomer>> GetBookCustomer(int id)
        {
            var bookCustomer = await _context.BookCustomers.FindAsync(id);

            if (bookCustomer == null)
            {
                return NotFound();
            }

            return bookCustomer;
        }

        // PUT: api/BookCustomers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookCustomer(int id, BookCustomer bookCustomer)
        {
            if (id != bookCustomer.Id)
            {
                return BadRequest();
            }

            _context.Entry(bookCustomer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookCustomerExists(id))
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

        // POST: api/BookCustomers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookCustomer>> PostBookCustomer(BookCustomer bookCustomer)
        {
            _context.BookCustomers.Add(bookCustomer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookCustomer", new { id = bookCustomer.Id }, bookCustomer);
        }

        // DELETE: api/BookCustomers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookCustomer(int id)
        {
            var bookCustomer = await _context.BookCustomers.FindAsync(id);
            if (bookCustomer == null)
            {
                return NotFound();
            }

            _context.BookCustomers.Remove(bookCustomer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookCustomerExists(int id)
        {
            return _context.BookCustomers.Any(e => e.Id == id);
        }
    }
}
