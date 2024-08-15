using AlQalem.DTOs.Student;
using AlQalem.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly InterfaceStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentsController(InterfaceStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        [HttpGet("allStudents")]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetStudents()
        {
            var students = await _studentService.GetStudentsAsync();
            var studentDtos = _mapper.Map<IEnumerable<StudentDTO>>(students);
            return Ok(studentDtos);
        }

        [HttpGet("allStudentEvenDeleted")]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetAllStudents()
        {
            var students = await _studentService.GetAllStudentsAsync();
            var studentDtos = _mapper.Map<IEnumerable<StudentDTO>>(students);
            return Ok(studentDtos);
        }

        [HttpGet("studentId{id}")]
        public async Task<ActionResult<StudentDTO>> GetStudent(Guid id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            var studentDto = _mapper.Map<StudentDTO>(student);
            return Ok(studentDto);
        }

        [HttpPost("createStudent")]
        public async Task<ActionResult<StudentDTO>> CreateStudent([FromBody] CreateStudentDto createStudentDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = _mapper.Map<Student>(createStudentDto);
            var createdStudent = await _studentService.CreateStudentAsync(createStudentDto);
            var createdStudentDto = _mapper.Map<StudentDTO>(createdStudent);

            return CreatedAtAction(nameof(GetStudent), new { id = createdStudentDto.StudentId }, createdStudentDto);
        }

        [HttpPut("updateStudent{id}")]
        public async Task<IActionResult> UpdateStudent(Guid id, [FromBody] UpdateStudentDTO updateStudentDTO)
        {
            if (id != updateStudentDTO.StudentId)
            {
                return BadRequest("Student ID mismatch.");
            }

            var student = _mapper.Map<Student>(updateStudentDTO);
            var updatedStudent = await _studentService.UpdateStudentAsync(id, updateStudentDTO);

            if (updatedStudent == null)
            {
                return NotFound("Student not found.");
            }

            return NoContent();
        }

        [HttpDelete("delete{id}")]
        public async Task<IActionResult> DeleteStudent(Guid id)
        {
            await _studentService.DeleteStudentAsync(id);
            return NoContent();
        }
    }
}
