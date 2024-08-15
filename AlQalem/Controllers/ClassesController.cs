using AlQalem.DTOs.Class;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AlQalem.Models;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly InterfaceClassService _classService;
        private readonly IMapper _mapper;

        public ClassesController(InterfaceClassService classService, IMapper mapper)
        {
            _classService = classService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassDTO>>> GetClasses()
        {
            var classes = await _classService.GetAllClassesAsync();
            var classDtos = _mapper.Map<IEnumerable<ClassDTO>>(classes);
            return Ok(classDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClassDTO>> GetClassById(Guid id)
        {
            var classEntity = await _classService.GetClassByIdAsync(id);

            if (classEntity == null)
            {
                return NotFound();
            }

            var classDto = _mapper.Map<ClassDTO>(classEntity);
            return Ok(classDto);
        }

        [HttpPost]
        public async Task<ActionResult<ClassDTO>> CreateClass([FromBody] CreateClassDTO createClassDto)
        {
            if (createClassDto == null)
            {
                return BadRequest("بيانات الصف غير صالحة.");
            }

            var classEntity = _mapper.Map<Class>(createClassDto);
            var createdClass = await _classService.CreateClassAsync(createClassDto);

            var createdClassDto = _mapper.Map<ClassDTO>(createdClass);
            return CreatedAtAction(nameof(GetClassById), new { id = createdClassDto.ClassId }, createdClassDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClass(Guid id, [FromBody] UpdateClassDTO updateClassDTO)
        {
            if (id != updateClassDTO.ClassId)
            {
                return BadRequest("Class ID mismatch.");
            }

            var classEntity = _mapper.Map<Class>(updateClassDTO);
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
            var classDtos = _mapper.Map<IEnumerable<ClassDTO>>(classes);
            return Ok(classDtos);
        }
    }
}
