using AlQalem.DTOs.Subject;
using AlQalem.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly InterfaceSubjectService _subjectService;
        private readonly IMapper _mapper;

        public SubjectsController(InterfaceSubjectService subjectService, IMapper mapper)
        {
            _subjectService = subjectService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubjectDTO>>> GetSubjects()
        {
            var subjects = await _subjectService.GetSubjectsAsync();
            var subjectDtos = _mapper.Map<IEnumerable<SubjectDTO>>(subjects);
            return Ok(subjectDtos);
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<SubjectDTO>>> GetSubjectsAll()
        {
            var subjects = await _subjectService.GetAllSubjectsAsync();
            var subjectDtos = _mapper.Map<IEnumerable<SubjectDTO>>(subjects);
            return Ok(subjectDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubjectDTO>> GetSubject(Guid id)
        {
            var subject = await _subjectService.GetSubjectByIdAsync(id);

            if (subject == null)
            {
                return NotFound();
            }

            var subjectDto = _mapper.Map<SubjectDTO>(subject);
            return Ok(subjectDto);
        }

        [HttpPost]
        public async Task<ActionResult<SubjectDTO>> CreateSubject(CreateSubjectDTO createSubjectDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subject = _mapper.Map<Subject>(createSubjectDto);
            var createdSubject = await _subjectService.CreateSubjectAsync(createSubjectDto);
            var createdSubjectDto = _mapper.Map<SubjectDTO>(createdSubject);

            return CreatedAtAction(nameof(GetSubject), new { id = createdSubjectDto.SubjectId }, createdSubjectDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSubject(Guid id, UpdateSubjectDTO updateSubjectDto)
        {
            if (id != updateSubjectDto.SubjectId)
            {
                return BadRequest("Subject ID mismatch.");
            }

            var subject = _mapper.Map<Subject>(updateSubjectDto);
            var updatedSubject = await _subjectService.UpdateSubjectAsync(id, updateSubjectDto);

            if (updatedSubject == null)
            {
                return NotFound("Subject not found.");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubjectAsync(Guid id)
        {
            // تحقق من وجود الموضوع
            var subject = await _subjectService.GetSubjectByIdAsync(id);
            if (subject == null)
            {
                return NotFound("Subject not found.");
            }

            // تحقق من وجود ارتباطات مع الفصول أو الدرجات
            if (await _subjectService.HasClassSubjectTeachersAsync(id) || await _subjectService.HasGradesAsync(id))
            {
                return BadRequest("Cannot delete the subject as it is linked to classes or grades.");
            }

            // تعيين خاصية IsDeleted بدلاً من حذف الكائن فعليًا
            await _subjectService.DeleteSubjectAsync(id);
            return NoContent();
        }
    }
}
