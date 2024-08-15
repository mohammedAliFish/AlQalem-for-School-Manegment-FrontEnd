using AlQalem.DTOs.Teacher;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly InterfaceTeacherService _teacherService;
        private readonly IMapper _mapper;

        public TeachersController(InterfaceTeacherService teacherService, IMapper mapper)
        {
            _teacherService = teacherService;
            _mapper = mapper;
        }

        [HttpGet("allTeachers")]
        public async Task<ActionResult<IEnumerable<TeacherDTO>>> GetTeachers()
        {
            var teachers = await _teacherService.GetAllTeachersAsync();
            var teacherDTOs = _mapper.Map<IEnumerable<TeacherDTO>>(teachers);
            return Ok(teacherDTOs);
        }

        [HttpGet("teacherId{id}")]
        public async Task<ActionResult<TeacherDTO>> GetTeacher(Guid id)
        {
            var teacher = await _teacherService.GetTeacherByIdAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            var teacherDTO = _mapper.Map<TeacherDTO>(teacher);
            return Ok(teacherDTO);
        }

        [HttpPost("createTeacher")]

        public async Task<IActionResult> CreateTeacher([FromBody] CreateTeacherDTO createTeacherDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
            var userExists = await _teacherService.CheckIfUserExistsAsync(createTeacherDTO.UserId);
            if (!userExists)
            {
                return BadRequest("UserId does not exist.");
            }

            var teacherDTO = await _teacherService.CreateTeacherAsync(createTeacherDTO);
            return CreatedAtAction(nameof(GetTeacher), new { id = teacherDTO.TeacherId }, teacherDTO);
        }



        [HttpPut("updateId{id}")]
        public async Task<IActionResult> UpdateTeacher(Guid id, [FromBody] UpdateTeacherDTO updateTeacherDTO)
        {
            if (id != updateTeacherDTO.TeacherId)
            {
                return BadRequest("Mismatched Teacher Id");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var teacher = await _teacherService.GetTeacherByIdAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            var updatedTeacher = await _teacherService.UpdateTeacherAsync(id, updateTeacherDTO); 

            return NoContent();
        }


        [HttpDelete("deleteTeacher{id}")]
        public async Task<IActionResult> DeleteTeacher(Guid id)
        {
            var teacher = await _teacherService.GetTeacherByIdAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            await _teacherService.DeleteTeacherAsync(id);
            return NoContent();
        }

        [HttpGet("allTeacherEvenDeleted")]
        public async Task<IActionResult> GetAllTeachersAsync()
        {
            var teachers = await _teacherService.GetAllTeachersAsync();
            return Ok(teachers);
        }
    }
}
