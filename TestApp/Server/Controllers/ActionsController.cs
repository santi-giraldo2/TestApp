using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.Server.Data;
using TestApp.Server.Models;
using TestApp.Shared;

namespace TestApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ActionsController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        //Obtener el nombre completo de todas las personas insertadas
        [HttpGet("GetFullName")]
        public async Task<List<string>> GetFullName()
        {
            return await _context.Persons.Select(x => $"{x.FirstName} {x.LastName} {x.SecondLastName} {x.MiddleName}").ToListAsync();
        }

        //obtener la cantidad de mujeres que hay en la base de datos
        [HttpGet("GetWomen")]
        public async Task<int> GetWomen()
        {
            return await _context.Persons.Where(x => x.Gender == "F").CountAsync();
        }

        //obtener la cantidad de hombres que hay en la base de datos
        [HttpGet("GetMen")]
        public async Task<int> GetMen()
        {
            return await _context.Persons.Where(x => x.Gender == "M").CountAsync();
        }

        //obtener el promedio de edad de las personas
        [HttpGet("GetAverageAge")]
        public async Task<double> GetAverageAge()
        {
            return await _context.Persons.AverageAsync(x => x.Age);
        }

        //Obtener el nombre completo de la persona com mayor edad
        [HttpGet("GetOldestPerson")]
        public async Task<string?> GetOldestPerson()
        {
            return await _context.Persons.OrderByDescending(x => x.Age).Select(x => $"{x.FirstName} {x.LastName} {x.SecondLastName} {x.MiddleName}").FirstOrDefaultAsync();
        }
    }
}
