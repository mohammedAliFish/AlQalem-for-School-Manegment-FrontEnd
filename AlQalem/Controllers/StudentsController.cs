using AlQalem.DTOs.Student;
using AlQalem.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AlQalem.Exceptions.StudentExceptions;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetStudents()
        {
            var students = await _studentService.GetStudentsAsync();
            var studentDtos = _mapper.Map<IEnumerable<StudentDTO>>(students);
            return Ok(studentDtos);
        }

      

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDTO>> GetStudent(Guid id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);

            if (student == null)
            {
                throw new StudentNotFoundException("الطالب المطلوب غير موجود.");
            }

            var studentDto = _mapper.Map<StudentDTO>(student);
            return Ok(studentDto);
        }

        [HttpPost]
        public async Task<ActionResult<StudentDTO>> CreateStudent([FromBody] CreateStudentDto createStudentDto)
        {
            if (!ModelState.IsValid)
            {
                throw new InvalidStudentDataException();
            }

            var student = _mapper.Map<Student>(createStudentDto);
            var createdStudent = await _studentService.CreateStudentAsync(createStudentDto);
            var createdStudentDto = _mapper.Map<StudentDTO>(createdStudent);

            return CreatedAtAction(nameof(GetStudent), new { id = createdStudentDto.StudentId }, createdStudentDto);
        }

        [HttpPut("{id}")]
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
                throw new StudentNotFoundException();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(Guid id)
        {
            await _studentService.DeleteStudentAsync(id);
            return NoContent();
        }
    }
}
