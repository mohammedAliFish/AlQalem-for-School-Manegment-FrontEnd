using Microsoft.AspNetCore.Mvc;
using AlQalem.Enums;
using AlQalem.Models;
using AlQalem.DTOs.School;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly ISchoolService _schoolService;
        private readonly string _logoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "SchoolLogo");

        public SchoolsController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        // GET: api/schools
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchoolDTO>>> GetAllSchools()
        {
            var schools = await _schoolService.GetSchoolsAsync();
            return Ok(schools);
        }

        // GET: api/schools/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SchoolDTO>> GetSchoolById(Guid id)
        {
            var school = await _schoolService.GetSchoolByIdAsync(id);
            if (school == null)
            {
                return NotFound();
            }
            return Ok(school);
        }

        // POST: api/schools
        [HttpPost]
        public async Task<ActionResult<SchoolDTO>> CreateSchool([FromForm] CreateSchoolDTO schoolCreateDto)
        {
            try
            {
                // معالجة حفظ الشعار
                if (!Directory.Exists(_logoPath))
                    Directory.CreateDirectory(_logoPath);

                string fileName = String.Empty;

                if (schoolCreateDto.Logo != null && schoolCreateDto.Logo.Length > 0)
                {
                    fileName = Guid.NewGuid().ToString() + Path.GetExtension(schoolCreateDto.Logo.FileName);
                    var filePath = Path.Combine(_logoPath, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await schoolCreateDto.Logo.CopyToAsync(stream);
                    }
                }

                // إنشاء كائن المدرسة
                var schoolDto = new SchoolDTO
                {
                    Name = schoolCreateDto.Name,
                    Type = (SchoolType)schoolCreateDto.Type,

                    LogoPath = fileName
                };

                var createdSchool = await _schoolService.CreateSchoolAsync(schoolDto);

                return CreatedAtAction(nameof(GetSchoolById), new { id = createdSchool.SchoolId }, createdSchool);
            }
            catch (Exception ex)
            {
                return BadRequest($"حدث خطأ أثناء إنشاء المدرسة: {ex.Message}");
            }
        }

        // PUT: api/schools/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSchool(Guid id, [FromForm] UpdateSchoolDTO schoolUpdateDTO)
        {
            if (schoolUpdateDTO == null)
            {
                return BadRequest("بيانات المدرسة غير صالحة.");
            }

            var updatedSchool = await _schoolService.UpdateSchoolAsync(id, schoolUpdateDTO);

            if (updatedSchool == null)
            {
                return NotFound("لم يتم العثور على المدرسة.");
            }

            return NoContent();
        }

        // DELETE: api/schools/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchool(Guid id)
        {
            await _schoolService.DeleteSchoolAsync(id);
            return NoContent();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllSchoolsIncludingDeleted()
        {
            var schools = await _schoolService.GetAllSchoolsIncludingDeletedAsync();
            return Ok(schools);
        }


    }
}
