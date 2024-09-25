using AlQalem.DTOs.Teacher;
using AlQalem.Exceptions;
using AlQalem.Exceptions.TeacherExceptions;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
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
        public async Task<ActionResult<TeacherDTO>> CreateTeacher([FromBody] CreateTeacherDTO createTeacherDTO)
        {
            

            var teacherDTO = await _teacherService.CreateTeacherAsync(createTeacherDTO);

         
            return CreatedAtAction(nameof(GetTeacher), new { id = teacherDTO.TeacherId }, teacherDTO);
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTeacher(Guid id, [FromBody] UpdateTeacherDTO updateTeacherDTO)
        {
           

            

            var teacher = await _teacherService.GetTeacherByIdAsync(id);
           

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
