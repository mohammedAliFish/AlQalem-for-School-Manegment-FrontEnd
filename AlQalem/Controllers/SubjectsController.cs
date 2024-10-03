using AlQalem.DTOs.Subject;
using AlQalem.Exceptions.SubjectExceptions;
using AlQalem.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AlQalem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
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

      

        [HttpGet("{id}")]
        public async Task<ActionResult<SubjectDTO>> GetSubject(Guid id)
        {
            var subject = await _subjectService.GetSubjectByIdAsync(id);

            if (subject == null)
            {
                throw new SubjectNotFoundException();
            }

            var subjectDto = _mapper.Map<SubjectDTO>(subject);
            return Ok(subjectDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubject([FromBody] CreateSubjectDTO createSubjectDTO)
        {
            var createdSubject = await _subjectService.CreateSubjectAsync(createSubjectDTO);
            return CreatedAtAction(nameof(GetSubject), new { id = createdSubject.SubjectId }, createdSubject);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSubject(Guid id, UpdateSubjectDTO updateSubjectDto)
        {
           

            var subject = _mapper.Map<Subject>(updateSubjectDto);
            var updatedSubject = await _subjectService.UpdateSubjectAsync(id, updateSubjectDto);

            if (updatedSubject == null)
            {
                throw new SubjectNotFoundException();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubjectAsync(Guid id)
        {
            
            var subject = await _subjectService.GetSubjectByIdAsync(id);
            if (subject == null)
            {
                throw new SubjectNotFoundException();
            }


            if (await _subjectService.HasClassSubjectTeachersAsync(id) || await _subjectService.HasGradesAsync(id))
            {
                throw new SubjectDeletionException();
            }


            await _subjectService.DeleteSubjectAsync(id);
            return NoContent();
        }
    }
}
