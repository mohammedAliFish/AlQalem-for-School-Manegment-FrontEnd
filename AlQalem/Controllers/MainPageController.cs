using Microsoft.AspNetCore.Mvc;
using AlQalem.Data;
using Microsoft.EntityFrameworkCore;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainPageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MainPageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMainPageData()
        {
            var numberOfClasses = await _context.Classes.CountAsync();
            var numberOfStudents = await _context.Students.CountAsync();
            var numberOfTeachers = await _context.Teachers.CountAsync();

            var result = new
            {
                NumberOfClasses = numberOfClasses,
                NumberOfStudents = numberOfStudents,
                NumberOfTeachers = numberOfTeachers
            };

            return Ok(result);
        }
    }
}
