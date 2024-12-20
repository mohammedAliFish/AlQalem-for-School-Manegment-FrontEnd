﻿using AlQalem.Data;
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
            var classEntity = _mapper.Map<Class>(createClassDto);

            classEntity.ClassId = Guid.NewGuid();

            for (int i = 0; i < classEntity.ClassSubjectTeachers.Count; i++)
                classEntity.ClassSubjectTeachers[i].ClassId = classEntity.ClassId;

            _context.Classes.Add(classEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<ClassDTO>(classEntity);
        }

        public async Task<ClassDTO> UpdateClassAsync(Guid id, UpdateClassDTO updateClassDto)
        {
           

            var classEntity = await _context.Classes.FindAsync(id);
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
