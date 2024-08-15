﻿using AlQalem.Data;
using AlQalem.DTOs.Grade;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


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

        // Retrieve all grades
        public async Task<IEnumerable<GradeDTO>> GetGradesAsync()
        {
            var grades = await _context.Grades
                .Include(g => g.Student) 
                .Include(g => g.Subject) 
                .Include(g => g.AcademicYear) 
                .ToListAsync();
            return _mapper.Map<IEnumerable<GradeDTO>>(grades);
        }

        public async Task<IEnumerable<GradeDTO>> GetAllGradesAsync()
        {
            var grades = await _context.Grades.IgnoreQueryFilters()
              
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
            return _mapper.Map<GradeDTO>(grade);
        }

        
        public async Task<GradeDTO> CreateGradeAsync(CreateGradeDTO createGradeDTO)
        {
            var grade = _mapper.Map<Grade>(createGradeDTO);
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
            return _mapper.Map<GradeDTO>(grade);
        }

        
        public async Task<GradeDTO> UpdateGradeAsync(Guid id, UpdateGradeDTO updateGradeDTO)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null) return null;

            _mapper.Map(updateGradeDTO, grade);
            _context.Grades.Update(grade);
            await _context.SaveChangesAsync();
            return _mapper.Map<GradeDTO>(grade);
        }

       
        public async Task DeleteGradeAsync(Guid id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null) return;
            
            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();
        }
    }
}
