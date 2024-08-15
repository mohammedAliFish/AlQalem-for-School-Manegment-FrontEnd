using AlQalem.DTOs.Class;
using AlQalem.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassesController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassDTO>>> GetClasses()
        {
            var classes = await _classService.GetAllClassesAsync();
            return Ok(classes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClassDTO>> GetClassById(Guid id)
        {
            var classDto = await _classService.GetClassByIdAsync(id);

            if (classDto == null)
            {
                return NotFound();
            }

            return Ok(classDto);
        }

        [HttpPost]
        public async Task<ActionResult<ClassDTO>> CreateClass([FromBody] CreateClassDTO createClassDto)
        {
            if (createClassDto == null)
            {
                return BadRequest("بيانات الصف غير صالحة.");
            }

            var createdClass = await _classService.CreateClassAsync(createClassDto);
            return CreatedAtAction(nameof(GetClassById), new { id = createdClass.ClassId }, createdClass);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClass(Guid id, [FromBody] UpdateClassDTO updateClassDTO)
        {
            if (id != updateClassDTO.ClassId)
            {
                return BadRequest("Class ID mismatch.");
            }

            var updatedClass = await _classService.UpdateClassAsync(id, updateClassDTO);

            if (updatedClass == null)
            {
                return NotFound("Class not found.");
            }

            return NoContent();
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(Guid id)
        {
            await _classService.DeleteClassAsync(id);
            return NoContent();
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllSchoolsIncludingDeleted()
        {
            var classes = await _classService.GetAllClassesIncludingDeletedAsync();
            return Ok(classes);
        }
    }
}
