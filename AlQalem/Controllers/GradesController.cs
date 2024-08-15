using AlQalem.DTOs.Grade;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly IGradeService _gradeService;
        private readonly IMapper _mapper;

        public GradesController(IGradeService gradeService, IMapper mapper)
        {
            _gradeService = gradeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GradeDTO>>> GetGrades()
        {
            var grades = await _gradeService.GetGradesAsync();
            return Ok(grades);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GradeDTO>> GetGrade(Guid id)
        {
            var grade = await _gradeService.GetGradeByIdAsync(id);

            if (grade == null)
            {
                return NotFound();
            }

            return Ok(grade);
        }

        [HttpPost]
        public async Task<ActionResult<GradeDTO>> CreateGrade([FromBody] CreateGradeDTO createGradeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
            var grade = _mapper.Map<GradeDTO>(createGradeDto);

            var createdGrade = await _gradeService.CreateGradeAsync(createGradeDto);

            
            var gradeDto = _mapper.Map<GradeDTO>(createdGrade);

            return CreatedAtAction(nameof(GetGrade), new { id = gradeDto.GradeId }, gradeDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGrade(Guid id, [FromBody] UpdateGradeDTO updateGradeDto)
        {
            if (id != updateGradeDto.GradeId)
            {
                return BadRequest("Grade ID mismatch.");
            }

            // استخدام AutoMapper لتحويل UpdateGradeDto إلى Grade
            var grade = _mapper.Map<Grade>(updateGradeDto);
            grade.GradeId = id;

            var updatedGrade = await _gradeService.UpdateGradeAsync(id, updateGradeDto);

            if (updatedGrade == null)
            {
                return NotFound("Grade not found.");
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
