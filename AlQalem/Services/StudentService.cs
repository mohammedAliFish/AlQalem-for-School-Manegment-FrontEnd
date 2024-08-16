using AlQalem.Data;
using AlQalem.DTOs.Student;
using AlQalem.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AlQalem.Exceptions.StudentExceptions;


namespace AlQalem.Services
{
    public class StudentService : InterfaceStudentService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public StudentService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        
        public async Task<IEnumerable<StudentDTO>> GetStudentsAsync()
        {
            var students = await _context.Students
             
                .ToListAsync();
            return _mapper.Map<IEnumerable<StudentDTO>>(students);
        }

      

        
        public async Task<StudentDTO> GetStudentByIdAsync(Guid id)
        {
            var student = await _context.Students
                
                .FirstOrDefaultAsync(s => s.StudentId == id);
            if (student == null)
            {
                throw new StudentNotFoundException("الطالب المطلوب غير موجود.");
            }
            return _mapper.Map<StudentDTO>(student);
        }

        

        public async Task<StudentDTO> CreateStudentAsync(CreateStudentDto createStudentDto)
        {
            if (createStudentDto == null)
            {
                throw new InvalidStudentDataException("بيانات الطالب غير صالحة.");
            }
            var student = _mapper.Map<Student>(createStudentDto);
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return _mapper.Map<StudentDTO>(student);
        }

        public async Task<StudentDTO> UpdateStudentAsync(Guid id, UpdateStudentDTO updateStudentDTO)
        {
            if (updateStudentDTO == null)
            {
                throw new InvalidStudentDataException("بيانات التحديث غير صالحة.");
            }
            var student = await _context.Students.FindAsync(id);
           
            if (student == null)
            {
                throw new StudentNotFoundException("الطالب المطلوب غير موجود.");
            }

            _mapper.Map(updateStudentDTO, student);
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
            return _mapper.Map<StudentDTO>(student);
        }

        
        public async Task DeleteStudentAsync(Guid id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                throw new StudentNotFoundException("الطالب المطلوب غير موجود.");
            }
            student.IsDeleted = true;
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }
    }
}
