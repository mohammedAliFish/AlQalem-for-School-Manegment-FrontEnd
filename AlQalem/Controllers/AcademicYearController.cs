using Microsoft.AspNetCore.Mvc;
using AlQalem.Data;
using AlQalem.Models;

using Microsoft.EntityFrameworkCore;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicYearController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AcademicYearController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AcademicYear>>> GetAcademicYears()
        {
            var academicYears = await _context.AcademicYears.ToListAsync();
            return Ok(academicYears); 
        }
    }
}
