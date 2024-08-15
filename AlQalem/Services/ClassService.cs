using AlQalem.Data;
using AlQalem.DTOs.Class;
using AlQalem.DTOs.School;
using AlQalem.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace AlQalem.Services
{
    public class ClassService : IClassService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ClassService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClassDTO>> GetAllClassesIncludingDeletedAsync()
        {
            var classes = await _context.Classes
                                        .IgnoreQueryFilters()
                                        .ToListAsync();

            // Map to DTOs
            return _mapper.Map<IEnumerable<ClassDTO>>(classes);
        }

        // Retrieve all classes
        public async Task<IEnumerable<ClassDTO>> GetAllClassesAsync()
        {
            var classes = await _context.Classes
                .Include(c => c.School)
                .Include(c => c.Students)
                .Include(c => c.ClassSubjectTeachers)
                .ToListAsync();
            return _mapper.Map<IEnumerable<ClassDTO>>(classes);
        }

        // Retrieve a class by ID
        public async Task<ClassDTO> GetClassByIdAsync(Guid id)
        {
            var classEntity = await _context.Classes
                .Include(c => c.School) // Include related entities if needed
                .Include(c => c.Students)
                .Include(c => c.ClassSubjectTeachers)
                .FirstOrDefaultAsync(c => c.ClassId == id);
            return _mapper.Map<ClassDTO>(classEntity);
        }

        // Create a new class
        public async Task<ClassDTO> CreateClassAsync(CreateClassDTO createClassDto)
        {
            var classEntity = _mapper.Map<Class>(createClassDto);
            _context.Classes.Add(classEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<ClassDTO>(classEntity);
        }

        // Update an existing class
        public async Task<ClassDTO> UpdateClassAsync(Guid id, UpdateClassDTO updateClassDto)
        {
            var classEntity = await _context.Classes.FindAsync(id);
            if (classEntity == null) return null;

            // Update the properties
            _mapper.Map(updateClassDto, classEntity);

            _context.Classes.Update(classEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<ClassDTO>(classEntity);
        }

        // Delete a class
        public async Task DeleteClassAsync(Guid id)
        {
            var classEntity = await _context.Classes.FindAsync(id);
            if (classEntity == null) return;
            classEntity.IsDeleted = true;
            _context.Classes.Update(classEntity);
            await _context.SaveChangesAsync();


            

            
        }
    }
}
