using AlQalem.DTOs.Student;
using Microsoft.AspNetCore.Mvc;


namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetStudents()
        {
            var students = await _studentService.GetStudentsAsync();
            return Ok(students);
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetAllStudents()
        {
            var students = await _studentService.GetAllStudentsAsync();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDTO>> GetStudent(Guid id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<StudentDTO>> CreateStudent([FromBody] CreateStudentDto createStudentDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdStudent = await _studentService.CreateStudentAsync(createStudentDto);
            return CreatedAtAction(nameof(GetStudent), new { id = createdStudent.StudentId }, createdStudent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(Guid id, [FromBody] UpdateStudentDTO updateStudentDTO)
        {
            if (id != updateStudentDTO.StudentId)
            {
                return BadRequest("Student ID mismatch.");
            }

            var updatedStudent = await _studentService.UpdateStudentAsync(id, updateStudentDTO);

            if (updatedStudent == null)
            {
                return NotFound("Student not found.");
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
