using FinallyProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinallyProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CitiesController(AppDbContext context)
        {
            _context = context;
        }
        // GET: 
        [HttpGet]
        [Route("GetCity")]
        public ActionResult<List<City>> GetCities()
        {
            return _context.Cities.ToList();
        }

        //[HttpGet]
        //[Route("GetCity")]
        //public IEnumerable<string> GetCities()
        //{
        //    var cities = _context.Cities.Select(c => c.Name).ToList();
        //       return Ok(cities);
        //}
    }
}
