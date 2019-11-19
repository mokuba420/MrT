using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MRTshirtAPi.Api.Modles;
using MRTshirtAPi.Api.Data;
namespace MRTshirtAPi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TshirtController : ControllerBase
    {
        private readonly information _context;

        public TshirtController(information context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<TShirttable>> GetAll() =>
           _context.TShirttable.ToList();

        [HttpGet("{id}")]
        public async Task<ActionResult<TShirttable>> GetById(long id)
        {
            var product = await _context.TShirttable.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, TShirttable product)
        {
            if (id != product.ID)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<TShirttable>> Create(TShirttable product)
        {
            _context.TShirttable.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = product.ID }, product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var product = await _context.TShirttable.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.TShirttable.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}