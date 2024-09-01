using AlQalem.Data;
using AlQalem.DTOs.Class;
using AlQalem.Exceptions.ClassExceptions;
using AlQalem.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace AlQalem.Services
{
    public class ClassService : InterfaceClassService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ClassService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

       

        
        public async Task<IEnumerable<ClassDTO>> GetAllClassesAsync()
        {
            

            var classes = await _context.Classes
                .Include(c => c.School)
                .Include(c => c.Students)
                .Include(c => c.ClassSubjectTeachers)
                .Include(c => c.GradeLevel)
                .ToListAsync();

            foreach (var classItem in classes)
            {
                Console.WriteLine($"Class: {classItem.Name}, GradeLevel: {classItem.GradeLevel?.Name}");
            }

            if (classes == null || !classes.Any())
            {
                throw new ClassNotFoundException("لم يتم العثور على أي صفوف.");
            }
            return _mapper.Map<IEnumerable<ClassDTO>>(classes);
        }

        
        public async Task<ClassDTO> GetClassByIdAsync(Guid id)
        {
            var classEntity = await _context.Classes
                .Include(c => c.School) 
                .Include(c => c.Students)
                .Include(c => c.ClassSubjectTeachers)
                .Include(c => c.GradeLevel)
                .FirstOrDefaultAsync(c => c.ClassId == id);

            if (classEntity == null)
            {
                throw new ClassNotFoundException();
            }
            return _mapper.Map<ClassDTO>(classEntity);
        }

        
        public async Task<ClassDTO> CreateClassAsync(CreateClassDTO createClassDto)
        {
            if (createClassDto == null)
            {
                throw new InvalidClassDataException();
            }
            var classEntity = _mapper.Map<Class>(createClassDto);
            _context.Classes.Add(classEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<ClassDTO>(classEntity);
        }

        
        public async Task<ClassDTO> UpdateClassAsync(Guid id, UpdateClassDTO updateClassDto)
        {
            if (id != updateClassDto.ClassId)
            {
                throw new ClassIdMismatchException();
            }
            var classEntity = await _context.Classes.FindAsync(id);
            if (classEntity == null)
            {
                throw new ClassNotFoundException();
            }


            _mapper.Map(updateClassDto, classEntity);

            _context.Classes.Update(classEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<ClassDTO>(classEntity);
        }

        
        public async Task DeleteClassAsync(Guid id)
        {
            var classEntity = await _context.Classes.FindAsync(id);
            if (classEntity == null)
                if (classEntity == null)
                {
                    throw new ClassNotFoundException();
                }
            classEntity.IsDeleted = true;
            _context.Classes.Update(classEntity);
            await _context.SaveChangesAsync();
        }
    }
}
