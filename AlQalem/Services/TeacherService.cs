using AlQalem.Data;
using AlQalem.DTOs.Teacher;
using AlQalem.Exceptions.TeacherExceptions;
using AlQalem.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace AlQalem.Services
{
    public class TeacherService : InterfaceTeacherService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TeacherService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

      
        public async Task<IEnumerable<TeacherDTO>> GetTeachersAsync()
        {
            var teachers = await _context.Teachers
                
                .Include(t => t.ClassTeachers)
                .Include(t => t.TeacherSubjects)
                .ToListAsync();
            return _mapper.Map<IEnumerable<TeacherDTO>>(teachers);
        }

        

       
        public async Task<TeacherDTO> GetTeacherByIdAsync(Guid id)
        {
            var teacher = await _context.Teachers
                
                .Include(t => t.ClassTeachers)
                .Include(t => t.TeacherSubjects)
                .FirstOrDefaultAsync(t => t.TeacherId == id);
            if (teacher == null)
            {
                throw new TeacherNotFoundException();
            }
            return _mapper.Map<TeacherDTO>(teacher);
        }

        
        public async Task<TeacherDTO> CreateTeacherAsync(CreateTeacherDTO createTeacherDto)
        {
            
            var teacher = _mapper.Map<Teacher>(createTeacherDto);
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
            return _mapper.Map<TeacherDTO>(teacher);
        }

        
        public async Task<TeacherDTO> UpdateTeacherAsync(Guid id, UpdateTeacherDTO updateTeacherDto)
        {
           
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                throw new TeacherNotFoundException();
            }

            _mapper.Map(updateTeacherDto, teacher);
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
            return _mapper.Map<TeacherDTO>(teacher);
        }

        
        public async Task DeleteTeacherAsync(Guid id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                throw new TeacherNotFoundException();
            }
            teacher.IsDeleted=true;
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
        }
       
    }
}
