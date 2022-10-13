using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.Server.Data;
using TestApp.Server.Models;
using TestApp.Shared;

namespace TestApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IEnumerable<PersonDTO>> Get()
        {
            return await _context.Persons.Select(x =>
            new PersonDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                SecondLastName = x.SecondLastName,
                Email = x.Email,
                Address = x.Address,
                Age = x.Age,
                Gender = x.Gender,
                Phone = x.Phone
            }).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<PersonDTO> Get(int id)
        {
            return await _context.Persons.Select(x =>
            new PersonDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                SecondLastName = x.SecondLastName,
                Email = x.Email,
                Address = x.Address,
                Age = x.Age,
                Gender = x.Gender,
                Phone = x.Phone
            }).SingleAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonDTO person)
        {
            Person model = new()
            {
                FirstName = person.FirstName,
                MiddleName = person.MiddleName,
                LastName = person.LastName,
                SecondLastName = person.SecondLastName,
                Email = person.Email,
                Address = person.Address,
                Age = person.Age,
                Gender = person.Gender,
                Phone = person.Phone
            };
            _context.Add(model);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PersonDTO person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }

            Person model = await _context.Persons.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            model.FirstName = person.FirstName;
            model.MiddleName = person.MiddleName;
            model.LastName = person.LastName;
            model.SecondLastName = person.SecondLastName;
            model.Email = person.Email;
            model.Address = person.Address;
            model.Age = person.Age;
            model.Gender = person.Gender;
            model.Phone = person.Phone;

            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _context.Persons.FirstOrDefaultAsync(x => x.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(model);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
