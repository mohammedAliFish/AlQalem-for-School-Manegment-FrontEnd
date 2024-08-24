using AlQalem.DTOs.Grade;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AlQalem.Exceptions.GradeExceptions;
using Microsoft.AspNetCore.Authorization;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Student")]
    public class GradesController : ControllerBase
    {
        private readonly InterfaceGradeService _gradeService;
        private readonly IMapper _mapper;

        public GradesController(InterfaceGradeService gradeService, IMapper mapper)
        {
            _gradeService = gradeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GradeDTO>>> GetGrades()
        {
            var grades = await _gradeService.GetGradesAsync();
            if (grades == null || !grades.Any())
            {
                throw new GradeNotFoundException("لم يتم العثور على درجات.");
            }
            return Ok(grades);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GradeDTO>> GetGrade(Guid id)
        {
            var grade = await _gradeService.GetGradeByIdAsync(id);

            if (grade == null)
            {
                throw new GradeNotFoundException();
            }

            return Ok(grade);
        }

        [HttpPost]
        public async Task<ActionResult<GradeDTO>> CreateGrade([FromForm] CreateGradeDTO createGradeDto)
        {
            if (!ModelState.IsValid)
            {
                throw new InvalidGradeDataException("بيانات الدرجة غير صالحة.");
            }


            var grade = _mapper.Map<GradeDTO>(createGradeDto);

            var createdGrade = await _gradeService.CreateGradeAsync(createGradeDto);

            
            var gradeDto = _mapper.Map<GradeDTO>(createdGrade);

            return CreatedAtAction(nameof(GetGrade), new { id = gradeDto.GradeId }, gradeDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGrade(Guid id, [FromForm] UpdateGradeDTO updateGradeDto)
        {
            if (id != updateGradeDto.GradeId)
            {
                throw new GradeIdMismatchException("تعارض في معرف الدرجة.");
            }


            var grade = _mapper.Map<Grade>(updateGradeDto);
            grade.GradeId = id;

            var updatedGrade = await _gradeService.UpdateGradeAsync(id, updateGradeDto);

            if (grade == null)
            {
                throw new GradeNotFoundException();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrade(Guid id)
        {
            await _gradeService.DeleteGradeAsync(id);
            return NoContent();
        }
       
    }
}
