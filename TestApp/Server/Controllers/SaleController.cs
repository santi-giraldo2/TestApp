using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using TestApp.Shared;
using TestApp.Server.Models;

namespace TestApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SaleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetByPerson/{IdPerson}")]
        public async Task<List<SaleDTO>> GetByPerson(int IdPerson)
        {
        Console.WriteLine(IdPerson);
            return await _context.Sales.Where(x => x.PersonId == IdPerson).Select(x =>
            new SaleDTO
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Total = x.Total,
                PersonId = x.PersonId,

            }).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<SaleDTO> Get(int id)
        {
            return await _context.Sales.Select(x =>
            new SaleDTO
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Total = x.Total,
                PersonId = x.PersonId,

            }).SingleAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(SaleDTO sale)
        {
            var model = new Sale
            {
                Name = sale.Name,
                Description = sale.Description,
                Total = sale.Total,
                PersonId = sale.PersonId,
            };

            _context.Add(model);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, SaleDTO sale)
        {
            if (id != sale.Id)
            {
                return BadRequest();
            }
            
            var model = await _context.Sales.FindAsync(id);
            if (model == null)
            {
                return BadRequest();
            }

            model.Name = sale.Name;
            model.Description = sale.Description;
            model.Total = sale.Total;
            model.PersonId = sale.PersonId;

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _context.Sales.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
            {
                return BadRequest();
            }

            _context.Remove(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
