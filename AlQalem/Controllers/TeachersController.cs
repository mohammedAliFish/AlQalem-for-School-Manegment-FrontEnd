using AlQalem.DTOs.Teacher;
using AlQalem.Exceptions;
using AlQalem.Exceptions.TeacherExceptions;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherDTO>>> GetTeachers()
        {
            var teachers = await _teacherService.GetTeachersAsync();
            var teacherDTOs = _mapper.Map<IEnumerable<TeacherDTO>>(teachers);
            return Ok(teacherDTOs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherDTO>> GetTeacher(Guid id)
        {
            var teacher = await _teacherService.GetTeacherByIdAsync(id);
            if (teacher == null)
            {
                throw new TeacherNotFoundException();
            }

            var teacherDTO = _mapper.Map<TeacherDTO>(teacher);
            return Ok(teacherDTO);
        }

        [HttpPost]

        public async Task<IActionResult> CreateTeacher([FromBody] CreateTeacherDTO createTeacherDTO)
        {

            if (!ModelState.IsValid)
            {
                throw new InvalidModelStateException();
            }


            var userExists = await _teacherService.CheckIfUserExistsAsync(createTeacherDTO.UserId);
            if (!userExists)
            {
                throw new UserIdNotFoundException();
            }

            var teacherDTO = await _teacherService.CreateTeacherAsync(createTeacherDTO);
            return CreatedAtAction(nameof(GetTeacher), new { id = teacherDTO.TeacherId }, teacherDTO);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeacher(Guid id, [FromBody] UpdateTeacherDTO updateTeacherDTO)
        {
            if (id != updateTeacherDTO.TeacherId)
            {
                throw new MismatchedTeacherIdException();
            }

            if (!ModelState.IsValid)
            {
                throw new InvalidModelStateException();
            }

            var teacher = await _teacherService.GetTeacherByIdAsync(id);
            if (teacher == null)
            {
                throw new TeacherNotFoundException();
            }

            var updatedTeacher = await _teacherService.UpdateTeacherAsync(id, updateTeacherDTO); 

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacher(Guid id)
        {
            var teacher = await _teacherService.GetTeacherByIdAsync(id);
            if (teacher == null)
            {
                throw new TeacherNotFoundException();
            }

            await _teacherService.DeleteTeacherAsync(id);
            return NoContent();
        }

       
    }
}
