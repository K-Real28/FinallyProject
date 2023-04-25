using FinallyProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinallyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecializationsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public SpecializationsController(AppDbContext context)
        {
            _context = context;
        }
        // GET: 
        [HttpGet]
        [Route("GetSpecialization")]
        public ActionResult<List<Specialization>> GetSpecializations()
        {
            return _context.Specializations.ToList();
        }
    }
}
