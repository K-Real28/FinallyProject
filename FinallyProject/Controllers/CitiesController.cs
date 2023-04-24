using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinallyProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        [Route("GetCity")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),

            })
            .ToArray();
        }
    }
}
