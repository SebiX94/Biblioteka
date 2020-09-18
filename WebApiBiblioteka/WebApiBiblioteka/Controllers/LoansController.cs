using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBiblioteka.Models;

namespace WebApiBiblioteka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly LoansContext _context;
        

        public LoansController(LoansContext context)
        {
            _context = context;
            
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Loans>>> GetLoans()
        {
            return await _context.Loans.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Loans>> GetLoans(int id)
        {
            var loans = await _context.Loans.FindAsync(id);

            if (loans == null)
            {
                return NotFound();
            }

            return loans;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoans(int id, Loans loans)
        {
            if (id != loans.Id)
            {
                return BadRequest();
            }

            _context.Entry(loans).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoansExists(id))
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

        
        [HttpPost]
        public async Task<ActionResult<Loans>> PostLoans(Loans loans)
        {
            var LonedBook = BookIsLone(loans.IdBooks);
            if (LonedBook.Count>0)
            {
                loans.Id = -1;
                loans.DateOfLoan = LonedBook[0].DateOfLoan;
                loans.DateOfReturn = LonedBook[0].DateOfLoan.AddDays(14);
                var response = CreatedAtAction("GetLoans", new { id = loans.Id }, loans);
                response.StatusCode = 200;
                return response;
            }
            else
            {
                _context.Loans.Add(loans);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetLoans", new { id = loans.Id }, loans);
            }
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Loans>> DeleteLoans(int id)
        {
            var loans = await _context.Loans.FindAsync(id);
            if (loans == null)
            {
                return NotFound();
            }

            _context.Loans.Remove(loans) ;
            await _context.SaveChangesAsync();

            return loans;
        }

        private bool LoansExists(int id)
        {
            return _context.Loans.Any(e => e.Id == id);
        }
        private List<Loans> BookIsLone(int BookId)
        {
            return _context.Loans.Where(e => (e.DateOfReturn < e.DateOfLoan)&&(e.IdBooks == BookId)).ToList();
        }
        
    }
}
