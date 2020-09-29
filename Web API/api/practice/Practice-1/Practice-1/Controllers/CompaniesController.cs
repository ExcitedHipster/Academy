using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice_1;
using Practice_1.Models;

namespace Practice_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly CompanyDbContext _context;

        public CompaniesController(CompanyDbContext context)
        {
            _context = context;
        }

        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> Get()
        {            
            return await _context.Companies.ToListAsync();
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> Get(int id)
        {
            var Company = await _context.Companies.FindAsync(id);

            Company.Emploies = await _context.Emploies.Where(x=>x.CompanyId==id).ToListAsync();


            if (Company == null)
            {
                return NotFound();
            }

            return Company;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Company Company)
        {
            if (id != Company.Id)
            {
                return BadRequest();
            }

            _context.Entry(Company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(id))
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
        public async Task<ActionResult<Company>> Post(Company Company)
        {
            _context.Companies.Add(Company);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = Company.Id }, Company);
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Company>> Delete(int id)
        {
            var Company = await _context.Companies.FindAsync(id);
            if (Company == null)
            {
                return NotFound();
            }

            _context.Companies.Remove(Company);
            await _context.SaveChangesAsync();

            return Company;
        }
        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.Id == id);
        }
    }
}
