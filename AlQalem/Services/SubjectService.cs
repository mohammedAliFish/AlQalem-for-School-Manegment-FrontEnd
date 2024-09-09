using AlQalem.Data;
using AlQalem.DTOs.Subject;
using AlQalem.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AlQalem.Exceptions.SubjectExceptions;


namespace AlQalem.Services
{
    public class SubjectService : InterfaceSubjectService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SubjectService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        
        public async Task<IEnumerable<SubjectDTO>> GetSubjectsAsync()
        {
            var subjects = await _context.Subjects
                .Include(s => s.ClassSubjectTeachers) 
                .Include(s => s.TeacherSubjects) 
                .ToListAsync();
            return _mapper.Map<IEnumerable<SubjectDTO>>(subjects);
        }
       

        
        public async Task<SubjectDTO> GetSubjectByIdAsync(Guid id)
        {
            var subject = await _context.Subjects
                .Include(s => s.ClassSubjectTeachers) 
                .Include(s => s.TeacherSubjects) 
                .FirstOrDefaultAsync(s => s.SubjectId == id);
            return _mapper.Map<SubjectDTO>(subject);
        }

        
        public async Task<SubjectDTO> CreateSubjectAsync(CreateSubjectDTO createSubjectDTO)
        {
            var subject = _mapper.Map<Subject>(createSubjectDTO);
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
            return _mapper.Map<SubjectDTO>(subject);
        }

        
        public async Task<SubjectDTO> UpdateSubjectAsync(Guid id, UpdateSubjectDTO updateSubjectDTO)
        {
          
            var subject = await _context.Subjects.FindAsync(id);
           

            _mapper.Map(updateSubjectDTO, subject);
            _context.Subjects.Update(subject);
            await _context.SaveChangesAsync();
            return _mapper.Map<SubjectDTO>(subject);
        }

        
        public async Task DeleteSubjectAsync(Guid id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            if (subject == null)
            {
                throw new SubjectNotFoundException();
            }
            subject.IsDeleted=true;
            _context.Subjects.Update(subject);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> HasClassSubjectTeachersAsync(Guid id)
        {
            return await _context.ClassSubjectTeachers
                .AnyAsync(cst => cst.SubjectId == id);
        }

        public async Task<bool> HasGradesAsync(Guid id)
        {
            return await _context.Grades
                .AnyAsync(g => g.SubjectId == id);
        }
    }
}
