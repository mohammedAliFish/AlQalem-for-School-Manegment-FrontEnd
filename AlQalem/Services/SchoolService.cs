using AlQalem.Data;
using AlQalem.DTOs.School;
using AlQalem.Exceptions.SchoolExceptions;
using AlQalem.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AlQalem.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SchoolService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SchoolDTO>> GetAllSchoolsIncludingDeletedAsync()
        {
            var schools = await _context.Schools
                                        .IgnoreQueryFilters() 
                                        .ToListAsync();

            // Map to DTOs
            return _mapper.Map<IEnumerable<SchoolDTO>>(schools);
        }



        // استرجاع جميع المدارس
        public async Task<IEnumerable<SchoolDTO>> GetSchoolsAsync()
        {
            var schools = await _context.Schools
                                        .Where(s => !s.IsDeleted) // Exclude soft-deleted records
                                        .ToListAsync();

            return _mapper.Map<IEnumerable<SchoolDTO>>(schools);
        }



        // استرجاع مدرسة حسب ID
        public async Task<SchoolDTO> GetSchoolByIdAsync(Guid id)
        {
            var school = await _context.Schools
                                       .Where(s => s.SchoolId == id)
                                       .Select(school => new SchoolDTO
                                       {
                                           SchoolId = school.SchoolId,
                                           Name = school.Name,
                                           LogoPath = school.LogoPath,  // Map the LogoPath here
                                           Type = school.Type,
                                           IsDeleted = school.IsDeleted
                                       })
                                       .FirstOrDefaultAsync();

            return school;
        }


        // إنشاء مدرسة جديدة
        public async Task<SchoolDTO> CreateSchoolAsync(SchoolDTO schoolDto)
        {
            // التحقق مما إذا كان الاسم موجودًا
            bool isSchoolNameExists = _context.Schools.Any(s => s.Name == schoolDto.Name);

            if (isSchoolNameExists)
                throw new SchoolNotFoundException();

            var school = new School
            {
                SchoolId = Guid.NewGuid(),
                Name = schoolDto.Name,
                Type = schoolDto.Type,
                LogoPath = schoolDto.LogoPath
            };

            _context.Schools.Add(school);
            await _context.SaveChangesAsync();

            return _mapper.Map<SchoolDTO>(school);
        }

        // تحديث مدرسة
        public async Task<SchoolDTO> UpdateSchoolAsync(Guid id, UpdateSchoolDTO schoolUpdateDTO)
        {
            var school = await _context.Schools.FindAsync(id);
            if (school == null) return null;

            // تحديث خصائص المدرسة
            school.Name = schoolUpdateDTO.Name;
            school.Type = schoolUpdateDTO.Type;

            if (schoolUpdateDTO.Logo != null && schoolUpdateDTO.Logo.Length > 0)
            {
                var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "SchoolLogo");
                if (!Directory.Exists(uploadsFolderPath))
                {
                    Directory.CreateDirectory(uploadsFolderPath);
                }

                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(schoolUpdateDTO.Logo.FileName);
                var filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

                try
                {
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await schoolUpdateDTO.Logo.CopyToAsync(fileStream);
                    }
                    school.LogoPath = uniqueFileName; // تحديث المسار هنا
                }
                catch (Exception ex)
                {
                    throw new Exception("حدث خطأ أثناء تحميل الشعار: " + ex.Message);
                }
            }

            _context.Schools.Update(school);
            await _context.SaveChangesAsync();

            return _mapper.Map<SchoolDTO>(school);
        }

        // حذف مدرسة
        public async Task DeleteSchoolAsync(Guid id)
        {
            var school = await _context.Schools.FindAsync(id);
            if (school == null) return;

            // Set IsDeleted flag to true instead of removing the record
            school.IsDeleted = true;

            // Update the school record
            _context.Schools.Update(school);
            await _context.SaveChangesAsync();
        }

    }
}
