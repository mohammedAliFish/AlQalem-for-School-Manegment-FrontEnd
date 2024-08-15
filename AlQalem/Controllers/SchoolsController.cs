using Microsoft.AspNetCore.Mvc;

using AlQalem.Models;
using AlQalem.DTOs.School;
using AutoMapper;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly InterfaceSchoolService _schoolService;
        private readonly IMapper _mapper;
        private readonly string _logoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "SchoolLogo");

        public SchoolsController(InterfaceSchoolService schoolService, IMapper mapper)
        {
            _schoolService = schoolService;
            _mapper = mapper;
        }

        
        [HttpGet("allSchool")]
        public async Task<ActionResult<IEnumerable<SchoolDTO>>> GetAllSchools()
        {
            var schools = await _schoolService.GetSchoolsAsync();
            var schoolDtos = _mapper.Map<IEnumerable<SchoolDTO>>(schools);
            return Ok(schoolDtos);
        }

        
        [HttpGet("schoolId{id}")]
        public async Task<ActionResult<SchoolDTO>> GetSchoolById(Guid id)
        {
            var school = await _schoolService.GetSchoolByIdAsync(id);
            if (school == null)
            {
                return NotFound();
            }
            var schoolDto = _mapper.Map<SchoolDTO>(school);
            return Ok(schoolDto);
        }

        
        [HttpPost("createSchool")]
        public async Task<ActionResult<SchoolDTO>> CreateSchool([FromForm] CreateSchoolDTO schoolCreateDto)
        {
            try
            {
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

                
                var schoolDto = _mapper.Map<SchoolDTO>(schoolCreateDto);
                schoolDto.LogoPath = fileName;

                
                var createdSchoolDto = await _schoolService.CreateSchoolAsync(schoolDto);

                return CreatedAtAction(nameof(GetSchoolById), new { id = createdSchoolDto.SchoolId }, createdSchoolDto);
            }
            catch (Exception ex)
            {
                return BadRequest($"حدث خطأ أثناء إنشاء المدرسة: {ex.Message}");
            }
        }



        
        [HttpPut("updateSchool{id}")]
        public async Task<IActionResult> UpdateSchool(Guid id, [FromForm] UpdateSchoolDTO schoolUpdateDTO)
        {
            if (schoolUpdateDTO == null)
            {
                return BadRequest("بيانات المدرسة غير صالحة.");
            }

            var schoolEntity = _mapper.Map<School>(schoolUpdateDTO);
            var updatedSchool = await _schoolService.UpdateSchoolAsync(id, schoolUpdateDTO);

            if (updatedSchool == null)
            {
                return NotFound("لم يتم العثور على المدرسة.");
            }

            return NoContent();
        }

        
        [HttpDelete("delete{id}")]
        public async Task<IActionResult> DeleteSchool(Guid id)
        {
            await _schoolService.DeleteSchoolAsync(id);
            return NoContent();
        }

        [HttpGet("allSchoolEvenDeleted")]
        public async Task<IActionResult> GetAllSchoolsIncludingDeleted()
        {
            var schools = await _schoolService.GetAllSchoolsIncludingDeletedAsync();
            var schoolDtos = _mapper.Map<IEnumerable<SchoolDTO>>(schools);
            return Ok(schoolDtos);
        }
    }
}
