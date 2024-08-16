using AlQalem.Data;
using AlQalem.DTOs.School;
using AlQalem.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AlQalem.Exceptions.SchoolExceptions;

namespace AlQalem.Services
{
    public class SchoolService : InterfaceSchoolService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SchoolService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

      



        
        public async Task<IEnumerable<SchoolDTO>> GetSchoolsAsync()
        {
            var schools = await _context.Schools
                                        .Where(s => !s.IsDeleted) 
                                        .ToListAsync();

            return _mapper.Map<IEnumerable<SchoolDTO>>(schools);
        }



        
        public async Task<SchoolDTO> GetSchoolByIdAsync(Guid id)
        {
            var school = await _context.Schools
                                       .Where(s => s.SchoolId == id)
                                       .Select(school => new SchoolDTO
                                       {
                                           SchoolId = school.SchoolId,
                                           Name = school.Name,
                                           LogoPath = school.LogoPath,  
                                           Type = school.Type,
                                           IsDeleted = school.IsDeleted
                                       })
                                       .FirstOrDefaultAsync();
            if (school == null)
            {
                throw new SchoolNotFoundException();
            }

            return school;
        }


        
        public async Task<SchoolDTO> CreateSchoolAsync(SchoolDTO schoolDto)
        {
            
            bool isSchoolNameExists = _context.Schools.Any(s => s.Name == schoolDto.Name);
            if (isSchoolNameExists)
                throw new SchoolNameAlreadyExistsException();



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

        
        public async Task<SchoolDTO> UpdateSchoolAsync(Guid id, UpdateSchoolDTO schoolUpdateDTO)
        {
            var school = await _context.Schools.FindAsync(id);
            if (school == null) throw new SchoolNotFoundException();

            
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
                    school.LogoPath = uniqueFileName;
                }
                catch (Exception)
                {
                    throw new LogoUploadException();
                }
            }

            _context.Schools.Update(school);
            await _context.SaveChangesAsync();

            return _mapper.Map<SchoolDTO>(school);
        }

        
        public async Task DeleteSchoolAsync(Guid id)
        {
            var school = await _context.Schools.FindAsync(id);
            if (school == null) return;

            
            school.IsDeleted = true;

            
            _context.Schools.Update(school);
            await _context.SaveChangesAsync();
        }

    }
}
