using AlQalem.Data;
using AlQalem.DTOs.Grade;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AlQalem.Exceptions.GradeExceptions;


namespace AlQalem.Services
{
    public class GradeService : InterfaceGradeService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GradeService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        
        public async Task<IEnumerable<GradeDTO>> GetGradesAsync()
        {
            var grades = await _context.Grades
                .Include(g => g.Student) 
                .Include(g => g.Subject) 
                .Include(g => g.AcademicYear) 
                .ToListAsync();
            return _mapper.Map<IEnumerable<GradeDTO>>(grades);
        }

      
        
        public async Task<GradeDTO> GetGradeByIdAsync(Guid id)
        {
            var grade = await _context.Grades
                .Include(g => g.Student) 
                .Include(g => g.Subject) 
                .Include(g => g.AcademicYear) 
                .FirstOrDefaultAsync(g => g.GradeId == id);
            if (grade == null)
            {
                throw new GradeNotFoundException("الدرجة المطلوبة غير موجودة.");
            }
            return _mapper.Map<GradeDTO>(grade);
        }

        
        public async Task<GradeDTO> CreateGradeAsync(CreateGradeDTO createGradeDTO)
        {
            if (createGradeDTO == null)
            {
                throw new InvalidGradeDataException("بيانات الدرجة غير صالحة.");
            }
            var grade = _mapper.Map<Grade>(createGradeDTO);
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
            return _mapper.Map<GradeDTO>(grade);
        }

        
        public async Task<GradeDTO> UpdateGradeAsync(Guid id, UpdateGradeDTO updateGradeDTO)
        {
            if (updateGradeDTO == null)
            {
                throw new InvalidGradeDataException("بيانات التحديث غير صالحة.");
            }
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null)
            {
                throw new GradeNotFoundException("الدرجة المطلوبة غير موجودة.");
            }
            _mapper.Map(updateGradeDTO, grade);
            _context.Grades.Update(grade);
            await _context.SaveChangesAsync();
            return _mapper.Map<GradeDTO>(grade);
        }

       
        public async Task DeleteGradeAsync(Guid id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null)
            {
                throw new GradeNotFoundException("الدرجة المطلوبة غير موجودة.");
            }

            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();
        }
    }
}
